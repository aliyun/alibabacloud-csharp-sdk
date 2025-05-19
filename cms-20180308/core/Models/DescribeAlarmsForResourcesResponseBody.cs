// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DescribeAlarmsForResourcesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeAlarmsForResourcesResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeAlarmsForResourcesResponseBodyDatapoints : TeaModel {
            [NameInMap("Alarm")]
            [Validation(Required=false)]
            public List<DescribeAlarmsForResourcesResponseBodyDatapointsAlarm> Alarm { get; set; }
            public class DescribeAlarmsForResourcesResponseBodyDatapointsAlarm : TeaModel {
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public string ContactGroups { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("EffectiveInterval")]
                [Validation(Required=false)]
                public string EffectiveInterval { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("Escalations")]
                [Validation(Required=false)]
                public DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalations Escalations { get; set; }
                public class DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalations : TeaModel {
                    [NameInMap("Critical")]
                    [Validation(Required=false)]
                    public DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsCritical Critical { get; set; }
                    public class DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsCritical : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    [NameInMap("Info")]
                    [Validation(Required=false)]
                    public DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsInfo Info { get; set; }
                    public class DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsInfo : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                    [NameInMap("Warn")]
                    [Validation(Required=false)]
                    public DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsWarn Warn { get; set; }
                    public class DescribeAlarmsForResourcesResponseBodyDatapointsAlarmEscalationsWarn : TeaModel {
                        [NameInMap("ComparisonOperator")]
                        [Validation(Required=false)]
                        public string ComparisonOperator { get; set; }

                        [NameInMap("Statistics")]
                        [Validation(Required=false)]
                        public string Statistics { get; set; }

                        [NameInMap("Threshold")]
                        [Validation(Required=false)]
                        public string Threshold { get; set; }

                        [NameInMap("Times")]
                        [Validation(Required=false)]
                        public string Times { get; set; }

                    }

                }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NoEffectiveInterval")]
                [Validation(Required=false)]
                public string NoEffectiveInterval { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("Resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                [NameInMap("SilenceTime")]
                [Validation(Required=false)]
                public string SilenceTime { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

                [NameInMap("Webhook")]
                [Validation(Required=false)]
                public string Webhook { get; set; }

            }

        }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
