// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8155823d057948c69a****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies the cluster specification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ack.standard</c>: Basic edition.</description></item>
        /// <item><description><c>ack.pro.small</c>: Pro edition.</description></item>
        /// <item><description><c>ack.pro.xlarge</c>: Pro XL.</description></item>
        /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL.</description></item>
        /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (requires whitelist approval from customer service).</description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are the three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure that API concurrency and pod scheduling capabilities remain consistently at a high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
        /// <para>For cluster management fees of the Pro edition and provisioned control plane editions, refer to &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.standard</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>Specifies the cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Kubernetes: ACK dedicated clusters.</description></item>
        /// <item><description>ManagedKubernetes: ACK managed clusters, including ACK managed clusters (ACK Pro and ACK Basic), ACK Serverless clusters (Pro and Basic), ACK Edge clusters (Pro and Basic), and ACK Lingjun clusters (Pro).</description></item>
        /// <item><description>ExternalKubernetes: registered clusters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Specifies the cluster name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cluster</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies the cluster subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Default: ACK managed clusters, including ACK Pro and ACK Basic.</description></item>
        /// <item><description>Edge: ACK Edge clusters, including ACK Edge Pro and ACK Edge Basic.</description></item>
        /// <item><description>Serverless: ACK Serverless clusters, including ACK Serverless Pro and ACK Serverless Basic.</description></item>
        /// <item><description>LingJun: ACK Lingjun clusters, available only in Pro edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Serverless</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

    }

}
