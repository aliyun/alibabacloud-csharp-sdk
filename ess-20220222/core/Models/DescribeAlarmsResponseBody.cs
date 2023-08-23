// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public List<DescribeAlarmsResponseBodyAlarmList> AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            [NameInMap("AlarmActions")]
            [Validation(Required=false)]
            public List<string> AlarmActions { get; set; }

            [NameInMap("AlarmTaskId")]
            [Validation(Required=false)]
            public string AlarmTaskId { get; set; }

            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListDimensions> Dimensions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListDimensions : TeaModel {
                [NameInMap("DimensionKey")]
                [Validation(Required=false)]
                public string DimensionKey { get; set; }

                [NameInMap("DimensionValue")]
                [Validation(Required=false)]
                public string DimensionValue { get; set; }

            }

            [NameInMap("Effective")]
            [Validation(Required=false)]
            public string Effective { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            [NameInMap("Expressions")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListExpressions> Expressions { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListExpressions : TeaModel {
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public float? Threshold { get; set; }

            }

            [NameInMap("ExpressionsLogicOperator")]
            [Validation(Required=false)]
            public string ExpressionsLogicOperator { get; set; }

            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
