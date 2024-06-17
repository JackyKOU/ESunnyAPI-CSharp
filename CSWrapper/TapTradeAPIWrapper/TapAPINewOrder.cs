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

public class TapAPINewOrder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPINewOrder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPINewOrder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPINewOrder obj) {
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

  ~TapAPINewOrder() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPINewOrder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint MinClipSize {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_MinClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_MinClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint MaxClipSize {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_MaxClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_MaxClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public double RefDouble {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefDouble_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefDouble_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public char TacticsType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TacticsType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TacticsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerCondition {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TriggerCondition_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TriggerCondition_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerPriceType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TriggerPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_TriggerPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLocationID {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ClientLocationID_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPINewOrder_ClientLocationID_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPINewOrder() : this(TapTradeAPIWrapperPINVOKE.new_TapAPINewOrder(), true) {
  }

}

}