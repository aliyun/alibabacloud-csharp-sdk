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
        /// Format:`[{"name":"tag name","value":"tag value"},{"name":"tag name","value":"tag value"}]`. The following tags are available:
        /// 
        /// *   metricCategory: the category of the metric.
        /// *   alertEnable: specifies whether to report alerts for the metric.
        /// *   alertUnit: the suggested unit of the metric value in alerts.
        /// *   unitFactor: the factor for metric unit conversion.
        /// *   minAlertPeriod: the minimum time interval to report a new alert.
        /// *   productCategory: the category of the service.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The name of the metric. For more information, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the service.
        /// 
        /// For more information, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The page to return. Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
