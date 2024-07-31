// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIAlarmRulesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("DIAlarmRulePaging")]
        [Validation(Required=false)]
        public ListDIAlarmRulesResponseBodyDIAlarmRulePaging DIAlarmRulePaging { get; set; }
        public class ListDIAlarmRulesResponseBodyDIAlarmRulePaging : TeaModel {
            /// <summary>
            /// The list of alert rules.
            /// </summary>
            [NameInMap("DIJobAlarmRules")]
            [Validation(Required=false)]
            public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules> DIJobAlarmRules { get; set; }
            public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules : TeaModel {
                /// <summary>
                /// The alert rule ID.
                /// </summary>
                [NameInMap("DIAlarmRuleId")]
                [Validation(Required=false)]
                public long? DIAlarmRuleId { get; set; }

                /// <summary>
                /// The ID of the task with which the alert rule is associated.
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                public long? DIJobId { get; set; }

                /// <summary>
                /// The description of the alert rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is enabled.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// The metric type in the alert rule. Valid values:
                /// 
                /// *   Heartbeat
                /// *   FailoverCount
                /// *   Delay
                /// </summary>
                [NameInMap("MetricType")]
                [Validation(Required=false)]
                public string MetricType { get; set; }

                /// <summary>
                /// The alert notification settings.
                /// </summary>
                [NameInMap("NotificationSettings")]
                [Validation(Required=false)]
                public ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings NotificationSettings { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings : TeaModel {
                    /// <summary>
                    /// The duration of the alert suppression interval. Unit: minutes.
                    /// </summary>
                    [NameInMap("InhibitionInterval")]
                    [Validation(Required=false)]
                    public int? InhibitionInterval { get; set; }

                    /// <summary>
                    /// The alert notification methods.
                    /// </summary>
                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels : TeaModel {
                        /// <summary>
                        /// The alert notification methods.
                        /// </summary>
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                        /// <summary>
                        /// The severity level. Valid values:
                        /// 
                        /// *   Warning
                        /// *   Critical
                        /// </summary>
                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                    /// <summary>
                    /// The alert notification recipients.
                    /// </summary>
                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers : TeaModel {
                        /// <summary>
                        /// The recipient type.
                        /// 
                        /// *   If the alert notification method is Mail, Phone, or Sms, the recipient type is Alibaba Cloud account ID.
                        /// *   If the alert notification method is Ding, the recipient type is DingTalk chatbot token.
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// The recipients.
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

                /// <summary>
                /// The conditions that can trigger the alert rule.
                /// </summary>
                [NameInMap("TriggerConditions")]
                [Validation(Required=false)]
                public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions> TriggerConditions { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions : TeaModel {
                    /// <summary>
                    /// The time interval for alert calculation. Unit: minutes.
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// The severity level. Valid values:
                    /// 
                    /// *   Warning
                    /// *   Critical
                    /// </summary>
                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                    /// <summary>
                    /// The alert threshold.
                    /// 
                    /// *   If the alert rule is for task status, no threshold is used.
                    /// *   If the alert rule is for failovers, the threshold is the number of failovers.
                    /// *   If the alert rule is for latency, the threshold is the latency duration, in seconds.
                    /// </summary>
                    [NameInMap("Threshold")]
                    [Validation(Required=false)]
                    public long? Threshold { get; set; }

                }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
