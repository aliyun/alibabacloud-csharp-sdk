// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically drain pods from the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Automatically drains pods from the nodes.</description></item>
        /// <item><description><c>false</c>: Does not automatically drain pods from the nodes.</description></item>
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
        /// <para>The drain timeout period in seconds. Valid values: (0, 1800]. If this parameter is not specified, the default value 1800 is used. This parameter takes effect only when drain_node is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("drain_timeout_seconds")]
        [Validation(Required=false)]
        public long? DrainTimeoutSeconds { get; set; }

        /// <summary>
        /// <para>The list of nodes to remove. The node name must be the name of the node in the cluster, such as <c>cn-hangzhou.192.168.xx.xx</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the associated ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Releases the associated ECS instances.</description></item>
        /// <item><description><c>false</c>: Retains the associated ECS instances.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para>When a node is a subscription instance, you cannot release the associated ECS instance.</para>
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
