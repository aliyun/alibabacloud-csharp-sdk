// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogCountRequest : TeaModel {
        /// <summary>
        /// The alert group.
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// The end timestamp of the alert logs to be queried.
        /// 
        /// Unit: milliseconds.
        /// 
        /// You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the `AlertLogCount` parameter is empty.
        /// 
        /// >  The interval between the start time (StartTime) and end time (EndTime) must be less than or equal to 15 days. The start time and end time must be specified or left empty at the same time. If you do not specify the start time and end time, the alert logs within the last 15 minutes are queried by default.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The type of the alert event. Valid values:
        /// 
        /// *   TRIGGERED: The alert is triggered.
        /// *   RESOLVED: The alert is resolved.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The dimension based on which data is aggregated. This parameter is similar to the Group By clause of SQL statements. Valid values:
        /// 
        /// *   `product`: aggregates data by cloud service.
        /// *   `level`: aggregates data by alert level.
        /// *   `groupId`: aggregates data by application group.
        /// *   `contactGroup`: aggregates data by alert group.
        /// *   `product,metricName`: aggregates data both by cloud service and by metric.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The statistical period of alert logs. Unit: minutes.
        /// </summary>
        [NameInMap("LastMin")]
        [Validation(Required=false)]
        public string LastMin { get; set; }

        /// <summary>
        /// The level and notification method of the alert. Valid values:
        /// 
        /// *   P4: Alert notifications are sent by using emails and DingTalk chatbots.
        /// *   OK: No alert is generated.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// >  For more information about the metrics of different cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// >  For more information about the namespaces of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL. Valid values:
        /// 
        /// *   `product`: aggregates data by cloud service.
        /// *   `level`: aggregates data by alert level.
        /// *   `groupId`: aggregates data by application group.
        /// *   `contactGroup`: aggregates data by alert contact group.
        /// *   `product,metricName`: aggregates data both by cloud service and by metric.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The abbreviation of the service name.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// For more information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
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
        /// The keyword based on which the alert logs to be counted are searched.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The status of the alert. Valid values:
        /// 
        /// *   0: The alert is triggered or cleared.
        /// *   1: The alert is generated not during the effective period.
        /// *   2: The alert is muted and not triggered in a specified period.
        /// *   3: The host is restarting.
        /// *   4: Notifications are not sent for the alert.
        /// 
        /// When the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.
        /// </summary>
        [NameInMap("SendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The start timestamp of the alert logs to be queried.
        /// 
        /// Unit: milliseconds.
        /// 
        /// You can query only the alert logs within the last year. If the query time is longer than one year, the return value of the `AlertLogCount` parameter is empty.
        /// 
        /// >  The interval between the start time (StartTime) and end time (EndTime) must be less than or equal to 15 days. The start time and end time must be specified or left empty at the same time. If you do not specify the start time and end time, the alert logs within the last 15 minutes are queried by default.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
