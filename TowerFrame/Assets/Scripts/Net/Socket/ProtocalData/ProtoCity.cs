//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model/ProtoCity.proto
// Note: requires additional types generated from: model/ProtoMarathon.proto
// Note: requires additional types generated from: model/ProtoChat.proto
namespace com.sporger.server.proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_city_info_in")]
  public partial class req_city_info_in : global::ProtoBuf.IExtensible
  {
    public req_city_info_in() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_city_info_out")]
  public partial class req_city_info_out : global::ProtoBuf.IExtensible
  {
    public req_city_info_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.marathon_event_info> _list = new global::System.Collections.Generic.List<com.sporger.server.proto.model.marathon_event_info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.marathon_event_info> list
    {
      get { return _list; }
    }
  
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.voice_message_base_info> _messageList = new global::System.Collections.Generic.List<com.sporger.server.proto.model.voice_message_base_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"messageList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.voice_message_base_info> messageList
    {
      get { return _messageList; }
    }
  
    private com.sporger.server.proto.model.voice_message_base_info _runnerReply = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"runnerReply", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public com.sporger.server.proto.model.voice_message_base_info runnerReply
    {
      get { return _runnerReply; }
      set { _runnerReply = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}