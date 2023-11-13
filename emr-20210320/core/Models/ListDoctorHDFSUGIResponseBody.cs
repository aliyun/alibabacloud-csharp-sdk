// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHDFSUGIResponseBody : TeaModel {
        /// <summary>
        /// The results of batch HDFS analysis.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHDFSUGIResponseBodyData> Data { get; set; }
        public class ListDoctorHDFSUGIResponseBodyData : TeaModel {
            /// <summary>
            /// The metric information.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHDFSUGIResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHDFSUGIResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The total data size.
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class ListDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The total number of directories.
                /// </summary>
                [NameInMap("TotalDirCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount TotalDirCount { get; set; }
                public class ListDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The total number of files.
                /// </summary>
                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class ListDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

            /// <summary>
            /// The actual name of the owner or group returned based on the value of Type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The maximum number of entries that are returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
