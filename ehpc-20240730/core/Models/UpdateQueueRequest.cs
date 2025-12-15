// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateQueueRequest : TeaModel {
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
        /// <para>The information about the queue to be updated.</para>
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public UpdateQueueRequestQueue Queue { get; set; }
        public class UpdateQueueRequestQueue : TeaModel {
            /// <summary>
            /// <para>The policy based on which instance types are selected for compute nodes during auto scale-outs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PriorityInstanceType</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PriorityInstanceType</para>
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// <para>The hardware configurations of the compute nodes in the queue. Valid values of N: 1 to 10.</para>
            /// </summary>
            [NameInMap("ComputeNodes")]
            [Validation(Required=false)]
            public List<NodeTemplate> ComputeNodes { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scale-in for the queue. Valid values:</para>
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
            /// <para>Specifies whether to enable auto scale-out for the queue. Valid values:</para>
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
            /// <para>The hostname prefix of the added compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compute</para>
            /// </summary>
            [NameInMap("HostnamePrefix")]
            [Validation(Required=false)]
            public string HostnamePrefix { get; set; }

            /// <summary>
            /// <para>The hostname suffix of the compute nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hpc</para>
            /// </summary>
            [NameInMap("HostnameSuffix")]
            [Validation(Required=false)]
            public string HostnameSuffix { get; set; }

            /// <summary>
            /// <para>The initial number of compute nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InitialCount")]
            [Validation(Required=false)]
            public int? InitialCount { get; set; }

            /// <summary>
            /// <para>The type of the network for interconnecting compute nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>erdma</para>
            /// </summary>
            [NameInMap("InterConnect")]
            [Validation(Required=false)]
            public string InterConnect { get; set; }

            /// <summary>
            /// <para>List of excluded compute nodes in the queue.</para>
            /// </summary>
            [NameInMap("KeepAliveNodes")]
            [Validation(Required=false)]
            public List<string> KeepAliveNodes { get; set; }

            /// <summary>
            /// <para>The maximum number of compute nodes that the queue can contain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxCount")]
            [Validation(Required=false)]
            public int? MaxCount { get; set; }

            /// <summary>
            /// <para>The minimum number of compute nodes that are added to the queue during an automatic scale-out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("MaxCountPerCycle")]
            [Validation(Required=false)]
            public long? MaxCountPerCycle { get; set; }

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
            /// <para>The queue name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comp</para>
            /// </summary>
            [NameInMap("QueueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The Resource Access Management (RAM) role that is assumed by compute nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunECSInstanceForEHPCRole</para>
            /// </summary>
            [NameInMap("RamRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            [NameInMap("ReservedNodePoolId")]
            [Validation(Required=false)]
            public string ReservedNodePoolId { get; set; }

            /// <summary>
            /// <para>The vSwitches available for use by compute nodes in the queue.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

    }

}
