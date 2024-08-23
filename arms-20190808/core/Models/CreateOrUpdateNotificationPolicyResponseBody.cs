// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateNotificationPolicyResponseBody : TeaModel {
        /// <summary>
        /// An array of notification policy objects.
        /// </summary>
        [NameInMap("NotificationPolicy")]
        [Validation(Required=false)]
        public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicy NotificationPolicy { get; set; }
        public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicy : TeaModel {
            /// <summary>
            /// Specifies whether to enable simple mode.
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
            /// An array of alert event group objects.
            /// </summary>
            [NameInMap("GroupRule")]
            [Validation(Required=false)]
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyGroupRule GroupRule { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyGroupRule : TeaModel {
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
            /// The matching rules.
            /// </summary>
            [NameInMap("MatchingRules")]
            [Validation(Required=false)]
            public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRules> MatchingRules { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRules : TeaModel {
                /// <summary>
                /// The matching conditions.
                /// </summary>
                [NameInMap("MatchingConditions")]
                [Validation(Required=false)]
                public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRulesMatchingConditions> MatchingConditions { get; set; }
                public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyMatchingRulesMatchingConditions : TeaModel {
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
            /// An array of notification rule objects.
            /// </summary>
            [NameInMap("NotifyRule")]
            [Validation(Required=false)]
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRule NotifyRule { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRule : TeaModel {
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
                /// An array of notification objects.
                /// </summary>
                [NameInMap("NotifyObjects")]
                [Validation(Required=false)]
                public List<CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRuleNotifyObjects> NotifyObjects { get; set; }
                public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyRuleNotifyObjects : TeaModel {
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
                    /// *   CONTACT: contact
                    /// *   CONTACT_GROUP: contact group
                    /// *   ARMS_CONTACT: ARMS contact
                    /// *   ARMS_CONTACT_GROUP: ARMS contact group
                    /// *   DING_ROBOT_GROUP: DingTalk, Lark, WeCom, or IM robot
                    /// *   CONTACT_SCHEDULE: user on duty defined by a schedule
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
            public CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyTemplate NotifyTemplate { get; set; }
            public class CreateOrUpdateNotificationPolicyResponseBodyNotificationPolicyNotifyTemplate : TeaModel {
                /// <summary>
                /// The content of the alert notification sent through email.
                /// </summary>
                [NameInMap("EmailContent")]
                [Validation(Required=false)]
                public string EmailContent { get; set; }

                /// <summary>
                /// The content of the alert resolution notification sent through email.
                /// </summary>
                [NameInMap("EmailRecoverContent")]
                [Validation(Required=false)]
                public string EmailRecoverContent { get; set; }

                /// <summary>
                /// The title of the alert resolution notification sent through email.
                /// </summary>
                [NameInMap("EmailRecoverTitle")]
                [Validation(Required=false)]
                public string EmailRecoverTitle { get; set; }

                /// <summary>
                /// The title of the alert notification sent through email.
                /// </summary>
                [NameInMap("EmailTitle")]
                [Validation(Required=false)]
                public string EmailTitle { get; set; }

                /// <summary>
                /// The content of the alert notification sent by the IM robot.
                /// </summary>
                [NameInMap("RobotContent")]
                [Validation(Required=false)]
                public string RobotContent { get; set; }

                /// <summary>
                /// The content of the alert notification sent through text message.
                /// </summary>
                [NameInMap("SmsContent")]
                [Validation(Required=false)]
                public string SmsContent { get; set; }

                /// <summary>
                /// The content of the alert resolution notification sent through text message.
                /// </summary>
                [NameInMap("SmsRecoverContent")]
                [Validation(Required=false)]
                public string SmsRecoverContent { get; set; }

                /// <summary>
                /// The content of the alert notification by phone.
                /// </summary>
                [NameInMap("TtsContent")]
                [Validation(Required=false)]
                public string TtsContent { get; set; }

                /// <summary>
                /// The content of the alert resolution notification by phone.
                /// </summary>
                [NameInMap("TtsRecoverContent")]
                [Validation(Required=false)]
                public string TtsRecoverContent { get; set; }

            }

            /// <summary>
            /// Indicates whether a notification is resent for a long-lasting unresolved alert. Default value: true. Valid values:
            /// 
            /// *   `true`: The system resends a notification for a long-lasting unresolved alert at a specified time interval.
            /// *   `false`: The system sends a notification for a long-lasting unresolved alert based on an escalation policy.
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
            /// Indicates whether the status of an alert automatically changes to Resolved when all events related to the alert change to the Restored state. ARMS notifies contacts when the alert status changes to Resolved.
            /// 
            /// *   `true`: The system sends a notification.
            /// *   `false`: The system does not send a notification.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
