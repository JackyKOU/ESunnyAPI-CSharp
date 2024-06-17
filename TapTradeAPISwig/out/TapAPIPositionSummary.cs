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

public class TapAPIPositionSummary : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionSummary(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIPositionSummary obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIPositionSummary obj) {
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

  ~TapAPIPositionSummary() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPIPositionSummary(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionPrice {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_PositionPrice_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_PositionPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_PositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_PositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint HisPositionQty {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_HisPositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = TapTradeAPIWrapperPINVOKE.TapAPIPositionSummary_HisPositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionSummary() : this(TapTradeAPIWrapperPINVOKE.new_TapAPIPositionSummary(), true) {
  }

}

}
