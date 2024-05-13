// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all pods from the nodes that you want to remove. Valid values:
        /// 
        /// *   `true`: removes all pods from the nodes that you want to remove.
        /// *   `false`: does not remove pods from the nodes that you want to remove.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// The list of nodes to be removed. You need to specify the name of the nodes used in the cluster, for example, `cn-hangzhou.192.168.0.70`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// Specifies whether to release the Elastic Compute Service (ECS) instances. Valid values:
        /// 
        /// *   `true`: releases the ECS instances.
        /// *   `false`: does not release the ECS instances.
        /// 
        /// Default value: `false`.
        /// 
        /// >  You cannot release subscription ECS instances.
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
