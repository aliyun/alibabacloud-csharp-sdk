// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all pods from the nodes you want to remove. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: removes all pods automatically.</description></item>
        /// <item><description><c>false</c>: skips removing pods.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>The list of nodes to remove. You must specify the node names used in the cluster, for example, <c>cn-hangzhou.192.168.xx.xx</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: releases the ECS instances.</description></item>
        /// <item><description><c>false</c>: retains the ECS instances.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c></para>
        /// <para>**</para>
        /// <para><b>Notes</b> Unsupported for subscription ECS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
