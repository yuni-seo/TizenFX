﻿using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Eext
    {
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_add(IntPtr parent);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_direction_set(IntPtr obj, int direction);

        [DllImport(Libraries.Eext)]
        internal static extern int eext_more_option_direction_get(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_item_append(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_item_del(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_item_domain_translatable_part_text_set(IntPtr item, string part_name, string domain, string text);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_item_insert_after(IntPtr obj, IntPtr after);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_item_insert_before(IntPtr obj, IntPtr before);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_item_part_content_get(IntPtr obj, string part_name);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_item_part_content_set(IntPtr item, string part_name, IntPtr content);

        [DllImport(Libraries.Eext, EntryPoint = "eext_more_option_item_part_text_get")]
        static extern IntPtr _eext_more_option_item_part_text_get(IntPtr item, string part_name);

        internal static string eext_more_option_item_part_text_get(IntPtr item, string part_name)
        {
            var ptr = _eext_more_option_item_part_text_get(item, part_name);
            return Marshal.PtrToStringAnsi(ptr);
        }

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_item_part_text_set(IntPtr item, string part_name, string text);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_item_prepend(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_items_clear(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_more_option_items_get(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern bool eext_more_option_opened_get(IntPtr obj);

        [DllImport(Libraries.Eext)]
        internal static extern void eext_more_option_opened_set(IntPtr obj, bool opened);
    }
}
