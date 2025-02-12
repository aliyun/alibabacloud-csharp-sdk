// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class QueueTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PriorityInstanceType</para>
        /// </summary>
        [NameInMap("AllocationStrategy")]
        [Validation(Required=false)]
        public string AllocationStrategy { get; set; }

        [NameInMap("ComputeNodes")]
        [Validation(Required=false)]
        public List<NodeTemplate> ComputeNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleIn")]
        [Validation(Required=false)]
        public bool? EnableScaleIn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableScaleOut")]
        [Validation(Required=false)]
        public bool? EnableScaleOut { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostnamePrefix")]
        [Validation(Required=false)]
        public string HostnamePrefix { get; set; }

        [NameInMap("HostnameSuffix")]
        [Validation(Required=false)]
        public string HostnameSuffix { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("InitialCount")]
        [Validation(Required=false)]
        public int? InitialCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>erdma</para>
        /// </summary>
        [NameInMap("InterConnect")]
        [Validation(Required=false)]
        public string InterConnect { get; set; }

        [NameInMap("KeepAliveNodes")]
        [Validation(Required=false)]
        public List<string> KeepAliveNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxCount")]
        [Validation(Required=false)]
        public int? MaxCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("MaxCountPerCycle")]
        [Validation(Required=false)]
        public long? MaxCountPerCycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comp</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AliyunECSInstanceForEHPCRole</para>
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rnp-756vlp7a</para>
        /// </summary>
        [NameInMap("ReservedNodePoolId")]
        [Validation(Required=false)]
        public string ReservedNodePoolId { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
