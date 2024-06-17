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

public class TapAPITradeLoginAuth : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginAuth obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeLoginAuth obj) {
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

  ~TapAPITradeLoginAuth() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPITradeLoginAuth(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ISModifyPassword {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_Password_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginIP {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_LoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_LoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginMac {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_LoginMac_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_LoginMac_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceName {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_DeviceName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeLoginAuth_DeviceName_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginAuth() : this(TapTradeAPIWrapperPINVOKE.new_TapAPITradeLoginAuth(), true) {
  }

}

}