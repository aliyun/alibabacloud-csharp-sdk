// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramRequest : TeaModel {
        /// <summary>
        /// <para>The alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// <para>The end timestamp for querying alert history.</para>
        /// <para>Unit: milliseconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can only query the alert history of the last year.</description></item>
        /// <item><description>The time interval between the start time (<c>StartTime</c>) and the end time (<c>EndTime</c>) must be less than or equal to 15 days.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1609989009694</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRIGGERED: The alert is triggered.</description></item>
        /// <item><description>RESOLVED: The alert recovers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RESOLVED</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The dimension for data aggregation, which is equivalent to the GROUP BY clause in SQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: Aggregates data by cloud service.</description></item>
        /// <item><description><c>level</c>: Aggregates data by alert level.</description></item>
        /// <item><description><c>groupId</c>: Aggregates data by application group.</description></item>
        /// <item><description><c>contactGroup</c>: Aggregates data by alert contact group.</description></item>
        /// <item><description><c>product,metricName</c>: Aggregates data by cloud service and metric.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7301****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The period for retrieving logs. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

        /// <summary>
        /// <para>The alert level and notification method. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P2: Phone call + text message + email + DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P3: Text message + email + DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P4: Email + DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- OK: No alert.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- P4: Email + DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- OK: No alert.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- P4: Email + DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- OK: No alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P4</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <remarks>
        /// <para>For more information about the metrics of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about the namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>For more information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae06917_75a8c43178ab66****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The search keyword for querying alert history.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The alert status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: An alert is triggered or the alert recovers to Normal.</description></item>
        /// <item><description>1: Outside the effective period.</description></item>
        /// <item><description>2: Mute epoch.</description></item>
        /// <item><description>3: The host is restarting.</description></item>
        /// <item><description>4: Does not send alert notifications.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;If the alert status is 0 and the value of Level is P2, P3, or P4, an alert is triggered. If the value of Level is OK, the alert recovers to Normal.
        /// &lt;props=&quot;intl&quot;&gt;If the alert status is 0 and the value of Level is P4, an alert is triggered. If the value of Level is OK, the alert recovers to Normal.
        /// &lt;props=&quot;partner&quot;&gt;If the alert status is 0 and the value of Level is P4, an alert is triggered. If the value of Level is OK, the alert recovers to Normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start timestamp for querying alert history.</para>
        /// <para>Unit: milliseconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can only query the alert history of the last year.</description></item>
        /// <item><description>The time interval between the start time (<c>StartTime</c>) and the end time (<c>EndTime</c>) must be less than or equal to 15 days.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1609988009694</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
