// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDIAlarmRuleRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIAlarmRuleId { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The description of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the alert rule.</para>
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
        /// <para>The alert rule Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>34982</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The metric type in the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Heartbeat</description></item>
        /// <item><description>FailoverCount</description></item>
        /// <item><description>Delay</description></item>
        /// <item><description>DdlReport</description></item>
        /// <item><description>ResourceUtilization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Heartbeat</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alarm_rule_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The alert notification settings.</para>
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public UpdateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class UpdateDIAlarmRuleRequestNotificationSettings : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The duration of the alert suppression interval. Default value: 5. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            [Obsolete]
            public long? InhibitionInterval { get; set; }

            /// <summary>
            /// <para>The duration of the alert suppression interval. Default value: 5. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MuteInterval")]
            [Validation(Required=false)]
            public long? MuteInterval { get; set; }

            /// <summary>
            /// <para>The alert notification methods.</para>
            /// </summary>
            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
                /// <summary>
                /// <para>The alert notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Mail</description></item>
                /// <item><description>Phone</description></item>
                /// <item><description>Sms</description></item>
                /// <item><description>Ding</description></item>
                /// </list>
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
            /// </summary>
            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The recipient type. Valid values: AliyunUid, DingToken, FeishuToken, and WebHookUrl.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingToken</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The recipient.</para>
                /// <list type="bullet">
                /// <item><description>If the ReceiverType parameter is set to AliyunUid, set this parameter to the Alibaba Cloud account ID of a user.</description></item>
                /// <item><description>If the ReceiverType parameter is set to DingToken, set this parameter to the token of a DingTalk chatbot.</description></item>
                /// </list>
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
        public List<UpdateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class UpdateDIAlarmRuleRequestTriggerConditions : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The types of DDL operations for which the alert rule takes effect.</para>
            /// </summary>
            [NameInMap("DdlReportTags")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> DdlReportTags { get; set; }

            /// <summary>
            /// <para>The types of DDL operations for which the alert rule takes effect.</para>
            /// </summary>
            [NameInMap("DdlTypes")]
            [Validation(Required=false)]
            public List<string> DdlTypes { get; set; }

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
            /// <item><description>If the alert rule is for failovers, you must specify the number of failovers.</description></item>
            /// <item><description>If the alert rule is for latency, you must specify the latency duration, in seconds.</description></item>
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
