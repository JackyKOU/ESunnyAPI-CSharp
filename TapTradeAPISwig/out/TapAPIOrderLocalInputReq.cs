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

public class TapAPIOrderLocalInputReq : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIOrderLocalInputReq(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIOrderLocalInputReq obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIOrderLocalInputReq obj) {
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

  ~TapAPIOrderLocalInputReq() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIOrderLocalInputReq(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSystemNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeSystemNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderExchangeSystemNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderExchangeSystemNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderMatchPrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMatchQty2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderMatchQty2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderState {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderState_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_OrderState_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public string LowerAccount {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_LowerAccount_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIOrderLocalInputReq_LowerAccount_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIOrderLocalInputReq() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIOrderLocalInputReq(), true) {
  }

}

}
