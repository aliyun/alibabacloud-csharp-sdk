// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of clusters.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersForRegionResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersForRegionResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The cluster domain.</para>
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
            /// <item><description><para><c>ack.standard</c>: Basic Edition</para>
            /// </description></item>
            /// <item><description><para><c>ack.pro.small</c>: Pro Edition</para>
            /// </description></item>
            /// <item><description><para><c>ack.pro.xlarge</c>: Pro XL</para>
            /// </description></item>
            /// <item><description><para><c>ack.pro.2xlarge</c>: Pro 2XL</para>
            /// </description></item>
            /// <item><description><para><c>ack.pro.4xlarge</c>: Pro 4XL. This specification is available only to allowlisted users.</para>
            /// </description></item>
            /// </list>
            /// <para>Pro XL, Pro 2XL, and Pro 4XL are three specifications available for the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/user-guide/ack-pro-provisioned-control-plane">ACK Pro provisioned control plane</a>. These specifications ensure a high and deterministic level of API concurrency and Pod scheduling capabilities by pre-allocating and dedicating control plane resources. They are suitable for AI training and inference, large-scale clusters, and mission-critical workloads.</para>
            /// <para>For information about the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">cluster management fee</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/ack/ack-managed-and-ack-dedicated/product-overview/cluster-management-fee">cluster management fee</a> for Pro Edition and ACK Pro provisioned control plane specifications, see the linked topic.</para>
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
            /// <item><description><para><c>ManagedKubernetes</c>: an ACK managed cluster. This type includes ACK managed clusters (Pro and Basic editions), ACK Serverless clusters (Pro and Basic editions), ACK Edge clusters (Pro and Basic editions), and ACK Lingjun clusters (Pro edition).</para>
            /// </description></item>
            /// <item><description><para><c>ExternalKubernetes</c>: a registered cluster.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The CIDR block for Pods in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.0.0/16</para>
            /// </summary>
            [NameInMap("container_cidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>The time the cluster was created.</para>
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
            /// <para>Specifies whether deletion protection is enabled for the cluster. If enabled, you cannot delete the cluster from the console or by an API call. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: Deletion protection is enabled.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Deletion protection is disabled.</para>
            /// </description></item>
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
            /// <para>The IP stack of the cluster.</para>
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
            /// <para>The available upgrade version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.18.8-aliyun.1</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The subtype of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Default</c>: An ACK managed cluster (Pro and Basic editions).</para>
            /// </description></item>
            /// <item><description><para><c>Edge</c>: An ACK Edge cluster (Pro and Basic editions).</para>
            /// </description></item>
            /// <item><description><para><c>Serverless</c>: An ACK Serverless cluster (Pro and Basic editions).</para>
            /// </description></item>
            /// <item><description><para><c>LingJun</c>: An ACK Lingjun cluster (Pro edition).</para>
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
            /// <para>The kube-proxy proxy mode of the cluster.</para>
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
            /// <para>The ID of the resource group to which the cluster belongs.</para>
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
            /// <para>The CIDR block for the service network.</para>
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
            /// <para>The state of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>initial</c>: The cluster is being created.</para>
            /// </description></item>
            /// <item><description><para><c>failed</c>: Cluster creation failed.</para>
            /// </description></item>
            /// <item><description><para><c>running</c>: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para><c>updating</c>: The cluster is being updated.</para>
            /// </description></item>
            /// <item><description><para><c>upgrading</c>: The cluster is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><c>removing</c>: Nodes are being removed from the cluster.</para>
            /// </description></item>
            /// <item><description><para><c>draining</c>: Node draining is in progress.</para>
            /// </description></item>
            /// <item><description><para><c>scaling</c>: The cluster is being scaled.</para>
            /// </description></item>
            /// <item><description><para><c>inactive</c>: The cluster is inactive.</para>
            /// </description></item>
            /// <item><description><para><c>unavailable</c>: The cluster is unavailable.</para>
            /// </description></item>
            /// <item><description><para><c>deleting</c>: The cluster is being deleted.</para>
            /// </description></item>
            /// <item><description><para><c>deleted</c>: The cluster is deleted.</para>
            /// </description></item>
            /// <item><description><para><c>delete_failed</c>: Cluster deletion failed.</para>
            /// </description></item>
            /// <item><description><para><c>waiting</c>: The cluster is waiting for a connection.</para>
            /// </description></item>
            /// <item><description><para><c>disconnected</c>: The cluster is disconnected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tags attached to the cluster.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

            /// <summary>
            /// <para>The time zone of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>The time the cluster was last updated.</para>
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
            /// <para>The IDs of the vSwitches for the control plane.</para>
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
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries that match the query.</para>
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
