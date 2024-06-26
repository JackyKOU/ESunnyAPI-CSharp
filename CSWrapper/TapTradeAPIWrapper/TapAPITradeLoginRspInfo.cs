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

public class TapAPITradeLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeLoginRspInfo obj) {
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

  ~TapAPITradeLoginRspInfo() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPITradeLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginProt {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginProt_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginProt_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string NextSecondDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_NextSecondDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_NextSecondDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginInfo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginRspInfo_LastLoginInfo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginRspInfo() : this(TapTradeAPIWrapperPINVOKE.new_TapAPITradeLoginRspInfo(), true) {
  }

}

}
