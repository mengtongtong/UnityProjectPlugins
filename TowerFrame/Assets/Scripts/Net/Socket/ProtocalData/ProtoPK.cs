//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model/ProtoPK.proto
// Note: requires additional types generated from: model/ProtoRunReport.proto
// Note: requires additional types generated from: model/ProtoBag.proto
namespace com.sporger.server.proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"notify_career_run_end_out")]
  public partial class notify_career_run_end_out : global::ProtoBuf.IExtensible
  {
    public notify_career_run_end_out() {}
    
    private bool _isWin;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"isWin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isWin
    {
      get { return _isWin; }
      set { _isWin = value; }
    }
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> _reward = new global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> reward
    {
      get { return _reward; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"notify_player_reach_out")]
  public partial class notify_player_reach_out : global::ProtoBuf.IExtensible
  {
    public notify_player_reach_out() {}
    
    private string _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"outdoor_pvp_player_reward")]
  public partial class outdoor_pvp_player_reward : global::ProtoBuf.IExtensible
  {
    public outdoor_pvp_player_reward() {}
    
    private uint _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private string _playerId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private uint _time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint time
    {
      get { return _time; }
      set { _time = value; }
    }
    private uint _exp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private uint _glory;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"glory", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint glory
    {
      get { return _glory; }
      set { _glory = value; }
    }
    private bool _isComplete;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"isComplete", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isComplete
    {
      get { return _isComplete; }
      set { _isComplete = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"notify_outdoor_pvp_result_out")]
  public partial class notify_outdoor_pvp_result_out : global::ProtoBuf.IExtensible
  {
    public notify_outdoor_pvp_result_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.outdoor_pvp_player_reward> _plyaerReward = new global::System.Collections.Generic.List<com.sporger.server.proto.model.outdoor_pvp_player_reward>();
    [global::ProtoBuf.ProtoMember(1, Name=@"plyaerReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.outdoor_pvp_player_reward> plyaerReward
    {
      get { return _plyaerReward; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"item_pvp_player_reward")]
  public partial class item_pvp_player_reward : global::ProtoBuf.IExtensible
  {
    public item_pvp_player_reward() {}
    
    private uint _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private string _playerId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private uint _time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint time
    {
      get { return _time; }
      set { _time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"notify_item_pvp_result_out")]
  public partial class notify_item_pvp_result_out : global::ProtoBuf.IExtensible
  {
    public notify_item_pvp_result_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.item_pvp_player_reward> _plyaerReward = new global::System.Collections.Generic.List<com.sporger.server.proto.model.item_pvp_player_reward>();
    [global::ProtoBuf.ProtoMember(1, Name=@"plyaerReward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.item_pvp_player_reward> plyaerReward
    {
      get { return _plyaerReward; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}