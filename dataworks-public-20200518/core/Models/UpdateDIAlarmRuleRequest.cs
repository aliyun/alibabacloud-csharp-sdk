// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIAlarmRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>You can obtain the ID from the DIAlarmRulePaging.DIJobAlarmRules[].DIAlarmRuleId parameter in the response of the ListDIAlarmRules operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql synchronizes to hologres heartbeat alert</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert rule is enabled. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The type of the alert metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Heartbeat: task status alert</description></item>
        /// <item><description>FailoverCount: failover count alert</description></item>
        /// <item><description>Delay: task latency alert</description></item>
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
        public UpdateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class UpdateDIAlarmRuleRequestNotificationSettings : TeaModel {
            /// <summary>
            /// <para>The alert inhibition interval. Unit: minutes. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            public int? InhibitionInterval { get; set; }

            /// <summary>
            /// <para>The alert notification channels. Multiple values are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
                /// <summary>
                /// <para>The list of channels.</para>
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
            /// <para>The alert notification recipients. Multiple values are supported.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The type of the recipient.</para>
                /// <list type="bullet">
                /// <item><description>If the alert notification channel is email, phone call, or text message, set the recipient type to Alibaba Cloud user ID.</description></item>
                /// <item><description>If the alert notification channel is DingTalk, set the recipient type to DingTalk token.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DingToken</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The list of recipient values.</para>
                /// </summary>
                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of alert trigger conditions. Multiple conditions are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public List<UpdateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class UpdateDIAlarmRuleRequestTriggerConditions : TeaModel {
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
            /// <item><description>Task status alert: No threshold is required.</description></item>
            /// <item><description>Failover count alert: The threshold is the number of failovers.</description></item>
            /// <item><description>Task latency alert: The threshold is the latency duration. Unit: seconds.</description></item>
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
