//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Buddy : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Buddy(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Buddy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Buddy() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_Buddy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Buddy() : this(pjsua2PINVOKE.new_Buddy(), true) {
    SwigDirectorConnect();
  }

  public void create(Account acc, BuddyConfig cfg) {
    pjsua2PINVOKE.Buddy_create(swigCPtr, Account.getCPtr(acc), BuddyConfig.getCPtr(cfg));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = pjsua2PINVOKE.Buddy_isValid(swigCPtr);
    return ret;
  }

  public BuddyInfo getInfo() {
    BuddyInfo ret = new BuddyInfo(pjsua2PINVOKE.Buddy_getInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void subscribePresence(bool subscribe) {
    pjsua2PINVOKE.Buddy_subscribePresence(swigCPtr, subscribe);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void updatePresence() {
    pjsua2PINVOKE.Buddy_updatePresence(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendInstantMessage(SendInstantMessageParam prm) {
    pjsua2PINVOKE.Buddy_sendInstantMessage(swigCPtr, SendInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendTypingIndication(SendTypingIndicationParam prm) {
    pjsua2PINVOKE.Buddy_sendTypingIndication(swigCPtr, SendTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onBuddyState() {
    if (SwigDerivedClassHasMethod("onBuddyState", swigMethodTypes0)) pjsua2PINVOKE.Buddy_onBuddyStateSwigExplicitBuddy(swigCPtr); else pjsua2PINVOKE.Buddy_onBuddyState(swigCPtr);
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onBuddyState", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateBuddy_0(SwigDirectoronBuddyState);
    pjsua2PINVOKE.Buddy_director_connect(swigCPtr, swigDelegate0);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Buddy));
    return hasDerivedMethod;
  }

  private void SwigDirectoronBuddyState() {
    onBuddyState();
  }

  public delegate void SwigDelegateBuddy_0();

  private SwigDelegateBuddy_0 swigDelegate0;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
}
