// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIAlarmRulesResponseBody : TeaModel {
        [NameInMap("DIAlarmRulePaging")]
        [Validation(Required=false)]
        public ListDIAlarmRulesResponseBodyDIAlarmRulePaging DIAlarmRulePaging { get; set; }
        public class ListDIAlarmRulesResponseBodyDIAlarmRulePaging : TeaModel {
            [NameInMap("DIJobAlarmRules")]
            [Validation(Required=false)]
            public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules> DIJobAlarmRules { get; set; }
            public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRules : TeaModel {
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
                public ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings NotificationSettings { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettings : TeaModel {
                    [NameInMap("InhibitionInterval")]
                    [Validation(Required=false)]
                    public int? InhibitionInterval { get; set; }

                    [NameInMap("NotificationChannels")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels> NotificationChannels { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationChannels : TeaModel {
                        [NameInMap("Channels")]
                        [Validation(Required=false)]
                        public List<string> Channels { get; set; }

                        [NameInMap("Severity")]
                        [Validation(Required=false)]
                        public string Severity { get; set; }

                    }

                    [NameInMap("NotificationReceivers")]
                    [Validation(Required=false)]
                    public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers> NotificationReceivers { get; set; }
                    public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesNotificationSettingsNotificationReceivers : TeaModel {
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
                public List<ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions> TriggerConditions { get; set; }
                public class ListDIAlarmRulesResponseBodyDIAlarmRulePagingDIJobAlarmRulesTriggerConditions : TeaModel {
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

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
