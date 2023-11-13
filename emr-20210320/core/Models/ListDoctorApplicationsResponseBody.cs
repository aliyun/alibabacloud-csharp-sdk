// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorApplicationsResponseBody : TeaModel {
        /// <summary>
        /// The details of jobs.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorApplicationsResponseBodyData> Data { get; set; }
        public class ListDoctorApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// The analysis results of the jobs.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorApplicationsResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorApplicationsResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// The score of the job.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The suggestion on executing the job.
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// The job ID in YARN. The value of QueryID or SessionID is returned for a Hive job.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The name of the job.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The time when the job ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The job IDs. Multiple job IDs are separated with commas (,).
            /// </summary>
            [NameInMap("Ids")]
            [Validation(Required=false)]
            public List<string> Ids { get; set; }

            /// <summary>
            /// The data about metrics.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorApplicationsResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorApplicationsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The amount of memory consumed.
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public ListDoctorApplicationsResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// The memory usage
                /// </summary>
                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public ListDoctorApplicationsResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsMemUtilization : TeaModel {
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
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The CPU usage.
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public ListDoctorApplicationsResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                /// The CPU utilization. This parameter has the same meaning as %CPU in the Linux top command.
                /// </summary>
                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public ListDoctorApplicationsResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class ListDoctorApplicationsResponseBodyDataMetricsVcoreUtilization : TeaModel {
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
                    public float? Value { get; set; }

                }

            }

            /// <summary>
            /// The query statement. This parameter is left empty for non-SQL jobs.
            /// </summary>
            [NameInMap("QuerySql")]
            [Validation(Required=false)]
            public string QuerySql { get; set; }

            /// <summary>
            /// The YARN queue to which the job was submitted.
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// The time when the job was submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The type of the compute engine.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The username that was used to submit the job.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

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
