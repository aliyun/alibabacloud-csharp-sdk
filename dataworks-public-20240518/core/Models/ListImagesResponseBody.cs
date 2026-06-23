// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListImagesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListImagesResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The list of image details.</para>
            /// </summary>
            [NameInMap("ImageList")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyPagingInfoImageList> ImageList { get; set; }
            public class ListImagesResponseBodyPagingInfoImageList : TeaModel {
                /// <summary>
                /// <para>The accessibility:</para>
                /// <list type="bullet">
                /// <item><description><para>Public: Visible to all members.</para>
                /// </description></item>
                /// <item><description><para>Private: Visible only to the creator.</para>
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
                /// <para>The VPC ID associated with the ACR instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxx</para>
                /// </summary>
                [NameInMap("AcrAssociatedVpcId")]
                [Validation(Required=false)]
                public string AcrAssociatedVpcId { get; set; }

                /// <summary>
                /// <para>ACR Endpoint</para>
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
                public ListImagesResponseBodyPagingInfoImageListBuildConfig BuildConfig { get; set; }
                public class ListImagesResponseBodyPagingInfoImageListBuildConfig : TeaModel {
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
                    /// <para>The list of pre-installation scripts.</para>
                    /// </summary>
                    [NameInMap("PackageInstallationScripts")]
                    [Validation(Required=false)]
                    public List<ListImagesResponseBodyPagingInfoImageListBuildConfigPackageInstallationScripts> PackageInstallationScripts { get; set; }
                    public class ListImagesResponseBodyPagingInfoImageListBuildConfigPackageInstallationScripts : TeaModel {
                        /// <summary>
                        /// <para>The script content. If the content specifies package names, separate them with commas (,).</para>
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
                /// <para>The creation time, represented as a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
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
                /// <para>Indicates whether synchronization with MaxCompute is enabled.</para>
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
                /// <para>The image VPC URI.</para>
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
                /// <para>The last modification time, represented as a 64-bit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the modifier.</para>
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
                /// <para>The image ID assigned by the provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acr_image_id</para>
                /// </summary>
                [NameInMap("ProviderImageId")]
                [Validation(Required=false)]
                public string ProviderImageId { get; set; }

                /// <summary>
                /// <para>The image provider type:</para>
                /// <list type="bullet">
                /// <item><description><para>ACR: ACR image repository.</para>
                /// </description></item>
                /// <item><description><para>DataWorks: DataWorks official image.</para>
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
                /// <para>The publish stage:</para>
                /// <list type="bullet">
                /// <item><description><para>Untest: Not tested.</para>
                /// </description></item>
                /// <item><description><para>Testing: Being tested.</para>
                /// </description></item>
                /// <item><description><para>TestFailed: Test failed.</para>
                /// </description></item>
                /// <item><description><para>Unpublished: Not published.</para>
                /// </description></item>
                /// <item><description><para>Publishing: Being published.</para>
                /// </description></item>
                /// <item><description><para>Published: Published.</para>
                /// </description></item>
                /// <item><description><para>PublishFailed: Publish failed.</para>
                /// </description></item>
                /// <item><description><para>Building: Being built.</para>
                /// </description></item>
                /// <item><description><para>BuildSuccess: Build succeeded.</para>
                /// </description></item>
                /// <item><description><para>BuildFailed: Build failed.</para>
                /// </description></item>
                /// <item><description><para>Accelerating: Being accelerated.</para>
                /// </description></item>
                /// <item><description><para>AccelerateSuccess: Acceleration succeeded.</para>
                /// </description></item>
                /// <item><description><para>AccelerateFailed: Acceleration failed.</para>
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
                /// <para>The image status:</para>
                /// <list type="bullet">
                /// <item><description><para>Disabled: The image is disabled.</para>
                /// </description></item>
                /// <item><description><para>Expired: The image has expired.</para>
                /// </description></item>
                /// <item><description><para>Available: The image is available.</para>
                /// </description></item>
                /// <item><description><para>ReadOnly: The image is read-only.</para>
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
                public ListImagesResponseBodyPagingInfoImageListSupported Supported { get; set; }
                public class ListImagesResponseBodyPagingInfoImageListSupported : TeaModel {
                    /// <summary>
                    /// <para>The supported module:</para>
                    /// <list type="bullet">
                    /// <item><description>Scheduler: Scheduling.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scheduler</para>
                    /// </summary>
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    /// <summary>
                    /// <para>The list of supported task types.</para>
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
            /// <para>The page size.</para>
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
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
