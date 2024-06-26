//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeAPI {

public class TapAPITradeMessage : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeMessage(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeMessage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeMessage obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~TapAPITradeMessage() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeAPIWrapperPINVOKE.delete_TapAPITradeMessage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint SerialID {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_SerialID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_SerialID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TMsgValidDateTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgValidDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgValidDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TMsgTitle {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgTitle_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgTitle_get(swigCPtr);
      return ret;
    } 
  }

  public string TMsgContent {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgContent_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgContent_get(swigCPtr);
      return ret;
    } 
  }

  public char TMsgType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgType_get(swigCPtr);
      return ret;
    } 
  }

  public char TMsgLevel {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgLevel_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_TMsgLevel_get(swigCPtr);
      return ret;
    } 
  }

  public char IsSendBySMS {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_IsSendBySMS_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_IsSendBySMS_get(swigCPtr);
      return ret;
    } 
  }

  public char IsSendByEMail {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_IsSendByEMail_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_IsSendByEMail_get(swigCPtr);
      return ret;
    } 
  }

  public string Sender {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_Sender_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_Sender_get(swigCPtr);
      return ret;
    } 
  }

  public string SendDateTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_SendDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeMessage_SendDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeMessage() : this(TapTradeAPIWrapperPINVOKE.new_TapAPITradeMessage(), true) {
  }

}

}
