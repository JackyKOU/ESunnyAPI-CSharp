//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteAPI {

public class TapAPIQuotLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuotLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuotLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIQuotLoginRspInfo obj) {
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

  ~TapAPIQuotLoginRspInfo() {
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
          TapQuotePINVOKE.delete_TapAPIQuotLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginProt {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_set(swigCPtr, value);
    } 
    get {
      uint ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginProt_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string InitTime {
    set {
      TapQuotePINVOKE.TapAPIQuotLoginRspInfo_InitTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuotLoginRspInfo_InitTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIQuotLoginRspInfo() : this(TapQuotePINVOKE.new_TapAPIQuotLoginRspInfo(), true) {
  }

}

}
