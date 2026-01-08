// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImageResponseBodyData> Data { get; set; }
        public class ListImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The application configuration.</para>
            /// </summary>
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<ListImageResponseBodyDataAppList> AppList { get; set; }
            public class ListImageResponseBodyDataAppList : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-xxx</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>应用名称</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// <para>The base image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("BaseImageId")]
            [Validation(Required=false)]
            public string BaseImageId { get; set; }

            /// <summary>
            /// <para>The version of the base image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("BaseImageVersion")]
            [Validation(Required=false)]
            public string BaseImageVersion { get; set; }

            /// <summary>
            /// <para>The service type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the compatibility mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompatibleMode")]
            [Validation(Required=false)]
            public bool? CompatibleMode { get; set; }

            /// <summary>
            /// <para>The size of the data disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ubuntu 22.04 64位</para>
            /// </summary>
            [NameInMap("Distro")]
            [Validation(Required=false)]
            public string Distro { get; set; }

            /// <summary>
            /// <para>The information about each driver.</para>
            /// </summary>
            [NameInMap("DriverList")]
            [Validation(Required=false)]
            public List<string> DriverList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-164c321f405ca84143e4b730dbe4</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The image feature tags.</para>
            /// </summary>
            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<string> FeatureList { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not available for public use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>镜像支持的fota渠道，暂未启用</para>
            /// </summary>
            [NameInMap("FotaChannel")]
            [Validation(Required=false)]
            public string FotaChannel { get; set; }

            /// <summary>
            /// <para>The FOTA version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.3.0-xxx</para>
            /// </summary>
            [NameInMap("FotaVersion")]
            [Validation(Required=false)]
            public string FotaVersion { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The image creation type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BY_SNAPSHOT_ID: The image is created from the snapshot or contains only a system disk.</description></item>
            /// <item><description>BUILDER_MANUAL: The image is manually generated.</description></item>
            /// <item><description>INSTANCE_AUTO: The image is automatically generated based on an instance.</description></item>
            /// <item><description>BY_INSTANCE_ID: The image is created from an instance or contains both a system disk and data disks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BUILDER_MANUAL</para>
            /// </summary>
            [NameInMap("ImageCreateMode")]
            [Validation(Required=false)]
            public string ImageCreateMode { get; set; }

            [NameInMap("ImageIconUrl")]
            [Validation(Required=false)]
            public string ImageIconUrl { get; set; }

            /// <summary>
            /// <para>System image IDs follow a descriptive, human-readable format, while custom image IDs are automatically generated by the system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoImage</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>Layered supported regions information.</para>
            /// </summary>
            [NameInMap("ImageRegionDistributeList")]
            [Validation(Required=false)]
            public List<ListImageResponseBodyDataImageRegionDistributeList> ImageRegionDistributeList { get; set; }
            public class ListImageResponseBodyDataImageRegionDistributeList : TeaModel {
                /// <summary>
                /// <para>System image IDs follow a descriptive, human-readable format, while custom image IDs are automatically generated by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imgc-xxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70%</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The supported region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The version of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iv-xxx</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// </summary>
            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <para>The type of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The image language. When the packaging type is VHD or Container, the image inherits its properties from the ECS-type image within the same image bundle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The latest sub-version of the image. (An image consists of multiple sub-versions.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// <para>Indicates whether the current version is the active version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OnlineVersion")]
            [Validation(Required=false)]
            public bool? OnlineVersion { get; set; }

            /// <summary>
            /// <para>This image tag currently points to the specified sub-version of the parent image. (An image consists of multiple sub-versions.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxxx</para>
            /// </summary>
            [NameInMap("OnlineVersionId")]
            [Validation(Required=false)]
            public string OnlineVersionId { get; set; }

            /// <summary>
            /// <para>The type of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The image encapsulation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <para>The ID of the parent image from which this image is derived. Note: This field is only applicable to custom images, as system images do not have a parent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("ParentImageId")]
            [Validation(Required=false)]
            public string ParentImageId { get; set; }

            /// <summary>
            /// <para>The version of the parent image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("ParentImageVersion")]
            [Validation(Required=false)]
            public string ParentImageVersion { get; set; }

            /// <summary>
            /// <para>The operating system platform of the image.</para>
            /// <remarks>
            /// <para> When the packaging type is VHD or Container, the image inherits its properties from the ECS-type image within the same image bundle.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            /// <summary>
            /// <para>The name of the operating system platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("PlatformName")]
            [Validation(Required=false)]
            public string PlatformName { get; set; }

            /// <summary>
            /// <para>The product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>95</para>
            /// </summary>
            [NameInMap("Rating")]
            [Validation(Required=false)]
            public int? Rating { get; set; }

            /// <summary>
            /// <para>The types of resources that are supported by the images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;eds.cpu.category&quot;]</para>
            /// </summary>
            [NameInMap("ResourceInstanceCategory")]
            [Validation(Required=false)]
            public string ResourceInstanceCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AIGC</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The type of the session.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SINGLE_SESSION</description></item>
            /// <item><description>MULTIPLE_SESSION</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The state of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The supported languages.</para>
            /// </summary>
            [NameInMap("SupportedLanguageList")]
            [Validation(Required=false)]
            public List<string> SupportedLanguageList { get; set; }

            /// <summary>
            /// <para>The size of the system disk. Unit: GiB.</para>
            /// <remarks>
            /// <para> The system disk must be at least as large as the image.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<ListImageResponseBodyDataTagList> TagList { get; set; }
            public class ListImageResponseBodyDataTagList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1630348213973321</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>inner</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The version of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable disk encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the Key Management Service (KMS) key that is used to encrypt the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7b3c0c8-xxxx</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8737D130-BFD0-5D51-96F6-C08EB1139A25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
