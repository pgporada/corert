// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal unsafe partial class Sys
    {
        [DllImport(Interop.Libraries.CoreLibNative, EntryPoint = "CoreLibNative_GetHighPrecisionCount")]
        internal static extern ulong GetHighPrecisionCount();

        [DllImport(Interop.Libraries.CoreLibNative, EntryPoint = "CoreLibNative_GetHighPrecisionCounterFrequency")]
        internal static extern ulong GetHighPrecisionCounterFrequency();
    }
}
