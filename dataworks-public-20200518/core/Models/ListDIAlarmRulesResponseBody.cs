// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIAlarmRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("DIAlarmRulePaging")]
        [Validation(Required=false)]
        public ListDIAlarmRulesResponseBodyDIAlarmRulePaging DIAlarmRulePaging { get; set; }
        public class ListDIAlarmRulesResponseBodyDIAlarmRulePaging : TeaModel {
            /// <summary>
            /// <para>The list of alert rules.</para>
            /// </summary>
            [NameInMap("DIJobAlarmRules")]
            [Validation(Required=false)]
            public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules> DIJobAlarmRules { get; set; }
            public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules : TeaModel {
                /// <summary>
                /// <para>The alert rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>41998</para>
                /// </summary>
                [NameInMap("DIAlarmRuleId")]
                [Validation(Required=false)]
                public long? DIAlarmRuleId { get; set; }

                /// <summary>
                /// <para>The ID of the task with which the alert rule is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11260</para>
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
                public ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings NotificationSettings { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings : TeaModel {
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
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels : TeaModel {
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
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers : TeaModel {
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
                public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions> TriggerConditions { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions : TeaModel {
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
                    /// <item><description>If the alert rule is for failovers, the threshold is the number of failovers.</description></item>
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

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74C2FECD-5B3A-554A-BCF5-351A36DE9815</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
