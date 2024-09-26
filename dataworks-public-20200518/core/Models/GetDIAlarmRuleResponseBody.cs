// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDIAlarmRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the alert rule.</para>
        /// </summary>
        [NameInMap("DIAlarmRule")]
        [Validation(Required=false)]
        public GetDIAlarmRuleResponseBodyDIAlarmRule DIAlarmRule { get; set; }
        public class GetDIAlarmRuleResponseBodyDIAlarmRule : TeaModel {
            /// <summary>
            /// <para>The timestamp when the alert rule was created. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663573162</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("CreatedUid")]
            [Validation(Required=false)]
            public string CreatedUid { get; set; }

            /// <summary>
            /// <para>The alert rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34988</para>
            /// </summary>
            [NameInMap("DIAlarmRuleId")]
            [Validation(Required=false)]
            public long? DIAlarmRuleId { get; set; }

            /// <summary>
            /// <para>The ID of the task with which the alert rule is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11170</para>
            /// </summary>
            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            public long? DIJobId { get; set; }

            /// <summary>
            /// <para>The description of the alert rule.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert rule is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The metric type in the alert rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Heartbeat</description></item>
            /// <item><description>FailoverCount</description></item>
            /// <item><description>Delay</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Heartbeat</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            /// <summary>
            /// <para>The alert notification settings.</para>
            /// </summary>
            [NameInMap("NotificationSettings")]
            [Validation(Required=false)]
            public GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettings NotificationSettings { get; set; }
            public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettings : TeaModel {
                /// <summary>
                /// <para>The duration of the alert suppression interval. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("InhibitionInterval")]
                [Validation(Required=false)]
                public int? InhibitionInterval { get; set; }

                /// <summary>
                /// <para>The alert notification methods.</para>
                /// </summary>
                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationChannels : TeaModel {
                    /// <summary>
                    /// <para>The alert notification methods.</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                    /// <summary>
                    /// <para>The severity level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Warning</description></item>
                    /// <item><description>Critical</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Warning</para>
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                }

                /// <summary>
                /// <para>The alert notification recipients.</para>
                /// </summary>
                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationReceivers : TeaModel {
                    /// <summary>
                    /// <para>The recipient type.</para>
                    /// <list type="bullet">
                    /// <item><description>If the alert notification method is Mail, Phone, or Sms, the recipient type is Alibaba Cloud account ID.</description></item>
                    /// <item><description>If the alert notification method is Ding, the recipient type is DingTalk chatbot token.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DingToken</para>
                    /// </summary>
                    [NameInMap("ReceiverType")]
                    [Validation(Required=false)]
                    public string ReceiverType { get; set; }

                    /// <summary>
                    /// <para>The recipients.</para>
                    /// </summary>
                    [NameInMap("ReceiverValues")]
                    [Validation(Required=false)]
                    public List<string> ReceiverValues { get; set; }

                }

            }

            /// <summary>
            /// <para>The conditions that can trigger the alert rule.</para>
            /// </summary>
            [NameInMap("TriggerConditions")]
            [Validation(Required=false)]
            public List<GetDIAlarmRuleResponseBodyDIAlarmRuleTriggerConditions> TriggerConditions { get; set; }
            public class GetDIAlarmRuleResponseBodyDIAlarmRuleTriggerConditions : TeaModel {
                /// <summary>
                /// <para>The time interval for alert calculation. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The severity level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Warning</description></item>
                /// <item><description>Critical</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Warning</para>
                /// </summary>
                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// <list type="bullet">
                /// <item><description>If the alert rule is for task status, no threshold is used.</description></item>
                /// <item><description>If the alert rule is for failovers, specify the number of failovers.</description></item>
                /// <item><description>If the alert rule is for latency, the threshold is the latency duration, in seconds.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public long? Threshold { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the alert rule was last updated. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1663573163</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last updates the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("UpdatedUid")]
            [Validation(Required=false)]
            public string UpdatedUid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A807D85-AC9F-55F7-A58F-998D5249CAD9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
