//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: model/ProtoMail.proto
// Note: requires additional types generated from: model/ProtoBag.proto
namespace com.sporger.server.proto.model
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"mail_base_info")]
  public partial class mail_base_info : global::ProtoBuf.IExtensible
  {
    public mail_base_info() {}
    
    private ulong _mailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong mailId
    {
      get { return _mailId; }
      set { _mailId = value; }
    }
    private string _title;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private ulong _time;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong time
    {
      get { return _time; }
      set { _time = value; }
    }
    private string _text;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string text
    {
      get { return _text; }
      set { _text = value; }
    }
    private string _sender;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"sender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sender
    {
      get { return _sender; }
      set { _sender = value; }
    }
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> _items = new global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info>();
    [global::ProtoBuf.ProtoMember(7, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> items
    {
      get { return _items; }
    }
  
    private bool _isRead;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"isRead", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isRead
    {
      get { return _isRead; }
      set { _isRead = value; }
    }
    private bool _isGetItems;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"isGetItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool isGetItems
    {
      get { return _isGetItems; }
      set { _isGetItems = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_mail_info_out")]
  public partial class req_mail_info_out : global::ProtoBuf.IExtensible
  {
    public req_mail_info_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info> _mailList = new global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mailList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info> mailList
    {
      get { return _mailList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_read_mail_in")]
  public partial class req_read_mail_in : global::ProtoBuf.IExtensible
  {
    public req_read_mail_in() {}
    
    private ulong _mailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong mailId
    {
      get { return _mailId; }
      set { _mailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_read_mail_out")]
  public partial class req_read_mail_out : global::ProtoBuf.IExtensible
  {
    public req_read_mail_out() {}
    
    private ulong _mailId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong mailId
    {
      get { return _mailId; }
      set { _mailId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_get_mail_items_in")]
  public partial class req_get_mail_items_in : global::ProtoBuf.IExtensible
  {
    public req_get_mail_items_in() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _mailId = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> mailId
    {
      get { return _mailId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_get_mail_items_out")]
  public partial class req_get_mail_items_out : global::ProtoBuf.IExtensible
  {
    public req_get_mail_items_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> _items = new global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.item_simple_info> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_delete_mail_in")]
  public partial class req_delete_mail_in : global::ProtoBuf.IExtensible
  {
    public req_delete_mail_in() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _mailId = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> mailId
    {
      get { return _mailId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"req_delete_mail_out")]
  public partial class req_delete_mail_out : global::ProtoBuf.IExtensible
  {
    public req_delete_mail_out() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _mailId = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> mailId
    {
      get { return _mailId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"notify_new_mail_out")]
  public partial class notify_new_mail_out : global::ProtoBuf.IExtensible
  {
    public notify_new_mail_out() {}
    
    private readonly global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info> _mailList = new global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info>();
    [global::ProtoBuf.ProtoMember(1, Name=@"mailList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<com.sporger.server.proto.model.mail_base_info> mailList
    {
      get { return _mailList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}