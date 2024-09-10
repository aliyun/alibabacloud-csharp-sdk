// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertHistoryListRequest : TeaModel {
        /// <summary>
        /// The order of alerts. Valid values:
        /// 
        /// *   true (default value): reverse chronological order
        /// *   false: chronological order
        /// </summary>
        [NameInMap("Ascending")]
        [Validation(Required=false)]
        public bool? Ascending { get; set; }

        /// <summary>
        /// The end timestamp of the historical alerts that you want to query.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// 
        /// For information about how to query the name of a metric, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For information about how to query the namespace of a cloud service, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// 
        /// For information about how to query the name of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The start timestamp of the historical alerts that you want to query.
        /// 
        /// Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the alert. Valid values:
        /// 
        /// *   ALARM (default value): Alerts are triggered.
        /// *   OK: No alerts are triggered.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Specifies whether alerts are muted. Valid values:
        /// 
        /// *   2 (default value): Alerts are muted and are not triggered within the mute period, even if the condition specified in the alert rule is met.
        /// *   0: Alerts are triggered or cleared.
        /// *   1: The alert rule is ineffective.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
