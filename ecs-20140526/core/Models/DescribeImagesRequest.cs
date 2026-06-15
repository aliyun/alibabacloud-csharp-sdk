// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which the image will be used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateEcs (default): Create an instance.</para>
        /// </description></item>
        /// <item><description><para>ChangeOS: Replace the system disk or change the operating system.</para>
        /// </description></item>
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
        /// <item><description><para>i386</para>
        /// </description></item>
        /// <item><description><para>x86_64</para>
        /// </description></item>
        /// <item><description><para>arm64</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i386</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Sends a dry run request without querying resource status. The system checks whether the AccessKey is valid, whether the Resource Access Management (RAM) user is authorized, and whether all required parameters are specified. If the check fails, an error is returned. If the check passes, the error code DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para>false: Sends a normal request. After the check passes, an HTTP 2XX status code is returned and the resource status is queried directly.</para>
        /// </description></item>
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
        /// <para>A list of filter conditions for querying resources.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeImagesRequestFilter> Filter { get; set; }
        public class DescribeImagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter key used when querying resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is set to <c>CreationStartTime</c>, you can query resources created after the specified time point (<c>Filter.N.Value</c>).</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to <c>CreationEndTime</c>, you can query resources created before the specified time point (<c>Filter.N.Value</c>).</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to <c>NetworkType</c>, you can query resources of the specified network type.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is set to any of <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, you can query the hot-swapping support status of CPU or memory for the specified image.</para>
            /// </description></item>
            /// </list>
            /// <para>Default Value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreationStartTime</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value used when querying resources.</para>
            /// <list type="bullet">
            /// <item><description><para>When (<c>Filter.N.Key</c>) is <c>CreationStartTime</c> or <c>CreationEndTime</c>, the format is <c>yyyy-MM-ddTHH:mmZ</c> in UTC+0 time zone.</para>
            /// </description></item>
            /// <item><description><para>When (<c>Filter.N.Key</c>) is <c>NetworkType</c>, valid values include <c>vpc</c>, <c>classic</c>, etc.</para>
            /// </description></item>
            /// <item><description><para>When (<c>Filter.N.Key</c>) is <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, the value can be <c>supported</c> or <c>unsupported</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>Default Value: null.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-12-05T22:40Z</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the image family. When querying images, you can use this parameter to filter images belonging to the specified image family.</para>
        /// <para>Default value: empty.</para>
        /// <remarks>
        /// <para>For information about image families associated with official Alibaba Cloud images, see <a href="https://help.aliyun.com/document_detail/108393.html">Overview of public images</a>.</para>
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
        /// 
        /// <summary>
        /// 
        /// <para>Naming convention for image IDs</para>
        /// </summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>Public images: Named based on the operating system version, architecture, language, and published date. For example, the image ID for Windows Server 2008 R2 Enterprise Edition, 64-bit English system is <c>win2008r2_64_ent_sp1_en-us_40G_alibase_20190318.vhd</c>.</para>
        /// </description></item>
        /// <item><description><para>Custom images, shared images, Alibaba Cloud Marketplace images, and community images: Start with the letter <c>m</c>.</para>
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
        /// <para>The name of the image. Fuzzy search is supported.</para>
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
        /// <item><description><para>system: Images provided by Alibaba Cloud that are not published on Alibaba Cloud Marketplace. This differs from the &quot;public image&quot; concept in the console.</para>
        /// </description></item>
        /// <item><description><para>self: Your custom images.</para>
        /// </description></item>
        /// <item><description><para>others: Includes shared images (images directly shared with you by other Alibaba Cloud users) and community images (custom images fully publicly shared by any Alibaba Cloud user). Note the following:</para>
        /// <list type="bullet">
        /// <item><description><para>To find community images, IsPublic must be true.</para>
        /// </description></item>
        /// <item><description><para>To find shared images, IsPublic must be set to false or omitted.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>marketplace: Images published on Alibaba Cloud Marketplace by Alibaba Cloud or third-party ISVs, which must be purchased together with ECS instances. Please review the pricing details of Alibaba Cloud Marketplace images yourself.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: empty.</para>
        /// <remarks>
        /// <para>An empty value returns results with ImageOwnerAlias values of system, self, and others.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the image belongs. This parameter takes effect only when you query shared images and community images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20169351435666****</para>
        /// </summary>
        [NameInMap("ImageOwnerId")]
        [Validation(Required=false)]
        public long? ImageOwnerId { get; set; }

        /// <summary>
        /// <para>Queries images that can be used with the specified instance type.</para>
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
        /// <item><description><para>true: Queries published community images. When this parameter is set to true, ImageOwnerAlias must be set to others.</para>
        /// </description></item>
        /// <item><description><para>false: Queries other image types excluding community images, depending on the value of the ImageOwnerAlias parameter.</para>
        /// </description></item>
        /// </list>
        /// <para>Default Value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// <para>Indicates whether the image supports cloud-init.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSupportCloudinit")]
        [Validation(Required=false)]
        public bool? IsSupportCloudinit { get; set; }

        /// <summary>
        /// <para>Indicates whether the image can run on I/O optimized instances.</para>
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
        /// <item><description><para>windows</para>
        /// </description></item>
        /// <item><description><para>linux</para>
        /// </description></item>
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
        /// <para>The page number of the image resource list.</para>
        /// <para>Starting value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
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
        /// <para>The region ID to which the image belongs. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group to which the custom image belongs. When using this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
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
        /// <para>Indicates whether subscription-based images have exceeded their usage period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowExpired")]
        [Validation(Required=false)]
        public bool? ShowExpired { get; set; }

        /// <summary>
        /// <para>The custom image created from a specific snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp17ot2q7x72ggtw****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>Queries images in the specified status. If this parameter is not configured, only images in the Available status are returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Creating: The image is being created.</para>
        /// </description></item>
        /// <item><description><para>Waiting: The image is queued for multitasking.</para>
        /// </description></item>
        /// <item><description><para>Available (default): The image is available for your use.</para>
        /// </description></item>
        /// <item><description><para>UnAvailable: The image is unavailable for your use.</para>
        /// </description></item>
        /// <item><description><para>CreateFailed: The image creation failed.</para>
        /// </description></item>
        /// <item><description><para>Deprecated: The image has been deprecated.</para>
        /// </description></item>
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
            /// <para>When you use one tag to filter resources, the number of resources retrieved under this tag cannot exceed 1,000. When you use multiple tags to filter resources, the number of resources that are attached with all specified tags cannot exceed 1,000. If the resource count exceeds 1,000, use the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> API to query the resources.</para>
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

        /// <summary>
        /// <para>Indicates whether the image is already running on an ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>instance: The image is in use by one or more ECS instances.</para>
        /// </description></item>
        /// <item><description><para>none: The image is idle and not used by any ECS instance.</para>
        /// </description></item>
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
