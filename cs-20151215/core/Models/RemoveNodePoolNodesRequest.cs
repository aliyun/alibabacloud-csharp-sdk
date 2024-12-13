// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveNodePoolNodesRequest : TeaModel {
        /// <summary>
        /// <para>Whether to remove concurrently.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("concurrency")]
        [Validation(Required=false)]
        public bool? Concurrency { get; set; }

        /// <summary>
        /// <para>Specifies whether to drain the nodes that you want to remove. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: drain the nodes that you want to remove.</description></item>
        /// <item><description>false: do not drain the nodes that you want to remove.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>A list of instances that you want to remove.</para>
        /// </summary>
        [NameInMap("instance_ids")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// <para>A list of nodes that you want to remove.</para>
        /// <remarks>
        /// <para> This parameter is deprecated. Use instance_ids instead.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the nodes after they are removed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: release the nodes after they are removed.</description></item>
        /// <item><description>false: do not release the nodes after they are removed.</description></item>
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
