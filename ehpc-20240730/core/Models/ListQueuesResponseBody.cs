// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListQueuesResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the queues.</para>
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<ListQueuesResponseBodyQueues> Queues { get; set; }
        public class ListQueuesResponseBodyQueues : TeaModel {
            /// <summary>
            /// <para>The hardware configurations of the compute nodes that are added in auto scale-outs. Up to five nodes are displayed.</para>
            /// </summary>
            [NameInMap("ComputeNodes")]
            [Validation(Required=false)]
            public List<NodeTemplate> ComputeNodes { get; set; }

            /// <summary>
            /// <para>The time when the queue was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-10T02:04:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether auto scale-in is enabled for the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableScaleIn")]
            [Validation(Required=false)]
            public bool? EnableScaleIn { get; set; }

            /// <summary>
            /// <para>Indicates whether auto scale-out is enabled for the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableScaleOut")]
            [Validation(Required=false)]
            public bool? EnableScaleOut { get; set; }

            /// <summary>
            /// <para>The maximum number of compute nodes that the queue can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            /// <summary>
            /// <para>The minimum number of compute nodes that are added to the queue in each auto scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaxCountPerCycle")]
            [Validation(Required=false)]
            public int? MaxCountPerCycle { get; set; }

            /// <summary>
            /// <para>The minimum number of compute nodes that the queue must contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinCount")]
            [Validation(Required=false)]
            public int? MinCount { get; set; }

            /// <summary>
            /// <para>The statistics about the compute nodes in the queue.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public ListQueuesResponseBodyQueuesNodes Nodes { get; set; }
            public class ListQueuesResponseBodyQueuesNodes : TeaModel {
                /// <summary>
                /// <para>The number of compute nodes that are not ready.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CreatingCounts")]
                [Validation(Required=false)]
                public int? CreatingCounts { get; set; }

                /// <summary>
                /// <para>The number of malfunctioning compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ExceptionCounts")]
                [Validation(Required=false)]
                public int? ExceptionCounts { get; set; }

                /// <summary>
                /// <para>The number of running compute nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RunningCounts")]
                [Validation(Required=false)]
                public int? RunningCounts { get; set; }

            }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comp</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The total number of vCPUs that are used by all compute nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("TotalCores")]
            [Validation(Required=false)]
            public int? TotalCores { get; set; }

            /// <summary>
            /// <para>The time when the queue was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time is displayed in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-25T02:02:32</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The vSwitches that can be used for added nodes during auto scale-outs. Up to three vSwitches are displayed.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6E5005C-00B0-4F27-98BB-95AB88016C22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
