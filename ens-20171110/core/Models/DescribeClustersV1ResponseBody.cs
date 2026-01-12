// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClustersV1ResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<DescribeClustersV1ResponseBodyClusters> Clusters { get; set; }
        public class DescribeClustersV1ResponseBodyClusters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1375383353108460</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eck-xxxxxxx</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("ContainerCidr")]
            [Validation(Required=false)]
            public string ContainerCidr { get; set; }

            [NameInMap("ControlPlaneConfig")]
            [Validation(Required=false)]
            public DescribeClustersV1ResponseBodyClustersControlPlaneConfig ControlPlaneConfig { get; set; }
            public class DescribeClustersV1ResponseBodyClustersControlPlaneConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>containerd</para>
                /// </summary>
                [NameInMap("ContainerRuntime")]
                [Validation(Required=false)]
                public string ContainerRuntime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m-68be8cb9f71fhyvjekxa23qsf</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ens.sn1.medium</para>
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
                /// <para>5</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("SystemDiskCategory")]
                [Validation(Required=false)]
                public string SystemDiskCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public long? SystemDiskSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-55</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxxxxxx.yyyyyyy</para>
            /// </summary>
            [NameInMap("JoinToken")]
            [Validation(Required=false)]
            public string JoinToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.31.9-aliyunedge.1</para>
            /// </summary>
            [NameInMap("KubernetesVersion")]
            [Validation(Required=false)]
            public string KubernetesVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lb-58dngw0fyimzzvwljfec7hy0z</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-eck-name</para>
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
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("ServiceCidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-5wsgr3xeolb2ist303wp3cscp</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
