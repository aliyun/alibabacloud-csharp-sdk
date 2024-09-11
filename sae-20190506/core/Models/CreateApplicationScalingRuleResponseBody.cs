// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateApplicationScalingRuleResponseBodyData Data { get; set; }
        public class CreateApplicationScalingRuleResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("EnableIdle")]
            [Validation(Required=false)]
            public bool? EnableIdle { get; set; }

            [NameInMap("LastDisableTime")]
            [Validation(Required=false)]
            public long? LastDisableTime { get; set; }

            [NameInMap("Metric")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyDataMetric Metric { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataMetric : TeaModel {
                [NameInMap("MaxReplicas")]
                [Validation(Required=false)]
                public int? MaxReplicas { get; set; }

                [NameInMap("Metrics")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyDataMetricMetrics> Metrics { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataMetricMetrics : TeaModel {
                    [NameInMap("MetricTargetAverageUtilization")]
                    [Validation(Required=false)]
                    public int? MetricTargetAverageUtilization { get; set; }

                    [NameInMap("MetricType")]
                    [Validation(Required=false)]
                    public string MetricType { get; set; }

                    [NameInMap("SlbId")]
                    [Validation(Required=false)]
                    public string SlbId { get; set; }

                    [NameInMap("SlbLogstore")]
                    [Validation(Required=false)]
                    public string SlbLogstore { get; set; }

                    [NameInMap("SlbProject")]
                    [Validation(Required=false)]
                    public string SlbProject { get; set; }

                    [NameInMap("Vport")]
                    [Validation(Required=false)]
                    public string Vport { get; set; }

                }

                [NameInMap("MinReplicas")]
                [Validation(Required=false)]
                public int? MinReplicas { get; set; }

            }

            [NameInMap("ScaleRuleEnabled")]
            [Validation(Required=false)]
            public bool? ScaleRuleEnabled { get; set; }

            [NameInMap("ScaleRuleName")]
            [Validation(Required=false)]
            public string ScaleRuleName { get; set; }

            [NameInMap("ScaleRuleType")]
            [Validation(Required=false)]
            public string ScaleRuleType { get; set; }

            [NameInMap("Timer")]
            [Validation(Required=false)]
            public CreateApplicationScalingRuleResponseBodyDataTimer Timer { get; set; }
            public class CreateApplicationScalingRuleResponseBodyDataTimer : TeaModel {
                [NameInMap("BeginDate")]
                [Validation(Required=false)]
                public string BeginDate { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("Schedules")]
                [Validation(Required=false)]
                public List<CreateApplicationScalingRuleResponseBodyDataTimerSchedules> Schedules { get; set; }
                public class CreateApplicationScalingRuleResponseBodyDataTimerSchedules : TeaModel {
                    [NameInMap("AtTime")]
                    [Validation(Required=false)]
                    public string AtTime { get; set; }

                    [NameInMap("MaxReplicas")]
                    [Validation(Required=false)]
                    public int? MaxReplicas { get; set; }

                    [NameInMap("MinReplicas")]
                    [Validation(Required=false)]
                    public int? MinReplicas { get; set; }

                    [NameInMap("TargetReplicas")]
                    [Validation(Required=false)]
                    public int? TargetReplicas { get; set; }

                }

            }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
