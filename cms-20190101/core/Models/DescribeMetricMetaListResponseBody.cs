// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configuration of the metrics in the resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMetricMetaListResponseBodyResources Resources { get; set; }
        public class DescribeMetricMetaListResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMetricMetaListResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMetricMetaListResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// The metric description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The monitoring dimensions of the resource. Multiple monitoring dimensions are separated with commas (,).
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The tags of the metric, including one or more JSON strings.
                /// 
                /// Format: `[{"name":"tag key","value":"tag value"}]`. The `name` can be repeated. The following tags are available:
                /// 
                /// *   metricCategory: the category of the metric.
                /// *   alertEnable: indicates whether to report alerts for the metric.
                /// *   alertUnit: the unit of the metric in the alerts.
                /// *   unitFactor: the factor for metric unit conversion.
                /// *   minAlertPeriod: the minimum interval at which the alert is reported.
                /// *   productCategory: the category of the service.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The metric name.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The statistical periods of the metric. Multiple statistical periods are separated with commas (,).
                /// 
                /// Unit: seconds.
                /// </summary>
                [NameInMap("Periods")]
                [Validation(Required=false)]
                public string Periods { get; set; }

                /// <summary>
                /// The statistical method. Multiple statistical methods are separated with commas (,).
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The unit of the metric.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
