//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AudioDevInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AudioDevInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioDevInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AudioDevInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AudioDevInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string name {
    set {
      pjsua2PINVOKE.AudioDevInfo_name_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AudioDevInfo_name_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint inputCount {
    set {
      pjsua2PINVOKE.AudioDevInfo_inputCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioDevInfo_inputCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint outputCount {
    set {
      pjsua2PINVOKE.AudioDevInfo_outputCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioDevInfo_outputCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint defaultSamplesPerSec {
    set {
      pjsua2PINVOKE.AudioDevInfo_defaultSamplesPerSec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioDevInfo_defaultSamplesPerSec_get(swigCPtr);
      return ret;
    } 
  }

  public string driver {
    set {
      pjsua2PINVOKE.AudioDevInfo_driver_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AudioDevInfo_driver_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint caps {
    set {
      pjsua2PINVOKE.AudioDevInfo_caps_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioDevInfo_caps_get(swigCPtr);
      return ret;
    } 
  }

  public uint routes {
    set {
      pjsua2PINVOKE.AudioDevInfo_routes_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioDevInfo_routes_get(swigCPtr);
      return ret;
    } 
  }

  public MediaFormatVector extFmt {
    set {
      pjsua2PINVOKE.AudioDevInfo_extFmt_set(swigCPtr, MediaFormatVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.AudioDevInfo_extFmt_get(swigCPtr);
      MediaFormatVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFormatVector(cPtr, false);
      return ret;
    } 
  }

  public AudioDevInfo() : this(pjsua2PINVOKE.new_AudioDevInfo(), true) {
  }

}
