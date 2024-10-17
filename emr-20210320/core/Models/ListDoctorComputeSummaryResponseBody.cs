// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorComputeSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of resource usage.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorComputeSummaryResponseBodyData> Data { get; set; }
        public class ListDoctorComputeSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The resource analysis results.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorComputeSummaryResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorComputeSummaryResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// <para>The total number of healthy jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HealthyJobCount")]
                [Validation(Required=false)]
                public long? HealthyJobCount { get; set; }

                /// <summary>
                /// <para>The total number of jobs that require attention.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("NeedAttentionJobCount")]
                [Validation(Required=false)]
                public long? NeedAttentionJobCount { get; set; }

                /// <summary>
                /// <para>The score for jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The day-to-day growth rate of the score for jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.03</para>
                /// </summary>
                [NameInMap("ScoreDayGrowthRatio")]
                [Validation(Required=false)]
                public float? ScoreDayGrowthRatio { get; set; }

                /// <summary>
                /// <para>The total number of sub-healthy jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("SubHealthyJobCount")]
                [Validation(Required=false)]
                public long? SubHealthyJobCount { get; set; }

                /// <summary>
                /// <para>The total number of unhealthy jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("UnhealthyJobCount")]
                [Validation(Required=false)]
                public long? UnhealthyJobCount { get; set; }

            }

            /// <summary>
            /// <para>The name of the resource whose details are obtained based on the value of ComponentTypes. For example, if the value of ComponentTypes is Queue, the value of this parameter is a queue, such as DW.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The metric information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorComputeSummaryResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorComputeSummaryResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The total memory consumption over time in seconds.</para>
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// <para>The day-to-day growth rate of the total memory consumption over time in seconds.</para>
                /// </summary>
                [NameInMap("MemSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio MemSecondsDayGrowthRatio { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemSecondsDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Growth ratio of memory usage in seconds per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>memSecondsDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.36</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The average memory usage.</para>
                /// </summary>
                [NameInMap("MemUtilization")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsMemUtilization MemUtilization { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsMemUtilization : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of used memory to total available memory</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>memUtilization</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.82</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The total amount of data read from the file system.</para>
                /// </summary>
                [NameInMap("ReadSize")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsReadSize ReadSize { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsReadSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total cumulative size of data read in megabytes (MB)</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>readSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
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
                    /// <para>504888659968</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The total CPU consumption over time in seconds.</para>
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
                    /// <para>1231412</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the total CPU consumption over time in seconds.</para>
                /// </summary>
                [NameInMap("VcoreSecondsDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio VcoreSecondsDayGrowthRatio { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreSecondsDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Growth ratio of virtual core usage in seconds per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vcoreSecondsDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.22</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The average CPU utilization. The meaning is the same as the %CPU parameter in the output of the top command in Linux.</para>
                /// </summary>
                [NameInMap("VcoreUtilization")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization VcoreUtilization { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsVcoreUtilization : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of used vcore to total available cores</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vcoreUtilization</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32.1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The total amount of data written to the file system.</para>
                /// </summary>
                [NameInMap("WriteSize")]
                [Validation(Required=false)]
                public ListDoctorComputeSummaryResponseBodyDataMetricsWriteSize WriteSize { get; set; }
                public class ListDoctorComputeSummaryResponseBodyDataMetricsWriteSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total cumulative size of data written in megabytes (MB)</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>writeSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
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
                    /// <para>6294093393920</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries that are returned.</para>
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
