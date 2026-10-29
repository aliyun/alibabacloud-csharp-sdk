// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveNodePoolNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove the nodes concurrently. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: removes the nodes from the scaling group concurrently.</para>
        /// </description></item>
        /// <item><description><para>false: removes the nodes from the scaling group sequentially.</para>
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
        /// <item><description>true: drains the nodes.</description></item>
        /// <item><description>false: does not drain the nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("drain_node")]
        [Validation(Required=false)]
        public bool? DrainNode { get; set; }

        /// <summary>
        /// <para>The list of instances to be removed.</para>
        /// </summary>
        [NameInMap("instance_ids")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// <para>The list of nodes to be removed.</para>
        /// <remarks>
        /// <para>Danger: This parameter is deprecated. Use instance_ids instead.</danger></para>
        /// </remarks>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to release the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: releases the nodes.</description></item>
        /// <item><description>false: does not release the nodes.</description></item>
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
