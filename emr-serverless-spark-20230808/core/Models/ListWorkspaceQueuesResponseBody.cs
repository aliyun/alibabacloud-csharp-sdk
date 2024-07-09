// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspaceQueuesResponseBody : TeaModel {
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
        /// The list of queues.
        /// </summary>
        [NameInMap("queues")]
        [Validation(Required=false)]
        public List<ListWorkspaceQueuesResponseBodyQueues> Queues { get; set; }
        public class ListWorkspaceQueuesResponseBodyQueues : TeaModel {
            /// <summary>
            /// The operations allowed for the queue.
            /// </summary>
            [NameInMap("allowActions")]
            [Validation(Required=false)]
            public List<ListWorkspaceQueuesResponseBodyQueuesAllowActions> AllowActions { get; set; }
            public class ListWorkspaceQueuesResponseBodyQueuesAllowActions : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of a behavior.
                /// </summary>
                [NameInMap("actionArn")]
                [Validation(Required=false)]
                public string ActionArn { get; set; }

                /// <summary>
                /// The name of the permission.
                /// </summary>
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// The dependencies of the operation.
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public List<string> Dependencies { get; set; }

                /// <summary>
                /// The description of the operation.
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The display name of the permission.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// The ID of the user who created the queue.
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// The environment types of the queue.
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<string> Environments { get; set; }

            /// <summary>
            /// The maximum capacity of resources that can be used in the queue.
            /// </summary>
            [NameInMap("maxResource")]
            [Validation(Required=false)]
            public string MaxResource { get; set; }

            /// <summary>
            /// The minimum capacity of resources that can be used in the queue.
            /// </summary>
            [NameInMap("minResource")]
            [Validation(Required=false)]
            public string MinResource { get; set; }

            /// <summary>
            /// The queue label.
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// The name of the queue.
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// The queue architecture.
            /// </summary>
            [NameInMap("queueScope")]
            [Validation(Required=false)]
            public string QueueScope { get; set; }

            /// <summary>
            /// The status of the queue.
            /// </summary>
            [NameInMap("queueStatus")]
            [Validation(Required=false)]
            public string QueueStatus { get; set; }

            /// <summary>
            /// The queue type.
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The capacity of resources that are used in the queue.
            /// </summary>
            [NameInMap("usedResource")]
            [Validation(Required=false)]
            public string UsedResource { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

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
