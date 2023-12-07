// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorComputeSummaryResponseBody : TeaModel {
        /// <summary>
        /// The details of resource usage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorComputeSummaryResponseBodyData Data { get; set; }
        public class GetDoctorComputeSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// The resource analysis information.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorComputeSummaryResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorComputeSummaryResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// The total number of healthy jobs.
                /// </summary>
                [NameInMap("HealthyJobCount")]
                [Validation(Required=false)]
                public long? HealthyJobCount { get; set; }

                /// <summary>
                /// The total number of jobs that require attention.
                /// </summary>
                [NameInMap("NeedAttentionJobCount")]
                [Validation(Required=false)]
                public long? NeedAttentionJobCount { get; set; }

                /// <summary>
                /// The score for jobs.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The day-to-day growth rate of the score for jobs.
                /// </summary>
                [NameInMap("ScoreDayGrowthRatio")]
                [Validation(Required=false)]
                public float? ScoreDayGrowthRatio { get; set; }

                /// <summary>
                /// The total number of sub-healthy jobs.
                /// </summary>
                [NameInMap("SubHealthyJobCount")]
                [Validation(Required=false)]
                public long? SubHealthyJobCount { get; set; }

                /// <summary>
                /// The total number of unhealthy jobs.
                /// </summary>
                [NameInMap("UnhealthyJobCount")]
                [Validation(Required=false)]
                public long? UnhealthyJobCount { get; set; }

            }

            /// <summary>
            /// The metrics.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorComputeSummaryResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorComputeSummaryResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The total memory consumption over time in seconds.
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// The day-to-day growth rate of the total memory consumption over time in seconds.
                /// </summary>
                [NameInMap("MemSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio MemSecondsDayGrowthRatio { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio : TeaModel {
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
                /// The average memory usage.
                /// </summary>
                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsMemUtilization : TeaModel {
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
                /// The total amount of data read from the file system.
                /// </summary>
                [NameInMap("ReadSize")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsReadSize ReadSize { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsReadSize : TeaModel {
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
                /// The total CPU consumption over time in seconds.
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                /// The day-to-day growth rate of the total CPU consumption over time in seconds.
                /// </summary>
                [NameInMap("VcoreSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio VcoreSecondsDayGrowthRatio { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio : TeaModel {
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
                /// The average CPU utilization. The meaning is the same as the %CPU parameter in the output of the top command in Linux.
                /// </summary>
                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization : TeaModel {
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
                /// The total amount of data written to the file system.
                /// </summary>
                [NameInMap("WriteSize")]
                [Validation(Required=false)]
                public GetDoctorComputeSummaryResponseBodyDataMetricsWriteSize WriteSize { get; set; }
                public class GetDoctorComputeSummaryResponseBodyDataMetricsWriteSize : TeaModel {
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
