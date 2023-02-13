// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricsResponseBody : TeaModel {
        /// <summary>
        /// The list of diagnostic metrics.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricsResponseBodyMetrics> Metrics { get; set; }
        public class DescribeDiagnosticMetricsResponseBodyMetrics : TeaModel {
            /// <summary>
            /// The description of the diagnostic metric.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// Indicates whether the diagnostic metric needs to be assessed by running a Cloud Assistant command in a guest operating system.
            /// </summary>
            [NameInMap("GuestMetric")]
            [Validation(Required=false)]
            public bool? GuestMetric { get; set; }

            /// <summary>
            /// The category of the diagnostic metric.
            /// </summary>
            [NameInMap("MetricCategory")]
            [Validation(Required=false)]
            public string MetricCategory { get; set; }

            /// <summary>
            /// The ID of the diagnostic metric.
            /// </summary>
            [NameInMap("MetricId")]
            [Validation(Required=false)]
            public string MetricId { get; set; }

            /// <summary>
            /// The name of the diagnostic metric.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The resource type supported by the diagnostic metric.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The operating system type supported by the diagnostic metric. Valid values:
            /// 
            /// *   Windows
            /// *   Linux
            /// *   All: both Windows and Linux
            /// </summary>
            [NameInMap("SupportedOperatingSystem")]
            [Validation(Required=false)]
            public string SupportedOperatingSystem { get; set; }

        }

        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
