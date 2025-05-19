// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DescribeAlarmHistoryResponseBody : TeaModel {
        [NameInMap("AlarmHistoryList")]
        [Validation(Required=false)]
        public DescribeAlarmHistoryResponseBodyAlarmHistoryList AlarmHistoryList { get; set; }
        public class DescribeAlarmHistoryResponseBodyAlarmHistoryList : TeaModel {
            [NameInMap("AlarmHistory")]
            [Validation(Required=false)]
            public List<DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistory> AlarmHistory { get; set; }
            public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistory : TeaModel {
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                [NameInMap("ContactALIIMs")]
                [Validation(Required=false)]
                public DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs ContactALIIMs { get; set; }
                public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs : TeaModel {
                    [NameInMap("ContactALIIM")]
                    [Validation(Required=false)]
                    public List<string> ContactALIIM { get; set; }

                }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactGroups ContactGroups { get; set; }
                public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                [NameInMap("ContactMails")]
                [Validation(Required=false)]
                public DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactMails ContactMails { get; set; }
                public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactMails : TeaModel {
                    [NameInMap("ContactMail")]
                    [Validation(Required=false)]
                    public List<string> ContactMail { get; set; }

                }

                [NameInMap("ContactSmses")]
                [Validation(Required=false)]
                public DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactSmses ContactSmses { get; set; }
                public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContactSmses : TeaModel {
                    [NameInMap("ContactSms")]
                    [Validation(Required=false)]
                    public List<string> ContactSms { get; set; }

                }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContacts Contacts { get; set; }
                public class DescribeAlarmHistoryResponseBodyAlarmHistoryListAlarmHistoryContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }

                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("PreLevel")]
                [Validation(Required=false)]
                public string PreLevel { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public string Webhooks { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
