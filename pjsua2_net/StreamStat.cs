//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class StreamStat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StreamStat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StreamStat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamStat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_StreamStat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RtcpStat rtcp {
    set {
      pjsua2PINVOKE.StreamStat_rtcp_set(swigCPtr, RtcpStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.StreamStat_rtcp_get(swigCPtr);
      RtcpStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new RtcpStat(cPtr, false);
      return ret;
    } 
  }

  public JbufState jbuf {
    set {
      pjsua2PINVOKE.StreamStat_jbuf_set(swigCPtr, JbufState.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.StreamStat_jbuf_get(swigCPtr);
      JbufState ret = (cPtr == global::System.IntPtr.Zero) ? null : new JbufState(cPtr, false);
      return ret;
    } 
  }

  public StreamStat() : this(pjsua2PINVOKE.new_StreamStat(), true) {
  }

}
