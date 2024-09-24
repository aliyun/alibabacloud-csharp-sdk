// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveNodePoolNodesShrinkRequest : TeaModel {
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// Specifies whether to drain the nodes that you want to remove. Valid values:
        /// 
        /// *   true: drain the nodes that you want to remove.
        /// *   false: do not drain the nodes that you want to remove.
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// A list of instances that you want to remove.
        /// </summary>
        [NameInMap("instance_ids")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// A list of nodes that you want to remove.
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodesShrink { get; set; }

        /// <summary>
        /// Specifies whether to release the nodes after they are removed. Valid values:
        /// 
        /// *   true: release the nodes after they are removed.
        /// *   false: do not release the nodes after they are removed.
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
