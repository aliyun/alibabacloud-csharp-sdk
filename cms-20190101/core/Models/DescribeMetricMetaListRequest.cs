// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricMetaListRequest : TeaModel {
        /// <summary>
        /// The tags for filtering metrics. Specify a JSON string.
        /// 
        /// Format: ` [{"name":"tag key","value":"tag value"},{"name":"tag key","value":"tag value"}]  `. The following tags are available:
        /// 
        /// *   metricCategory: the category of the metric.
        /// *   alertEnable: specifies whether to report alerts for the metric.
        /// *   alertUnit: the unit of the metric in the alerts.
        /// *   unitFactor: the factor for metric unit conversion.
        /// *   minAlertPeriod: the minimum interval at which the alert is reported.
        /// *   productCategory: the category of the service.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The metric name. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
