// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListJobRunsResponseBody : TeaModel {
        /// <summary>
        /// The list of Spark jobs.
        /// </summary>
        [NameInMap("jobRuns")]
        [Validation(Required=false)]
        public List<ListJobRunsResponseBodyJobRuns> JobRuns { get; set; }
        public class ListJobRunsResponseBodyJobRuns : TeaModel {
            /// <summary>
            /// The code type of the job. Valid values:
            /// 
            /// SQL
            /// 
            /// JAR
            /// 
            /// PYTHON
            /// </summary>
            [NameInMap("codeType")]
            [Validation(Required=false)]
            public string CodeType { get; set; }

            /// <summary>
            /// The advanced configurations of Spark.
            /// </summary>
            [NameInMap("configurationOverrides")]
            [Validation(Required=false)]
            public ListJobRunsResponseBodyJobRunsConfigurationOverrides ConfigurationOverrides { get; set; }
            public class ListJobRunsResponseBodyJobRunsConfigurationOverrides : TeaModel {
                /// <summary>
                /// The SparkConf objects.
                /// </summary>
                [NameInMap("configurations")]
                [Validation(Required=false)]
                public List<Configuration> Configurations { get; set; }

            }

            /// <summary>
            /// The ID of the user who created the job.
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// The end time of the job.
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The timeout period of the job.
            /// </summary>
            [NameInMap("executionTimeoutSeconds")]
            [Validation(Required=false)]
            public int? ExecutionTimeoutSeconds { get; set; }

            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            /// <summary>
            /// The information about Spark Driver.
            /// </summary>
            [NameInMap("jobDriver")]
            [Validation(Required=false)]
            public JobDriver JobDriver { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("jobRunId")]
            [Validation(Required=false)]
            public string JobRunId { get; set; }

            /// <summary>
            /// The path where the operational logs are stored.
            /// </summary>
            [NameInMap("log")]
            [Validation(Required=false)]
            public RunLog Log { get; set; }

            /// <summary>
            /// The job name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The version of Spark on which the jobs run.
            /// </summary>
            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// The job state.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The reason of the job status change.
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListJobRunsResponseBodyJobRunsStateChangeReason StateChangeReason { get; set; }
            public class ListJobRunsResponseBodyJobRunsStateChangeReason : TeaModel {
                /// <summary>
                /// The error code.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The time when the job was submitted.
            /// </summary>
            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public long? SubmitTime { get; set; }

            /// <summary>
            /// The tags of the job.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// The web UI of the job.
            /// </summary>
            [NameInMap("webUI")]
            [Validation(Required=false)]
            public string WebUI { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
