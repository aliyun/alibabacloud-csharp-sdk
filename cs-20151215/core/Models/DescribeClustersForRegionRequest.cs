// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8155823d057948c69a****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The specification of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ack.standard</c>: Standard Edition</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.small</c>: Pro Edition</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.xlarge</c>: Pro XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.2xlarge</c>: Pro 2XL</para>
        /// </description></item>
        /// <item><description><para><c>ack.pro.4xlarge</c>: Pro 4XL (To use this specification, you must submit a ticket.)</para>
        /// </description></item>
        /// </list>
        /// <para>Pro XL, Pro 2XL, and Pro 4XL are three specifications available for the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. These specifications ensure a high and deterministic level of API concurrency and Pod scheduling capabilities by pre-allocating and dedicating control plane resources. They are suitable for AI training and inference, large-scale clusters, and mission-critical workloads.</para>
        /// <para>For information about the cluster management fees for Pro Edition and provisioned control plane clusters, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">cluster management fee</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">cluster management fee</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack.standard</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <para>The type of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Kubernetes</c>: an ACK dedicated cluster.</para>
        /// </description></item>
        /// <item><description><para><c>ManagedKubernetes</c>: an ACK managed cluster. This includes ACK managed clusters (Pro and Standard Editions), ACK Serverless clusters (Pro and Standard Editions), ACK Edge clusters (Pro and Standard Editions), and ACK Lingjun clusters (Pro Edition).</para>
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
        /// <para>The name of the cluster. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cluster</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The subtype of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Default</c>: ACK managed clusters, including Pro and Standard Editions.</para>
        /// </description></item>
        /// <item><description><para><c>Edge</c>: ACK Edge clusters, including Pro and Standard Editions.</para>
        /// </description></item>
        /// <item><description><para><c>Serverless</c>: ACK Serverless clusters, including Pro and Standard Editions.</para>
        /// </description></item>
        /// <item><description><para><c>LingJun</c>: ACK Lingjun clusters, available in the Pro Edition.</para>
        /// </description></item>
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
