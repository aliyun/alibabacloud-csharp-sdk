// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateImageCacheRequest : TeaModel {
        /// <summary>
        /// <para>Information about the Container Registry Enterprise Edition instance. For more information, see <a href="https://help.aliyun.com/document_detail/194250.html">Pull images from a Container Registry Enterprise Edition instance without using secrets</a>.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestAcrRegistryInfo> AcrRegistryInfo { get; set; }
        public class CreateImageCacheRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM roles in the Alibaba Cloud account to which the elastic container instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1609982529******:role/role-assume</para>
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM roles in the Alibaba Cloud account to which the Container Registry Enterprise Edition instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1298452580******:role/role-acr</para>
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// <para>The domain names of the Container Registry Enterprise Edition instance. By default, all domain names of the instance are displayed. You can specify multiple domain names. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****-registry.cn-beijing.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<string> Domain { get; set; }

            /// <summary>
            /// <para>The ID of Container Registry Enterprise Edition instance N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of Container Registry Enterprise Edition instance N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region ID of Container Registry Enterprise Edition instance N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reuse of image cache layers. If you enable this feature, and the image cache that you want to create and an existing image cache contain duplicate image layers, the system reuses the duplicate image layers to create the new image cache. This accelerates the creation of the image cache. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables reuse of image cache layers.</description></item>
        /// <item><description>false: disables reuse of image cache layers.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure the idempotence of a request</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-xxx-xxx-xxxx-42665544xxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the elastic IP address (EIP). If you want to pull images over the Internet, make sure that the elastic container instance can access the Internet. You can configure an EIP or a NAT gateway for the elastic container instance to access the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-2zedsm5mfl3uhdj2d****</para>
        /// </summary>
        [NameInMap("EipInstanceId")]
        [Validation(Required=false)]
        public string EipInstanceId { get; set; }

        /// <summary>
        /// <para>The elimination policy of the image cache. This parameter is empty by default, which indicates that the image cache is always retained.</para>
        /// <para>You can set this parameter to LRU, which indicates that the image cache can be automatically deleted. When the number of image caches reaches the quota, the system automatically deletes the image caches whose EliminationStrategy parameter is set to LRU and that are least commonly used.</para>
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
        /// <para>The number of temporary local snapshots. By default, the system creates one snapshot for each image cache. If an image cache is used to create multiple elastic container instances at a time, we recommend that you set this parameter to create multiple snapshots for the image cache. We recommend that you create one snapshot for creation of every 1,000 elastic container instances.</para>
        /// <remarks>
        /// <para> If you set the Flash parameter to true, instant image cache is enabled. During the creation of the image cache, the system first creates a temporary local snapshot for you to instantly use the snapshot. After the temporary local snapshot is created, the system begins to create a regular snapshot. After the regular snapshot is created, the temporary local snapshot is automatically deleted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FlashCopyCount")]
        [Validation(Required=false)]
        public int? FlashCopyCount { get; set; }

        /// <summary>
        /// <para>Container image N that is used to create the image cache.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eci_open/nginx:1.15.10-perl</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public List<string> Image { get; set; }

        /// <summary>
        /// <para>The name of the image cache.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The image repository.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredential")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestImageRegistryCredential> ImageRegistryCredential { get; set; }
        public class CreateImageCacheRequestImageRegistryCredential : TeaModel {
            /// <summary>
            /// <para>The password that is used to log on to image repository N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The address of the image repository without the <c>http://</c> or <c>https://</c> prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>The username that is used to log on to image repository N.</para>
            /// 
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The address of the self-managed image repository.</para>
        /// <para>When you create an image cache by using an image in a self-managed image repository that uses a self-signed certificate, you must specify this parameter to skip the certificate authentication. This can prevent the image from failing to pull due to certificate authentication failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;harbor***.pre.com,192.168.XX.XX:5000,reg***.test.com:80&quot;</para>
        /// </summary>
        [NameInMap("InsecureRegistry")]
        [Validation(Required=false)]
        public string InsecureRegistry { get; set; }

        /// <summary>
        /// <para>The operating system of the image. Default value: Linux. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Windows</description></item>
        /// </list>
        /// <remarks>
        /// <para>Windows instances are in invitational preview. To use the operating system, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The address of the self-managed image repository. When you create an image cache by using an image in a self-managed image repository that uses the HTTP protocol, you must specify this parameter. This way, Elastic Container Instance uses the HTTP protocol instead of the default HTTPS protocol to pull the image. This can prevent the image from failing to pull due to different protocols.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;harbor***.pre.com,192.168.XX.XX:5000,reg***.test.com:80&quot;</para>
        /// </summary>
        [NameInMap("PlainHttpRegistry")]
        [Validation(Required=false)]
        public string PlainHttpRegistry { get; set; }

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
        /// <para>The ID of the resource group.</para>
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
        /// <para>The retention period of the image cache. Unit: days. When the retention period ends, the image cache expires and is deleted. By default, image caches never expire.</para>
        /// <remarks>
        /// <para> The image caches that fail to be created are only retained for one day.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The ID of the security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The number of regular snapshots. By default, the system creates one snapshot for each image cache. If an image cache is used to create multiple elastic container instances at a time, we recommend that you set this parameter to create multiple snapshots for the image cache. We recommend that you create one snapshot for creation of every 1,000 elastic container instances.</para>
        /// <remarks>
        /// <para> If you set the Flash parameter to false, instant image cache is disabled. In this case, only regular snapshots are generated during the creation of the image cache.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("StandardCopyCount")]
        [Validation(Required=false)]
        public int? StandardCopyCount { get; set; }

        /// <summary>
        /// <para>The tag of the image cache.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestTag> Tag { get; set; }
        public class CreateImageCacheRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N of the image cache. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the image cache. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch. You can specify up to 10 vSwitch IDs. Separate multiple vSwitch IDs with commas (,). Example: <c>vsw-***,vsw-***</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6h3rbwbm90urjwa****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
