// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIAlarmRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated result of alert rules.</para>
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
                /// <para>The task ID. This is the task ID associated with the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11260</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                public long? DIJobId { get; set; }

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
                /// <para>Indicates whether the alert rule is enabled.</para>
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
                /// <item><description>Delay: task delay alert.</description></item>
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
                    /// <para>The alert suppression interval. Unit: minutes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("InhibitionInterval")]
                    [Validation(Required=false)]
                    public int? InhibitionInterval { get; set; }

                    /// <summary>
                    /// <para>The alert notification channels. Multiple values are supported.</para>
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels : TeaModel {
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
                    /// <para>The alert notification receivers. Multiple values are supported.</para>
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>The receiver type.</para>
                        /// <list type="bullet">
                        /// <item><description>If the alert notification channel is email, phone call, or text message, the receiver type is Alibaba Cloud user ID (<b>AliyunUid</b>).</description></item>
                        /// <item><description>If the alert notification channel is DingTalk, the receiver type is DingTalk token (<b>DingToken</b>).</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DingToken</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>The list of receiver values.</para>
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of alert trigger conditions. Multiple conditions are supported.</para>
                /// </summary>
                [NameInMap("TriggerConditions")]
                [Validation(Required=false)]
                public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions> TriggerConditions { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions : TeaModel {
                    /// <summary>
                    /// <para>The time window for alert calculation. Unit: minutes.</para>
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
                    /// <item><description>Task status alert: no threshold.</description></item>
                    /// <item><description>Failover count alert: the threshold is the number of failovers.</description></item>
                    /// <item><description>Task delay alert: the threshold is the delay duration. Unit: seconds.</description></item>
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
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
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
        /// <para>74C2FECD-5B3A-554A-BCF5-35****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
