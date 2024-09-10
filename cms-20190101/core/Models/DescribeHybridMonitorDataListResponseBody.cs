// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorDataListResponseBody : TeaModel {
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
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The returned monitoring data.
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
                /// The tag key.
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// The metric name.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The metric values that are collected at different timestamps.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorDataListResponseBodyTimeSeriesValues> Values { get; set; }
            public class DescribeHybridMonitorDataListResponseBodyTimeSeriesValues : TeaModel {
                /// <summary>
                /// The timestamp that indicates the time when the metric value is collected.
                /// 
                /// Unit: seconds.
                /// </summary>
                [NameInMap("Ts")]
                [Validation(Required=false)]
                public string Ts { get; set; }

                /// <summary>
                /// The metric value.
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

        }

    }

}
