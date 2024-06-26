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

public class TapAPIAccountIPOAddReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountIPOAddReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountIPOAddReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountIPOAddReq obj) {
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

  ~TapAPIAccountIPOAddReq() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIAccountIPOAddReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ApplyType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ApplyType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ApplyType_get(swigCPtr);
      return ret;
    } 
  }

  public uint ApplyQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ApplyQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_ApplyQty_get(swigCPtr);
      return ret;
    } 
  }

  public double LoanRatio {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_LoanRatio_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountIPOAddReq_LoanRatio_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountIPOAddReq() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIAccountIPOAddReq(), true) {
  }

}

}
