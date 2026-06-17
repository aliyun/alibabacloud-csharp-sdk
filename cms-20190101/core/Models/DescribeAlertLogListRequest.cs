// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListRequest : TeaModel {
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
        /// <para>The end of the time range to query the alert history.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert history within the last year. If the query time range exceeds one year, the return value of the <c>AlertLogList</c> parameter is empty.</para>
        /// <remarks>
        /// <para>The interval between the start time (<c>StartTime</c>) and end time (<c>EndTime</c>) must be less than or equal to 15 days. Both parameters must be specified or unspecified at the same time. If they are not specified, the alert history within the last 15 minutes is queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610074409694</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>TRIGGERED: The alert is triggered.</para>
        /// </description></item>
        /// <item><description><para>RESOLVED: The alert is cleared.</para>
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
        /// <para>The spatial dimension by which the data is aggregated, which is equivalent to Group By in SQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: aggregates data by cloud service.</description></item>
        /// <item><description><c>level</c>: aggregates data by alert level.</description></item>
        /// <item><description><c>groupId</c>: aggregates data by application group.</description></item>
        /// <item><description><c>contactGroup</c>: aggregates data by alert contact group.</description></item>
        /// <item><description><c>product,metricName</c>: aggregates data by cloud service and metric.</description></item>
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
        /// <para>The interval at which logs are obtained. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

        /// <summary>
        /// <para>The alert level and notification methods. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P2: phone calls, text messages, emails, and DingTalk chatbots.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P3: text messages, emails, and DingTalk chatbots.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- P4: emails and DingTalk chatbots.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;- OK: no alerts.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- P4: emails and DingTalk chatbots.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;- OK: no alerts.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- P4: emails and DingTalk chatbots.</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;- OK: no alerts.</para>
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
        /// <para>For more information about the metrics of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IntranetInRate</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about the namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Metrics</a>.</para>
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
        /// <para>The number of entries per page.</para>
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
        /// <para>For more information about how to obtain the abbreviation of a cloud service name, see <a href="https://help.aliyun.com/document_detail/114930.html">DescribeProductsOfActiveMetricRule</a>.</para>
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
        /// <para>For more information about how to query the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bc369e8_30f87e517ed2fc****</para>
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
        /// <para>The keyword used to query the alert history.</para>
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
        /// <item><description>0: An alert is triggered or cleared.</description></item>
        /// <item><description>1: The current time is not within the effective period of the alert.</description></item>
        /// <item><description>2: The current time is within the channel silence period.</description></item>
        /// <item><description>3: The host is being restarted.</description></item>
        /// <item><description>4: No alerts are sent.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;china&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P2, P3, or P4; the alert is cleared if Level is set to OK.
        /// &lt;props=&quot;intl&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P4; the alert is cleared if Level is set to OK.
        /// &lt;props=&quot;partner&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P4; the alert is cleared if Level is set to OK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

        /// <summary>
        /// <para>The type of the alert rule. Valid value: METRIC, which indicates a time series metric alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>METRIC</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query the alert history.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert history within the last year. If the query time range exceeds one year, the return value of the <c>AlertLogList</c> parameter is empty.</para>
        /// <remarks>
        /// <para>The interval between the start time (<c>StartTime</c>) and end time (<c>EndTime</c>) must be less than or equal to 15 days. Both parameters must be specified or unspecified at the same time. If they are not specified, the alert history within the last 15 minutes is queried by default.</para>
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
