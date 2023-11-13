// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSUGIResponseBody : TeaModel {
        /// <summary>
        /// The results of HDFS analysis.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHDFSUGIResponseBodyData Data { get; set; }
        public class GetDoctorHDFSUGIResponseBodyData : TeaModel {
            /// <summary>
            /// The metric information.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHDFSUGIResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHDFSUGIResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The total data size.
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize : TeaModel {
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
                    /// The unit.
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
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount TotalDirCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount : TeaModel {
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
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount : TeaModel {
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

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
