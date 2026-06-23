// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cluster details.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersForRegionResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersForRegionResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The local domain name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster.local</para>
            /// </summary>
            [NameInMap("cluster_domain")]
            [Validation(Required=false)]
            public string ClusterDomain { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c905d1364c2dd4b6284a3f41790c4****</para>
            /// </summary>
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The specification of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>ack.standard</c>: Basic</description></item>
            /// <item><description><c>ack.pro.small</c>: Pro</description></item>
            /// <item><description><c>ack.pro.xlarge</c>: Pro XL</description></item>
            /// <item><description><c>ack.pro.2xlarge</c>: Pro 2XL</description></item>
            /// <item><description><c>ack.pro.4xlarge</c>: Pro 4XL (contact customer service to add your account to the whitelist)</description></item>
            /// </list>
            /// <para>Pro XL, Pro 2XL, and Pro 4XL are three tiers provided by &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro Provisioned Control Plane</a>. By pre-allocating and dedicating control plane resources, these tiers ensure that API concurrency and Pod scheduling capabilities remain at a consistently high level. They are suitable for AI training and inference, ultra-large-scale clusters, and mission-critical workloads.</para>
            /// <para>For information about cluster management fees for Pro and Provisioned Control Plane editions, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">Cluster management fees</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack.standard</para>
            /// </summary>
            [NameInMap("cluster_spec")]
            [Validation(Required=false)]
            public string ClusterSpec { get; set; }

            /// <summary>
            /// <para>The cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Kubernetes: ACK dedicated cluster.</description></item>
            /// <item><description>ManagedKubernetes: ACK managed cluster types, including ACK managed clusters (ACK Pro and ACK Basic), ACK Serverless clusters (Pro and Basic), ACK Edge clusters (Pro and Basic), and ACK Lingjun clusters (Pro).</description></item>
            /// <item><description>ExternalKubernetes: registered cluster.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The pod CIDR block of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.0.0/16</para>
            /// </summary>
            [NameInMap("container_cidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-01T20:40:40+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The current version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.6-aliyun.1</para>
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled for the cluster. Deletion protection prevents the cluster from being accidentally deleted in the console or by calling API operations. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Deletion protection is enabled. The cluster cannot be deleted in the console or by calling API operations.</description></item>
            /// <item><description>false: Deletion protection is not enabled. The cluster can be deleted in the console or by calling API operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The initial version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.6-aliyun.1</para>
            /// </summary>
            [NameInMap("init_version")]
            [Validation(Required=false)]
            public string InitVersion { get; set; }

            /// <summary>
            /// <para>The IP protocol stack of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("ip_stack")]
            [Validation(Required=false)]
            public string IpStack { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cluster</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The version to which the cluster can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.18.8-aliyun.1</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The cluster subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: ACK managed cluster, including ACK Pro and ACK Basic.</description></item>
            /// <item><description>Edge: ACK Edge cluster, including ACK Edge Pro and ACK Edge Basic.</description></item>
            /// <item><description>Serverless: ACK Serverless cluster, including ACK Serverless Pro and ACK Serverless Basic.</description></item>
            /// <item><description>LingJun: ACK Lingjun cluster, available in Pro.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

            /// <summary>
            /// <para>The kube-proxy mode of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ipvs</para>
            /// </summary>
            [NameInMap("proxy_mode")]
            [Validation(Required=false)]
            public string ProxyMode { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-a</para>
            /// </summary>
            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The security group ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The service CIDR block.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.0.0/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The number of nodes in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The running state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>initial</c>: The cluster is being created.</description></item>
            /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
            /// <item><description><c>running</c>: The cluster is running.</description></item>
            /// <item><description><c>updating</c>: The cluster is being updated.</description></item>
            /// <item><description><c>upgrading</c>: The cluster is being upgraded.</description></item>
            /// <item><description><c>removing</c>: Nodes are being removed.</description></item>
            /// <item><description><c>draining</c>: Nodes are being drained.</description></item>
            /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
            /// <item><description><c>inactive</c>: The cluster is inactive.</description></item>
            /// <item><description><c>unavailable</c>: The cluster is unavailable.</description></item>
            /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
            /// <item><description><c>deleted</c>: The cluster has been deleted.</description></item>
            /// <item><description><c>delete_failed</c>: The cluster failed to be deleted.</description></item>
            /// <item><description><c>waiting</c>: The cluster is in the accessed state, waiting to be connected.</description></item>
            /// <item><description><c>disconnected</c>: The cluster is disconnected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The list of cluster tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-08T15:37:00+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The VPC ID of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zeg8nf1ukc0fcmvq****</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The list of vSwitches for the cluster control plane.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersForRegionResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersForRegionResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

    }

}
