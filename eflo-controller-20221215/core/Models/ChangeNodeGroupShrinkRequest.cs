// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ChangeNodeGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public string NodesShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i234242342342</para>
        /// </summary>
        [NameInMap("TargetNodeGroupId")]
        [Validation(Required=false)]
        public string TargetNodeGroupId { get; set; }

    }

}
