// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the job.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorJobResponseBodyData Data { get; set; }
        public class GetDoctorJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the job that was submitted to YARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application_1542620905989_****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE TABLE test...ranks=1 (Stage-1)</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The total running time of the job. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>278</para>
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
            /// <para>The time when the job ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658388322000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The time when the job was started. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665014400000</para>
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            /// <summary>
            /// <para>The data about metrics.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorJobResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorJobResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The amount of memory consumed.</para>
                /// </summary>
                [NameInMap("MemSeconds")]
                [Validation(Required=false)]
                public GetDoctorJobResponseBodyDataMetricsMemSeconds MemSeconds { get; set; }
                public class GetDoctorJobResponseBodyDataMetricsMemSeconds : TeaModel {
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
                public GetDoctorJobResponseBodyDataMetricsVcoreSeconds VcoreSeconds { get; set; }
                public class GetDoctorJobResponseBodyDataMetricsVcoreSeconds : TeaModel {
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
            /// <para>1673946000000</para>
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
