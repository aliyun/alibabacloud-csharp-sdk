// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class QueueTemplate : TeaModel {
        /// <summary>
        /// <para>The auto scale-out policy for the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PriorityInstanceType</para>
        /// </summary>
        [NameInMap("AllocationStrategy")]
        [Validation(Required=false)]
        public string AllocationStrategy { get; set; }

        /// <summary>
        /// <para>The list of hardware configurations for the compute nodes in the queue. You can specify 0 to 10 configurations.</para>
        /// </summary>
        [NameInMap("ComputeNodes")]
        [Validation(Required=false)]
        public List<NodeTemplate> ComputeNodes { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable auto scale-in for the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled</para>
        /// </description></item>
        /// <item><description><para>false: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable auto scale-out for the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled</para>
        /// </description></item>
        /// <item><description><para>false: disabled</para>
        /// </description></item>
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
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The prefix can be up to 8 characters in length for Windows operating systems and up to 32 characters in length for Linux operating systems. The prefix can contain only lowercase letters, digits, and hyphens (-).</para>
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
        /// <para>The initial number of compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InitialCount")]
        [Validation(Required=false)]
        public int? InitialCount { get; set; }

        /// <summary>
        /// <para>The network type of the compute nodes in the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>vpc</para>
        /// </description></item>
        /// <item><description><para>eRDMA</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>erdma</para>
        /// </summary>
        [NameInMap("InterConnect")]
        [Validation(Required=false)]
        public string InterConnect { get; set; }

        /// <summary>
        /// <para>The list of nodes in the queue that have deletion protection enabled.</para>
        /// </summary>
        [NameInMap("KeepAliveNodes")]
        [Validation(Required=false)]
        public List<string> KeepAliveNodes { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// <para>The maximum number of compute nodes that can be scaled out in each cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("MaxCountPerCycle")]
        [Validation(Required=false)]
        public long? MaxCountPerCycle { get; set; }

        /// <summary>
        /// <para>The minimum number of compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        /// <summary>
        /// <para>The queue name. The name must be 1 to 15 characters long. It can contain letters from the Unicode letter category, such as English letters and digits, and periods (.).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comp</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The name of the instance role attached to the compute nodes in the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunECSInstanceForEHPCRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <para>The ID of the reserved node pool that the queue uses.</para>
        /// <remarks>
        /// <para>If this parameter is specified, allocatable nodes from the reserved node pool are used to create compute nodes. The <c>VSwitchIds</c>, <c>HostnamePrefix</c>, and <c>HostnameSuffix</c> parameters are ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rnp-756vlp7a</para>
        /// </summary>
        [NameInMap("ReservedNodePoolId")]
        [Validation(Required=false)]
        public string ReservedNodePoolId { get; set; }

        /// <summary>
        /// <para>A list of virtual switches available to the compute nodes in the queue. You can specify 1 to 5 virtual switches.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
