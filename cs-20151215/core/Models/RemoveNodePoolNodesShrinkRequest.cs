// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RemoveNodePoolNodesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove nodes concurrently. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Nodes are removed from the scaling group concurrently.</description></item>
        /// <item><description>false: Nodes are removed from the scaling group sequentially.</description></item>
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
        /// <para>The drain timeout period in seconds. Valid values: (0, 1800]. Default value: 1800. This parameter takes effect only when drain_node is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("drain_timeout_seconds")]
        [Validation(Required=false)]
        public long? DrainTimeoutSeconds { get; set; }

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
        /// <para>Danger: This parameter is deprecated. Use <c>instance_ids</c> instead.</danger></para>
        /// </remarks>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        [Obsolete]
        public string NodesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether automatic release the nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Release the nodes.</description></item>
        /// <item><description>false: Do not release the nodes.</description></item>
        /// </list>
        /// <para>Removing nodes does not automatically release subscription nodes. Automatic release subscription nodes, <a href="https://www.alibabacloud.com/help/en/ecs/change-the-billing-method-of-an-instance-from-subscription-to-pay-as-you-go-1">change the billing method of the nodes from subscription to pay-as-you-go</a>, and then log on to the ECS console automatic release them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("release_node")]
        [Validation(Required=false)]
        public bool? ReleaseNode { get; set; }

    }

}
