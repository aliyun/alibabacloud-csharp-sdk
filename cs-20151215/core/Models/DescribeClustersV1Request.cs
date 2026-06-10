// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersV1Request : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3fb96524f9274b4495df0f12a6b5****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster specification. This parameter is valid only when <c>cluster_type</c> is set to <c>ManagedKubernetes</c> and the <c>profile</c> parameter is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.standard</c>: Standard</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.small</c>: Pro</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.xlarge</c>: Pro XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.2xlarge</c>: Pro 2XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.4xlarge</c>: Pro 4XL (Contact customer service to enable this option.)</para>
        /// </description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. These tiers pre-allocate and dedicate control plane resources to ensure a consistently high, predictable level of performance for API concurrency and pod scheduling. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For information about the cluster management fees for Pro and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fee</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fee</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The cluster type.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Kubernetes</c>: an ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ManagedKubernetes</c>: an ACK managed cluster. This type includes ACK managed clusters (Pro and Standard), ACK Serverless clusters (Pro and Standard), ACK Edge clusters (Pro and Standard), and ACK Lingjun clusters (Pro).</para>
        /// </description></item>
        /// <item><description><para><c>ExternalKubernetes</c>: a registered cluster.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>When <c>cluster_type</c> is set to <c>ManagedKubernetes</c>, you can further specify a sub-type of the cluster.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Default</c>: an ACK managed cluster. This includes ACK Pro and ACK Standard clusters.</para>
        /// </description></item>
        /// <item><description><para><c>Edge</c>: an ACK Edge cluster. This includes ACK Edge Pro and ACK Edge Standard clusters.</para>
        /// </description></item>
        /// <item><description><para><c>Serverless</c>: an ACK Serverless cluster. This includes ACK Serverless Pro and ACK Serverless Standard clusters.</para>
        /// </description></item>
        /// <item><description><para><c>Lingjun</c>: an ACK Lingjun cluster (Pro edition).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the clusters belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
