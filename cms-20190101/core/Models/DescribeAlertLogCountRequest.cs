// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogCountRequest : TeaModel {
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
        /// <para>You can only query the alert history within the last year. If the query time range exceeds one year, the return value of the <c>AlertLogCount</c> parameter is empty.</para>
        /// <remarks>
        /// <para>The interval between the start time (StartTime) and the end time (EndTime) must be less than or equal to 15 days. You must specify both parameters or neither. If you do not specify these parameters, the alert history within the last 15 minutes is queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610074409694</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The Alarm Metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>TRIGGERED: Alert triggered.</para>
        /// </description></item>
        /// <item><description><para>RESOLVED: Alert recovered.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TRIGGERED</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>Aggregates data by spatial dimension, which is equivalent to the GROUP BY clause in SQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: Aggregates by Alibaba Cloud service.</description></item>
        /// <item><description><c>level</c>: Aggregates by alert level.</description></item>
        /// <item><description><c>groupId</c>: Aggregates by application group.</description></item>
        /// <item><description><c>contactGroup</c>: Aggregates by alert contact group.</description></item>
        /// <item><description><c>product,metricName</c>: Aggregates by Alibaba Cloud service and metric.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <para>The time range for retrieving logs. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

        /// <summary>
        /// <para>The alert level and notification method. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P2: Phone call, text message, email, and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P3: Text message, email, and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P4: Email and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- OK: No alerts.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- P4: Email and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- OK: No alerts.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- P4: Email and DingTalk chatbot.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- OK: No alerts.</para>
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
        /// <para>For more information about the metrics of Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics of Alibaba Cloud services</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the Alibaba Cloud service.</para>
        /// <remarks>
        /// <para>For more information about the namespaces of Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics of Alibaba Cloud services</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The abbreviation of the Alibaba Cloud service name.</para>
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
        /// <para>bfae2ca5b4e07d2c7278772e***********</para>
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
        /// <para>The search keyword for alert history statistics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The alert status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Alert triggered or recovered to Normal.</description></item>
        /// <item><description>1: Not in the effective period.</description></item>
        /// <item><description>2: mute for epoch.</description></item>
        /// <item><description>3: Host restarting.</description></item>
        /// <item><description>4: Do not send alerts.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;When the alert status is 0, if the value of Level is P2, P3, or P4, an alert is triggered. If the value of Level is OK, the alert is recovered to Normal.
        /// &lt;props=&quot;intl&quot;&gt;When the alert status is 0, if the value of Level is P4, an alert is triggered. If the value of Level is OK, the alert is recovered to Normal.
        /// &lt;props=&quot;partner&quot;&gt;When the alert status is 0, if the value of Level is P4, an alert is triggered. If the value of Level is OK, the alert is recovered to Normal.</para>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You can ignore this parameter.</para>
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
        /// <para>You can only query the alert history within the last year. If the query time range exceeds one year, the return value of the <c>AlertLogCount</c> parameter is empty.</para>
        /// <remarks>
        /// <para>The interval between the start time (StartTime) and the end time (EndTime) must be less than or equal to 15 days. You must specify both parameters or neither. If you do not specify these parameters, the alert history within the last 15 minutes is queried by default.</para>
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
