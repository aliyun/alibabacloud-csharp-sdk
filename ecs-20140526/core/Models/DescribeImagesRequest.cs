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
        /// <item><description>CreateEcs (default): creates an instance.</description></item>
        /// <item><description>ChangeOS: replaces the system disk or changes the operating system.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>i386</para>
        /// </summary>
        [NameInMap("Architecture")]
        [Validation(Required=false)]
        public string Architecture { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request.</para>
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
            /// <para>The filter key used to query resources. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreationStartTime: queries information about resources that are created after the point in time specified by Filter.N.Value.</description></item>
            /// <item><description>CreationEndTime: queries information about resources that are created before the point in time specified by Filter.N.Value.</description></item>
            /// <item><description>NetworkType: queries information about resources of the specified network type.</description></item>
            /// <item><description>CpuOnlineUpgrade, CpuOnlineDowngrade, MemoryOnlineUpgrade, or MemoryOnlineDowngrade: queries the CPU or memory hot-plugging support of the specified image.</description></item>
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
            /// <para>The filter value used when querying resources.</para>
            /// <list type="bullet">
            /// <item><description><para>When Filter.N.Key is <c>CreationStartTime</c> or <c>CreationEndTime</c>, the format is <c>yyyy-MM-ddTHH:mmZ</c> in the UTC+0 time zone.</para>
            /// </description></item>
            /// <item><description><para>When Filter.N.Key is <c>NetworkType</c>, you can specify network type values such as <c>vpc</c> and <c>classic</c>.</para>
            /// </description></item>
            /// <item><description><para>When Filter.N.Key is set to <c>CpuOnlineUpgrade</c>, <c>CpuOnlineDowngrade</c>, <c>MemoryOnlineUpgrade</c>, or <c>MemoryOnlineDowngrade</c>, the value can be <c>supported</c> or <c>unsupported</c>.</para>
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
        /// <para>The image family name. You can set this parameter to filter images that belong to the specified image family.</para>
        /// <para>Default value: null.</para>
        /// <remarks>
        /// <para>For information about image families associated with Alibaba Cloud official images, see <a href="https://help.aliyun.com/document_detail/108393.html">Public image overview</a>.</para>
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
        /// <item><description><para>Public image: Named based on the operating system version, architecture, language, and release date. For example, the image ID of a Windows Server 2008 R2 Enterprise Edition 64-bit English image is win2008r2_64_ent_sp1_en-us_40G_alibase_20190318.vhd.</para>
        /// </description></item>
        /// <item><description><para>Custom image, shared image, Alibaba Cloud Marketplace image, and community image: Starts with m.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>self</para>
        /// </summary>
        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID to which the image belongs. This parameter takes effect only when you query shared images or community images.</para>
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
        /// <item><description>true: Queries published community images. If you set this parameter to true, you must set ImageOwnerAlias to others.</description></item>
        /// <item><description>false: Queries image types other than community images. The specific image type depends on the value of ImageOwnerAlias.</description></item>
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
        /// <para>The page number of the image resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings for paging determine how many rows are returned per page.</para>
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
        /// <para>The ID of the enterprise resource group to which the custom image belongs. When you use this parameter to filter resources, the number of resources cannot exceed 1,000.</para>
        /// <remarks>
        /// <para>Default resource group-based filtering is not supported.</para>
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
        /// <para>Indicates whether the image is available.</para>
        /// <remarks>
        /// <para>An available image can be used immediately to create instances. For more available scenarios, see <a href="https://help.aliyun.com/document_detail/3044728.html">Snapshot instant access</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Usable")]
        [Validation(Required=false)]
        public bool? Usable { get; set; }

        /// <summary>
        /// <para>Specifies whether the image is running on an ECS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: The image is in use by an ECS instance.</description></item>
        /// <item><description>none: The image is idle and not in use by any ECS instance.</description></item>
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
