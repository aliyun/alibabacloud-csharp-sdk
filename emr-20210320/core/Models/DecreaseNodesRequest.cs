// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DecreaseNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cooldown time between batches.</para>
        /// </summary>
        [NameInMap("BatchInterval")]
        [Validation(Required=false)]
        public int? BatchInterval { get; set; }

        /// <summary>
        /// <para>The number of nodes to concurrently take offline in a single batch.</para>
        /// </summary>
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b933c5aac8fe****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of nodes to remove. The value must be less than the number of active nodes in the node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DecreaseNodeCount")]
        [Validation(Required=false)]
        public int? DecreaseNodeCount { get; set; }

        /// <summary>
        /// <para>The node group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>An array of node IDs. The array can contain from 1 to 500 elements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;i-bp1cudc25w2bfwl5****&quot;]</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
