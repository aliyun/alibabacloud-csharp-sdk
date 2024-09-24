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
        /// <para>The end timestamp of the alert logs to be queried.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the <c>AlertLogList</c> parameter is empty.</para>
        /// <remarks>
        /// <para> The time period between the start time specified by <c>StartTime</c> and end time specified by <c>EndTime</c> must be less than or equal to 15 days. You must specify StartTime and EndTime at the same time, or leave StartTime and EndTime empty at the same time. If you do not specify this parameter, the alert logs within the last 15 minutes are queried by default.</para>
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
        /// <para>The dimensions based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>product</c>: aggregates data by cloud service.</description></item>
        /// <item><description><c>level</c>: aggregates data by alert level.</description></item>
        /// <item><description><c>groupId</c>: aggregates data by application group.</description></item>
        /// <item><description><c>contactGroup</c>: aggregates data by alert contact group.</description></item>
        /// <item><description><c>product,metricName</c>: aggregates data both by cloud service and by metric.</description></item>
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
        /// <para>The statistical period of alert logs. Unit: minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>360</para>
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

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
        /// <remarks>
        /// <para>For more information about the metrics of different cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
        /// <para> For information about how to query the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
        /// <para>The abbreviation of the service name.</para>
        /// <para>For information about how to obtain the abbreviation of a cloud service name, see <a href="https://help.aliyun.com/document_detail/114930.html">DescribeProductsOfActiveMetricRule</a>.</para>
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
        /// <para>For information about how to obtain the ID of an alert rule, see <a href="https://help.aliyun.com/document_detail/114941.html">DescribeMetricRuleList</a>.</para>
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
        /// <para>The search keyword that is used to query alert logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The status of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The alert is triggered or cleared.</description></item>
        /// <item><description>1: The alert is ineffective.</description></item>
        /// <item><description>2: The alert is muted.</description></item>
        /// <item><description>3: The host is restarting.</description></item>
        /// <item><description>4: No alert notification is sent.</description></item>
        /// </list>
        /// <para>If the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

        /// <summary>
        /// <para>The type of the alert rule. Valid value: METRIC. This value indicates an alert rule for time series metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>METRIC</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start timestamp of the alert logs to be queried.</para>
        /// <para>Unit: milliseconds.</para>
        /// <para>You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the <c>AlertLogList</c> parameter is empty.</para>
        /// <remarks>
        /// <para> The time period between the start time specified by <c>StartTime</c> and the end time specified by <c>EndTime</c> must be less than or equal to 15 days. You must specify StartTime and EndTime at the same time, or leave StartTime and EndTime empty at the same time. If you do not specify this parameter, the alert logs within the last 15 minutes are queried by default.</para>
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
