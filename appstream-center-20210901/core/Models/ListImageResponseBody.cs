// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListImageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImageResponseBodyData> Data { get; set; }
        public class ListImageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<ListImageResponseBodyDataAppList> AppList { get; set; }
            public class ListImageResponseBodyDataAppList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ca-xxx</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("BaseImageId")]
            [Validation(Required=false)]
            public string BaseImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("BaseImageVersion")]
            [Validation(Required=false)]
            public string BaseImageVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CompatibleMode")]
            [Validation(Required=false)]
            public bool? CompatibleMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Distro")]
            [Validation(Required=false)]
            public string Distro { get; set; }

            [NameInMap("DriverList")]
            [Validation(Required=false)]
            public List<string> DriverList { get; set; }

            [NameInMap("FeatureList")]
            [Validation(Required=false)]
            public List<string> FeatureList { get; set; }

            [NameInMap("FotaChannel")]
            [Validation(Required=false)]
            public string FotaChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.3.0-xxx</para>
            /// </summary>
            [NameInMap("FotaVersion")]
            [Validation(Required=false)]
            public string FotaVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-25 15:13:57</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BUILDER_MANUAL</para>
            /// </summary>
            [NameInMap("ImageCreateMode")]
            [Validation(Required=false)]
            public string ImageCreateMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imgc-xxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DemoImage</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageRegionDistributeList")]
            [Validation(Required=false)]
            public List<ListImageResponseBodyDataImageRegionDistributeList> ImageRegionDistributeList { get; set; }
            public class ListImageResponseBodyDataImageRegionDistributeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>imgc-xxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70%</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iv-xxx</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }

            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh-CN</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            [NameInMap("OnlineVersion")]
            [Validation(Required=false)]
            public bool? OnlineVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iv-xxxx</para>
            /// </summary>
            [NameInMap("OnlineVersionId")]
            [Validation(Required=false)]
            public string OnlineVersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("PackageType")]
            [Validation(Required=false)]
            public string PackageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imgc-xxx</para>
            /// </summary>
            [NameInMap("ParentImageId")]
            [Validation(Required=false)]
            public string ParentImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("ParentImageVersion")]
            [Validation(Required=false)]
            public string ParentImageVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows Server 2022</para>
            /// </summary>
            [NameInMap("PlatformName")]
            [Validation(Required=false)]
            public string PlatformName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CloudApp</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;eds.cpu.category&quot;]</para>
            /// </summary>
            [NameInMap("ResourceInstanceCategory")]
            [Validation(Required=false)]
            public string ResourceInstanceCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SINGLE_SESSION</para>
            /// </summary>
            [NameInMap("SessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SupportedLanguageList")]
            [Validation(Required=false)]
            public List<string> SupportedLanguageList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>iv-xxx</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v0.1.0</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("VolumeEncryptionEnabled")]
            [Validation(Required=false)]
            public bool? VolumeEncryptionEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a7b3c0c8-xxxx</para>
            /// </summary>
            [NameInMap("VolumeEncryptionKey")]
            [Validation(Required=false)]
            public string VolumeEncryptionKey { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8737D130-BFD0-5D51-96F6-C08EB1139A25</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
