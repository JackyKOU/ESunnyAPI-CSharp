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

public class TapAPIIPOInfoQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIIPOInfoQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIIPOInfoQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIIPOInfoQryRsp obj) {
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

  ~TapAPIIPOInfoQryRsp() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIIPOInfoQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BeginDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_BeginDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_BeginDate_get(swigCPtr);
      return ret;
    } 
  }

  public string EndDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_EndDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_EndDate_get(swigCPtr);
      return ret;
    } 
  }

  public string IPODate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_IPODate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_IPODate_get(swigCPtr);
      return ret;
    } 
  }

  public string ResultDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_ResultDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_ResultDate_get(swigCPtr);
      return ret;
    } 
  }

  public double IPOFee {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_IPOFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_IPOFee_get(swigCPtr);
      return ret;
    } 
  }

  public double FinancingFee {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_FinancingFee_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_FinancingFee_get(swigCPtr);
      return ret;
    } 
  }

  public double LoanRatio {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_LoanRatio_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_LoanRatio_get(swigCPtr);
      return ret;
    } 
  }

  public uint FinancingDays {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_FinancingDays_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_FinancingDays_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxLoanRatio {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_MaxLoanRatio_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_MaxLoanRatio_get(swigCPtr);
      return ret;
    } 
  }

  public double MaxLoanValue {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_MaxLoanValue_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_MaxLoanValue_get(swigCPtr);
      return ret;
    } 
  }

  public double Price {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_Price_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_Price_get(swigCPtr);
      return ret;
    } 
  }

  public string OperatorNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_OperatorNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_OperatorNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OperateTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_OperateTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIIPOInfoQryRsp_OperateTime_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIIPOInfoQryRsp() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIIPOInfoQryRsp(), true) {
  }

}

}
