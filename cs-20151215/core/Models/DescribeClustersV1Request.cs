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
        /// <para>The cluster specification. This parameter is valid when cluster_type is set to ManagedKubernetes and profile is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ack.standard: Basic Edition.</description></item>
        /// <item><description>ack.pro.small: Pro Edition.</description></item>
        /// <item><description>ack.pro.xlarge: Pro XL.</description></item>
        /// <item><description>ack.pro.2xlarge: Pro 2XL.</description></item>
        /// <item><description>ack.pro.4xlarge: Pro 4XL. To use this specification, contact customer service to apply for whitelist access.</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are the three tiers provided by the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure consistently high levels of API concurrency and pod scheduling capabilities. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For information about the cluster management fees for the Pro Edition and provisioned control plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Kubernetes: ACK dedicated cluster.</description></item>
        /// <item><description>ManagedKubernetes: ACK managed clusters, including ACK managed clusters (Pro Edition and Basic Edition), ACK Serverless clusters (Pro Edition and Basic Edition), ACK Edge clusters (Pro Edition and Basic Edition), and ACK Lingjun clusters (Pro Edition).</description></item>
        /// <item><description>ExternalKubernetes: registered cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The cluster name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The cluster subtype. This parameter is valid only when cluster_type is set to ManagedKubernetes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: ACK serverless clusters, including ACK serverless cluster Pro Edition and Basic Edition.</description></item>
        /// <item><description>Edge: ACK Edge clusters, including ACK Edge cluster Pro Edition and Basic Edition.</description></item>
        /// <item><description>Serverless: ACK ACK clusters, including ACK ACK cluster Pro Edition and Basic Edition.</description></item>
        /// <item><description>Lingjun: ACK Lingjun clusters, providing Pro Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>The region of the cluster. Specify this parameter to filter clusters by region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
