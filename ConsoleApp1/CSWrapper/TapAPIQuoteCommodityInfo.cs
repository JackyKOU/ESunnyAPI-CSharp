//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapQuoteAPI {

public class TapAPIQuoteCommodityInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIQuoteCommodityInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIQuoteCommodityInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIQuoteCommodityInfo obj) {
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

  ~TapAPIQuoteCommodityInfo() {
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
          TapQuotePINVOKE.delete_TapAPIQuoteCommodityInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPICommodity Commodity {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_Commodity_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_Commodity_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public string CommodityName {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityName_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityEngName {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityEngName_set(swigCPtr, value);
    } 
    get {
      string ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityEngName_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public double CommodityTickSize {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityTickSize_set(swigCPtr, value);
    } 
    get {
      double ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityTickSize_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityDenominator {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityDenominator_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityDenominator_get(swigCPtr);
      return ret;
    } 
  }

  public char CmbDirect {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CmbDirect_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CmbDirect_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityContractLen {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityContractLen_set(swigCPtr, value);
    } 
    get {
      int ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_CommodityContractLen_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDST {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_IsDST_set(swigCPtr, value);
    } 
    get {
      char ret = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_IsDST_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICommodity RelateCommodity1 {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity1_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity1_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public TapAPICommodity RelateCommodity2 {
    set {
      TapQuotePINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity2_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapQuotePINVOKE.TapAPIQuoteCommodityInfo_RelateCommodity2_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public TapAPIQuoteCommodityInfo() : this(TapQuotePINVOKE.new_TapAPIQuoteCommodityInfo(), true) {
  }

}

}
