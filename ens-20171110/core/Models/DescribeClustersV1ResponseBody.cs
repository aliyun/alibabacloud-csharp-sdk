// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The user IDs.</para>
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
            /// <para>The kubeconfig file of the cluster.</para>
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
            /// <para>The pod CIDR block. You can specify 10.0.0.0/8, 172.16-31.0.0/12-16, 192.168.0.0/16, or their subnets as the pod CIDR block. The pod CIDR block cannot overlap with the CIDR block of the VPC in which the cluster is deployed and the CIDR blocks of existing clusters in the VPC. You cannot modify the pod CIDR block after you create the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("ContainerCidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            /// <summary>
            /// <para>Control plane configuration.</para>
            /// </summary>
            [NameInMap("ControlPlaneConfig")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersControlPlaneConfig ControlPlaneConfig { get; set; }
            public class DescribeClustersV1ResponseBodyClustersControlPlaneConfig : TeaModel {
                /// <summary>
                /// <para>The runtime type used by the nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>containerd</para>
                /// </summary>
                [NameInMap("ContainerRuntime")]
                [Validation(Required=false)]
                public string ContainerRuntime { get; set; }

                /// <summary>
                /// <para>The ID of the custom image.</para>
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
                /// <para>The node port range.</para>
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
                /// <para>The system disk type of the node. Valid value: local_ssd, cloud_ssd, cloud_efficiency, and local_hdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <para>The size of the system disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

            }

            /// <summary>
            /// <para>The ID of the ENS node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-55</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The cluster access authentication token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxxxx.yyyyyyy</para>
            /// </summary>
            [NameInMap("JoinToken")]
            [Validation(Required=false)]
            public string JoinToken { get; set; }

            /// <summary>
            /// <para>The Kubernetes version of the cluster. The Kubernetes versions supported are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not specify this parameter, the latest Kubernetes version is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.31.9-aliyunedge.1</para>
            /// </summary>
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }

            /// <summary>
            /// <para>The ID of the ALB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-58dngw0fyimzzvwljfec7hy0z</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The name of the monitoring object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-eck-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>For each vSwitch that allocates IP addresses to worker nodes, you must select a vSwitch in the same zone to allocate IP addresses to pods. If you do not specify this parameter, vswitch_ids is used by default.</para>
            /// </summary>
            [NameInMap("PodVswitchIds")]
            [Validation(Required=false)]
            public List<string> PodVswitchIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable Internet access for the application. You can use an elastic IP address (EIP) to expose the API server. This way, you can access the cluster over the Internet. Valid values: true: enables Internet access for the application. false: disables Internet access to the API server of the cluster. If you set the value to false, the API server cannot be accessed over the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicAccess")]
            [Validation(Required=false)]
            public bool? PublicAccess { get; set; }

            /// <summary>
            /// <para>Valid values: 10.0.0.0/16-24, 172.16-31.0.0/16-24, and 192.168.0.0/16-24. The Service CIDR block cannot overlap with the VPC CIDR block 10.1.0.0/21 or the CIDR blocks of existing ACK clusters in the VPC. You cannot change the Service CIDR block after you create the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("ServiceCidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The VPC of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-5wsgr3xeolb2ist303wp3cscp</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>the id of the vswitch to which the cluster node belongs. The ENS region of the vswitch_ids service must be the same as that of the ens_region_id.</para>
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
