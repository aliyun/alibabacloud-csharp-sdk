// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAutoScalingConfigurationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoScalingConfigurationResponseBodyData Data { get; set; }
        public class GetAutoScalingConfigurationResponseBodyData : TeaModel {
            [NameInMap("ScheduledScalingRules")]
            [Validation(Required=false)]
            public GetAutoScalingConfigurationResponseBodyDataScheduledScalingRules ScheduledScalingRules { get; set; }
            public class GetAutoScalingConfigurationResponseBodyDataScheduledScalingRules : TeaModel {
                [NameInMap("ScheduledScalingRules")]
                [Validation(Required=false)]
                public List<GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRules> ScheduledScalingRules { get; set; }
                public class GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRules : TeaModel {
                    [NameInMap("DurationMinutes")]
                    [Validation(Required=false)]
                    public long? DurationMinutes { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    [NameInMap("EstimatedElasticScalingDownTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingDownTimeSecs { get; set; }

                    [NameInMap("EstimatedElasticScalingUpTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingUpTimeSecs { get; set; }

                    [NameInMap("FirstScheduledTime")]
                    [Validation(Required=false)]
                    public long? FirstScheduledTime { get; set; }

                    [NameInMap("RepeatType")]
                    [Validation(Required=false)]
                    public string RepeatType { get; set; }

                    [NameInMap("ReservedPubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedPubFlow { get; set; }

                    [NameInMap("ReservedSubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedSubFlow { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("ScheduleType")]
                    [Validation(Required=false)]
                    public string ScheduleType { get; set; }

                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                    [NameInMap("WeeklyTypes")]
                    [Validation(Required=false)]
                    public GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRulesWeeklyTypes WeeklyTypes { get; set; }
                    public class GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRulesWeeklyTypes : TeaModel {
                        [NameInMap("WeeklyTypes")]
                        [Validation(Required=false)]
                        public List<string> WeeklyTypes { get; set; }

                    }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
