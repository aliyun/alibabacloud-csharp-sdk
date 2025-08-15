// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The Spark jobs.</para>
        /// </summary>
        [NameInMap("jobRuns")]
        [Validation(Required=false)]
        public List<ListJobRunsResponseBodyJobRuns> JobRuns { get; set; }
        public class ListJobRunsResponseBodyJobRuns : TeaModel {
            /// <summary>
            /// <para>The code type of the job. Valid values:</para>
            /// <para>SQL</para>
            /// <para>JAR</para>
            /// <para>PYTHON</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("codeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The advanced configurations of Spark.</para>
            /// </summary>
            [NameInMap("configurationOverrides")]
            [Validation(Required=false)]
            public ListJobRunsResponseBodyJobRunsConfigurationOverrides ConfigurationOverrides { get; set; }
            public class ListJobRunsResponseBodyJobRunsConfigurationOverrides : TeaModel {
                /// <summary>
                /// <para>The SparkConf objects.</para>
                /// </summary>
                [NameInMap("configurations")]
                [Validation(Required=false)]
                public List<Configuration> Configurations { get; set; }

            }

            /// <summary>
            /// <para>The ID of the user who created the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509789347011222</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The number of CUs consumed during a specified cycle of a task. The value is an estimated value. Refer to your Alibaba Cloud bill for the actual number of consumed CUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.059</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <para>The version of Spark on which the jobs run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-3.0.0 (Spark 3.4.3, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The end time of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The timeout period of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("executionTimeoutSeconds")]
            [Validation(Required=false)]
            public int? ExecutionTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>Indicates whether the Fusion engine is used for acceleration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The information about Spark Driver.</para>
            /// </summary>
            [NameInMap("jobDriver")]
            [Validation(Required=false)]
            public JobDriver JobDriver { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-231231</para>
            /// </summary>
            [NameInMap("jobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// <para>The path where the operational logs are stored.</para>
            /// </summary>
            [NameInMap("log")]
            [Validation(Required=false)]
            public RunLog Log { get; set; }

            /// <summary>
            /// <para>The total amount of memory allocated to the job multiplied by the running duration (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>33030784</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version of Spark on which the jobs run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-native-3.4.0</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The job state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The reason of the job status change.</para>
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListJobRunsResponseBodyJobRunsStateChangeReason StateChangeReason { get; set; }
            public class ListJobRunsResponseBodyJobRunsStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// <para>The tags of the job.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The total number of CPU cores allocated to the job multiplied by the running duration (seconds).</para>
            /// 
            /// <b>Example:</b>
            /// <para>8236</para>
            /// </summary>
            [NameInMap("vcoreSeconds")]
            [Validation(Required=false)]
            public long? VcoreSeconds { get; set; }

            /// <summary>
            /// <para>The web UI of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://spark-ui">http://spark-ui</a></para>
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-1234abcd</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
