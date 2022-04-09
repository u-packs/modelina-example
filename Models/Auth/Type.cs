namespace example
{
  
  public enum Type {
  Auth, AuthUnderscoreOk, AuthUnderscoreInvalid, AuthUnderscoreRequired, Event, CallUnderscoreService, Ping, Pong, Result, SubscribeUnderscoreEvents, SubscribeUnderscoreTrigger, UnsubscribeUnderscoreEvents, ValidateUnderscoreConfig, FireUnderscoreEvent, GetUnderscoreConfig, GetUnderscorePanels, GetUnderscoreServices, GetUnderscoreStates
}
public static class TypeExtensions {
  public static dynamic GetValue(this Type enumValue)
  {
    switch (enumValue)
    {
      case Type.Auth: return "auth";
      case Type.AuthUnderscoreOk: return "auth_ok";
      case Type.AuthUnderscoreInvalid: return "auth_invalid";
      case Type.AuthUnderscoreRequired: return "auth_required";
      case Type.Event: return "event";
      case Type.CallUnderscoreService: return "call_service";
      case Type.Ping: return "ping";
      case Type.Pong: return "pong";
      case Type.Result: return "result";
      case Type.SubscribeUnderscoreEvents: return "subscribe_events";
      case Type.SubscribeUnderscoreTrigger: return "subscribe_trigger";
      case Type.UnsubscribeUnderscoreEvents: return "unsubscribe_events";
      case Type.ValidateUnderscoreConfig: return "validate_config";
      case Type.FireUnderscoreEvent: return "fire_event";
      case Type.GetUnderscoreConfig: return "get_config";
      case Type.GetUnderscorePanels: return "get_panels";
      case Type.GetUnderscoreServices: return "get_services";
      case Type.GetUnderscoreStates: return "get_states";
    }
    return null;
  }

  public static Type? ToType(dynamic value)
  {
    switch (value)
    {
      case "auth": return Type.Auth;
      case "auth_ok": return Type.AuthUnderscoreOk;
      case "auth_invalid": return Type.AuthUnderscoreInvalid;
      case "auth_required": return Type.AuthUnderscoreRequired;
      case "event": return Type.Event;
      case "call_service": return Type.CallUnderscoreService;
      case "ping": return Type.Ping;
      case "pong": return Type.Pong;
      case "result": return Type.Result;
      case "subscribe_events": return Type.SubscribeUnderscoreEvents;
      case "subscribe_trigger": return Type.SubscribeUnderscoreTrigger;
      case "unsubscribe_events": return Type.UnsubscribeUnderscoreEvents;
      case "validate_config": return Type.ValidateUnderscoreConfig;
      case "fire_event": return Type.FireUnderscoreEvent;
      case "get_config": return Type.GetUnderscoreConfig;
      case "get_panels": return Type.GetUnderscorePanels;
      case "get_services": return Type.GetUnderscoreServices;
      case "get_states": return Type.GetUnderscoreStates;
    }
    return null;
  }
}


}