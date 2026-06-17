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
                [NameInMap("AlertTime")]
                [Validation(Required=false)]
                public long? AlertTime { get; set; }

                [NameInMap("ContactALIIMs")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs ContactALIIMs { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactALIIMs : TeaModel {
                    [NameInMap("ContactALIIM")]
                    [Validation(Required=false)]
                    public List<string> ContactALIIM { get; set; }

                }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups ContactGroups { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<string> ContactGroup { get; set; }

                }

                [NameInMap("ContactMails")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails ContactMails { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactMails : TeaModel {
                    [NameInMap("ContactMail")]
                    [Validation(Required=false)]
                    public List<string> ContactMail { get; set; }

                }

                [NameInMap("ContactSmses")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses ContactSmses { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContactSmses : TeaModel {
                    [NameInMap("ContactSms")]
                    [Validation(Required=false)]
                    public List<string> ContactSms { get; set; }

                }

                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts Contacts { get; set; }
                public class DescribeAlertHistoryListResponseBodyAlarmHistoryListAlarmHistoryContacts : TeaModel {
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

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

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
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
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
