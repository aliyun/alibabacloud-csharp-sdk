// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetQueueResponseBody : TeaModel {
        /// <summary>
        /// <para>The queue configurations.</para>
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public GetQueueResponseBodyQueue Queue { get; set; }
        public class GetQueueResponseBodyQueue : TeaModel {
            /// <summary>
            /// <para>The auto scale-out policy of the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PriorityInstanceType</para>
            /// </summary>
            [NameInMap("AllocationStrategy")]
            [Validation(Required=false)]
            public string AllocationStrategy { get; set; }

            /// <summary>
            /// <para>The hardware configurations of the compute nodes in the queue.</para>
            /// </summary>
            [NameInMap("ComputeNodes")]
            [Validation(Required=false)]
            public List<NodeTemplate> ComputeNodes { get; set; }

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
            /// <para>The hostname prefix of the compute nodes in the queue.</para>
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
            /// <para>demo</para>
            /// </summary>
            [NameInMap("HostnameSuffix")]
            [Validation(Required=false)]
            public string HostnameSuffix { get; set; }

            /// <summary>
            /// <para>The initial number of nodes in the queue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InitialCount")]
            [Validation(Required=false)]
            public int? InitialCount { get; set; }

            /// <summary>
            /// <para>The type of the network between compute nodes in the queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>vpc</description></item>
            /// <item><description>eRDMA</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>erdma</para>
            /// </summary>
            [NameInMap("InterConnect")]
            [Validation(Required=false)]
            public string InterConnect { get; set; }

            /// <summary>
            /// <para>The nodes for which deletion protection is enabled in the queue.</para>
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
            /// <para>The minimum number of nodes that are delivered to the queue in each scale-out cycle.</para>
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
            /// <para>The available vSwitches for compute nodes in the queue. Valid values of N: 1 to 5.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
