// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1574790082031102</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-11111111</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The cluster kubeconfig.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1
        /// clusters:</para>
        /// <list type="bullet">
        /// <item><description>cluster:
        ///   certificate-authority-data: x
        ///   server: <a href="https://111.111.111.111:6443">https://111.111.111.111:6443</a>
        /// name: kubernetes
        /// contexts:</description></item>
        /// <item><description>context:
        ///   cluster: kubernetes
        ///   user: user
        /// name: eck-xxxxx
        /// current-context: eck-xxxx
        /// kind: Config
        /// preferences: {}
        /// users:</description></item>
        /// <item><description>name: user
        /// user:
        ///   client-certificate-data: x
        ///   client-key-data: x</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public object Config { get; set; }

        /// <summary>
        /// <para>The CIDR block for pods.</para>
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
        public DescribeClusterDetailResponseBodyControlPlaneConfig ControlPlaneConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneConfig : TeaModel {
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
            /// <para>The image ID of the control plane virtual machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-5ul335umat4e2y9ynwi84p3f9</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The node instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ens.esk.sn1.medium</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The system cloud disk type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <para>The system cloud disk size of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

        [NameInMap("ControlPlaneMeta")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyControlPlaneMeta ControlPlaneMeta { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneMeta : TeaModel {
            [NameInMap("MasterInstances")]
            [Validation(Required=false)]
            public List<DescribeClusterDetailResponseBodyControlPlaneMetaMasterInstances> MasterInstances { get; set; }
            public class DescribeClusterDetailResponseBodyControlPlaneMetaMasterInstances : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>i-573utia8wbecrbgsm6o8fx132</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.10.0.2</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i-573utia8wbecrbgsm6o8fx132</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("MasterUrl")]
            [Validation(Required=false)]
            public DescribeClusterDetailResponseBodyControlPlaneMetaMasterUrl MasterUrl { get; set; }
            public class DescribeClusterDetailResponseBodyControlPlaneMetaMasterUrl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://10.0.0.1:6443">https://10.0.0.1:6443</a></para>
                /// </summary>
                [NameInMap("PrivateUrl")]
                [Validation(Required=false)]
                public string PrivateUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://0.0.0.0:6443">https://0.0.0.0:6443</a></para>
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-04-07T09:57:26+08:00</para>
        /// </summary>
        [NameInMap("Created")]
        [Validation(Required=false)]
        public string Created { get; set; }

        /// <summary>
        /// <para>The ENS edge zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-fuzhou-23</para>
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
        /// <para>xxxx.yyy</para>
        /// </summary>
        [NameInMap("JoinToken")]
        [Validation(Required=false)]
        public string JoinToken { get; set; }

        /// <summary>
        /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. We recommend that you select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1.aliyunedge.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The CLB instance ID of the API server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5snthcyu1x10g7tywj7iu****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your-cluster-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>nat-5tawjw5j7sgd2deujxuk0****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyNodeCount NodeCount { get; set; }
        public class DescribeClusterDetailResponseBodyNodeCount : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Ready")]
            [Validation(Required=false)]
            public int? Ready { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("PodStatus")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyPodStatus PodStatus { get; set; }
        public class DescribeClusterDetailResponseBodyPodStatus : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Running")]
            [Validation(Required=false)]
            public int? Running { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch IDs for pods.</para>
        /// </summary>
        [NameInMap("PodVswitchIds")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>Indicates whether public network access is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicAccess")]
        [Validation(Required=false)]
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// <para>Id of the request。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The CIDR block for services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.19.0.0/20</para>
        /// </summary>
        [NameInMap("ServiceCidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <para>The cluster status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>initial</b>: Being created.</description></item>
        /// <item><description><b>failed</b>: Creation failed.</description></item>
        /// <item><description><b>running</b>: Running.</description></item>
        /// <item><description><b>deleting</b>: Being released.</description></item>
        /// </list>
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
        /// <para>n-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs of the cluster nodes.</para>
        /// </summary>
        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
