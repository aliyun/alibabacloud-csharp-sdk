// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDIAlarmRuleResponseBody : TeaModel {
        [NameInMap("DIAlarmRule")]
        [Validation(Required=false)]
        public GetDIAlarmRuleResponseBodyDIAlarmRule DIAlarmRule { get; set; }
        public class GetDIAlarmRuleResponseBodyDIAlarmRule : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("CreatedUid")]
            [Validation(Required=false)]
            public string CreatedUid { get; set; }

            [NameInMap("DIAlarmRuleId")]
            [Validation(Required=false)]
            public long? DIAlarmRuleId { get; set; }

            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            public long? DIJobId { get; set; }

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
            public GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettings NotificationSettings { get; set; }
            public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettings : TeaModel {
                [NameInMap("InhibitionInterval")]
                [Validation(Required=false)]
                public int? InhibitionInterval { get; set; }

                [NameInMap("NotificationChannels")]
                [Validation(Required=false)]
                public List<GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationChannels : TeaModel {
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                    [NameInMap("Severity")]
                    [Validation(Required=false)]
                    public string Severity { get; set; }

                }

                [NameInMap("NotificationReceivers")]
                [Validation(Required=false)]
                public List<GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                public class GetDIAlarmRuleResponseBodyDIAlarmRuleNotificationSettingsNotificationReceivers : TeaModel {
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
            public List<GetDIAlarmRuleResponseBodyDIAlarmRuleTriggerConditions> TriggerConditions { get; set; }
            public class GetDIAlarmRuleResponseBodyDIAlarmRuleTriggerConditions : TeaModel {
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

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            [NameInMap("UpdatedUid")]
            [Validation(Required=false)]
            public string UpdatedUid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
