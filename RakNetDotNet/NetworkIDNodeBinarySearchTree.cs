/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNetDotNet {

using System;
using System.Runtime.InteropServices;

public class NetworkIDNodeBinarySearchTree : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NetworkIDNodeBinarySearchTree(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NetworkIDNodeBinarySearchTree obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NetworkIDNodeBinarySearchTree() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        RakNetPINVOKE.delete_NetworkIDNodeBinarySearchTree(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public NetworkIDNodeBinarySearchTree() : this(RakNetPINVOKE.new_NetworkIDNodeBinarySearchTree__SWIG_0(), true) {
  }

  public NetworkIDNodeBinarySearchTree(NetworkIDNodeBinarySearchTree original_type) : this(RakNetPINVOKE.new_NetworkIDNodeBinarySearchTree__SWIG_1(NetworkIDNodeBinarySearchTree.getCPtr(original_type)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.NetworkIDNodeBinarySearchTree_Size(swigCPtr);
    return ret;
  }

  public void Clear() {
    RakNetPINVOKE.NetworkIDNodeBinarySearchTree_Clear(swigCPtr);
  }

  public void DisplayInorder(NetworkIDNode return_array) {
    RakNetPINVOKE.NetworkIDNodeBinarySearchTree_DisplayInorder(swigCPtr, NetworkIDNode.getCPtr(return_array));
  }

  public void DisplayPreorder(NetworkIDNode return_array) {
    RakNetPINVOKE.NetworkIDNodeBinarySearchTree_DisplayPreorder(swigCPtr, NetworkIDNode.getCPtr(return_array));
  }

  public void DisplayPostorder(NetworkIDNode return_array) {
    RakNetPINVOKE.NetworkIDNodeBinarySearchTree_DisplayPostorder(swigCPtr, NetworkIDNode.getCPtr(return_array));
  }

  public void DisplayBreadthFirstSearch(NetworkIDNode return_array) {
    RakNetPINVOKE.NetworkIDNodeBinarySearchTree_DisplayBreadthFirstSearch(swigCPtr, NetworkIDNode.getCPtr(return_array));
  }

  public NetworkIDNode GetPointerToNode(NetworkIDNode element) {
    IntPtr cPtr = RakNetPINVOKE.NetworkIDNodeBinarySearchTree_GetPointerToNode(swigCPtr, NetworkIDNode.getCPtr(element));
    NetworkIDNode ret = (cPtr == IntPtr.Zero) ? null : new NetworkIDNode(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
