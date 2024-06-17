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

public class TapAPIVerifyIdentityReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIVerifyIdentityReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIVerifyIdentityReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIVerifyIdentityReq obj) {
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

  ~TapAPIVerifyIdentityReq() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIVerifyIdentityReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CertificateType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_CertificateType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_CertificateType_get(swigCPtr);
      return ret;
    } 
  }

  public string CertificateNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_CertificateNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_CertificateNo_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public string PhoneNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_PhoneNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIVerifyIdentityReq_PhoneNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIVerifyIdentityReq() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIVerifyIdentityReq(), true) {
  }

}

}
