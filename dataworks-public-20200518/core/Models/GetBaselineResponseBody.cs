// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineResponseBodyData Data { get; set; }
        public class GetBaselineResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Specifies whether alerts are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AlertEnabled")]
            [Validation(Required=false)]
            public bool? AlertEnabled { get; set; }

            /// <summary>
            /// <para>The alert margin threshold, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AlertMarginThreshold")]
            [Validation(Required=false)]
            public int? AlertMarginThreshold { get; set; }

            /// <summary>
            /// <para>The alert settings.</para>
            /// </summary>
            [NameInMap("AlertSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataAlertSettings> AlertSettings { get; set; }
            public class GetBaselineResponseBodyDataAlertSettings : TeaModel {
                /// <summary>
                /// <para>The event alerting interval, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("AlertInterval")]
                [Validation(Required=false)]
                public int? AlertInterval { get; set; }

                /// <summary>
                /// <para>The maximum number of event alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertMaximum")]
                [Validation(Required=false)]
                public int? AlertMaximum { get; set; }

                /// <summary>
                /// <para>The list of alert methods.</para>
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// <para>The details of the alert recipient.</para>
                /// <list type="bullet">
                /// <item><description>If AlertRecipientType is set to OWNER, this parameter is left empty.</description></item>
                /// <item><description>If AlertRecipientType is set to SHIFT_SCHEDULE, the value is the UID of the shift schedule.</description></item>
                /// <item><description>If AlertRecipientType is set to OTHER, the value is a list of UIDs. Multiple UIDs are separated by commas (,).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("AlertRecipient")]
                [Validation(Required=false)]
                public string AlertRecipient { get; set; }

                /// <summary>
                /// <para>The type of the alert recipient. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OWNER: The owner of the node.</description></item>
                /// <item><description>OTHER: Specified users.</description></item>
                /// <item><description>SHIFT_SCHEDULE: Shift schedule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AlertRecipientType")]
                [Validation(Required=false)]
                public string AlertRecipientType { get; set; }

                /// <summary>
                /// <para>The alerting type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BASELINE: Baseline.</description></item>
                /// <item><description>TOPIC: Event.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASELINE</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>Specifies whether baseline alerts are enabled. This is a baseline-specific configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BaselineAlertEnabled")]
                [Validation(Required=false)]
                public bool? BaselineAlertEnabled { get; set; }

                /// <summary>
                /// <para>The list of DingTalk chatbots.</para>
                /// </summary>
                [NameInMap("DingRobots")]
                [Validation(Required=false)]
                public List<GetBaselineResponseBodyDataAlertSettingsDingRobots> DingRobots { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsDingRobots : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to @all.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AtAll")]
                    [Validation(Required=false)]
                    public bool? AtAll { get; set; }

                    /// <summary>
                    /// <para>The webhook URL of the DingTalk chatbot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
                    /// </summary>
                    [NameInMap("WebUrl")]
                    [Validation(Required=false)]
                    public string WebUrl { get; set; }

                }

                /// <summary>
                /// <para>The end time of the silence period, in the HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the silence period, in the HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

                /// <summary>
                /// <para>The threshold configuration for slow event alerts.</para>
                /// </summary>
                [NameInMap("TopicSlowConfig")]
                [Validation(Required=false)]
                public GetBaselineResponseBodyDataAlertSettingsTopicSlowConfig TopicSlowConfig { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsTopicSlowConfig : TeaModel {
                    /// <summary>
                    /// <para>The minimum threshold for slow events, in seconds. Valid values: 300 to 18000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("MinOver")]
                    [Validation(Required=false)]
                    public int? MinOver { get; set; }

                    /// <summary>
                    /// <para>The ratio used to calculate the slow event threshold based on the historical average execution duration of the node. Valid values: 0.1 to 2.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2</para>
                    /// </summary>
                    [NameInMap("OverFactor")]
                    [Validation(Required=false)]
                    public double? OverFactor { get; set; }

                }

                /// <summary>
                /// <para>The list of event alerting types. This is an event-specific configuration.</para>
                /// </summary>
                [NameInMap("TopicTypes")]
                [Validation(Required=false)]
                public List<string> TopicTypes { get; set; }

                /// <summary>
                /// <para>The list of webhooks.</para>
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public List<string> Webhooks { get; set; }

            }

            /// <summary>
            /// <para>The ID of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test baseline</para>
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <para>The type of the baseline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAILY: Daily baseline.</description></item>
            /// <item><description>HOURLY: Hourly baseline.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }

            /// <summary>
            /// <para>Specifies whether the baseline is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of upstream nodes of the baseline.</para>
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<long?> NodeIds { get; set; }

            /// <summary>
            /// <para>The commitment time settings of the baseline.</para>
            /// </summary>
            [NameInMap("OverTimeSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataOverTimeSettings> OverTimeSettings { get; set; }
            public class GetBaselineResponseBodyDataOverTimeSettings : TeaModel {
                /// <summary>
                /// <para>The cycle corresponding to the commitment time. The value is 1 for a daily baseline. For an hourly baseline, you can configure up to 24 cycles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public int? Cycle { get; set; }

                /// <summary>
                /// <para>The commitment time, in the hh:mm format. Valid values for hh: 0 to 47. Valid values for mm: 0 to 59.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <para>The owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the baseline. Valid values: 1, 3, 5, 7, and 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecb967ec-c137-48a5-860****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
