//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MediaFormatVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<MediaFormat>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaFormatVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaFormatVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaFormatVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaFormatVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MediaFormatVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (MediaFormat element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public MediaFormat this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(MediaFormat[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(MediaFormat[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, MediaFormat[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<MediaFormat> global::System.Collections.Generic.IEnumerable<MediaFormat>.GetEnumerator() {
    return new MediaFormatVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MediaFormatVectorEnumerator(this);
  }

  public MediaFormatVectorEnumerator GetEnumerator() {
    return new MediaFormatVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MediaFormatVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<MediaFormat>
  {
    private MediaFormatVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MediaFormatVectorEnumerator(MediaFormatVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public MediaFormat Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (MediaFormat)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    pjsua2PINVOKE.MediaFormatVector_Clear(swigCPtr);
  }

  public void Add(MediaFormat x) {
    pjsua2PINVOKE.MediaFormatVector_Add(swigCPtr, MediaFormat.getCPtr(x));
  }

  private uint size() {
    uint ret = pjsua2PINVOKE.MediaFormatVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = pjsua2PINVOKE.MediaFormatVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    pjsua2PINVOKE.MediaFormatVector_reserve(swigCPtr, n);
  }

  public MediaFormatVector() : this(pjsua2PINVOKE.new_MediaFormatVector__SWIG_0(), true) {
  }

  public MediaFormatVector(MediaFormatVector other) : this(pjsua2PINVOKE.new_MediaFormatVector__SWIG_1(MediaFormatVector.getCPtr(other)), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public MediaFormatVector(int capacity) : this(pjsua2PINVOKE.new_MediaFormatVector__SWIG_2(capacity), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  private MediaFormat getitemcopy(int index) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.MediaFormatVector_getitemcopy(swigCPtr, index);
    MediaFormat ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFormat(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private MediaFormat getitem(int index) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.MediaFormatVector_getitem(swigCPtr, index);
    MediaFormat ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFormat(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, MediaFormat val) {
    pjsua2PINVOKE.MediaFormatVector_setitem(swigCPtr, index, MediaFormat.getCPtr(val));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(MediaFormatVector values) {
    pjsua2PINVOKE.MediaFormatVector_AddRange(swigCPtr, MediaFormatVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public MediaFormatVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.MediaFormatVector_GetRange(swigCPtr, index, count);
    MediaFormatVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFormatVector(cPtr, true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, MediaFormat x) {
    pjsua2PINVOKE.MediaFormatVector_Insert(swigCPtr, index, MediaFormat.getCPtr(x));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, MediaFormatVector values) {
    pjsua2PINVOKE.MediaFormatVector_InsertRange(swigCPtr, index, MediaFormatVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    pjsua2PINVOKE.MediaFormatVector_RemoveAt(swigCPtr, index);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    pjsua2PINVOKE.MediaFormatVector_RemoveRange(swigCPtr, index, count);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public static MediaFormatVector Repeat(MediaFormat value, int count) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.MediaFormatVector_Repeat(MediaFormat.getCPtr(value), count);
    MediaFormatVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFormatVector(cPtr, true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    pjsua2PINVOKE.MediaFormatVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    pjsua2PINVOKE.MediaFormatVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, MediaFormatVector values) {
    pjsua2PINVOKE.MediaFormatVector_SetRange(swigCPtr, index, MediaFormatVector.getCPtr(values));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(MediaFormat value) {
    bool ret = pjsua2PINVOKE.MediaFormatVector_Contains(swigCPtr, MediaFormat.getCPtr(value));
    return ret;
  }

  public int IndexOf(MediaFormat value) {
    int ret = pjsua2PINVOKE.MediaFormatVector_IndexOf(swigCPtr, MediaFormat.getCPtr(value));
    return ret;
  }

  public int LastIndexOf(MediaFormat value) {
    int ret = pjsua2PINVOKE.MediaFormatVector_LastIndexOf(swigCPtr, MediaFormat.getCPtr(value));
    return ret;
  }

  public bool Remove(MediaFormat value) {
    bool ret = pjsua2PINVOKE.MediaFormatVector_Remove(swigCPtr, MediaFormat.getCPtr(value));
    return ret;
  }

}
