// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineResponseBodyData Data { get; set; }
        public class GetBaselineResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AlertEnabled")]
            [Validation(Required=false)]
            public bool? AlertEnabled { get; set; }

            /// <summary>
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
                /// <para>The interval at which an event alert notification is sent. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>900</para>
                /// </summary>
                [NameInMap("AlertInterval")]
                [Validation(Required=false)]
                public int? AlertInterval { get; set; }

                /// <summary>
                /// <para>The maximum number of times an event alert notification is sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AlertMaximum")]
                [Validation(Required=false)]
                public int? AlertMaximum { get; set; }

                /// <summary>
                /// <para>The alert notification methods.</para>
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// <para>The details of the alert recipient.</para>
                /// <list type="bullet">
                /// <item><description>If the value of AlertRecipientType is OWNER, this parameter is left empty.</description></item>
                /// <item><description>If the value of AlertRecipientType is SHIFT_SCHEDULE, the value of this parameter is the ID of a shift schedule.</description></item>
                /// <item><description>If the value of AlertRecipientType is OTHER, the value of this parameter is the UIDs of specified personnel. Multiple UIDs are separated by commas (,).</description></item>
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
                /// <item><description>OWNER: indicates the node owner.</description></item>
                /// <item><description>OTHER: indicates specified personnel.</description></item>
                /// <item><description>SHIFT_SCHEDULE: indicates personnel in a shift schedule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AlertRecipientType")]
                [Validation(Required=false)]
                public string AlertRecipientType { get; set; }

                /// <summary>
                /// <para>The type of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BASELINE: indicates a baseline alert.</description></item>
                /// <item><description>TOPIC: indicates an event alert.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASELINE</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>Indicates whether the baseline alerting feature is enabled. The feature is specific to baselines. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("BaselineAlertEnabled")]
                [Validation(Required=false)]
                public bool? BaselineAlertEnabled { get; set; }

                /// <summary>
                /// <para>The DingTalk chatbots.</para>
                /// </summary>
                [NameInMap("DingRobots")]
                [Validation(Required=false)]
                public List<GetBaselineResponseBodyDataAlertSettingsDingRobots> DingRobots { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsDingRobots : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether all members were reminded by using the at sign (@).</para>
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
                /// <para>The end of the time range for silence. The time is in the HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                /// <summary>
                /// <para>The beginning of the time range for silence. The time is in the HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

                /// <summary>
                /// <para>The types of event alerts, which are event-specific configurations.</para>
                /// </summary>
                [NameInMap("TopicTypes")]
                [Validation(Required=false)]
                public List<string> TopicTypes { get; set; }

                /// <summary>
                /// <para>The webhook URLs.</para>
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public List<string> Webhooks { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<long?> NodeIds { get; set; }

            [NameInMap("OverTimeSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataOverTimeSettings> OverTimeSettings { get; set; }
            public class GetBaselineResponseBodyDataOverTimeSettings : TeaModel {
                /// <summary>
                /// <para>The cycle that corresponds to the committed completion time. For a day-level baseline, the value of this parameter is 1. For an hour-level baseline, the value of this parameter cannot exceed 24.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public int? Cycle { get; set; }

                /// <summary>
                /// <para>The committed completion time in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9527952****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecb967ec-c137-48a5-860****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
