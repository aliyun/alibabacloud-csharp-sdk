// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeAlarmsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("AlarmList")]
        [Validation(Required=false)]
        public DescribeAlarmsResponseBodyAlarmList AlarmList { get; set; }
        public class DescribeAlarmsResponseBodyAlarmList : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeAlarmsResponseBodyAlarmListAlarm> Alarm { get; set; }
            public class DescribeAlarmsResponseBodyAlarmListAlarm : TeaModel {
                public string AlarmTaskId { get; set; }
                public string MetricName { get; set; }
                public int? EvaluationCount { get; set; }
                public string State { get; set; }
                public int? Period { get; set; }
                public string ScalingGroupId { get; set; }
                public string ComparisonOperator { get; set; }
                public string Effective { get; set; }
                public string Description { get; set; }
                public string MetricType { get; set; }
                public string Name { get; set; }
                public float? Threshold { get; set; }
                public bool? Enable { get; set; }
                public string Statistics { get; set; }
                public DescribeAlarmsResponseBodyAlarmListAlarmDimensions Dimensions { get; set; }
                public class DescribeAlarmsResponseBodyAlarmListAlarmDimensions : TeaModel {
                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public List<DescribeAlarmsResponseBodyAlarmListAlarmDimensionsDimension> Dimension { get; set; }
                    public class DescribeAlarmsResponseBodyAlarmListAlarmDimensionsDimension : TeaModel {
                        [NameInMap("DimensionKey")]
                        [Validation(Required=false)]
                        public string DimensionKey { get; set; }

                        [NameInMap("DimensionValue")]
                        [Validation(Required=false)]
                        public string DimensionValue { get; set; }

                    }

                }
                public DescribeAlarmsResponseBodyAlarmListAlarmAlarmActions AlarmActions { get; set; }
                public class DescribeAlarmsResponseBodyAlarmListAlarmAlarmActions : TeaModel {
                    [NameInMap("AlarmAction")]
                    [Validation(Required=false)]
                    public List<string> AlarmAction { get; set; }

                }
            }
        };

    }

}
