// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorApplicationResponseBody : TeaModel {
        /// <summary>
        /// The details of the job.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorApplicationResponseBodyData Data { get; set; }
        public class GetDoctorApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// The job analysis result.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorApplicationResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorApplicationResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// The score of the job.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The suggestion for running the job.
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// The name of the job.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// The end time of the job. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
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
            /// The metric information.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorApplicationResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorApplicationResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The aggregated amount of memory that is allocated to the job multiplied by the number of seconds the job has been running.
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// The memory usage.
                /// </summary>
                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsMemUtilization : TeaModel {
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
                /// The aggregated number of vCPUs that are allocated to the job multiplied by the number of seconds the job has been running.
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                /// The CPU utilization. The meaning is the same as that of the %CPU command in the output of the Linux top command.
                /// </summary>
                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public GetDoctorApplicationResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class GetDoctorApplicationResponseBodyDataMetricsVcoreUtilization : TeaModel {
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
            /// The SQL statement of the job. This parameter is left empty for non-SQL jobs.
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
            /// The username that is used to submit the job.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
