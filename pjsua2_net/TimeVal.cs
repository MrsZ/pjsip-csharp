//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TimeVal : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TimeVal(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TimeVal obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TimeVal() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_TimeVal(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int sec {
    set {
      pjsua2PINVOKE.TimeVal_sec_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.TimeVal_sec_get(swigCPtr);
      return ret;
    } 
  }

  public int msec {
    set {
      pjsua2PINVOKE.TimeVal_msec_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.TimeVal_msec_get(swigCPtr);
      return ret;
    } 
  }

  public TimeVal() : this(pjsua2PINVOKE.new_TimeVal(), true) {
  }

}
