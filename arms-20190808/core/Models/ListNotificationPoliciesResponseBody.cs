// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListNotificationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The returned pages.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListNotificationPoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListNotificationPoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The queried notification policies.
            /// </summary>
            [NameInMap("NotificationPolicies")]
            [Validation(Required=false)]
            public List<ListNotificationPoliciesResponseBodyPageBeanNotificationPolicies> NotificationPolicies { get; set; }
            public class ListNotificationPoliciesResponseBodyPageBeanNotificationPolicies : TeaModel {
                /// <summary>
                /// Indicates whether simple mode is enabled.
                /// </summary>
                [NameInMap("DirectedMode")]
                [Validation(Required=false)]
                public bool? DirectedMode { get; set; }

                /// <summary>
                /// The ID of the escalation policy.
                /// </summary>
                [NameInMap("EscalationPolicyId")]
                [Validation(Required=false)]
                public long? EscalationPolicyId { get; set; }

                /// <summary>
                /// The grouping rule for alert events.
                /// </summary>
                [NameInMap("GroupRule")]
                [Validation(Required=false)]
                public ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesGroupRule GroupRule { get; set; }
                public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesGroupRule : TeaModel {
                    /// <summary>
                    /// The time interval of grouping. Unit: seconds. Default value: 30.
                    /// </summary>
                    [NameInMap("GroupInterval")]
                    [Validation(Required=false)]
                    public long? GroupInterval { get; set; }

                    /// <summary>
                    /// The waiting time for grouping. Unit: seconds. Default value: 5.
                    /// </summary>
                    [NameInMap("GroupWait")]
                    [Validation(Required=false)]
                    public long? GroupWait { get; set; }

                    /// <summary>
                    /// An array of alert event group objects.
                    /// 
                    /// *   If you do not specify the groupingFields field, all alerts will be sent to contacts based on `alertname`.
                    /// *   If you specify the groupingFields field, alerts with the same field will be sent to contacts in one notification.
                    /// </summary>
                    [NameInMap("GroupingFields")]
                    [Validation(Required=false)]
                    public List<string> GroupingFields { get; set; }

                }

                /// <summary>
                /// The ID of the notification policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The integration ID of the ticket system to which alerts are pushed.
                /// </summary>
                [NameInMap("IntegrationId")]
                [Validation(Required=false)]
                public long? IntegrationId { get; set; }

                /// <summary>
                /// The matching rules for alert events.
                /// </summary>
                [NameInMap("MatchingRules")]
                [Validation(Required=false)]
                public List<ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesMatchingRules> MatchingRules { get; set; }
                public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesMatchingRules : TeaModel {
                    /// <summary>
                    /// The matching conditions.
                    /// </summary>
                    [NameInMap("MatchingConditions")]
                    [Validation(Required=false)]
                    public List<ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                    public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesMatchingRulesMatchingConditions : TeaModel {
                        /// <summary>
                        /// The key of the matching condition.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The logical operator of the matching condition. Valid values:
                        /// 
                        /// *   `eq`: equal to
                        /// *   `neq`: not equal to
                        /// *   `in`: contains
                        /// *   `nin`: does not contain
                        /// *   `re`: regular expression match
                        /// *   `nre`: regular expression mismatch
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// The value of the matching condition.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The name of the notification policy.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The notification rule.
                /// </summary>
                [NameInMap("NotifyRule")]
                [Validation(Required=false)]
                public ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyRule NotifyRule { get; set; }
                public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyRule : TeaModel {
                    /// <summary>
                    /// The notification method.
                    /// </summary>
                    [NameInMap("NotifyChannels")]
                    [Validation(Required=false)]
                    public List<string> NotifyChannels { get; set; }

                    /// <summary>
                    /// The end time of the notification window.
                    /// </summary>
                    [NameInMap("NotifyEndTime")]
                    [Validation(Required=false)]
                    public string NotifyEndTime { get; set; }

                    /// <summary>
                    /// The notification objects.
                    /// </summary>
                    [NameInMap("NotifyObjects")]
                    [Validation(Required=false)]
                    public List<ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyRuleNotifyObjects> NotifyObjects { get; set; }
                    public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyRuleNotifyObjects : TeaModel {
                        /// <summary>
                        /// The notification methods specified for a contact.
                        /// </summary>
                        [NameInMap("NotifyChannels")]
                        [Validation(Required=false)]
                        public List<string> NotifyChannels { get; set; }

                        /// <summary>
                        /// The ID of the notification object.
                        /// </summary>
                        [NameInMap("NotifyObjectId")]
                        [Validation(Required=false)]
                        public long? NotifyObjectId { get; set; }

                        /// <summary>
                        /// The name of the notification object.
                        /// </summary>
                        [NameInMap("NotifyObjectName")]
                        [Validation(Required=false)]
                        public string NotifyObjectName { get; set; }

                        /// <summary>
                        /// The type of the notification object. Valid values:
                        /// 
                        /// - CONTACT: an individual contact
                        /// - CONTACT_GROUP: a contact group
                        /// - DING_ROBOT: an instant messaging (IM) chatbot
                        /// - CONTACT_SCHEDULE: a person on duty based on an established schedule
                        /// </summary>
                        [NameInMap("NotifyObjectType")]
                        [Validation(Required=false)]
                        public string NotifyObjectType { get; set; }

                    }

                    /// <summary>
                    /// The start time of the notification window.
                    /// </summary>
                    [NameInMap("NotifyStartTime")]
                    [Validation(Required=false)]
                    public string NotifyStartTime { get; set; }

                }

                /// <summary>
                /// The notification template.
                /// </summary>
                [NameInMap("NotifyTemplate")]
                [Validation(Required=false)]
                public ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyTemplate NotifyTemplate { get; set; }
                public class ListNotificationPoliciesResponseBodyPageBeanNotificationPoliciesNotifyTemplate : TeaModel {
                    /// <summary>
                    /// The content of the alert notification sent by email.
                    /// </summary>
                    [NameInMap("EmailContent")]
                    [Validation(Required=false)]
                    public string EmailContent { get; set; }

                    /// <summary>
                    /// The content of the alert resolution notification sent by email.
                    /// </summary>
                    [NameInMap("EmailRecoverContent")]
                    [Validation(Required=false)]
                    public string EmailRecoverContent { get; set; }

                    /// <summary>
                    /// The title of the alert resolution notification sent by email.
                    /// </summary>
                    [NameInMap("EmailRecoverTitle")]
                    [Validation(Required=false)]
                    public string EmailRecoverTitle { get; set; }

                    /// <summary>
                    /// The title of the alert notification sent by email.
                    /// </summary>
                    [NameInMap("EmailTitle")]
                    [Validation(Required=false)]
                    public string EmailTitle { get; set; }

                    /// <summary>
                    /// The content of the alert notification sent by an IM chatbot.
                    /// </summary>
                    [NameInMap("RobotContent")]
                    [Validation(Required=false)]
                    public string RobotContent { get; set; }

                    /// <summary>
                    /// The content of the alert notification sent by text message.
                    /// </summary>
                    [NameInMap("SmsContent")]
                    [Validation(Required=false)]
                    public string SmsContent { get; set; }

                    /// <summary>
                    /// The content of the alert resolution notification sent by text message.
                    /// </summary>
                    [NameInMap("SmsRecoverContent")]
                    [Validation(Required=false)]
                    public string SmsRecoverContent { get; set; }

                    /// <summary>
                    /// The content of the alert notification sent by phone.
                    /// </summary>
                    [NameInMap("TtsContent")]
                    [Validation(Required=false)]
                    public string TtsContent { get; set; }

                    /// <summary>
                    /// The content of the alert resolution notification sent by phone.
                    /// </summary>
                    [NameInMap("TtsRecoverContent")]
                    [Validation(Required=false)]
                    public string TtsRecoverContent { get; set; }

                }

                /// <summary>
                /// Indicates whether the system resends notifications for a long-lasting unresolved alert. Valid values:
                /// 
                /// - `true` (default): The system resends notifications for a long-lasting unresolved alert at a specified time interval.
                /// - `false`: The system resends notifications for a long-lasting unresolved alert based on an escalation policy.
                /// </summary>
                [NameInMap("Repeat")]
                [Validation(Required=false)]
                public bool? Repeat { get; set; }

                /// <summary>
                /// The time interval at which a notification is resent for a long-lasting unresolved alert. Unit: seconds.
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

                /// <summary>
                /// Indicates whether the status of an alert automatically changes to Resolved when all events related to the alert change to the Restored state. The system sends a notification to the alert contacts when the alert status changes to Resolved.
                /// 
                /// - `true` (default): The system sends a notification.
                /// - `false`: The system does not send a notification.
                /// </summary>
                [NameInMap("SendRecoverMessage")]
                [Validation(Required=false)]
                public bool? SendRecoverMessage { get; set; }

                /// <summary>
                /// Indicates whether the notification policy is enabled. Valid values: enable and disable.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// The number of the page returned.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of entries that are returned on each page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The number of notification policies that are returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
