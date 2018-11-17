﻿using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace Analyzer.Utilities.FlowAnalysis.Analysis.TaintedDataAnalysis
{
    internal partial class TaintedDataAnalysis
    {
        private sealed class CoreTaintedDataAnalysisDataDomain : AnalysisEntityMapAbstractDomain<TaintedDataAbstractValue>
        {
            public static readonly CoreTaintedDataAnalysisDataDomain Instance = new CoreTaintedDataAnalysisDataDomain(TaintedDataAbstractValueDomain.Default);

            private CoreTaintedDataAnalysisDataDomain(TaintedDataAbstractValueDomain valueDomain) : base(valueDomain)
            {
            }

            protected override bool CanSkipNewEntry(AnalysisEntity analysisEntity, TaintedDataAbstractValue value)
            {
                return value.Kind == TaintedDataAbstractValueKind.NotTainted;
            }

            protected override TaintedDataAbstractValue GetDefaultValue(AnalysisEntity analysisEntity)
            {
                return TaintedDataAbstractValue.NotTainted;
            }
        }
    }
}
