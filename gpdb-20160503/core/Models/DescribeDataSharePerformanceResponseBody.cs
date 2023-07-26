// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataSharePerformanceResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end time of the query.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Details of data sharing performance metrics.
        /// </summary>
        [NameInMap("PerformanceKeys")]
        [Validation(Required=false)]
        public List<DescribeDataSharePerformanceResponseBodyPerformanceKeys> PerformanceKeys { get; set; }
        public class DescribeDataSharePerformanceResponseBodyPerformanceKeys : TeaModel {
            /// <summary>
            /// The name of the performance metric.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Details of the performance metric.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeDataSharePerformanceResponseBodyPerformanceKeysSeries> Series { get; set; }
            public class DescribeDataSharePerformanceResponseBodyPerformanceKeysSeries : TeaModel {
                /// <summary>
                /// The name of the performance metric.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// One or more values of the performance metric.
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues> Values { get; set; }
                public class DescribeDataSharePerformanceResponseBodyPerformanceKeysSeriesValues : TeaModel {
                    /// <summary>
                    /// The value of the performance metric at a point in time.
                    /// </summary>
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            /// <summary>
            /// The unit of the performance metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start time of the query.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
