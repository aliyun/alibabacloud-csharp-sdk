// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIAlarmRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task with which the alert rule is associated.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11265</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql synchronizes to hologres heartbeat alert</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. By default, the alert rule is disabled.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Heartbeat</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The alert notification settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public CreateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class CreateDIAlarmRuleRequestNotificationSettings : TeaModel {
            /// <summary>
            /// <para>The duration of the alert suppression interval. Default value: 5. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            public int? InhibitionInterval { get; set; }

            /// <summary>
            /// <para>The alert notification methods.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
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
            /// <para>The settings of alert notification recipients.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The recipient type. Valid values: AliyunUid and DingToken.</para>
                /// <list type="bullet">
                /// <item><description>If the alert notification method is Mail, Phone, or Sms, set this parameter to <b>AliyunUid</b>, which specifies the Alibaba Cloud account ID.</description></item>
                /// <item><description>If the alert notification method is Ding, set this parameter to <b>DingToken</b>, which indicates the DingTalk chatbot token.</description></item>
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
        /// <para>The conditions that are used to trigger the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public List<CreateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class CreateDIAlarmRuleRequestTriggerConditions : TeaModel {
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
            /// <item><description>If the alert rule is for task status, you do not need to specify a threshold.</description></item>
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

    }

}
