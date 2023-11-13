// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorJobResponseBody : TeaModel {
        /// <summary>
        /// The information about the job.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorJobResponseBodyData Data { get; set; }
        public class GetDoctorJobResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the job that was submitted to YARN.
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
            /// The total running time of the job. Unit: milliseconds.
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// The final state of the job. Valid values:
            /// 
            /// *   SUCCEEDED
            /// *   FAILED
            /// *   KILLED
            /// *   ENDED
            /// *   UNDEFINED
            /// </summary>
            [NameInMap("FinalStatus")]
            [Validation(Required=false)]
            public string FinalStatus { get; set; }

            /// <summary>
            /// The time when the job ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// The time when the job was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            /// <summary>
            /// The data about metrics.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorJobResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorJobResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The amount of memory consumed.
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorJobResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorJobResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// The CPU usage.
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public GetDoctorJobResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorJobResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
            /// The running state of the job. Valid values:
            /// 
            /// *   FINISHED
            /// *   FAILED
            /// *   KILLED
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
