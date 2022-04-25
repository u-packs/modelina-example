namespace example
{
  using System.Text.Json;
  using System.Text.Json.Serialization;
  using System.Text.RegularExpressions;

  [JsonConverter(typeof(AuthMsgConverter))]
  public class AuthMsg
  {
    private int? type;

    public int? Type 
    {
      get { return type; }
      set { type = value; }
    }
  }

  internal class AuthMsgConverter : JsonConverter<AuthMsg>
  {
    public override bool CanConvert(System.Type objectType)
    {
      // this converter can be applied to any type
      return true;
    }
    public override AuthMsg Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
    {
      if (reader.TokenType != JsonTokenType.StartObject)
      {
        throw new JsonException();
      }

      var instance = new AuthMsg();
  
      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return instance;
        }

        // Get the key.
        if (reader.TokenType != JsonTokenType.PropertyName)
        {
          throw new JsonException();
        }

        string propertyName = reader.GetString();
        if (propertyName == "type")
        {
          var value = JsonSerializer.Deserialize<int?>(ref reader, options);
          instance.Type = value;
          continue;
        }

    

    
      }
  
      throw new JsonException();
    }
    public override void Write(Utf8JsonWriter writer, AuthMsg value, JsonSerializerOptions options)
    {
      if (value == null)
      {
        JsonSerializer.Serialize(writer, null);
        return;
      }
      var properties = value.GetType().GetProperties();
  
      writer.WriteStartObject();

      if(value.Type != null) { 
        // write property name and let the serializer serialize the value itself
        writer.WritePropertyName("type");
        JsonSerializer.Serialize(writer, value.Type);
      }


  

  

      writer.WriteEndObject();
    }

  }

}