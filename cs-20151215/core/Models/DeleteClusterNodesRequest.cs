// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all pods from the nodes that you want to remove. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: removes all pods from the nodes that you want to remove.</description></item>
        /// <item><description><c>false</c>: does not remove pods from the nodes that you want to remove.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>The list of nodes to be removed. You need to specify the name of the nodes used in the cluster, for example, <c>cn-hangzhou.192.168.0.70</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the Elastic Compute Service (ECS) instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: releases the ECS instances.</description></item>
        /// <item><description><c>false</c>: does not release the ECS instances.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// <remarks>
        /// <para> You cannot release subscription ECS instances.</para>
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
