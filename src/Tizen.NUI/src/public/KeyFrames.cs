/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
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

    public class KeyFrames : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal KeyFrames(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.KeyFrames_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KeyFrames obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~KeyFrames()
        {
            DisposeQueue.Instance.Add(this);
        }

        public override void Dispose()
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
                        NDalicPINVOKE.delete_KeyFrames(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }



        public void Add(float progress, object value)
        {
            dynamic obj = value;
            Add(progress, new PropertyValue(obj));
        }

        public void Add(float progress, object value, AlphaFunction alpha)
        {
            dynamic obj = value;
            Add(progress, new PropertyValue(obj), alpha);
        }


        public KeyFrames() : this(NDalicPINVOKE.KeyFrames_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public static KeyFrames DownCast(BaseHandle handle)
        {
            KeyFrames ret = new KeyFrames(NDalicPINVOKE.KeyFrames_DownCast(BaseHandle.getCPtr(handle)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal KeyFrames(KeyFrames handle) : this(NDalicPINVOKE.new_KeyFrames__SWIG_1(KeyFrames.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal KeyFrames Assign(KeyFrames rhs)
        {
            KeyFrames ret = new KeyFrames(NDalicPINVOKE.KeyFrames_Assign(swigCPtr, KeyFrames.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public PropertyType GetType()
        {
            PropertyType ret = (PropertyType)NDalicPINVOKE.KeyFrames_GetType(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Add(float progress, PropertyValue value)
        {
            NDalicPINVOKE.KeyFrames_Add__SWIG_0(swigCPtr, progress, PropertyValue.getCPtr(value));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Add(float progress, PropertyValue value, AlphaFunction alpha)
        {
            NDalicPINVOKE.KeyFrames_Add__SWIG_1(swigCPtr, progress, PropertyValue.getCPtr(value), AlphaFunction.getCPtr(alpha));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
