// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1375383353108460</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The cluster instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eck-xxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster kubeconfig.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;kind&quot;: &quot;Config&quot;,
            ///         &quot;apiVersion&quot;: &quot;v1&quot;,
            ///         &quot;preferences&quot;: {},
            ///         &quot;clusters&quot;: [
            ///           {
            ///             &quot;name&quot;: &quot;kubernetes&quot;,
            ///             &quot;cluster&quot;: {
            ///               &quot;server&quot;: &quot;<a href="https://000.000.000.000:6443">https://000.000.000.000:6443</a>&quot;,
            ///               &quot;certificate-authority-data&quot;: &quot;&quot;
            ///             }
            ///           }
            ///         ],
            ///         &quot;users&quot;: [
            ///           {
            ///             &quot;name&quot;: &quot;kubernetes-admin&quot;,
            ///             &quot;user&quot;: {
            ///               &quot;client-certificate-data&quot;: &quot;&quot;,
            ///               &quot;client-key-data&quot;: &quot;&quot;
            ///             }
            ///           }
            ///         ],
            ///         &quot;contexts&quot;: [
            ///           {
            ///             &quot;name&quot;: &quot;kubernetes-admin@kubernetes&quot;,
            ///             &quot;context&quot;: {
            ///               &quot;cluster&quot;: &quot;kubernetes&quot;,
            ///               &quot;user&quot;: &quot;kubernetes-admin&quot;
            ///             }
            ///           }
            ///         ],
            ///         &quot;current-context&quot;: &quot;kubernetes-admin@kubernetes&quot;
            ///       }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public object Config { get; set; }

            /// <summary>
            /// <para>The pod network CIDR block. The value must be a valid private CIDR block, which includes the following CIDR blocks and their subnets: 10.0.0.0/8, 172.16-31.0.0/12-16, and 192.168.0.0/16. The CIDR block cannot overlap with the VPC CIDR block or the CIDR blocks used by existing Kubernetes clusters in the VPC. You cannot modify this value after the cluster is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("ContainerCidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>The control plane configuration.</para>
            /// </summary>
            [NameInMap("ControlPlaneConfig")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersControlPlaneConfig ControlPlaneConfig { get; set; }
            public class DescribeClustersV1ResponseBodyClustersControlPlaneConfig : TeaModel {
                /// <summary>
                /// <para>The container runtime type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>containerd</para>
                /// </summary>
                [NameInMap("ContainerRuntime")]
                [Validation(Required=false)]
                public string ContainerRuntime { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-68be8cb9f71fhyvjekxa23qsf</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens.sn1.medium</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The node service port range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000-32767</para>
                /// </summary>
                [NameInMap("NodePortRange")]
                [Validation(Required=false)]
                public string NodePortRange { get; set; }

                /// <summary>
                /// <para>The number of control plane nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The system cloud disk type of the node. Valid values: local_ssd, cloud_ssd, cloud_efficiency, and local_hdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The system cloud disk size. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-07T09:57:26+08:00</para>
            /// </summary>
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The ENS node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-55</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <para>The authentication token for cluster access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxx.yyyyyyy</para>
            /// </summary>
            [NameInMap("JoinToken")]
            [Validation(Required=false)]
            public string JoinToken { get; set; }

            /// <summary>
            /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. Use the latest version. If you do not specify this parameter, the latest version is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.31.9-aliyunedge.1</para>
            /// </summary>
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }

            /// <summary>
            /// <para>The load balancing instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-58dngw0fyimzzvwljfec7hy0z</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-eck-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs for pods. Each pod vSwitch corresponds to a worker node vSwitch, and the zones of the pod vSwitch and the worker node vSwitch must be the same. If you leave this parameter empty, the value of vswitch_ids is used by default.</para>
            /// </summary>
            [NameInMap("PodVswitchIds")]
            [Validation(Required=false)]
            public List<string> PodVswitchIds { get; set; }

            /// <summary>
            /// <para>Indicates whether public network access is enabled. The API Server is exposed through an EIP to enable public access to the cluster. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Public network access is enabled.</description></item>
            /// <item><description>false: Public network access is disabled. If you select this option, the cluster API Server cannot be accessed from the Internet.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicAccess")]
            [Validation(Required=false)]
            public bool? PublicAccess { get; set; }

            /// <summary>
            /// <para>The service network CIDR block. Valid ranges: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or the CIDR blocks used by existing Kubernetes clusters in the VPC. You cannot modify this value after the cluster is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("ServiceCidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <para>The cluster status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The VPC used by the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5wsgr3xeolb2ist303wp3cscp</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The vSwitch IDs of the cluster nodes. The ENS region of the vSwitch IDs must be the same as the value of ens_region_id.</para>
            /// </summary>
            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public List<string> VswitchIds { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
