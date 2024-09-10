// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertingMetricRuleResourcesRequest : TeaModel {
        /// <summary>
        /// Queries the alerts that were triggered before the specified time. Timestamps in milliseconds are supported.
        /// </summary>
        [NameInMap("AlertBeforeTime")]
        [Validation(Required=false)]
        public string AlertBeforeTime { get; set; }

        /// <summary>
        /// The dimensions that specify the resources whose monitoring data you want to query.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The ID of the application group. For information about how to obtain the ID of an application group, see [DescribeMonitorGroups](https://help.aliyun.com/document_detail/115032.html).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The ID of the alert rule. For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](https://help.aliyun.com/document_detail/114941.html).
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
