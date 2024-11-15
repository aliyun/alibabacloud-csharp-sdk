// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAutoScalingConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAutoScalingConfigurationResponseBodyData Data { get; set; }
        public class GetAutoScalingConfigurationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The scheduled scaling rules.</para>
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
                    /// <para>The duration of a scheduled scaling task. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("DurationMinutes")]
                    [Validation(Required=false)]
                    public long? DurationMinutes { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the scheduled scaling rule is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The estimated scale-in duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>780</para>
                    /// </summary>
                    [NameInMap("EstimatedElasticScalingDownTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingDownTimeSecs { get; set; }

                    /// <summary>
                    /// <para>The estimated scale-out duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>780</para>
                    /// </summary>
                    [NameInMap("EstimatedElasticScalingUpTimeSecs")]
                    [Validation(Required=false)]
                    public long? EstimatedElasticScalingUpTimeSecs { get; set; }

                    /// <summary>
                    /// <para>The timestamp that indicates the start time of the scheduled scaling task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1714467540000</para>
                    /// </summary>
                    [NameInMap("FirstScheduledTime")]
                    [Validation(Required=false)]
                    public long? FirstScheduledTime { get; set; }

                    /// <summary>
                    /// <para>The frequency at which the scheduled scaling task is executed. This parameter is returned only if ScheduleType is set to repeat. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Daily: The scheduled scaling task is executed every day.</para>
                    /// </description></item>
                    /// <item><description><para>Weekly: The scheduled scaling task is executed every week.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Weekly</para>
                    /// </summary>
                    [NameInMap("RepeatType")]
                    [Validation(Required=false)]
                    public string RepeatType { get; set; }

                    /// <summary>
                    /// <para>The reserved production capacity for scheduled scaling. Unit: MB/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("ReservedPubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedPubFlow { get; set; }

                    /// <summary>
                    /// <para>The reserved consumption capacity for scheduled scaling. Unit: MB/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("ReservedSubFlow")]
                    [Validation(Required=false)]
                    public long? ReservedSubFlow { get; set; }

                    /// <summary>
                    /// <para>The ID of the scheduled scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public long? RuleId { get; set; }

                    /// <summary>
                    /// <para>The name of the scheduled scaling rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The type of the scheduled scaling task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>at: The scheduled scaling task is executed only once.</description></item>
                    /// <item><description>repeat: The scheduled scaling task is repeatedly executed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>at</para>
                    /// </summary>
                    [NameInMap("ScheduleType")]
                    [Validation(Required=false)]
                    public string ScheduleType { get; set; }

                    /// <summary>
                    /// <para>The time zone in Coordinated Universal Time (UTC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GMT+8</para>
                    /// </summary>
                    [NameInMap("TimeZone")]
                    [Validation(Required=false)]
                    public string TimeZone { get; set; }

                    /// <summary>
                    /// <para>The day on which the scheduled scaling task is repeatedly executed. You can specify multiple days for this parameter.</para>
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
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7A39AE5-0B36-4442-A304-E0885265***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
