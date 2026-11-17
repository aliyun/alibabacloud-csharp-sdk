// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetJobRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The job run details.</para>
        /// </summary>
        [NameInMap("jobRun")]
        [Validation(Required=false)]
        public GetJobRunResponseBodyJobRun JobRun { get; set; }
        public class GetJobRunResponseBodyJobRun : TeaModel {
            /// <summary>
            /// <para>The code type of the job run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SQL</para>
            /// </description></item>
            /// <item><description><para>JAR</para>
            /// </description></item>
            /// <item><description><para>PYTHON</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SQL</para>
            /// </summary>
            [NameInMap("codeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// <para>The configuration overrides for the Spark job run.</para>
            /// </summary>
            [NameInMap("configurationOverrides")]
            [Validation(Required=false)]
            public GetJobRunResponseBodyJobRunConfigurationOverrides ConfigurationOverrides { get; set; }
            public class GetJobRunResponseBodyJobRunConfigurationOverrides : TeaModel {
                /// <summary>
                /// <para>The list of configurations.</para>
                /// </summary>
                [NameInMap("configurations")]
                [Validation(Required=false)]
                public List<Configuration> Configurations { get; set; }

            }

            /// <summary>
            /// <para>The version displayed in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-4.0.0 (Spark 3.5.2, Scala 2.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The end time of the job run. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684122914000</para>
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
            /// <para>The execution timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("executionTimeoutSeconds")]
            [Validation(Required=false)]
            public int? ExecutionTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The timestamp in milliseconds when the resources become ready, indicating the first report time. The first report time takes precedence. If it is empty, the job report time is used as a fallback. If neither has a value, null is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("firstReportTime")]
            [Validation(Required=false)]
            public long? FirstReportTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the Fusion engine acceleration is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// <para>The information about the Spark driver.</para>
            /// </summary>
            [NameInMap("jobDriver")]
            [Validation(Required=false)]
            public JobDriver JobDriver { get; set; }

            /// <summary>
            /// <para>The job run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jr-93d98d2f7061****</para>
            /// </summary>
            [NameInMap("jobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// <para>The execution log path.</para>
            /// </summary>
            [NameInMap("log")]
            [Validation(Required=false)]
            public RunLog Log { get; set; }

            /// <summary>
            /// <para>The job run name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobName</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The download URL of the notebook file. This parameter is returned only when the job type is NOTEBOOK.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://workflow-ide-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/spark-notebook-output/w-xxxxxxxxx/xxxxxxx">http://workflow-ide-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/spark-notebook-output/w-xxxxxxxxx/xxxxxxx</a></para>
            /// </summary>
            [NameInMap("notebookAccessUrl")]
            [Validation(Required=false)]
            public string NotebookAccessUrl { get; set; }

            /// <summary>
            /// <para>The priority of the job run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The database engine version of the Spark DPI engine for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>esr-3.3.1</para>
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// <para>The UID of the user who created the job run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150978934701****</para>
            /// </summary>
            [NameInMap("resourceOwnerId")]
            [Validation(Required=false)]
            public string ResourceOwnerId { get; set; }

            /// <summary>
            /// <para>The name of the resource queue for the job run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("resourceQueueId")]
            [Validation(Required=false)]
            public string ResourceQueueId { get; set; }

            /// <summary>
            /// <para>The resource startup duration in milliseconds, which is calculated by subtracting the first submission time from the resource ready time. If the first submission time or the resource ready time is missing, or if the calculation result is negative, null is returned instead of 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60000</para>
            /// </summary>
            [NameInMap("resourceStartupDurationMs")]
            [Validation(Required=false)]
            public long? ResourceStartupDurationMs { get; set; }

            /// <summary>
            /// <para>The job run duration in milliseconds, which is calculated by subtracting the resource ready time from the job end time. If the job has not ended, the current time is used. If the resource ready time is missing or the calculation result is negative, null is returned instead of 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("runDurationMs")]
            [Validation(Required=false)]
            public long? RunDurationMs { get; set; }

            /// <summary>
            /// <para>The state of the job run.</para>
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
            /// <para>The submission time of the job run. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684119314000</para>
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The details of the tokens consumed.</para>
            /// </summary>
            [NameInMap("tokenDetails")]
            [Validation(Required=false)]
            public List<GetJobRunResponseBodyJobRunTokenDetails> TokenDetails { get; set; }
            public class GetJobRunResponseBodyJobRunTokenDetails : TeaModel {
                /// <summary>
                /// <para>Specifies whether thinking mode is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enableThinking")]
                [Validation(Required=false)]
                public string EnableThinking { get; set; }

                /// <summary>
                /// <para>The input modality.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("inputModality")]
                [Validation(Required=false)]
                public string InputModality { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-plus</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The input token range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0&lt;Token≤256K</para>
                /// </summary>
                [NameInMap("tokenRange")]
                [Validation(Required=false)]
                public string TokenRange { get; set; }

                /// <summary>
                /// <para>The source of the tokens, such as input or output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>input</para>
                /// </summary>
                [NameInMap("tokenSource")]
                [Validation(Required=false)]
                public string TokenSource { get; set; }

                /// <summary>
                /// <para>The number of tokens consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("tokenUsed")]
                [Validation(Required=false)]
                public long? TokenUsed { get; set; }

            }

            /// <summary>
            /// <para>The total number of tokens consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

            /// <summary>
            /// <para>The Web UI of the job run.</para>
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
            /// <para>w-d2d82aa09155****</para>
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
