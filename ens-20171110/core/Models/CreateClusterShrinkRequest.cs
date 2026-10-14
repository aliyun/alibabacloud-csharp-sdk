// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Kubernetes or ManagedKubernetes. The former indicates an ECK cluster, and the latter indicates a serverless VC.
        /// Must be used together with the profile parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The pod network CIDR block. The CIDR block must be a valid private CIDR block, which includes the following CIDR blocks and their subnets: 10.0.0.0/8, 172.16-31.0.0/12-16, and 192.168.0.0/16. The CIDR block cannot overlap with the CIDR blocks used by the VPC or existing Kubernetes clusters in the VPC. You cannot modify the CIDR block after the cluster is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("ContainerCidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        /// <summary>
        /// <para>The control plane configuration.</para>
        /// </summary>
        [NameInMap("ControlPlaneConfig")]
        [Validation(Required=false)]
        public string ControlPlaneConfigShrink { get; set; }

        /// <summary>
        /// <para>The ENS Region ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. Select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance used for API Server access. If you specify this parameter, automatic creation of a CLB instance for the API Server is skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz9t256gqa3vbouk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycluster-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>Each pod vSwitch corresponds to a worker node vSwitch. The zone of the pod vSwitch must be the same as that of the worker node vSwitch. If you do not specify this parameter, vswitch_ids is used by default.</para>
        /// </summary>
        [NameInMap("PodVswitchIds")]
        [Validation(Required=false)]
        public string PodVswitchIdsShrink { get; set; }

        /// <summary>
        /// <para>Default or Serverless. The former indicates an ECK cluster, and the latter indicates a serverless VC.
        /// Must be used together with the cluster_type parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access. The API Server is exposed through an EIP to enable public access to the cluster.
        /// ● true: Enable public network access.
        /// ● false: Disable public network access. If you select this option, you cannot access the cluster API Server from the Internet.
        /// Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicAccess")]
        [Validation(Required=false)]
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// <para>The service network CIDR block. Valid ranges: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or the CIDR blocks used by existing Kubernetes clusters in the VPC. You cannot modify the CIDR block after the cluster is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.19.0.0/20</para>
        /// </summary>
        [NameInMap("ServiceCidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The VPC used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches for cluster nodes. The ENS Region of the vswitch_ids must be the same as the ens_region_id value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-xxx&quot;, &quot;vsw-yyy&quot;]</para>
        /// </summary>
        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public string VswitchIdsShrink { get; set; }

    }

}
