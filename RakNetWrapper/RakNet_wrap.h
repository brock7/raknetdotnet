/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 * 
 * This file is not intended to be easily readable and contains a number of 
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG 
 * interface file instead. 
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_RakNet_WRAP_H_
#define SWIG_RakNet_WRAP_H_

class SwigDirector_NetworkIDGenerator : public NetworkIDGenerator, public Swig::Director {

public:
    SwigDirector_NetworkIDGenerator();
    virtual ~SwigDirector_NetworkIDGenerator();
    virtual NetworkID GetNetworkID();
    virtual void SetNetworkID(NetworkID id);
    virtual void SetParent(void *_parent);
    virtual void *GetParent() const;
    virtual bool IsNetworkIDAuthority() const;
    virtual bool RequiresSetParent() const;

    typedef void * (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void *);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void*);
    typedef void* (SWIGSTDCALL* SWIG_Callback3_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback4_t)();
    typedef unsigned int (SWIGSTDCALL* SWIG_Callback5_t)();
    void swig_connect_director(SWIG_Callback0_t callbackGetNetworkID, SWIG_Callback1_t callbackSetNetworkID, SWIG_Callback2_t callbackSetParent, SWIG_Callback3_t callbackGetParent, SWIG_Callback4_t callbackIsNetworkIDAuthority, SWIG_Callback5_t callbackRequiresSetParent);

private:
    SWIG_Callback0_t swig_callbackGetNetworkID;
    SWIG_Callback1_t swig_callbackSetNetworkID;
    SWIG_Callback2_t swig_callbackSetParent;
    SWIG_Callback3_t swig_callbackGetParent;
    SWIG_Callback4_t swig_callbackIsNetworkIDAuthority;
    SWIG_Callback5_t swig_callbackRequiresSetParent;
    void swig_init_callbacks();
};


#endif
