// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIAlarmRuleRequest : TeaModel {
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("NotificationSettings")]
        [Validation(Required=false)]
        public UpdateDIAlarmRuleRequestNotificationSettings NotificationSettings { get; set; }
        public class UpdateDIAlarmRuleRequestNotificationSettings : TeaModel {
            [NameInMap("InhibitionInterval")]
            [Validation(Required=false)]
            public int? InhibitionInterval { get; set; }

            [NameInMap("NotificationChannels")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationChannels : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public List<string> Channels { get; set; }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

            }

            [NameInMap("NotificationReceivers")]
            [Validation(Required=false)]
            public List<UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
            public class UpdateDIAlarmRuleRequestNotificationSettingsNotificationReceivers : TeaModel {
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public string ReceiverType { get; set; }

                [NameInMap("ReceiverValues")]
                [Validation(Required=false)]
                public List<string> ReceiverValues { get; set; }

            }

        }

        [NameInMap("TriggerConditions")]
        [Validation(Required=false)]
        public List<UpdateDIAlarmRuleRequestTriggerConditions> TriggerConditions { get; set; }
        public class UpdateDIAlarmRuleRequestTriggerConditions : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public long? Threshold { get; set; }

        }

    }

}
