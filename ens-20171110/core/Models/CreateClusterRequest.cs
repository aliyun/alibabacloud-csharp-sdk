// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>Kubernetes or ManagedKubernetes. The former indicates an ECK cluster, and the latter indicates a serverless VC. This parameter must be used together with the Profile parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The CIDR block for pods. It must be a valid private CIDR block, such as 10.0.0.0/8, 172.16.0.0/12 to 172.31.0.0/16, or 192.168.0.0/16, and their subnets. The CIDR block cannot overlap with the CIDR block of the VPC or the CIDR blocks used by existing Kubernetes clusters in the VPC. The CIDR block cannot be modified after the cluster is created.</para>
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
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the virtual machine image for the control plane.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-5ul335umat4e2y9ynwi84p3f9</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens.esk.sn1.medium</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }

            /// <summary>
            /// <para>The logon password for the control plane machines of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ThisIsAPassword</para>
            /// </summary>
            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <para>The edge zone service port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("NodePortRange")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <para>The name of the runtime for the control plane nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The number of control plane nodes. Valid values: 3 and 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The category of the system cloud disk for the node. Valid values: local_ssd, cloud_ssd, cloud_efficiency, and local_hdd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Edge Node Service (ENS) region where the cluster is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The Internet service provider (ISP) information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cmcc</b>: China Mobile.</description></item>
        /// <item><description><b>unicom</b>: China Unicom.</description></item>
        /// <item><description><b>telecom</b>: China Telecom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The Kubernetes version of the cluster. The version aligns with the Kubernetes community baseline version. We recommend that you select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The ID of the Classic Load Balancer (CLB) instance used for API server access. If you specify this parameter, automatic creation of a CLB instance for the API server is skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-wz9t256gqa3vbouk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycluster-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway used by the cluster. If you specify this parameter, automatic creation of a NAT gateway is skipped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The IDs of the pod vSwitches. Each pod vSwitch corresponds to a worker node vSwitch. The pod vSwitch and the worker node vSwitch must be in the same zone. If you do not specify this parameter, the vSwitches specified by the VswitchIds parameter are used by default.</para>
        /// </summary>
        [NameInMap("PodVswitchIds")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>Default or Serverless. The former indicates an ECK cluster, and the latter indicates a serverless VC. This parameter must be used together with the ClusterType parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access. You can expose the API server by using an elastic IP address (EIP) to enable public network access to the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables public network access.</description></item>
        /// <item><description>false: disables public network access. If you select false, you cannot access the API server of the cluster over the Internet.
        /// Default value: false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicAccess")]
        [Validation(Required=false)]
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// <para>The CIDR block for Services. Valid ranges include 10.0.0.0/16 to 10.0.0.0/24, 172.16.0.0/16 to 172.31.0.0/24, and 192.168.0.0/16 to 192.168.0.0/24. The CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or the CIDR blocks used by existing Kubernetes clusters in the VPC. The CIDR block cannot be modified after the cluster is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.19.0.0/20</para>
        /// </summary>
        [NameInMap("ServiceCidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) used by the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches where the cluster nodes are deployed. The ENS region of the vSwitches must be the same as the ENS region specified by the EnsRegionId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-xxx&quot;, &quot;vsw-yyy&quot;]</para>
        /// </summary>
        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
