// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateImageCacheRequest : TeaModel {
        /// <summary>
        /// Information about the Container Registry Enterprise Edition instance. For more information, see [Pull images from a Container Registry Enterprise Edition instance without using secrets](https://help.aliyun.com/document_detail/194250.html).
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateImageCacheRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the RAM roles in the Alibaba Cloud account to which the elastic container instance belongs.
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// The ARN of the RAM roles in the Alibaba Cloud account to which the Container Registry Enterprise Edition instance belongs.
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify multiple domain names. Separate multiple domain names with commas (,).
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

            /// <summary>
            /// The ID of Container Registry Enterprise Edition instance N.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of Container Registry Enterprise Edition instance N.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The region ID of Container Registry Enterprise Edition instance N.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// Comments.
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// Specifies whether to enable reuse of image cache layers. If you enable this feature, and the image cache that you want to create and an existing image cache contain duplicate image layers, the system reuses the duplicate image layers to create the new image cache. This accelerates the creation of the image cache. Valid values:
        /// 
        /// *   true: enables reuse of image cache layers.
        /// *   false: disables reuse of image cache layers.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure the idempotence of a request](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the elastic IP address (EIP). If you want to pull images over the Internet, make sure that the elastic container instance can access the Internet. You can configure an EIP or a NAT gateway for the elastic container instance to access the Internet.
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// The elimination policy of the image cache. This parameter is empty by default, which indicates that the image cache is always retained.
        /// 
        /// You can set this parameter to LRU, which indicates that the image cache can be automatically deleted. When the number of image caches reaches the quota, the system automatically deletes the image caches whose EliminationStrategy parameter is set to LRU and that are least commonly used.
        /// </summary>
        [NameInMap("EliminationStrategy")]
        [Validation(Required=false)]
        public string EliminationStrategy { get; set; }

        /// <summary>
        /// Specifies whether to enable the instant image cache feature. The feature can accelerate the creation of image caches. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Flash")]
        [Validation(Required=false)]
        public bool? Flash { get; set; }

        /// <summary>
        /// The number of temporary local snapshots. By default, the system creates one snapshot for each image cache. If an image cache is used to create multiple elastic container instances at a time, we recommend that you set this parameter to create multiple snapshots for the image cache. We recommend that you create one snapshot for creation of every 1,000 elastic container instances.
        /// 
        /// >  If you set the Flash parameter to true, instant image cache is enabled. During the creation of the image cache, the system first creates a temporary local snapshot for you to instantly use the snapshot. After the temporary local snapshot is created, the system begins to create a regular snapshot. After the regular snapshot is created, the temporary local snapshot is automatically deleted.
        /// </summary>
        [NameInMap("FlashCopyCount")]
        [Validation(Required=false)]
        public int? FlashCopyCount { get; set; }

        /// <summary>
        /// Container image N that is used to create the image cache.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public List<string> Image { get; set; }

        /// <summary>
        /// The name of the image cache.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// The size of the image cache. Unit: GiB. Default value: 20.
        /// </summary>
        [NameInMap("ImageCacheSize")]
        [Validation(Required=false)]
        public int? ImageCacheSize { get; set; }

        /// <summary>
        /// The image repository.
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class CreateImageCacheRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// The password that is used to log on to image repository N.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The address of the image repository without the `http://` or `https://` prefix.
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// The username that is used to log on to image repository N.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The address of the self-managed image repository.
        /// 
        /// When you create an image cache by using an image in a self-managed image repository that uses a self-signed certificate, you must specify this parameter to skip the certificate authentication. This can prevent the image from failing to pull due to certificate authentication failures.
        /// </summary>
        [NameInMap("InsecureRegistry")]
        [Validation(Required=false)]
        public string InsecureRegistry { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The address of the self-managed image repository. When you create an image cache by using an image in a self-managed image repository that uses the HTTP protocol, you must specify this parameter. This way, Elastic Container Instance uses the HTTP protocol instead of the default HTTPS protocol to pull the image. This can prevent the image from failing to pull due to different protocols.
        /// </summary>
        [NameInMap("PlainHttpRegistry")]
        [Validation(Required=false)]
        public string PlainHttpRegistry { get; set; }

        /// <summary>
        /// The region ID of the image cache.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The retention period of the image cache. Unit: days. When the retention period ends, the image cache expires and is deleted. By default, image caches never expire.
        /// 
        /// >  The image caches that fail to be created are only retained for one day.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The ID of the security group.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The number of regular snapshots. By default, the system creates one snapshot for each image cache. If an image cache is used to create multiple elastic container instances at a time, we recommend that you set this parameter to create multiple snapshots for the image cache. We recommend that you create one snapshot for creation of every 1,000 elastic container instances.
        /// 
        /// >  If you set the Flash parameter to false, instant image cache is disabled. In this case, only regular snapshots are generated during the creation of the image cache.
        /// </summary>
        [NameInMap("StandardCopyCount")]
        [Validation(Required=false)]
        public int? StandardCopyCount { get; set; }

        /// <summary>
        /// The tag of the image cache.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestTag> Tag { get; set; }
        public class CreateImageCacheRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the image cache. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the image cache. Valid values of N: 1 to 20.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch. You can specify up to 10 vSwitch IDs. Separate multiple vSwitch IDs with commas (,). Example: `vsw-***,vsw-***`.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID of the image cache.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
