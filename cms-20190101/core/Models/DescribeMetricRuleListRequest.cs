// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListRequest : TeaModel {
        /// <summary>
        /// The status of the alert rule. Valid values:
        /// 
        /// *   OK: The alert rule has no active alerts.
        /// *   ALARM: The alert rule has active alerts.
        /// *   INSUFFICIENT_DATA: No data is available.
        /// </summary>
        [NameInMap("AlertState")]
        [Validation(Required=false)]
        public string AlertState { get; set; }

        /// <summary>
        /// The dimensions of the alert rule. The dimensions specify the resources for which you want to query monitoring data.
        /// 
        /// Set the value to a set of key-value pairs, for example, `userId:120886317861****` or `i-2ze2d6j5uhg20x47****`.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// Specifies whether to query enabled or disabled alert rules. Valid values:
        /// 
        /// *   true: queries enabled alert rules.
        /// *   false: queries disabled alert rules.
        /// </summary>
        [NameInMap("EnableState")]
        [Validation(Required=false)]
        public bool? EnableState { get; set; }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](~~115032~~).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// For information about how to obtain the name of a metric, see [DescribeMetricMetaList](~~98846~~) or [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For information about how to obtain the namespace of a cloud service, see [DescribeMetricMetaList](~~98846~~) or [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// 
        /// Minimum value: 1. Default value: 1.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Minimum value: 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the alert rule. You can specify up to 20 IDs at a time. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// 
        /// This parameter supports fuzzy match.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
