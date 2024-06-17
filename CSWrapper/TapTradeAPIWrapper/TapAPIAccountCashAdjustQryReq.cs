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

public class TapAPIAccountCashAdjustQryReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountCashAdjustQryReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountCashAdjustQryReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountCashAdjustQryReq obj) {
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

  ~TapAPIAccountCashAdjustQryReq() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIAccountCashAdjustQryReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint SerialID {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_SerialID_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_SerialID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BeginDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_BeginDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_BeginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string EndDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_EndDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountCashAdjustQryReq_EndDate_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountCashAdjustQryReq() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIAccountCashAdjustQryReq(), true) {
  }

}

}
