// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>Whether to automatically drain Pods on the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatically drain Pods on the node.</description></item>
        /// <item><description><c>false</c>: Do not automatically drain Pods on the node.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>List of nodes to remove. The node names must be the names of the nodes in the cluster, for example: <c>cn-hangzhou.192.168.xx.xx</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Whether to simultaneously remove ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Simultaneously remove ECS instances.</description></item>
        /// <item><description><c>false</c>: Retain ECS instances.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>Simultaneous removal of ECS instances is not supported when the nodes are subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
