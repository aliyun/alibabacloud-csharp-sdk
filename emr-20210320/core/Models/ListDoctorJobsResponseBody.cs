// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the jobs.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorJobsResponseBodyData> Data { get; set; }
        public class ListDoctorJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the job that was submitted to YARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application_1607584549220_*****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpcds</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The total running time of the job. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>242</para>
            /// </summary>
            [NameInMap("ElapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            /// <summary>
            /// <para>The final state of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCEEDED</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>KILLED</description></item>
            /// <item><description>ENDED</description></item>
            /// <item><description>UNDEFINED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>KILLED</para>
            /// </summary>
            [NameInMap("FinalStatus")]
            [Validation(Required=false)]
            public string FinalStatus { get; set; }

            /// <summary>
            /// <para>The end time of the job. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683690929000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The time when the job was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672148400000</para>
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            /// <summary>
            /// <para>The data about the metrics.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorJobsResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorJobsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The amount of memory consumed.</para>
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public ListDoctorJobsResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class ListDoctorJobsResponseBodyDataMetricsMemSeconds : TeaModel {
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
                /// <para>The CPU usage.</para>
                /// </summary>
                [NameInMap("VcoreSeconds")]
                [Validation(Required=false)]
                public ListDoctorJobsResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class ListDoctorJobsResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
            /// <para>The YARN queue to which the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1675180800000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The running state of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FINISHED</description></item>
            /// <item><description>FAILED</description></item>
            /// <item><description>KILLED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

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
            /// <para>The username that was used to submit the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

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
