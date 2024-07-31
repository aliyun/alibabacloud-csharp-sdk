// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIAlarmRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the task with which the alert rule is associated.
        /// 
        /// This parameter is required.
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
        /// Specifies whether to enable the alert rule. By default, the alert rule is disabled.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// The alert notification settings.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public CreateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class CreateDIAlarmRuleRequestNotificationSettings : TeaModel {
            /// <summary>
            /// The duration of the alert suppression interval. Default value: 5. Unit: minutes.
            /// </summary>
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            public int? InhibitionInterval { get; set; }

            /// <summary>
            /// The alert notification methods.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
                /// <summary>
                /// The alert notification methods.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public List<string> Channels { get; set; }

                /// <summary>
                /// The severity level.
                /// 
                /// Valid values:
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
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class CreateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public List<CreateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class CreateDIAlarmRuleRequestTriggerConditions : TeaModel {
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
            /// *   If the alert rule is for task status, you do not need to specify a threshold.
            /// *   If the alert rule is for failovers, specify the number of failovers.
            /// *   If the alert rule is for latency, the threshold is the latency duration, in seconds.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public long? Threshold { get; set; }

        }

    }

}
