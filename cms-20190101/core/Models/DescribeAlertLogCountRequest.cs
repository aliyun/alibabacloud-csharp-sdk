// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogCountRequest : TeaModel {
        /// <summary>
        /// <para>The alert group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// <para>The end timestamp of the alert logs to be queried.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the <c>AlertLogCount</c> parameter is empty.</para>
        /// <remarks>
        /// <para> The interval between the start time (StartTime) and end time (EndTime) must be less than or equal to 15 days. The start time and end time must be specified or left empty at the same time. If you do not specify the start time and end time, the alert logs within the last 15 minutes are queried by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610074409694</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The type of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRIGGERED: The alert is triggered.</description></item>
        /// <item><description>RESOLVED: The alert is resolved.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TRIGGERED</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The dimension based on which data is aggregated. This parameter is similar to the Group By clause of SQL statements. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: aggregates data by cloud service.</description></item>
        /// <item><description><c>level</c>: aggregates data by alert level.</description></item>
        /// <item><description><c>groupId</c>: aggregates data by application group.</description></item>
        /// <item><description><c>contactGroup</c>: aggregates data by alert group.</description></item>
        /// <item><description><c>product,metricName</c>: aggregates data both by cloud service and by metric.</description></item>
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
        /// <para>The statistical period of alert logs. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

        /// <summary>
        /// <para>The level and notification method of the alert. Valid values:</para>
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
        /// <para>The name of the metric.</para>
        /// <remarks>
        /// <para> For more information about the metrics of different cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
        /// <para> For more information about the namespaces of cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: aggregates data by cloud service.</description></item>
        /// <item><description><c>level</c>: aggregates data by alert level.</description></item>
        /// <item><description><c>groupId</c>: aggregates data by application group.</description></item>
        /// <item><description><c>contactGroup</c>: aggregates data by alert contact group.</description></item>
        /// <item><description><c>product,metricName</c>: aggregates data both by cloud service and by metric.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The abbreviation of the service name.</para>
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
        /// <para>The keyword based on which the alert logs to be counted are searched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The status of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The alert is triggered or cleared.</description></item>
        /// <item><description>1: The alert is generated not during the effective period.</description></item>
        /// <item><description>2: The alert is muted and not triggered in a specified period.</description></item>
        /// <item><description>3: The host is restarting.</description></item>
        /// <item><description>4: Notifications are not sent for the alert.</description></item>
        /// </list>
        /// <para>When the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start timestamp of the alert logs to be queried.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the <c>AlertLogCount</c> parameter is empty.</para>
        /// <remarks>
        /// <para> The interval between the start time (StartTime) and end time (EndTime) must be less than or equal to 15 days. The start time and end time must be specified or left empty at the same time. If you do not specify the start time and end time, the alert logs within the last 15 minutes are queried by default.</para>
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
