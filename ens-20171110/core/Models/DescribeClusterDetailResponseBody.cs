// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1574790082031102</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eck-11111111</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("ContainerCidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        [NameInMap("ControlPlaneConfig")]
        [Validation(Required=false)]
        public DescribeClusterDetailResponseBodyControlPlaneConfig ControlPlaneConfig { get; set; }
        public class DescribeClusterDetailResponseBodyControlPlaneConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("ContainerRuntime")]
            [Validation(Required=false)]
            public string ContainerRuntime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>m-5ul335umat4e2y9ynwi84p3f9</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ens.esk.sn1.medium</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public string InstanceSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("NodePortRange")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-fuzhou-23</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx.yyy</para>
        /// </summary>
        [NameInMap("JoinToken")]
        [Validation(Required=false)]
        public string JoinToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.32.1.aliyunedge.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lb-5snthcyu1x10g7tywj7iu****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your-cluster-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PodVswitchIds")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>172.19.0.0/20</para>
        /// </summary>
        [NameInMap("ServiceCidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>n-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
