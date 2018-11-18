﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Analyzer.Utilities;

namespace Microsoft.CodeAnalysis.FlowAnalysis.DataFlow
{
    internal abstract partial class AbstractIndex
    {
        private sealed class ConstantValueIndex : AbstractIndex
        {
            public ConstantValueIndex(int index)
            {
                Index = index;
            }

            public int Index { get; }

#pragma warning disable CA1307 // Specify StringComparison - string.GetHashCode(StringComparison) not available in all projects that reference this shared project
            protected override int ComputeHashCode() => HashUtilities.Combine(Index.GetHashCode(), nameof(ConstantValueIndex).GetHashCode());
#pragma warning restore CA1307 // Specify StringComparison
        }
    }
}
