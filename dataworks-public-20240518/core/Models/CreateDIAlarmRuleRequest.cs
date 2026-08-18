// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDIAlarmRuleRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The task ID associated with the alert rule.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>Alert description</para>
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
        /// <para>The alert metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Heartbeat: task status alert.</description></item>
        /// <item><description>FailoverCount: failover count alert.</description></item>
        /// <item><description>Delay: task latency alert.</description></item>
        /// <item><description>DdlReport: DDL notification.</description></item>
        /// <item><description>ResourceUtilization: resource group utilization.</description></item>
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
        /// <para>The name of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alartRule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The alert notification settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public CreateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class CreateDIAlarmRuleRequestNotificationSettings : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use the MuteInterval parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            [Obsolete]
            public int? InhibitionInterval { get; set; }

            /// <summary>
            /// <para>The alert mute interval. Unit: minutes. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MuteInterval")]
            [Validation(Required=false)]
            public int? MuteInterval { get; set; }

            /// <summary>
            /// <para>The alert notification channels.</para>
            /// </summary>
            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
                /// <summary>
                /// <para>The notification channel. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Mail: email.</description></item>
                /// <item><description>Phone: phone call.</description></item>
                /// <item><description>Sms: text message.</description></item>
                /// <item><description>Ding: DingTalk.</description></item>
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
            /// <para>The alert notification receivers.</para>
            /// </summary>
            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
                /// <summary>
                /// <para>The receiver type. Valid values: AliyunUid, DingToken, FeishuToken, and WebHookUrl.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingToken</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                /// <summary>
                /// <para>The receiver values.</para>
                /// <list type="bullet">
                /// <item><description>If the receiver type is AliyunUid, the value is the Alibaba Cloud account ID.</description></item>
                /// <item><description>If the receiver type is DingToken, the value is the DingTalk token.</description></item>
                /// </list>
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
        public List<CreateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class CreateDIAlarmRuleRequestTriggerConditions : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para><b>[Deprecated]</b> Use the DdlTypes parameter instead.</para>
            /// </summary>
            [NameInMap("DdlReportTags")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> DdlReportTags { get; set; }

            /// <summary>
            /// <para>The list of DDL types that take effect. This parameter takes effect only when the metric type is DDL notification.</para>
            /// </summary>
            [NameInMap("DdlTypes")]
            [Validation(Required=false)]
            public List<string> DdlTypes { get; set; }

            /// <summary>
            /// <para>The time window for alert calculation. Unit: minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <item><description>Task status alert: no threshold is required.</description></item>
            /// <item><description>Failover count alert: the threshold is the number of failovers.</description></item>
            /// <item><description>Task latency alert: the threshold is the latency duration. Unit: seconds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public long? Threshold { get; set; }

        }

    }

}
