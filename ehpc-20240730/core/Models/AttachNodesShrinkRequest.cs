// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class AttachNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-xxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of compute nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ComputeNode")]
        [Validation(Required=false)]
        public string ComputeNodeShrink { get; set; }

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
