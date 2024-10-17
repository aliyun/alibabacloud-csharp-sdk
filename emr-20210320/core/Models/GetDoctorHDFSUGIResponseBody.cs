// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSUGIResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of HDFS analysis.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHDFSUGIResponseBodyData Data { get; set; }
        public class GetDoctorHDFSUGIResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The metric information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHDFSUGIResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHDFSUGIResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The total data size.</para>
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total data size in megabytes (MB)</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40440503</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The total number of directories.</para>
                /// </summary>
                [NameInMap("TotalDirCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount TotalDirCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalDirCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of total dirs</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalDirCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The total number of files.</para>
                /// </summary>
                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHDFSUGIResponseBodyDataMetricsTotalFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
