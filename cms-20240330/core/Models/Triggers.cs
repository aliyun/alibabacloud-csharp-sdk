// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Triggers : TeaModel {
        [NameInMap("comparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<TriggerConditions> Conditions { get; set; }

        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

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

        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("preCondition")]
        [Validation(Required=false)]
        public string PreCondition { get; set; }

        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        [NameInMap("threshold")]
        [Validation(Required=false)]
        public object Threshold { get; set; }

        [NameInMap("times")]
        [Validation(Required=false)]
        public int? Times { get; set; }

    }

}
