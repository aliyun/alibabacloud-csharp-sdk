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
            /// <para>The feature capabilities of the Kubernetes version.</para>
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
            /// <para>The list of system images.</para>
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyImages> Images { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyImages : TeaModel {
                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun_3_x64_20G_alibase_20241218.vhd</para>
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Linux 3.2104</para>
                /// </summary>
                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The operating system platform. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>AliyunLinux</c></description></item>
                /// <item><description><c>CentOS</c></description></item>
                /// <item><description><c>Windows</c></description></item>
                /// <item><description><c>WindowsCore</c></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AliyunLinux</para>
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.2104</para>
                /// </summary>
                [NameInMap("os_version")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// <para>The type of the operating system distribution. We recommend that you use this field to specify the node operating system. Valid values:</para>
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
                /// <para>AliyunLinux3</para>
                /// </summary>
                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The operating system type. Examples:</para>
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
                /// <para>The image category. Partial valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>system</c>: public image.</description></item>
                /// <item><description><c>self</c>: custom image.</description></item>
                /// <item><description><c>others</c>: shared image from other users.</description></item>
                /// <item><description><c>marketplace</c>: Alibaba Cloud Marketplace image.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("image_category")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// <para>The image architecture.</para>
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
            /// <para>The Kubernetes version released by ACK. For more information about versions, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.31.1-aliyun.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The release date of the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("release_date")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            /// <summary>
            /// <para>The expiration date of the Kubernetes version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-30T00:00:00Z</para>
            /// </summary>
            [NameInMap("expiration_date")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// <para>Indicates whether the Kubernetes version can be used to create clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("creatable")]
            [Validation(Required=false)]
            public bool? Creatable { get; set; }

            /// <summary>
            /// <para>The list of upgradable versions.</para>
            /// </summary>
            [NameInMap("upgradable_versions")]
            [Validation(Required=false)]
            public List<string> UpgradableVersions { get; set; }

        }

    }

}
