// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class TreeNode : TeaModel {
        /// <summary>
        /// <para>The list of child nodes.</para>
        /// </summary>
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<TreeNode> Children { get; set; }

        /// <summary>
        /// <para>The final step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FinalStepNo")]
        [Validation(Required=false)]
        public int? FinalStepNo { get; set; }

        /// <summary>
        /// <para>The completion time.</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public long? FinishTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the node is a container node.</para>
        /// </summary>
        [NameInMap("IsContainerNode")]
        [Validation(Required=false)]
        public bool? IsContainerNode { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2927b500-c4e2-4241-bacf-0a2991c4be12</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Single-channel output</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The node status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UP</para>
        /// </summary>
        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        /// <summary>
        /// <para>The operator role.</para>
        /// </summary>
        [NameInMap("OperatorRole")]
        [Validation(Required=false)]
        public string OperatorRole { get; set; }

        /// <summary>
        /// <para>The parent node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dpYLaezmVNRMGX56Cg4gLjrrVrMqPxX6</para>
        /// </summary>
        [NameInMap("ParentNodeId")]
        [Validation(Required=false)]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// <para>The step number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StepNo")]
        [Validation(Required=false)]
        public int? StepNo { get; set; }

    }

}
