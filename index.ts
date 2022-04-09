import {
  CSharpGenerator,
  CSHARP_JSON_SERIALIZER_PRESET,
  CSharpRenderCompleteModelOptions
} from "@asyncapi/modelina";
import glob from "glob";
import { promises as fs } from "fs";
import yaml from "js-yaml";
import { camelCase, startCase } from "lodash";
import path from "path";

const generator = new CSharpGenerator({
  presets: [CSHARP_JSON_SERIALIZER_PRESET],
});

const cSharpModelOptions: CSharpRenderCompleteModelOptions = {
  namespace: "example",
};

const schemasFolder = "./schemas/*yaml";
const modelsFolder = "./Models";

fs
  .rm(modelsFolder, { recursive: true, force: true })
  .then(() => {
    glob.sync(schemasFolder)
      .map(file => {
        fs.mkdir(`${modelsFolder}/${parseFile(file)}`, { recursive: true });
        return file;
      })
      .map((file) => fs
        .readFile(file, "utf8")
        .then((content) => yaml.load(content))
        .then((schema) => generator.process(schema as any))
        .then((inputModel) => generator.generateCompleteModels(inputModel, cSharpModelOptions))
        .then((api) => api.forEach((model) => fs.writeFile(`${modelsFolder}/${parseFile(file)}/${model.modelName}.cs`, model.result)))
      );
  }
  );

function parseFile(file: string): string {
  return startCase(camelCase(path.basename(file, ".yaml"))).replace(/ /g, '');
}
