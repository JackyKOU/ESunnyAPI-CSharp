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

public class TapAPIAccountInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountInfo obj) {
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

  ~TapAPIAccountInfo() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIAccountInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountType_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountState {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountState_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountTradeRight {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountTradeRight_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityGroupNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_CommodityGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountShortName {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountShortName_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountEnShortName {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountInfo_AccountEnShortName_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountInfo() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIAccountInfo(), true) {
  }

}

}