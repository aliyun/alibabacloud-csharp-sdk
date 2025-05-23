// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeKubernetesVersionMetadataResponseBody> Body { get; set; }
        public class DescribeKubernetesVersionMetadataResponseBody : TeaModel {
            /// <summary>
            /// <para>Features of the queried Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;AnyAZ&quot;: true,
            ///       &quot;ChargeType&quot;: &quot;PostPaid&quot;
            /// }</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public Dictionary<string, object> Capabilities { get; set; }

            /// <summary>
            /// <para>The OS images that are returned.</para>
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyImages> Images { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyImages : TeaModel {
                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_7_x64_20G_alibase_20200426.vhd</para>
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS 7.7</para>
                /// </summary>
                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The OS platform. You can obtain the terminal ID by calling one of the following operations:</para>
                /// <list type="bullet">
                /// <item><description><c>AliyunLinux</c></description></item>
                /// <item><description><c>CentOS</c></description></item>
                /// <item><description><c>Windows</c></description></item>
                /// <item><description><c>WindowsCore</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.7</para>
                /// </summary>
                [NameInMap("os_version")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// <para>The type of operating system distribution that you want to use. We recommend that you use this parameter to specify the node operating system. You can obtain the terminal ID by calling one of the following operations:</para>
                /// <list type="bullet">
                /// <item><description><c>CentOS</c></description></item>
                /// <item><description><c>AliyunLinux</c></description></item>
                /// <item><description><c>AliyunLinux Qboot</c></description></item>
                /// <item><description><c>AliyunLinuxUEFI</c></description></item>
                /// <item><description><c>AliyunLinux3</c></description></item>
                /// <item><description><c>Windows</c></description></item>
                /// <item><description><c>WindowsCore</c></description></item>
                /// <item><description><c>AliyunLinux3Arm64</c></description></item>
                /// <item><description><c>ContainerOS</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>centos_7_7_20</para>
                /// </summary>
                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The type of OS. Examples:</para>
                /// <list type="bullet">
                /// <item><description><c>Windows</c></description></item>
                /// <item><description><c>Linux</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("os_type")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// <para>The type of image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>system</c>: public image</description></item>
                /// <item><description><c>self</c>: custom image</description></item>
                /// <item><description><c>others</c>: shared image from other Alibaba Cloud accounts</description></item>
                /// <item><description><c>marketplace</c>: image from the marketplace</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("image_category")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// <para>The architecture of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

            }

            /// <summary>
            /// <para>The metadata of the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;KubernetesVersion&quot;: &quot;1.31.1-aliyun.1&quot;,
            ///       &quot;SubClass&quot;: &quot;default&quot;,
            ///       &quot;ServiceCIDR&quot;: &quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

            /// <summary>
            /// <para>The container runtime configurations.</para>
            /// </summary>
            [NameInMap("runtimes")]
            [Validation(Required=false)]
            public List<Runtime> Runtimes { get; set; }

            /// <summary>
            /// <para>The Kubernetes version supported by ACK. For more information, see <a href="https://help.aliyun.com/document_detail/185269.html">Release notes for Kubernetes versions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.16.9-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The release date of the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("release_date")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            /// <summary>
            /// <para>The expiration date of the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("expiration_date")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// <para>Indicates whether you can create clusters that run the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("creatable")]
            [Validation(Required=false)]
            public bool? Creatable { get; set; }

            /// <summary>
            /// <para>The list of available Kubernetes versions for updates.</para>
            /// </summary>
            [NameInMap("upgradable_versions")]
            [Validation(Required=false)]
            public List<string> UpgradableVersions { get; set; }

        }

    }

}
