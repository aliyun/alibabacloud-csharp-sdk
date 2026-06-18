// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip failed nodes. The default value is False.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The ID of the target node group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i234242342342</para>
        /// </summary>
        [NameInMap("TargetNodeGroupId")]
        [Validation(Required=false)]
        public string TargetNodeGroupId { get; set; }

    }

}
