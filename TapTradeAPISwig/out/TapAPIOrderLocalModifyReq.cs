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

public class TapAPIOrderLocalModifyReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderLocalModifyReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderLocalModifyReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIOrderLocalModifyReq obj) {
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

  ~TapAPIOrderLocalModifyReq() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIOrderLocalModifyReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPIOrderLocalInputReq req {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_req_set(swigCPtr, TapAPIOrderLocalInputReq.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_req_get(swigCPtr);
      TapAPIOrderLocalInputReq ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderLocalInputReq(cPtr, false);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalModifyReq_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderLocalModifyReq() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIOrderLocalModifyReq(), true) {
  }

}

}
