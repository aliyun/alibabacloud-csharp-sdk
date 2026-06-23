// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveNodePoolNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove nodes concurrently.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Nodes are concurrently removed from the scaling group.</para>
        /// </description></item>
        /// <item><description><para>false: Nodes are sequentially removed from the scaling group.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to drain the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Drain the nodes.</description></item>
        /// <item><description>false: Do not drain the nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>The list of instances to remove.</para>
        /// </summary>
        [NameInMap("instance_ids")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>[This parameter is deprecated]</para>
        /// <para>The list of nodes to remove.</para>
        /// <remarks>
        /// <para>Danger: This parameter is deprecated. Use <c>instance_ids</c> instead.</danger>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Release the nodes.</description></item>
        /// <item><description>false: Do not release the nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
