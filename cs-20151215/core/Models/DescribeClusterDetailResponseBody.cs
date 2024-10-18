// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
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
        /// <para>c82e6987e2961451182edacd74faf****</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>After you set <c>cluster_type</c> to <c>ManagedKubernetes</c> and configure the <c>profile</c> parameter, you can further specify the edition of the cluster.</para>
        /// <list type="bullet">
        /// <item><description><c>ack.pro.small</c>: Pro.</description></item>
        /// <item><description><c>ack.standard</c>: Basic. If you leave the parameter empty, the Basic edition is selected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ack.pro.small</para>
        /// </summary>
        [NameInMap("cluster_spec")]
        [Validation(Required=false)]
        public string ClusterSpec { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster. ACK managed clusters include ACK Basic clusters, ACK Pro clusters, ACK Serverless clusters (Basic and Pro), ACK Edge clusters (Basic and Pro), and ACK Lingjun clusters (Pro).</description></item>
        /// <item><description><c>ExternalKubernetes</c>: registered cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
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
        /// <para>2019-11-25T15:50:20+08:00</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The current Kubernetes version of the cluster. For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Release notes for Kubernetes versions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.16.6-aliyun.1</para>
        /// </summary>
        [NameInMap("current_version")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled for the cluster. If deletion protection is enabled, the cluster cannot be deleted in the Container Service console or by calling API operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: deletion protection is enabled for the cluster. This way, the cluster cannot be deleted in the Container Service console or by calling API operations.</description></item>
        /// <item><description><c>false</c>: deletion protection is disabled for the cluster. This way, the cluster can be deleted in the Container Service console or by calling API operations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deletion_protection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The Docker version that is used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19.03.5</para>
        /// </summary>
        [NameInMap("docker_version")]
        [Validation(Required=false)]
        public string DockerVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lb-2zehc05z3b8dwiifh****</para>
        /// </summary>
        [NameInMap("external_loadbalancer_id")]
        [Validation(Required=false)]
        public string ExternalLoadbalancerId { get; set; }

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
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("ip_stack")]
        [Validation(Required=false)]
        public string IpStack { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. This feature is available only in ACK Pro clusters.</para>
        /// </summary>
        [NameInMap("maintenance_window")]
        [Validation(Required=false)]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// <para>The endpoints of the cluster, including an internal endpoint and a public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;intranet_api_server_endpoint\&quot;:\&quot;<a href="https://192.168.0.251:6443%5C%5C%22***%7D">https://192.168.0.251:6443\\&quot;***}</a></para>
        /// </summary>
        [NameInMap("master_url")]
        [Validation(Required=false)]
        public string MasterUrl { get; set; }

        /// <summary>
        /// <para>The metadata of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;Addons\&quot;:***</para>
        /// </summary>
        [NameInMap("meta_data")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// <para>The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). The name cannot start with a hyphen (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("network_mode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.18.8-aliyun.1</para>
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("node_cidr_mask")]
        [Validation(Required=false)]
        public string NodeCidrMask { get; set; }

        [NameInMap("operation_policy")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyOperationPolicy OperationPolicy { get; set; }
        public class DescribeClusterDetailResponseBodyOperationPolicy : TeaModel {
            [NameInMap("cluster_auto_upgrade")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade ClusterAutoUpgrade { get; set; }
            public class DescribeClusterDetailResponseBodyOperationPolicyClusterAutoUpgrade : TeaModel {
                [NameInMap("channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

        }

        /// <summary>
        /// <para>The ROS parameters of the cluster.</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("private_zone")]
        [Validation(Required=false)]
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// <para>If you set <c>cluster_type</c> to <c>ManagedKubernetes</c>, an ACK managed cluster is created. In this case, you can further specify the cluster edition.</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>. ACK managed cluster. ACK managed clusters include ACK Basic clusters and ACK Pro clusters.</description></item>
        /// <item><description><c>Edge</c>: ACK Edge cluster. ACK Edge clusters include ACK Edge Basic clusters and ACK Edge Pro clusters.</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster. ACK Serverless clusters include ACK Serverless Basic clusters and ACK Serverless Pro clusters.</description></item>
        /// <item><description><c>Lingjun</c>: ACK Lingjun Pro cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ipvs</para>
        /// </summary>
        [NameInMap("proxy_mode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
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
        /// <para>The ID of the security group to which the cluster belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-25yq****</para>
        /// </summary>
        [NameInMap("security_group_id")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.21.0.0/20</para>
        /// </summary>
        [NameInMap("service_cidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The number of nodes in the cluster. Master nodes and worker nodes are included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>initial</c>: The cluster is being created.</description></item>
        /// <item><description><c>failed</c>: The cluster failed to be created.</description></item>
        /// <item><description><c>running</c>: The cluster is running.</description></item>
        /// <item><description><c>updating</c>: The cluster is being updated.</description></item>
        /// <item><description><c>updating_failed</c>: The cluster failed to be updated.</description></item>
        /// <item><description><c>scaling</c>: The cluster is being scaled.</description></item>
        /// <item><description><c>waiting</c>: The cluster is waiting for connection requests.</description></item>
        /// <item><description><c>disconnected</c>: The cluster is disconnected.</description></item>
        /// <item><description><c>stopped</c>: The cluster is stopped.</description></item>
        /// <item><description><c>deleting</c>: The cluster is being deleted.</description></item>
        /// <item><description><c>deleted</c>: The cluster is deleted.</description></item>
        /// <item><description><c>delete_failed</c>: The cluster failed to be deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The pod CIDR block. It must be a valid and private CIDR block, and must be one of the following CIDR blocks or their subnets:</para>
        /// <list type="bullet">
        /// <item><description>10.0.0.0/8</description></item>
        /// <item><description>172.16-31.0.0/12-16</description></item>
        /// <item><description>192.168.0.0/16</description></item>
        /// </list>
        /// <para>The pod CIDR block cannot overlap with the CIDR block of the VPC or the CIDR blocks of the clusters in the VPC.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/186964.html">Plan CIDR blocks for an ACK cluster</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("subnet_cidr")]
        [Validation(Required=false)]
        [Obsolete]
        public string SubnetCidr { get; set; }

        /// <summary>
        /// <para>The resource tags of the cluster.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
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
        /// <para>2020-01-13T23:01:03+08:00</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public string Updated { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the cluster is deployed. This parameter is required when you create a cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zecuu62b9zw7a7qn****</para>
        /// </summary>
        [NameInMap("vpc_id")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The IDs of the vSwitches. You can select one to three vSwitches when you create a cluster. We recommend that you select vSwitches in different zones to ensure high availability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zete8s4qocqg0mf6****,vsw-2zete8s4qocqg0mf6****</para>
        /// </summary>
        [NameInMap("vswitch_id")]
        [Validation(Required=false)]
        [Obsolete]
        public string VswitchId { get; set; }

        [NameInMap("vswitch_ids")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

        /// <summary>
        /// <para>The name of the worker Resource Access Management (RAM) role. The RAM role is assigned to the worker nodes of the cluster to allow the worker nodes to manage Elastic Compute Service (ECS) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KubernetesWorkerRole-ec87d15b-edca-4302-933f-c8a16bf0****</para>
        /// </summary>
        [NameInMap("worker_ram_role_name")]
        [Validation(Required=false)]
        public string WorkerRamRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-a</para>
        /// </summary>
        [NameInMap("zone_id")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
