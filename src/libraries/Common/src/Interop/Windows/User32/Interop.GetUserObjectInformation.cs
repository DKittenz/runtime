// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class User32
    {
        [DllImport(Libraries.User32, SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true)]
        public static extern unsafe bool GetUserObjectInformationW(IntPtr hObj, int nIndex, void* pvBuffer, uint nLength, ref uint lpnLengthNeeded);
    }
}
