// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspaceQueuesResponseBody : TeaModel {
        /// <summary>
        /// 一次获取的最大记录数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 下一页TOKEN。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("queues")]
        [Validation(Required=false)]
        public List<ListWorkspaceQueuesResponseBodyQueues> Queues { get; set; }
        public class ListWorkspaceQueuesResponseBodyQueues : TeaModel {
            /// <summary>
            /// 队列允许的操作
            /// </summary>
            [NameInMap("allowActions")]
            [Validation(Required=false)]
            public List<ListWorkspaceQueuesResponseBodyQueuesAllowActions> AllowActions { get; set; }
            public class ListWorkspaceQueuesResponseBodyQueuesAllowActions : TeaModel {
                /// <summary>
                /// 行为 arn。
                /// </summary>
                [NameInMap("actionArn")]
                [Validation(Required=false)]
                public string ActionArn { get; set; }

                /// <summary>
                /// 权限名称。
                /// </summary>
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// action 依赖列表。
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public List<string> Dependencies { get; set; }

                /// <summary>
                /// action 描述。
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 权限展示名称。
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<string> Environments { get; set; }

            /// <summary>
            /// 队列资源最大容量
            /// </summary>
            [NameInMap("maxResource")]
            [Validation(Required=false)]
            public string MaxResource { get; set; }

            /// <summary>
            /// 队列资源最小容量
            /// </summary>
            [NameInMap("minResource")]
            [Validation(Required=false)]
            public string MinResource { get; set; }

            /// <summary>
            /// 队列Label
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// 队列名称。
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// 队列架构
            /// </summary>
            [NameInMap("queueScope")]
            [Validation(Required=false)]
            public string QueueScope { get; set; }

            [NameInMap("queueStatus")]
            [Validation(Required=false)]
            public string QueueStatus { get; set; }

            /// <summary>
            /// 队列类型
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// regionId。
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 队列资源使用容量
            /// </summary>
            [NameInMap("usedResource")]
            [Validation(Required=false)]
            public string UsedResource { get; set; }

            /// <summary>
            /// 工作空间id。
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 记录总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
