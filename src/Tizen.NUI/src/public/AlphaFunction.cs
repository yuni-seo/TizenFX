//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI
{

    public class AlphaFunction : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal AlphaFunction(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AlphaFunction obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~AlphaFunction()
        {
            DisposeQueue.Instance.Add(this);
        }

        public virtual void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_AlphaFunction(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }


        public AlphaFunction(System.Delegate func) : this(NDalicPINVOKE.new_AlphaFunction__SWIG_2(SWIGTYPE_p_f_float__float.getCPtr(new SWIGTYPE_p_f_float__float(System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(func), true))), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public AlphaFunction() : this(NDalicPINVOKE.new_AlphaFunction__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public AlphaFunction(AlphaFunction.BuiltinFunctions function) : this(NDalicPINVOKE.new_AlphaFunction__SWIG_1((int)function), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal AlphaFunction(SWIGTYPE_p_f_float__float function) : this(NDalicPINVOKE.new_AlphaFunction__SWIG_2(SWIGTYPE_p_f_float__float.getCPtr(function)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public AlphaFunction(Vector2 controlPoint0, Vector2 controlPoint1) : this(NDalicPINVOKE.new_AlphaFunction__SWIG_3(Vector2.getCPtr(controlPoint0), Vector2.getCPtr(controlPoint1)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void GetBezierControlPoints(out Vector2 controlPoint0, out Vector2 controlPoint1)
        {
            Vector4 ret = new Vector4(NDalicPINVOKE.AlphaFunction_GetBezierControlPoints(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            controlPoint0 = new Vector2(ret.X, ret.Y);
            controlPoint1 = new Vector2(ret.Z, ret.W);
        }

        internal SWIGTYPE_p_f_float__float GetCustomFunction()
        {
            global::System.IntPtr cPtr = NDalicPINVOKE.AlphaFunction_GetCustomFunction(swigCPtr);
            SWIGTYPE_p_f_float__float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_float__float(cPtr, false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public AlphaFunction.BuiltinFunctions GetBuiltinFunction()
        {
            AlphaFunction.BuiltinFunctions ret = (AlphaFunction.BuiltinFunctions)NDalicPINVOKE.AlphaFunction_GetBuiltinFunction(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public AlphaFunction.Modes GetMode()
        {
            AlphaFunction.Modes ret = (AlphaFunction.Modes)NDalicPINVOKE.AlphaFunction_GetMode(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public enum BuiltinFunctions
        {
            Default,
            Linear,
            Reverse,
            EaseInSquare,
            EaseOutSquare,
            EaseIn,
            EaseOut,
            EaseInOut,
            EaseInSine,
            EaseOutSine,
            EaseInOutSine,
            Bounce,
            Sin,
            EaseOutBack,
            Count
        }

        public enum Modes
        {
            CustomFunction = 1,
            Bezier
        }

    }

}
