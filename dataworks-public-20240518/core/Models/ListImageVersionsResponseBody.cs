// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImageVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination details.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListImageVersionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListImageVersionsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>A list of image version details.</para>
            /// </summary>
            [NameInMap("ImageVersions")]
            [Validation(Required=false)]
            public List<ListImageVersionsResponseBodyPagingInfoImageVersions> ImageVersions { get; set; }
            public class ListImageVersionsResponseBodyPagingInfoImageVersions : TeaModel {
                /// <summary>
                /// <para>The accessibility of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Public</c>: The image is visible to all users.</para>
                /// </description></item>
                /// <item><description><para><c>Private</c>: The image is visible only to the creator.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                /// <summary>
                /// <para>The ID of the VPC associated with the ACR instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxx</para>
                /// </summary>
                [NameInMap("AcrAssociatedVpcId")]
                [Validation(Required=false)]
                public string AcrAssociatedVpcId { get; set; }

                /// <summary>
                /// <para>The ACR endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("AcrEndpoint")]
                [Validation(Required=false)]
                public string AcrEndpoint { get; set; }

                /// <summary>
                /// <para>The ACR instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-xxx</para>
                /// </summary>
                [NameInMap("AcrInstanceId")]
                [Validation(Required=false)]
                public string AcrInstanceId { get; set; }

                /// <summary>
                /// <para>The image build configuration.</para>
                /// </summary>
                [NameInMap("BuildConfig")]
                [Validation(Required=false)]
                public ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfig BuildConfig { get; set; }
                public class ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfig : TeaModel {
                    /// <summary>
                    /// <para>The build type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PackageInstallation</para>
                    /// </summary>
                    [NameInMap("BuildType")]
                    [Validation(Required=false)]
                    public string BuildType { get; set; }

                    /// <summary>
                    /// <para>The pre-installation scripts.</para>
                    /// </summary>
                    [NameInMap("PackageInstallationScripts")]
                    [Validation(Required=false)]
                    public List<ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfigPackageInstallationScripts> PackageInstallationScripts { get; set; }
                    public class ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfigPackageInstallationScripts : TeaModel {
                        /// <summary>
                        /// <para>The script content. Separate multiple package names with a comma (,).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>requests</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The script type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Python3</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the image was created, as a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who created the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The image description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test image created by xxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether MaxCompute synchronization is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSyncMaxCompute")]
                [Validation(Required=false)]
                public bool? EnableSyncMaxCompute { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom_image_xxxx_xxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The image tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <para>The image URI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com/xxx/xxx:tag</para>
                /// </summary>
                [NameInMap("ImageUri")]
                [Validation(Required=false)]
                public string ImageUri { get; set; }

                /// <summary>
                /// <para>The VPC URI of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/xxx/xxx:tag</para>
                /// </summary>
                [NameInMap("ImageVpcUri")]
                [Validation(Required=false)]
                public string ImageVpcUri { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is the default image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The time when the image was last modified, as a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the user who last modified the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks_image</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is an official image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Official")]
                [Validation(Required=false)]
                public bool? Official { get; set; }

                /// <summary>
                /// <para>The ID of the image from the provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acr_image_id</para>
                /// </summary>
                [NameInMap("ProviderImageId")]
                [Validation(Required=false)]
                public string ProviderImageId { get; set; }

                /// <summary>
                /// <para>The type of the image provider. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>ACR</c>: The image is from an ACR repository.</para>
                /// </description></item>
                /// <item><description><para><c>DataWorks</c>: The image is an official image provided by DataWorks.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACR</para>
                /// </summary>
                [NameInMap("ProviderType")]
                [Validation(Required=false)]
                public string ProviderType { get; set; }

                /// <summary>
                /// <para>The publishing stage of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Untest</c>: Not tested.</para>
                /// </description></item>
                /// <item><description><para><c>Testing</c>: Being tested.</para>
                /// </description></item>
                /// <item><description><para><c>TestFailed</c>: Test failed.</para>
                /// </description></item>
                /// <item><description><para><c>Unpublished</c>: Not published.</para>
                /// </description></item>
                /// <item><description><para><c>Publishing</c>: Being published.</para>
                /// </description></item>
                /// <item><description><para><c>Published</c>: Published.</para>
                /// </description></item>
                /// <item><description><para><c>PublishFailed</c>: Publishing failed.</para>
                /// </description></item>
                /// <item><description><para><c>Building</c>: Being built.</para>
                /// </description></item>
                /// <item><description><para><c>BuildSuccess</c>: Build succeeded.</para>
                /// </description></item>
                /// <item><description><para><c>BuildFailed</c>: Build failed.</para>
                /// </description></item>
                /// <item><description><para><c>Accelerating</c>: Being accelerated.</para>
                /// </description></item>
                /// <item><description><para><c>AccelerateSuccess</c>: Acceleration succeeded.</para>
                /// </description></item>
                /// <item><description><para><c>AccelerateFailed</c>: Acceleration failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStage")]
                [Validation(Required=false)]
                public string PublishStage { get; set; }

                /// <summary>
                /// <para>The repository name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>repo_name</para>
                /// </summary>
                [NameInMap("RepositoryName")]
                [Validation(Required=false)]
                public string RepositoryName { get; set; }

                /// <summary>
                /// <para>The image size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1GB</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>The status of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Disabled</c>: The image is disabled.</para>
                /// </description></item>
                /// <item><description><para><c>Expired</c>: The image is expired.</para>
                /// </description></item>
                /// <item><description><para><c>Available</c>: The image is available.</para>
                /// </description></item>
                /// <item><description><para><c>ReadOnly</c>: The image is read-only.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The supported modules and task types.</para>
                /// </summary>
                [NameInMap("Supported")]
                [Validation(Required=false)]
                public ListImageVersionsResponseBodyPagingInfoImageVersionsSupported Supported { get; set; }
                public class ListImageVersionsResponseBodyPagingInfoImageVersionsSupported : TeaModel {
                    /// <summary>
                    /// <para>The supported module. Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description><c>Scheduler</c>: The scheduler module.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scheduler</para>
                    /// </summary>
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    /// <summary>
                    /// <para>The supported task types.</para>
                    /// </summary>
                    [NameInMap("TaskTypes")]
                    [Validation(Required=false)]
                    public List<string> TaskTypes { get; set; }

                }

                /// <summary>
                /// <para>The image version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
