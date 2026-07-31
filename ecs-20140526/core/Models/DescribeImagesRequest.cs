// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which the image is to be used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateEcs (default): instance creation.</description></item>
        /// <item><description>ChangeOS: system disk replacement or operating system change.</description></item>
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
        /// <item><description>true: Sends a check request without querying resource status. The check items include whether your AccessKey pair is valid, whether Resource Access Management (RAM) user authorization is granted, and whether required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the error code DryRunOperation is returned.  </description></item>
        /// <item><description>false: Sends a normal request. After the check succeeds, an HTTP status code of 2XX is returned and the resource status is queried directly.</description></item>
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
            /// <item><description>When set to <c>CreationStartTime</c>, queries resources created after the specified time point (<c>Filter.N.Value</c>).</description></item>
            /// <item><description>When set to <c>CreationEndTime</c>, queries resources created before the specified time point (<c>Filter.N.Value</c>).</description></item>
            /// <item><description>When set to <c>NetworkType</c>, queries resources of the specified network type.</description></item>
            /// <item><description>When set to <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, queries the CPU or memory hot-plugging support of the specified image.</description></item>
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
            /// <item><description><para>When <c>Filter.N.Key</c> is <c>NetworkType</c>, valid network type values include <c>vpc</c> and <c>classic</c>.</para>
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
        /// <para>For information about image families associated with Alibaba Cloud public images, see <a href="https://help.aliyun.com/document_detail/108393.html">Overview of public images</a>.</para>
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
        /// <summary>Naming conventions for image IDs</summary>
        /// 
        /// <list type="bullet">
        /// <item><description><para>Public images: Named by operating system version, architecture, language, and release date. For example, the image ID for Windows Server 2008 R2 Enterprise Edition, 64-bit English is win2008r2_64_ent_sp1_en-us_40G_alibase_20190318.vhd.</para>
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
        /// <item><description>system: Public images provided by Alibaba Cloud that are not published through Alibaba Cloud Marketplace. This is different from the &quot;Public Image&quot; concept in the console.</description></item>
        /// <item><description>self: Custom images that you created.</description></item>
        /// <item><description>others: Includes shared images (images directly shared by other Alibaba Cloud users) and community images (custom images that other Alibaba Cloud users have made fully public). Note the following:<list type="bullet">
        /// <item><description>To query community images, IsPublic must be set to true.</description></item>
        /// <item><description>To query shared images, IsPublic must be set to false or left empty.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>marketplace: Images published by Alibaba Cloud or third-party independent software vendors (ISVs) in Alibaba Cloud Marketplace. These images must be purchased together with ECS instances. Check the billing details of Alibaba Cloud Marketplace images.</description></item>
        /// </list>
        /// <para>Default value: empty.</para>
        /// <remarks>
        /// <para>An empty value returns results with values of system, self, and others.</para>
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
        /// <para>The instance type for which you want to query available images.</para>
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
        /// <para>The page number of the resources list.</para>
        /// <para>Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query. Settings for the number of entries to return on each page.</para>
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
        /// <para>The status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The image is being created.</description></item>
        /// <item><description>Waiting: The image is waiting in a multi-task queue.</description></item>
        /// <item><description>Available: The image is available for use.</description></item>
        /// <item><description>UnAvailable: The image is unavailable.</description></item>
        /// <item><description>CreateFailed: The image failed to be created.</description></item>
        /// <item><description>Deprecated: The image is deprecated.</description></item>
        /// <item><description>ALL: All image statuses.</description></item>
        /// </list>
        /// <para>Default value: Available. Status is required only when Usable is specified, and has no default value in that case.</para>
        /// <remarks>
        /// <para>This parameter supports multiple values separated by commas (,). When set to ALL, all image statuses are queried. ALL cannot be used together with other status values.</para>
        /// </remarks>
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
            /// <para>When you use a single tag to filter resources, the resource count with this tag cannot exceed 1000. When you use multiple tags to filter resources, the resource count of resources that have all specified tags attached cannot exceed 1000. If the resource count exceeds 1000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query resources.</para>
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
        /// <para>Specifies whether the image is available for use.</para>
        /// <remarks>
        /// <para>An available image can be immediately used to create instances. For more information about availability scenarios, see <a href="https://help.aliyun.com/document_detail/3044728.html">Image instant availability</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Usable")]
        [Validation(Required=false)]
        public bool? Usable { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is running on ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: The image is in use. ECS instances are using this image.</description></item>
        /// <item><description>none: The image is idle. No ECS instances are using this image.</description></item>
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
