// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which the image is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateEcs (default): instance creation.</description></item>
        /// <item><description>ChangeOS: replacement of the system disk or operating system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateEcs</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The architecture of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>i386.</description></item>
        /// <item><description>x86_64.</description></item>
        /// <item><description>arm64.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i386</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run.</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without querying resource status. The check items include whether the AccessKey pair is valid, whether the Resource Access Management (RAM) user has the required authorization, and whether required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.  </description></item>
        /// <item><description>false: Sends a normal request. After the check succeeds, a 2XX HTTP status code is returned and the resource status is queried.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The list of filter conditions for querying resources.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestFilter> Filter { get; set; }
        public class DescribeImagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key for querying resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When this parameter is set to <c>CreationStartTime</c>, you can query resources created after the time specified by <c>Filter.N.Value</c>.</description></item>
            /// <item><description>When this parameter is set to <c>CreationEndTime</c>, you can query resources created before the time specified by <c>Filter.N.Value</c>.</description></item>
            /// <item><description>When this parameter is set to <c>NetworkType</c>, you can query resources of the specified network type.</description></item>
            /// <item><description>When this parameter is set to <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, you can query the CPU or memory hot-plugging support of the specified image.</description></item>
            /// </list>
            /// <para>Default value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value for querying resources.</para>
            /// <list type="bullet">
            /// <item><description><para>When <c>Filter.N.Key</c> is <c>CreationStartTime</c> or <c>CreationEndTime</c>, the format is <c>yyyy-MM-ddTHH:mmZ</c> in UTC+0.</para>
            /// </description></item>
            /// <item><description><para>When <c>Filter.N.Key</c> is <c>NetworkType</c>, valid values for the network type include <c>vpc</c> and <c>classic</c>.</para>
            /// </description></item>
            /// <item><description><para>When <c>Filter.N.Key</c> is <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, valid values are <c>supported</c> and <c>unsupported</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>Default value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to filter images that belong to the specified image family.</para>
        /// <para>Default value: empty.</para>
        /// <remarks>
        /// <para>For information about image families associated with Alibaba Cloud official images, see <a href="https://help.aliyun.com/document_detail/108393.html">Overview of public images</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// <details>
        /// <summary>Naming rules for image IDs</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>Public images: Named by operating system version, architecture, language, and release date. For example, the image ID of Windows Server 2008 R2 Enterprise Edition, 64-bit English system is win2008r2_64_ent_sp1_en-us_40G_alibase_20190318.vhd.</para>
        /// </description></item>
        /// <item><description><para>Custom images, shared images, Alibaba Cloud Marketplace images, and community images: Start with m.</para>
        /// </description></item>
        /// </list>
        /// </details>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp1g7004ksh0oeuc****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testImageName</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The source of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: Public images provided by Alibaba Cloud that are not published through Alibaba Cloud Marketplace. This is different from the concept of &quot;Public Image&quot; in the console.</description></item>
        /// <item><description>self: Custom images that you created.</description></item>
        /// <item><description>others: Includes shared images (images directly shared by other Alibaba Cloud users) and community images (custom images that are fully shared publicly by any Alibaba Cloud user). Note:<list type="bullet">
        /// <item><description>To query community images, IsPublic must be set to true.</description></item>
        /// <item><description>To query shared images, IsPublic must be set to false or left empty.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>marketplace: Images published by Alibaba Cloud or third-party independent software vendors (ISVs) in Alibaba Cloud Marketplace. These images must be purchased together with ECS. Note the billing details of Alibaba Cloud Marketplace images.</description></item>
        /// </list>
        /// <para>Default value: empty.</para>
        /// <remarks>
        /// <para>An empty value indicates that images with system, self, and others values are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the image owner. This parameter takes effect only when you query shared images or community images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20169351435666****</para>
        /// </summary>
        [NameInMap("ImageOwnerId")]
        [Validation(Required=false)]
        public long? ImageOwnerId { get; set; }

        /// <summary>
        /// <para>The instance type for which available images are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query published community images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries published community images. When you set this parameter to true, ImageOwnerAlias must be set to others.</description></item>
        /// <item><description>false: Queries image types other than community images. The specific types depend on the ImageOwnerAlias parameter value.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// <para>Specifies whether the image supports cloud-init.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSupportCloudinit")]
        [Validation(Required=false)]
        public bool? IsSupportCloudinit { get; set; }

        /// <summary>
        /// <para>Specifies whether the image can run on I/O optimized instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSupportIoOptimized")]
        [Validation(Required=false)]
        public bool? IsSupportIoOptimized { get; set; }

        /// <summary>
        /// <para>The operating system type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows.</description></item>
        /// <item><description>linux.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the resources.</para>
        /// <para>Start value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the custom image belongs. When you use this parameter to filter resources, the resource count cannot exceed 1000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
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
        /// <para>Specifies whether the subscription image has expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowExpired")]
        [Validation(Required=false)]
        public bool? ShowExpired { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot used to create the custom image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp17ot2q7x72ggtw****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The status of the image. If you do not specify this parameter, only images in the Available state are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The image is being created.</description></item>
        /// <item><description>Waiting: The image is waiting in a multi-task queue.</description></item>
        /// <item><description>Available (default): The image is available for use.</description></item>
        /// <item><description>UnAvailable: The image is unavailable.</description></item>
        /// <item><description>CreateFailed: The image failed to be created.</description></item>
        /// <item><description>Deprecated: The image is deprecated.</description></item>
        /// </list>
        /// <para>Default value: Available. This parameter supports multiple values separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestTag> Tag { get; set; }
        public class DescribeImagesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the image. Valid values of N: 1 to 20.</para>
            /// <para>When you use a single tag to filter resources, the resource count with this tag cannot exceed 1000. When you use multiple tags to filter resources, the resource count of resources that have all specified tags attached cannot exceed 1000. If the resource count exceeds 1000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the image. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Usable")]
        [Validation(Required=false)]
        public bool? Usable { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is running on ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: The image is in use and associated with ECS instances.</description></item>
        /// <item><description>none: The image is idle and not associated with any ECS instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
