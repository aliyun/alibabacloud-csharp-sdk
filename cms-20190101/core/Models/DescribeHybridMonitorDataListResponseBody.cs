// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListResponseBody : TeaModel {
        /// <summary>
        /// The name of the metric.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned monitoring data.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](~~428880~~).
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp that indicates the time when the metric value is collected.
        /// 
        /// Unit: seconds.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The metric value.
        /// </summary>
        [NameInMap("TimeSeries")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorDataListResponseBodyTimeSeries> TimeSeries { get; set; }
        public class DescribeHybridMonitorDataListResponseBodyTimeSeries : TeaModel {
            /// <summary>
            /// The tags of the time dimension.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels> Labels { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesLabels : TeaModel {
                /// <summary>
                /// The timestamp that specifies the end of the time range to query.
                /// 
                /// Unit: seconds.
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// For more information about common request parameters, see [Common parameters](~~199331~~).
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesValues> Values { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesValues : TeaModel {
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public string Ts { get; set; }

                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

        }

    }

}
