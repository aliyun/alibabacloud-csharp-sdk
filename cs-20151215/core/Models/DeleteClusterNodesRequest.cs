// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically drain the pods on the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatically drains the pods on the nodes.</description></item>
        /// <item><description><c>false</c>: Does not automatically drain the pods on the nodes.</description></item>
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
        /// <para>The list of nodes to remove. The node name must be the name of the node in the cluster, such as <c>cn-hangzhou.192.168.xx.xx</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the ECS instances at the same time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Releases the ECS instances at the same time.</description></item>
        /// <item><description><c>false</c>: Retains the ECS instances.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>If the nodes are subscription instances, you cannot release the ECS instances at the same time.</para>
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
