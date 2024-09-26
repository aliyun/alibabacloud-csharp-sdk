// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class UpdateImageCacheRequest : TeaModel {
        /// <summary>
        /// <para>The information about the Container Registry Enterprise Edition instance.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<UpdateImageCacheRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class UpdateImageCacheRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify multiple domain names. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****-registry.cn-hangzhou.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable reuse of image cache layers. If you enable this feature and the image cache that you want to create and an existing image cache contain duplicate image layers, the system reuses the duplicate image layers to create the new image cache. This accelerates the creation of the image cache. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoMatchImageCache")]
        [Validation(Required=false)]
        public bool? AutoMatchImageCache { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure the idempotence of a request?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-xxx-xxx-xxxx-42665544xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the elastic IP address (EIP). If you want to pull public images, you must make sure that the elastic container instance can access the Internet. To enable Internet access, you can configure an EIP or a NAT gateway for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zedsm5mfl3uhdj2d****</para>
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// <para>The elimination policy for the image cache. This parameter is empty by default, which indicates that the image cache is always retained.</para>
        /// <para>You can set this parameter to LRU, which indicates that the image cache can be automatically deleted. When the number of image caches reaches the quota, the system automatically deletes the image caches whose EliminationStrategy parameter is set to LRU and that are least recently used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LRU</para>
        /// </summary>
        [NameInMap("EliminationStrategy")]
        [Validation(Required=false)]
        public string EliminationStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the instant image cache feature. The feature can accelerate the creation of image caches. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Flash")]
        [Validation(Required=false)]
        public bool? Flash { get; set; }

        /// <summary>
        /// <para>The number of duplicates of temporary local snapshots. By default, the system creates one snapshot for each image cache. If you use the image cache to create multiple elastic container instances at a time, we recommend that you configure this parameter to create multiple snapshot duplicates for the image cache. We recommend that you create one snapshot duplicate for creation of every 1,000 elastic container instances.</para>
        /// <remarks>
        /// <para>If you enable the instant image cache feature by setting Flash to true, a local snapshot is first created during the creation of the image cache. After the local snapshot is created, regular snapshots start to be created. After the regular snapshots are created, the local snapshot is automatically deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FlashCopyCount")]
        [Validation(Required=false)]
        public int? FlashCopyCount { get; set; }

        /// <summary>
        /// <para>Container images that are used to create the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:1.15.10-perl</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public List<string> Image { get; set; }

        /// <summary>
        /// <para>The ID of the image cache.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imc-bp195erqe9o2pb09****</para>
        /// </summary>
        [NameInMap("ImageCacheId")]
        [Validation(Required=false)]
        public string ImageCacheId { get; set; }

        /// <summary>
        /// <para>The name of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testcache</para>
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// <para>The size of the image cache. Unit: GiB. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ImageCacheSize")]
        [Validation(Required=false)]
        public int? ImageCacheSize { get; set; }

        /// <summary>
        /// <para>The information about the image repository.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<UpdateImageCacheRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class UpdateImageCacheRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The password that is used to access the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The image repository address without <c>http://</c> or <c>https://</c> as a prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The username that is used to access the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the image cache.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the image cache belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzh43v*****</para>
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
        /// <para>The retention period of the image cache. Unit: days. When the retention period elapses, the image cache expires and is deleted. By default, image caches never expire.</para>
        /// <remarks>
        /// <para>The image caches that fail to be created are retained for only 1 day.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The ID of the security group to which the image cache belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The number of duplicates of regular snapshots. By default, the system creates one snapshot for each image cache. If you use the image cache to create multiple elastic container instances at a time, we recommend that you configure this parameter to create multiple snapshot duplicates for the image cache. We recommend that you create one snapshot duplicate for creation of every 1,000 elastic container instances.</para>
        /// <remarks>
        /// <para>If you disable the instant image cache feature by setting Flash to false, only regular snapshots are generated when you create an image cache.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("StandardCopyCount")]
        [Validation(Required=false)]
        public int? StandardCopyCount { get; set; }

        /// <summary>
        /// <para>The tags to add to the image cache. A maximum of 20 tags can be added to the image cache.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateImageCacheRequestTag> Tag { get; set; }
        public class UpdateImageCacheRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the image cache is connected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6h3rbwbm90urjwa****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
