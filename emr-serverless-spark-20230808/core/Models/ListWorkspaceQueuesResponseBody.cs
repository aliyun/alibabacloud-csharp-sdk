// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListWorkspaceQueuesResponseBody : TeaModel {
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of queues.</para>
        /// </summary>
        [NameInMap("queues")]
        [Validation(Required=false)]
        public List<ListWorkspaceQueuesResponseBodyQueues> Queues { get; set; }
        public class ListWorkspaceQueuesResponseBodyQueues : TeaModel {
            /// <summary>
            /// <para>The operations allowed for the queue.</para>
            /// </summary>
            [NameInMap("allowActions")]
            [Validation(Required=false)]
            public List<ListWorkspaceQueuesResponseBodyQueuesAllowActions> AllowActions { get; set; }
            public class ListWorkspaceQueuesResponseBodyQueuesAllowActions : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of a behavior.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:emr::workspaceId:action/create_queue</para>
                /// </summary>
                [NameInMap("actionArn")]
                [Validation(Required=false)]
                public string ActionArn { get; set; }

                /// <summary>
                /// <para>The name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>view</para>
                /// </summary>
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                /// <summary>
                /// <para>The dependencies of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;view&quot;]</para>
                /// </summary>
                [NameInMap("dependencies")]
                [Validation(Required=false)]
                public List<string> Dependencies { get; set; }

                /// <summary>
                /// <para>The description of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文件目录遍历、文件浏览</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the permission.</para>
                /// 
                /// <b>Example:</b>
                /// <para>文件目录遍历、文件浏览</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

            }

            /// <summary>
            /// <para>The time when the workspace was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1684115879955</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>237109</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The environment types of the queue.</para>
            /// </summary>
            [NameInMap("environments")]
            [Validation(Required=false)]
            public List<string> Environments { get; set; }

            /// <summary>
            /// <para>The maximum capacity of resources that can be used in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cpu&quot;: &quot;2&quot;,&quot;memory&quot;: &quot;2Gi&quot;}</para>
            /// </summary>
            [NameInMap("maxResource")]
            [Validation(Required=false)]
            public string MaxResource { get; set; }

            /// <summary>
            /// <para>The minimum capacity of resources that can be used in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cpu&quot;: &quot;2&quot;,&quot;memory&quot;: &quot;2Gi&quot;}</para>
            /// </summary>
            [NameInMap("minResource")]
            [Validation(Required=false)]
            public string MinResource { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayAsYouGo</description></item>
            /// <item><description>Pre</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("preheat")]
            [Validation(Required=false)]
            public bool? Preheat { get; set; }

            /// <summary>
            /// <para>The queue label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The queue architecture.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;arch&quot;: &quot;x86&quot;}</para>
            /// </summary>
            [NameInMap("queueScope")]
            [Validation(Required=false)]
            public string QueueScope { get; set; }

            /// <summary>
            /// <para>The status of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("queueStatus")]
            [Validation(Required=false)]
            public string QueueStatus { get; set; }

            /// <summary>
            /// <para>The type of the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>instance</description></item>
            /// <item><description>instanceChildren</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance, instanceChildren</para>
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The capacity of resources that are used in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cpu&quot;: &quot;2&quot;,&quot;memory&quot;: &quot;2Gi&quot;}</para>
            /// </summary>
            [NameInMap("usedResource")]
            [Validation(Required=false)]
            public string UsedResource { get; set; }

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
