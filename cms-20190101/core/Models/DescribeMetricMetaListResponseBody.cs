// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The total number of returned records.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. The value true indicates success. The value false indicates failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of the metric.
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
                /// The unit of the metric.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The statistical period of the metric. Multiple statistical periods are separated with commas (,).
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The dimensions of the metric. Multiple dimensions are separated with commas (,).
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The tags of the metric, including one or more JSON strings. Format: `[{"name":"tag name","value":"tag value"}]`. The `name` can be repeated.
                /// 
                /// The following tags are available:
                /// 
                /// *   metricCategory: the category of the metric.
                /// *   alertEnable: specifies whether to report alerts for the metric.
                /// *   alertUnit: the suggested unit of the metric value in alerts.
                /// *   unitFactor: the factor for metric unit conversion.
                /// *   minAlertPeriod: the minimum time interval to report a new alert.
                /// *   productCategory: the category of the service.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The statistical method. Multiple statistic methods are separated with commas (,).
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// This operation is usually used with DescribeMetricList and DescribeMetricLast. For more information, see [DescribeMetricList](~~51936~~) and [DescribeMetricLast](~~51939~~).
                /// </summary>
                [NameInMap("Periods")]
                [Validation(Required=false)]
                public string Periods { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The namespace of the service. The value is usually in the format of acs_Service.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// The name of the metric.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The configuration of the metric.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
