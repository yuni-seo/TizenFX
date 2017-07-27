/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace ElmSharp.Wearable
{
    /// <summary>
    /// The Circle DateTime Selector is a widget to display and handle datetime value by rotary event
    /// Inherits <see cref="DateTimeSelector"/>
    /// </summary>
    public class CircleDateTimeSelector : DateTimeSelector
    {
        IntPtr circleHandle;

        /// <summary>
        /// Creates and initializes a new instance of the Circle DateTime class
        /// </summary>
        /// <param name="parent">The parent of new Circle DateTime instance</param>
        public CircleDateTimeSelector(EvasObject parent) : base(parent) { }

        /// <summary>
        /// Sets or gets the disabled state of the Circle DateTime Selector
        /// </summary>
        public bool Disabled
        {
            get
            {
                return Interop.Eext.eext_circle_object_disabled_get(circleHandle);
            }
            set
            {
                Interop.Eext.eext_circle_object_disabled_set(circleHandle, value);
            }
        }

        /// <summary>
        /// Sets or gets the color of the marker
        /// </summary>
        public Color MarkerColor
        {
            get
            {
                int r, g, b, a;
                Interop.Eext.eext_circle_object_item_color_get(circleHandle, "default", out r, out g, out b, out a);
                return new Color(r, g, b, a);
            }
            set
            {
                Interop.Eext.eext_circle_object_item_color_set(circleHandle, "default", value.R, value.G, value.B, value.A);
            }
        }

        /// <summary>
        /// Sets or gets the line width of the marker
        /// </summary>
        public int MarkerLineWidth
        {
            get
            {
                return Interop.Eext.eext_circle_object_item_line_width_get(circleHandle, "default");
            }
            set
            {
                Interop.Eext.eext_circle_object_item_line_width_set(circleHandle, "default", value);
            }
        }

        /// <summary>
        /// Sets or gets the radius at which the center of the marker lies
        /// </summary>
        public double MarkerRadius
        {
            get
            {
                return Interop.Eext.eext_circle_object_item_radius_get(circleHandle, "default");
            }
            set
            {
                Interop.Eext.eext_circle_object_item_radius_set(circleHandle, "default", value);
            }
        }

        protected override IntPtr CreateHandle(EvasObject parent)
        {
            var handle = base.CreateHandle(parent);

            IntPtr surface = IntPtr.Zero;

            if (parent is Conformant)
            {
                surface = Interop.Eext.eext_circle_surface_conformant_add(parent);
            }
            else if (parent is Naviframe)
            {
                surface = Interop.Eext.eext_circle_surface_naviframe_add(parent.RealHandle);
            }
            else if (parent is Layout)
            {
                surface = Interop.Eext.eext_circle_surface_layout_add(parent);
            }

            circleHandle = Interop.Eext.eext_circle_object_datetime_add(RealHandle, surface);
            if (surface == IntPtr.Zero)
            {
                EvasObject p = parent;
                while (!(p is Window))
                {
                    p = p.Parent;
                }
                var w = (p as Window).ScreenSize.Width;
                var h = (p as Window).ScreenSize.Height;
                Interop.Evas.evas_object_resize(circleHandle, w, h);
            }

            Interop.Eext.eext_rotary_object_event_activated_set(circleHandle, true);

            return handle;
        }
    }
}