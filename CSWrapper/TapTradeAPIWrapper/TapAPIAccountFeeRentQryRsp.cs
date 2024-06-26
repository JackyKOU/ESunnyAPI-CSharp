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

public class TapAPIAccountFeeRentQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountFeeRentQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountFeeRentQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountFeeRentQryRsp obj) {
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

  ~TapAPIAccountFeeRentQryRsp() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIAccountFeeRentQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char CalculateMode {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CalculateMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CalculateMode_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCloseFee {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_OpenCloseFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_OpenCloseFee_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayFee {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CloseTodayFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIAccountFeeRentQryRsp_CloseTodayFee_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountFeeRentQryRsp() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIAccountFeeRentQryRsp(), true) {
  }

}

}
