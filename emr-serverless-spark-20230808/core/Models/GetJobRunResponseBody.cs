// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetJobRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the job.</para>
        /// </summary>
        [NameInMap("jobRun")]
        [Validation(Required=false)]
        public GetJobRunResponseBodyJobRun JobRun { get; set; }
        public class GetJobRunResponseBodyJobRun : TeaModel {
            /// <summary>
            /// <para>The code type of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SQL</description></item>
            /// <item><description>JAR</description></item>
            /// <item><description>PYTHON</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("codeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The configurations of the Spark jobs.</para>
            /// </summary>
            [NameInMap("configurationOverrides")]
            [Validation(Required=false)]
            public GetJobRunResponseBodyJobRunConfigurationOverrides ConfigurationOverrides { get; set; }
            public class GetJobRunResponseBodyJobRunConfigurationOverrides : TeaModel {
                /// <summary>
                /// <para>The configurations.</para>
                /// </summary>
                [NameInMap("configurations")]
                [Validation(Required=false)]
                public List<Configuration> Configurations { get; set; }

            }

            /// <summary>
            /// <para>The version of the Spark engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
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
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cpv569tlhtgndjl8****</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

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
            /// <para>false</para>
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
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://workflow-ide-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/spark-notebook-output/w-xxxxxxxxx/xxxxxxx">http://workflow-ide-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/spark-notebook-output/w-xxxxxxxxx/xxxxxxx</a></para>
            /// </summary>
            [NameInMap("notebookAccessUrl")]
            [Validation(Required=false)]
            public string NotebookAccessUrl { get; set; }

            /// <summary>
            /// <para>The version of the Spark engine on which the job runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-3.3.1</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509789347011222</para>
            /// </summary>
            [NameInMap("resourceOwnerId")]
            [Validation(Required=false)]
            public string ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The name of the queue on which the job runs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("resourceQueueId")]
            [Validation(Required=false)]
            public string ResourceQueueId { get; set; }

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
            public GetJobRunResponseBodyJobRunStateChangeReason StateChangeReason { get; set; }
            public class GetJobRunResponseBodyJobRunStateChangeReason : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ERR-100000</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
