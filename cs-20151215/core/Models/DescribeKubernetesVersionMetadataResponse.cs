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
            /// Features of the queried Kubernetes version.
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public Dictionary<string, object> Capabilities { get; set; }

            /// <summary>
            /// The OS images that are returned.
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyImages> Images { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyImages : TeaModel {
                /// <summary>
                /// The image ID.
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The image name.
                /// </summary>
                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// The OS platform. Valid values:
                /// 
                /// *   `AliyunLinux`
                /// *   `CentOS`
                /// *   `Windows`
                /// *   `WindowsCore`
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The version of the image.
                /// </summary>
                [NameInMap("os_version")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// The type of OS distribution that you want to use. To specify the node OS, we recommend that you use this parameter. Valid values:
                /// 
                /// *   `CentOS`
                /// *   `AliyunLinux`
                /// *   `AliyunLinux Qboot`
                /// *   `AliyunLinuxUEFI`
                /// *   `AliyunLinux3`
                /// *   `Windows`
                /// *   `WindowsCore`
                /// *   `AliyunLinux3Arm64`
                /// *   `ContainerOS`
                /// </summary>
                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// The type of OS. Examples:
                /// 
                /// *   `Windows`
                /// *   `Linux`
                /// </summary>
                [NameInMap("os_type")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// The type of image. Valid values:
                /// 
                /// *   `system`: public image
                /// *   `self`: custom image
                /// *   `others`: shared image from other Alibaba Cloud accounts
                /// *   `marketplace`: image from the marketplace
                /// </summary>
                [NameInMap("image_category")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// The architecture of the image.
                /// </summary>
                [NameInMap("architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

            }

            /// <summary>
            /// The metadata of the Kubernetes version.
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

            /// <summary>
            /// Details of the supported container runtimes.
            /// </summary>
            [NameInMap("runtimes")]
            [Validation(Required=false)]
            public List<Runtime> Runtimes { get; set; }

            /// <summary>
            /// The Kubernetes version supported by ACK. For more information, see [Release notes for Kubernetes versions](https://help.aliyun.com/document_detail/185269.html).
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// The release date of the Kubernetes version.
            /// </summary>
            [NameInMap("release_date")]
            [Validation(Required=false)]
            public string ReleaseDate { get; set; }

            /// <summary>
            /// The expiration date of the Kubernetes version.
            /// </summary>
            [NameInMap("expiration_date")]
            [Validation(Required=false)]
            public string ExpirationDate { get; set; }

            /// <summary>
            /// Indicates whether you can create clusters that run the Kubernetes version.
            /// </summary>
            [NameInMap("creatable")]
            [Validation(Required=false)]
            public bool? Creatable { get; set; }

            /// <summary>
            /// The list of available versions for updates.
            /// </summary>
            [NameInMap("upgradable_versions")]
            [Validation(Required=false)]
            public List<string> UpgradableVersions { get; set; }

        }

    }

}
