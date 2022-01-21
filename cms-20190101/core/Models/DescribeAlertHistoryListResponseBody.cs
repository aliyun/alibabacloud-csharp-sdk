// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertHistoryListResponseBody : TeaModel {
        [NameInMap("AlarmHistoryList")]
        [Validation(Required=false)]
        public DescribeAlertHistoryListResponseBodyAlarmHistoryList AlarmHistoryList { get; set; }
        public class DescribeAlertHistoryListResponseBodyAlarmHistoryList : TeaModel {
            [NameInMap("AlarmHistory")]
            [Validation(Required=false)]
            public List<DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistory> AlarmHistory { get; set; }
            public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistory : TeaModel {
                public long? AlertTime { get; set; }
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs ContactALIIMs { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs : TeaModel {
                    [NameInMap("ContactALIIM")]
                    [Validation(Required=false)]
                    public List<string> ContactALIIM { get; set; }

                }
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups ContactGroups { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails ContactMails { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails : TeaModel {
                    [NameInMap("ContactMail")]
                    [Validation(Required=false)]
                    public List<string> ContactMail { get; set; }

                }
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses ContactSmses { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses : TeaModel {
                    [NameInMap("ContactSms")]
                    [Validation(Required=false)]
                    public List<string> ContactSms { get; set; }

                }
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts Contacts { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }
                public string Dimensions { get; set; }
                public int? EvaluationCount { get; set; }
                public string Expression { get; set; }
                public string GroupId { get; set; }
                public string InstanceName { get; set; }
                public long? LastTime { get; set; }
                public string Level { get; set; }
                public string MetricName { get; set; }
                public string Namespace { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public string State { get; set; }
                public int? Status { get; set; }
                public string Value { get; set; }
                public string Webhooks { get; set; }
            }
        };

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
