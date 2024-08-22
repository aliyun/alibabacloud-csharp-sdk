// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSessionClustersResponseBody : TeaModel {
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
        /// The SQL computes.
        /// </summary>
        [NameInMap("sessionClusters")]
        [Validation(Required=false)]
        public List<ListSessionClustersResponseBodySessionClusters> SessionClusters { get; set; }
        public class ListSessionClustersResponseBodySessionClusters : TeaModel {
            /// <summary>
            /// The SQL Compute configurations, which are equivalent to the configurations of the Spark job.
            /// </summary>
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<ListSessionClustersResponseBodySessionClustersApplicationConfigs> ApplicationConfigs { get; set; }
            public class ListSessionClustersResponseBodySessionClustersApplicationConfigs : TeaModel {
                /// <summary>
                /// The name of the configuration file.
                /// </summary>
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                /// <summary>
                /// The key of the configuration item.
                /// </summary>
                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                /// <summary>
                /// The value of the configuration item.
                /// </summary>
                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            /// <summary>
            /// The automatic startup configurations.
            /// </summary>
            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStartConfiguration : TeaModel {
                /// <summary>
                /// Indicates whether automatic startup is enabled.
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            /// <summary>
            /// The automatic termination configurations.
            /// </summary>
            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStopConfiguration : TeaModel {
                /// <summary>
                /// Indicates whether automatic termination is enabled.
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// The idle timeout period. The SQL Compute is automatically terminated if the idle timeout period is exceeded.
                /// </summary>
                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("draftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            [NameInMap("fusion")]
            [Validation(Required=false)]
            public bool? Fusion { get; set; }

            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// The name of the SQL Compute.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The name of the queue on which the SQL Compute runs.
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("releaseVersion")]
            [Validation(Required=false)]
            public string ReleaseVersion { get; set; }

            /// <summary>
            /// The SQL Compute ID.
            /// </summary>
            [NameInMap("sessionClusterId")]
            [Validation(Required=false)]
            public string SessionClusterId { get; set; }

            /// <summary>
            /// The status of the SQL Compute.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The details of the last status change of the SQL Compute.
            /// </summary>
            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersStateChangeReason StateChangeReason { get; set; }
            public class ListSessionClustersResponseBodySessionClustersStateChangeReason : TeaModel {
                /// <summary>
                /// The status change code.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The status change message.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// The name of the user.
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
