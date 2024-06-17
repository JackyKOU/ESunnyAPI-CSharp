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

public class TapAPIOrderLocalRemoveRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderLocalRemoveRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderLocalRemoveRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIOrderLocalRemoveRsp obj) {
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

  ~TapAPIOrderLocalRemoveRsp() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIOrderLocalRemoveRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPIOrderLocalRemoveReq req {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_req_set(swigCPtr, TapAPIOrderLocalRemoveReq.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_req_get(swigCPtr);
      TapAPIOrderLocalRemoveReq ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIOrderLocalRemoveReq(cPtr, false);
      return ret;
    } 
  }

  public string ClientLocalIP {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientLocalIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientLocalIP_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientMac {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientMac_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientMac_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIP {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalRemoveRsp_ClientIP_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderLocalRemoveRsp() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIOrderLocalRemoveRsp(), true) {
  }

}

}