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
            /// <para>Indicates whether the alerting feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AlertEnabled")]
            [Validation(Required=false)]
            public bool? AlertEnabled { get; set; }

            /// <summary>
            /// <para>The alert margin threshold. Unit: minutes.</para>
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
                /// <para>The event alert interval, in seconds.</para>
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
                /// <para>Alert method list</para>
                /// </summary>
                [NameInMap("AlertMethods")]
                [Validation(Required=false)]
                public List<string> AlertMethods { get; set; }

                /// <summary>
                /// <para>Alert recipient details.</para>
                /// <para>AlertRecipientType is OWNER: empty
                /// AlertRecipientType is SHIFT_SCHEDULE: duty table uid
                /// AlertRecipientType is OTHER: uid list, multiple UIDs are in English, split</para>
                /// 
                /// <b>Example:</b>
                /// <para>123123</para>
                /// </summary>
                [NameInMap("AlertRecipient")]
                [Validation(Required=false)]
                public string AlertRecipient { get; set; }

                /// <summary>
                /// <para>The type of alert recipient.</para>
                /// <list type="bullet">
                /// <item><description>OWNER: task owner</description></item>
                /// <item><description>OTHER: designated person</description></item>
                /// <item><description>SHIFT: SCHEDULE-duty table</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("AlertRecipientType")]
                [Validation(Required=false)]
                public string AlertRecipientType { get; set; }

                /// <summary>
                /// <para>Alert type</para>
                /// <list type="bullet">
                /// <item><description>BASELINE: baseline</description></item>
                /// <item><description>TOPIC: event</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASELINE</para>
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// <para>The baseline alarm switch.</para>
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
                /// <para>DingTalk robot list.</para>
                /// </summary>
                [NameInMap("DingRobots")]
                [Validation(Required=false)]
                public List<GetBaselineResponseBodyDataAlertSettingsDingRobots> DingRobots { get; set; }
                public class GetBaselineResponseBodyDataAlertSettingsDingRobots : TeaModel {
                    /// <summary>
                    /// <para>Whether @ everyone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AtAll")]
                    [Validation(Required=false)]
                    public bool? AtAll { get; set; }

                    /// <summary>
                    /// <para>DingTalk robot address</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
                    /// </summary>
                    [NameInMap("WebUrl")]
                    [Validation(Required=false)]
                    public string WebUrl { get; set; }

                }

                /// <summary>
                /// <para>The end time of the silence. The format is HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceEndTime")]
                [Validation(Required=false)]
                public string SilenceEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the silence. Format: HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("SilenceStartTime")]
                [Validation(Required=false)]
                public string SilenceStartTime { get; set; }

                /// <summary>
                /// <para>The list of Event Alert types.</para>
                /// </summary>
                [NameInMap("TopicTypes")]
                [Validation(Required=false)]
                public List<string> TopicTypes { get; set; }

                /// <summary>
                /// <para>webhook list.</para>
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public List<string> Webhooks { get; set; }

            }

            /// <summary>
            /// <para>The baseline ID.</para>
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
            /// <item><description>DAILY</description></item>
            /// <item><description>HOURLY</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The node IDs.</para>
            /// </summary>
            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<long?> NodeIds { get; set; }

            /// <summary>
            /// <para>The settings of the committed completion time of the baseline.</para>
            /// </summary>
            [NameInMap("OverTimeSettings")]
            [Validation(Required=false)]
            public List<GetBaselineResponseBodyDataOverTimeSettings> OverTimeSettings { get; set; }
            public class GetBaselineResponseBodyDataOverTimeSettings : TeaModel {
                /// <summary>
                /// <para>The period corresponding to the commitment time. The space-based line is 1, and the hourly baseline can be configured for up to 24 cycles.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cycle")]
                [Validation(Required=false)]
                public int? Cycle { get; set; }

                /// <summary>
                /// <para>Commitment time, hh:mm format, hh value range is [0,47],mm value range is [0,59].</para>
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
            /// <para>The workspace ID.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
