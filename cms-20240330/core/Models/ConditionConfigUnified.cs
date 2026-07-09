// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<ApmCompositeCompareConfig> CompareList { get; set; }

        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringCompositeEscalation CompositeEscalation { get; set; }

        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringExpressEscalation ExpressEscalation { get; set; }

        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("prometheus")]
        [Validation(Required=false)]
        public CloudMonitoringPrometheusEscalation Prometheus { get; set; }

        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringSimpleEscalation SimpleEscalation { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<ApmThresholdConfig> ThresholdList { get; set; }

        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<MetricSetMultiTrigger> Triggers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
