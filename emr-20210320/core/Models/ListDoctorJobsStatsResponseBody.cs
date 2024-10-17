// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorJobsStatsResponseBody : TeaModel {
        /// <summary>
        /// <para>The summary of job information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorJobsStatsResponseBodyData> Data { get; set; }
        public class ListDoctorJobsStatsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of jobs.</para>
            /// </summary>
            [NameInMap("AppsCount")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataAppsCount AppsCount { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataAppsCount : TeaModel {
                /// <summary>
                /// <para>The description of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Total apps count</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>appsCount</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
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
            /// <para>The aggregated amount of memory that is allocated to the job multiplied by the number of seconds the job has been running.</para>
            /// </summary>
            [NameInMap("MemSeconds")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataMemSeconds MemSeconds { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataMemSeconds : TeaModel {
                /// <summary>
                /// <para>The description of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Total memory usage over time in seconds</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memSeconds</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MB * Sec</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The value of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12312312</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            /// <summary>
            /// <para>The YARN queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The type of the compute engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPARK</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The username that is used to submit the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// <para>The aggregated number of vCPUs that are allocated to the job multiplied by the number of seconds the job has been running.</para>
            /// </summary>
            [NameInMap("VcoreSeconds")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataVcoreSeconds VcoreSeconds { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataVcoreSeconds : TeaModel {
                /// <summary>
                /// <para>The description of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Total vcore usage over time in seconds</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vcoreSeconds</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VCores * Sec</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The value of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11123</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
