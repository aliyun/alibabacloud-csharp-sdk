// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertHistoryListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of historical alerts.</para>
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
                /// <para>The timestamp when the alert was triggered. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1640586600000</para>
                /// </summary>
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                /// <summary>
                /// <para>The TradeManager IDs of the alert contacts.</para>
                /// <remarks>
                /// <para>This parameter is valid only on the China site (aliyun.com).</para>
                /// </remarks>
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
                /// <para>The alert contact groups.</para>
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
                /// <para>The email addresses of the alert contacts.</para>
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
                /// <para>The mobile numbers of the alert contacts.</para>
                /// <remarks>
                /// <para>This parameter is valid only on the China site (aliyun.com).</para>
                /// </remarks>
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
                /// <para>The alert contacts that receive alert notifications.</para>
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
                /// <para>The resources that are monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;instanceId\&quot;:\&quot;i-bp1cqhiw1za2****\&quot;}</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                /// <summary>
                /// <para>The expression that is used to trigger alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$Average&gt;=10</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7671****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp1cqhiw1za2****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The duration of the alert. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360133</para>
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// <para>The severity level and notification methods of the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>P4: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                /// <item><description>OK: No alert is generated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>P4</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu_total</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>applyTemplate61dc81b5-d357-4cf6-a9b7-9f83c1d5****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_Rule</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The alert status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ALARM: Alerts are triggered.</description></item>
                /// <item><description>OK: No alerts are triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALARM</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>Indicates whether alerts are muted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>2 (default): Alerts are muted and are not triggered within the mute period, even if the condition specified in the alert rule is met.</description></item>
                /// <item><description>0: Alerts are triggered or cleared.</description></item>
                /// <item><description>1: The alert rule is ineffective.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The threshold of the metric value to trigger or clear an alert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.58</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Webhooks")]
                [Validation(Required=false)]
                public string Webhooks { get; set; }

            }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3C69FBE-2262-541F-A409-C52F380BAE63</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
