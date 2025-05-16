// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class AttachNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-xxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The compute node information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ComputeNode")]
        [Validation(Required=false)]
        public AttachNodesRequestComputeNode ComputeNode { get; set; }
        public class AttachNodesRequestComputeNode : TeaModel {
            /// <summary>
            /// <para>The image ID. This image will be used to replace the original system disk image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1h765oyqyxxxxxxxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

        }

        /// <summary>
        /// <para>The name of the queue to which the instance is to be added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comp</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

    }

}
