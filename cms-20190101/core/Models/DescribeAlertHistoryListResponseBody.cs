// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertHistoryListResponseBody : TeaModel {
        /// <summary>
        /// The details of historical alerts.
        /// </summary>
        [NameInMap("AlarmHistoryList")]
        [Validation(Required=false)]
        public DescribeAlertHistoryListResponseBodyAlarmHistoryList AlarmHistoryList { get; set; }
        public class DescribeAlertHistoryListResponseBodyAlarmHistoryList : TeaModel {
            [NameInMap("AlarmHistory")]
            [Validation(Required=false)]
            public List<DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistory> AlarmHistory { get; set; }
            public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistory : TeaModel {
                /// <summary>
                /// The timestamp when the alert was triggered. Unit: milliseconds.
                /// </summary>
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                /// <summary>
                /// The TradeManager IDs of the alert contacts.
                /// 
                /// > This parameter is valid only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("ContactALIIMs")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs ContactALIIMs { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs : TeaModel {
                    [NameInMap("ContactALIIM")]
                    [Validation(Required=false)]
                    public List<string> ContactALIIM { get; set; }

                }

                /// <summary>
                /// The alert contact groups.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups ContactGroups { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                /// <summary>
                /// The email addresses of the alert contacts.
                /// </summary>
                [NameInMap("ContactMails")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails ContactMails { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails : TeaModel {
                    [NameInMap("ContactMail")]
                    [Validation(Required=false)]
                    public List<string> ContactMail { get; set; }

                }

                /// <summary>
                /// The mobile numbers of the alert contacts.
                /// 
                /// > This parameter is valid only on the China site (aliyun.com).
                /// </summary>
                [NameInMap("ContactSmses")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses ContactSmses { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses : TeaModel {
                    [NameInMap("ContactSms")]
                    [Validation(Required=false)]
                    public List<string> ContactSms { get; set; }

                }

                /// <summary>
                /// The alert contacts that receive alert notifications.
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts Contacts { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts : TeaModel {
                    [NameInMap("Contact")]
                    [Validation(Required=false)]
                    public List<string> Contact { get; set; }

                }

                /// <summary>
                /// The resources that are monitored.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// The expression that is used to trigger alerts.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The duration of the alert. Unit: milliseconds.
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// The severity level and notification methods of the alert. Valid values:
                /// 
                /// *   P4: Alert notifications are sent by using emails and DingTalk chatbots.
                /// *   OK: No alert is generated.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The metric name.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The alert status. Valid values:
                /// 
                /// *   ALARM: Alerts are triggered.
                /// *   OK: No alerts are triggered.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// Indicates whether alerts are muted. Valid values:
                /// 
                /// *   2 (default): Alerts are muted and are not triggered within the mute period, even if the condition specified in the alert rule is met.
                /// *   0: Alerts are triggered or cleared.
                /// *   1: The alert rule is ineffective.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The threshold of the metric value to trigger or clear an alert.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public string Webhooks { get; set; }

            }

        }

        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
