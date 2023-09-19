// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogHistogramRequest : TeaModel {
        /// <summary>
        /// The alert contact group.
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// The end timestamp of the alert logs to be queried.
        /// 
        /// Unit: milliseconds.
        /// 
        /// > 
        /// 
        /// *   You can query only the alert logs within the last year.
        /// 
        /// *   The interval between the start time (`StartTime`) and end time (`EndTime`) must be less than or equal to 15 days.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The dimensions based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL. Valid values:
        /// 
        /// *   `product`: aggregates data by cloud service.
        /// *   `level`: aggregates data by alert level.
        /// *   `groupId`: aggregates data by application group.
        /// *   `contactGroup`: aggregates data by alert contact group.
        /// *   `product,metricName`: aggregates data both by cloud service and by metric.
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
        /// 
        /// >  For more information about the metrics of different cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the Alibaba Cloud service.
        /// 
        /// >  For more information about the namespaces of different cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The keyword that is used to query alert logs.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The alert status. Valid values:
        /// 
        /// *   0: The alert is triggered or cleared.
        /// *   1: The alert is ineffective.
        /// *   2: The alert is muted and not triggered in a specified period.
        /// *   3: The host is restarting.
        /// *   4: No alert notification is sent.
        /// 
        /// If the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.
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
        /// > 
        /// 
        /// *   You can query only the alert logs within the last year.
        /// 
        /// *   The interval between the start time (`StartTime`) and end time (`EndTime`) must be less than or equal to 15 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
