// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistical results aggregated by job state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Success&quot;:&quot;2&quot;}</para>
        /// </summary>
        [NameInMap("aggregations")]
        [Validation(Required=false)]
        public Dictionary<string, string> Aggregations { get; set; }

        /// <summary>
        /// <para>The list of Spark job runs.</para>
        /// </summary>
        [NameInMap("jobRuns")]
        [Validation(Required=false)]
        public List<ListJobRunsResponseBodyJobRuns> JobRuns { get; set; }
        public class ListJobRunsResponseBodyJobRuns : TeaModel {
            /// <summary>
            /// <para>The code type of the job. Valid values:</para>
            /// <para>SQL</para>
            /// <para>JAR</para>
            /// <para>PYTHON.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("codeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The advanced Spark configurations. This parameter is not returned by the list operation.</para>
            /// </summary>
            [NameInMap("configurationOverrides")]
            [Validation(Required=false)]
            public ListJobRunsResponseBodyJobRunsConfigurationOverrides ConfigurationOverrides { get; set; }
            public class ListJobRunsResponseBodyJobRunsConfigurationOverrides : TeaModel {
                /// <summary>
                /// <para>The list of Spark configurations.</para>
                /// </summary>
                [NameInMap("configurations")]
                [Validation(Required=false)]
                public List<Configuration> Configurations { get; set; }

            }

            /// <summary>
            /// <para>The UID of the user who created the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150978934701****</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The number of compute units (CUs) consumed during the job run. This value is an estimate. The actual value is subject to the bill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.059</para>
            /// </summary>
            [NameInMap("cuHours")]
            [Validation(Required=false)]
            public double? CuHours { get; set; }

            /// <summary>
            /// <para>The Spark engine version used to run the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-3.0.0 (Spark 3.4.3, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The time when the job ended. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The execution timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("executionTimeoutSeconds")]
            [Validation(Required=false)]
            public int? ExecutionTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The timestamp in milliseconds when the resources are ready, which is the first report time. If the first report time is empty, the job report time is used. If both are empty, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("firstReportTime")]
            [Validation(Required=false)]
            public long? FirstReportTime { get; set; }

            /// <summary>
            /// <para>Specifies whether Fusion engine acceleration is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The information about the Spark driver. This parameter is not returned by the list operation.</para>
            /// </summary>
            [NameInMap("jobDriver")]
            [Validation(Required=false)]
            public JobDriver JobDriver { get; set; }

            /// <summary>
            /// <para>The ID of the job run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-231231</para>
            /// </summary>
            [NameInMap("jobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// <para>The path to the execution log.</para>
            /// </summary>
            [NameInMap("log")]
            [Validation(Required=false)]
            public RunLog Log { get; set; }

            /// <summary>
            /// <para>The total amount of memory allocated to the job multiplied by the number of seconds the job has run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33030784</para>
            /// </summary>
            [NameInMap("mbSeconds")]
            [Validation(Required=false)]
            public long? MbSeconds { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The priority of the Spark job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The Spark engine version used to run the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-3.0.0 (Spark 3.4.3, Scala 2.12, Native Runtime)</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The name of the resource queue in which the Spark job runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("resourceQueueId")]
            [Validation(Required=false)]
            public string ResourceQueueId { get; set; }

            /// <summary>
            /// <para>The resource startup duration in milliseconds. It is calculated by subtracting the first submission time from the resource ready time. If the first submission time or the resource ready time is missing, or if the calculation result is negative, null is returned instead of 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60000</para>
            /// </summary>
            [NameInMap("resourceStartupDurationMs")]
            [Validation(Required=false)]
            public long? ResourceStartupDurationMs { get; set; }

            /// <summary>
            /// <para>The job run duration in milliseconds. It is calculated by subtracting the resource ready time from the job end time. If the job has not ended, the current time is used. If the resource ready time is missing, or if the calculation result is negative, null is returned instead of 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("runDurationMs")]
            [Validation(Required=false)]
            public long? RunDurationMs { get; set; }

            /// <summary>
            /// <para>The states of the job runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The reason for the state change.</para>
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
                /// <para>connection refused</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The time when the job was submitted. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The total number of vcores allocated to the job multiplied by the number of seconds the job has run.</para>
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
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>w-d2d82aa09155****</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position of the data read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The total number of records that meet the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
