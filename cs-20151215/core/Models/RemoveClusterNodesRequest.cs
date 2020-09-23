// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveClusterNodesRequest : TeaModel {
        /// <summary>
        /// 是否同时释放ECS。
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

        /// <summary>
        /// 是否排空节点上的Pod。
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// 要移除的Node列表。
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

    }

}
