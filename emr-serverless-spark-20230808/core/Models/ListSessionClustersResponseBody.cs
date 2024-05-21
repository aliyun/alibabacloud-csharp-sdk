// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListSessionClustersResponseBody : TeaModel {
        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sessionClusters")]
        [Validation(Required=false)]
        public List<ListSessionClustersResponseBodySessionClusters> SessionClusters { get; set; }
        public class ListSessionClustersResponseBodySessionClusters : TeaModel {
            [NameInMap("applicationConfigs")]
            [Validation(Required=false)]
            public List<ListSessionClustersResponseBodySessionClustersApplicationConfigs> ApplicationConfigs { get; set; }
            public class ListSessionClustersResponseBodySessionClustersApplicationConfigs : TeaModel {
                [NameInMap("configFileName")]
                [Validation(Required=false)]
                public string ConfigFileName { get; set; }

                [NameInMap("configItemKey")]
                [Validation(Required=false)]
                public string ConfigItemKey { get; set; }

                [NameInMap("configItemValue")]
                [Validation(Required=false)]
                public string ConfigItemValue { get; set; }

            }

            [NameInMap("autoStartConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStartConfiguration AutoStartConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStartConfiguration : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

            [NameInMap("autoStopConfiguration")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersAutoStopConfiguration AutoStopConfiguration { get; set; }
            public class ListSessionClustersResponseBodySessionClustersAutoStopConfiguration : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("idleTimeoutMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeoutMinutes { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 作业实例名称。
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// SQL Compute id
            /// </summary>
            [NameInMap("sessionClusterId")]
            [Validation(Required=false)]
            public string SessionClusterId { get; set; }

            /// <summary>
            /// 作业状态。
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("stateChangeReason")]
            [Validation(Required=false)]
            public ListSessionClustersResponseBodySessionClustersStateChangeReason StateChangeReason { get; set; }
            public class ListSessionClustersResponseBodySessionClustersStateChangeReason : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// 任务实例ID。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 工作空间id。
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
