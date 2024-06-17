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

public class TapAPITradeContractInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeContractInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeContractInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeContractInfo obj) {
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

  ~TapAPITradeContractInfo() {
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
          TapTradeAPIWrapperPINVOKE.delete_TapAPITradeContractInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo1 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractNo1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractNo1_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice1 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_StrikePrice1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_StrikePrice1_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag1 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CallOrPutFlag1_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CallOrPutFlag1_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char ContractType {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractType_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteUnderlyingContract {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_QuoteUnderlyingContract_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_QuoteUnderlyingContract_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractName {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractName_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractExpDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractExpDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractExpDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastTradeDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_LastTradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_LastTradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string FirstNoticeDate {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_FirstNoticeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_FirstNoticeDate_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeAPIWrapperPINVOKE.TapAPITradeContractInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeContractInfo() : this(TapTradeAPIWrapperPINVOKE.new_TapAPITradeContractInfo(), true) {
  }

}

}