// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAutoScalingConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The response code. The value 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoScalingConfigurationResponseBodyData Data { get; set; }
        public class GetAutoScalingConfigurationResponseBodyData : TeaModel {
            /// <summary>
            /// The scheduled scaling rules.
            /// </summary>
            [NameInMap("ScheduledScalingRules")]
            [Validation(Required=false)]
            public GetAutoScalingConfigurationResponseBodyDataScheduledScalingRules ScheduledScalingRules { get; set; }
            public class GetAutoScalingConfigurationResponseBodyDataScheduledScalingRules : TeaModel {
                [NameInMap("ScheduledScalingRules")]
                [Validation(Required=false)]
                public List<GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRules> ScheduledScalingRules { get; set; }
                public class GetAutoScalingConfigurationResponseBodyDataScheduledScalingRulesScheduledScalingRules : TeaModel {
                    /// <summary>
                    /// The duration of a scheduled scaling task. Unit: minutes.
                    /// </summary>
                    [NameInMap("DurationMinutes")]
                    [Validation(Required=false)]
                    public long? DurationMinutes { get; set; }

                    /// <summary>
                    /// Indicates whether the scheduled scaling rule is enabled. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// The estimated scale-in duration. Unit: seconds.
                    /// </summary>
                    [NameInMap("EstimatedElasticScalingDownTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingDownTimeSecs { get; set; }

                    /// <summary>
                    /// The estimated scale-out duration. Unit: seconds.
                    /// </summary>
                    [NameInMap("EstimatedElasticScalingUpTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingUpTimeSecs { get; set; }

                    /// <summary>
                    /// The timestamp that indicates the start time of the scheduled scaling task.
                    /// </summary>
                    [NameInMap("FirstScheduledTime")]
                    [Validation(Required=false)]
                    public long? FirstScheduledTime { get; set; }

                    /// <summary>
                    /// The frequency at which the scheduled scaling task is executed. This parameter is returned only if ScheduleType is set to repeat. Valid values:
                    /// 
                    /// *   Daily: The scheduled scaling task is executed every day.
                    /// 
                    /// *   Weekly: The scheduled scaling task is executed every week.
                    /// </summary>
                    [NameInMap("RepeatType")]
                    [Validation(Required=false)]
                    public string RepeatType { get; set; }

                    /// <summary>
                    /// The reserved production capacity for scheduled scaling. Unit: MB/s.
                    /// </summary>
                    [NameInMap("ReservedPubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedPubFlow { get; set; }

                    /// <summary>
                    /// The reserved consumption capacity for scheduled scaling. Unit: MB/s.
                    /// </summary>
                    [NameInMap("ReservedSubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedSubFlow { get; set; }

                    /// <summary>
                    /// The ID of the scheduled scaling rule.
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    /// <summary>
                    /// The name of the scheduled scaling rule.
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// The type of the scheduled scaling task. Valid values:
                    /// 
                    /// *   at: The scheduled scaling task is executed only once.
                    /// *   repeat: The scheduled scaling task is repeatedly executed.
                    /// </summary>
                    [NameInMap("ScheduleType")]
                    [Validation(Required=false)]
                    public string ScheduleType { get; set; }

                    /// <summary>
                    /// The time zone in Coordinated Universal Time (UTC).
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                    /// <summary>
                    /// The day on which the scheduled scaling task is repeatedly executed. You can specify multiple days for this parameter.
                    /// </summary>
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

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
