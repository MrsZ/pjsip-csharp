//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class pjmedia_tone_desc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal pjmedia_tone_desc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(pjmedia_tone_desc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~pjmedia_tone_desc() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_pjmedia_tone_desc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public short freq1 {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_freq1_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_freq1_get(swigCPtr);
      return ret;
    } 
  }

  public short freq2 {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_freq2_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_freq2_get(swigCPtr);
      return ret;
    } 
  }

  public short on_msec {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_on_msec_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_on_msec_get(swigCPtr);
      return ret;
    } 
  }

  public short off_msec {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_off_msec_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_off_msec_get(swigCPtr);
      return ret;
    } 
  }

  public short volume {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_volume_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_volume_get(swigCPtr);
      return ret;
    } 
  }

  public short flags {
    set {
      pjsua2PINVOKE.pjmedia_tone_desc_flags_set(swigCPtr, value);
    } 
    get {
      short ret = pjsua2PINVOKE.pjmedia_tone_desc_flags_get(swigCPtr);
      return ret;
    } 
  }

  public pjmedia_tone_desc() : this(pjsua2PINVOKE.new_pjmedia_tone_desc(), true) {
  }

}
