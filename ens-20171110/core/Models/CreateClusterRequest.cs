// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.20.0.0/16</para>
        /// </summary>
        [NameInMap("ContainerCidr")]
        [Validation(Required=false)]
        public string ContainerCidr { get; set; }

        [NameInMap("ControlPlaneConfig")]
        [Validation(Required=false)]
        public CreateClusterRequestControlPlaneConfig ControlPlaneConfig { get; set; }
        public class CreateClusterRequestControlPlaneConfig : TeaModel {
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

            [NameInMap("LoginPassword")]
            [Validation(Required=false)]
            public string LoginPassword { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30000-32767</para>
            /// </summary>
            [NameInMap("NodePortRange")]
            [Validation(Required=false)]
            public string NodePortRange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>containerd</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

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
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.32.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
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

        [NameInMap("PodVswitchIds")]
        [Validation(Required=false)]
        public List<string> PodVswitchIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PublicAccess")]
        [Validation(Required=false)]
        public bool? PublicAccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.19.0.0/20</para>
        /// </summary>
        [NameInMap("ServiceCidr")]
        [Validation(Required=false)]
        public string ServiceCidr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;vsw-xxx&quot;, &quot;vsw-yyy&quot;]</para>
        /// </summary>
        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public List<string> VswitchIds { get; set; }

    }

}
