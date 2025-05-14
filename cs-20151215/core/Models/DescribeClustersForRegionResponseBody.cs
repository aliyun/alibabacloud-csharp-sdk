// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersForRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried clusters.</para>
        /// </summary>
        [NameInMap("clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersForRegionResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersForRegionResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The domain name of the cluster.</para>
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
            /// <para>The types of ACK managed clusters:</para>
            /// <list type="bullet">
            /// <item><description>ack.pro.small: ACK Pro cluster</description></item>
            /// <item><description>ack.standard: ACK Basic cluster</description></item>
            /// </list>
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
            /// <item><description>Kubernetes: ACK dedicated cluster</description></item>
            /// <item><description>ManagedKubernetes: ACK managed clusters. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless Basic clusters, ACK Serverless Pro clusters, ACK Edge Basic clusters, ACK Edge Pro clusters, and ACK Lingjun Pro clusters.</description></item>
            /// <item><description>ExternalKubernetes: registered cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ManagedKubernetes</para>
            /// </summary>
            [NameInMap("cluster_type")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The CIDR block of pods in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.20.0.0/16</para>
            /// </summary>
            [NameInMap("container_cidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>The time at which the instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-01T20:40:40+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The current Kubernetes version of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.6-aliyun.1</para>
            /// </summary>
            [NameInMap("current_version")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cluster deletion protection. If you enable this option, the cluster cannot be deleted in the console or by calling API operations. You can obtain the terminal ID by calling one of the following operations:</para>
            /// <list type="bullet">
            /// <item><description>true: enables deletion protection for the cluster. This way, the cluster cannot be deleted in the ACK console or by calling API operations.</description></item>
            /// <item><description>false: disables deletion protection for the cluster. This way, the cluster can be deleted in the ACK console or by calling API operations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deletion_protection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <para>The initial Kubernetes version of the cluster.</para>
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
            /// <para>The name of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cluster</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Kubernetes version to which the cluster can be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.18.8-aliyun.1</para>
            /// </summary>
            [NameInMap("next_version")]
            [Validation(Required=false)]
            public string NextVersion { get; set; }

            /// <summary>
            /// <para>The subtype of the clusters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Default: ACK managed clusters. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.</description></item>
            /// <item><description>Edge: ACK Edge clusters. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.</description></item>
            /// <item><description>Serverless: ACK Serverless clusters. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.</description></item>
            /// <item><description>Lingjun: ACK Lingjun Pro clusters.</description></item>
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
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>iptables: iptables.</description></item>
            /// <item><description>ipvs: ipvs.</description></item>
            /// </list>
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
            /// <para>The ID of the cluster resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyvw3wjm****</para>
            /// </summary>
            [NameInMap("resource_group_id")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security group of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-2zeihch86ooz9io4****</para>
            /// </summary>
            [NameInMap("security_group_id")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The CIDR block of the service network.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.0.0/20</para>
            /// </summary>
            [NameInMap("service_cidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The number of nodes in the ACK cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>initial: The cluster is being created.</description></item>
            /// <item><description>failed: The cluster failed to be created.</description></item>
            /// <item><description>running: The cluster is running.</description></item>
            /// <item><description>Upgrading: The cluster is being updated.</description></item>
            /// <item><description>scaling: The cluster is being scaled.</description></item>
            /// <item><description>waiting: The cluster is waiting for connection requests.</description></item>
            /// <item><description>disconnected: The cluster is disconnected.</description></item>
            /// <item><description>inactive: The cluster is inactive.</description></item>
            /// <item><description>unavailable: The cluster is unavailable.</description></item>
            /// <item><description>deleting: The cluster is being deleted.</description></item>
            /// <item><description>deleted: The ACK cluster is deleted.</description></item>
            /// <item><description>delete_failed: The cluster failed to be deleted.</description></item>
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
            /// <para>The time when the cluster was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-08T15:37:00+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2zeg8nf1ukc0fcmvq****</para>
            /// </summary>
            [NameInMap("vpc_id")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The list of vSwitches on the control plane of the cluster.</para>
            /// </summary>
            [NameInMap("vswitch_ids")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>The pagination details.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeClustersForRegionResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeClustersForRegionResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
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
