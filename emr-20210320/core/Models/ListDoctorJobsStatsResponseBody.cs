// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorJobsStatsResponseBody : TeaModel {
        /// <summary>
        /// The summary of job information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorJobsStatsResponseBodyData> Data { get; set; }
        public class ListDoctorJobsStatsResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of jobs.
            /// </summary>
            [NameInMap("AppsCount")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataAppsCount AppsCount { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataAppsCount : TeaModel {
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
            /// The aggregated amount of memory that is allocated to the job multiplied by the number of seconds the job has been running.
            /// </summary>
            [NameInMap("MemSeconds")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataMemSeconds MemSeconds { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataMemSeconds : TeaModel {
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
            /// The YARN queue to which the job was submitted.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// The type of the compute engine.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The username that is used to submit the job.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// The aggregated number of vCPUs that are allocated to the job multiplied by the number of seconds the job has been running.
            /// </summary>
            [NameInMap("VcoreSeconds")]
            [Validation(Required=false)]
            public ListDoctorJobsStatsResponseBodyDataVcoreSeconds VcoreSeconds { get; set; }
            public class ListDoctorJobsStatsResponseBodyDataVcoreSeconds : TeaModel {
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
        /// The maximum number of entries returned.
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
