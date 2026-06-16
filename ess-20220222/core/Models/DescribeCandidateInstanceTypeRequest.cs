// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeCandidateInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include vSwitches from other availability zones as candidates.</para>
        /// <remarks>
        /// <para>The instance types remain unchanged. Only new availability zones are added as candidates. If a scaling group fails to scale out in all selected availability zones due to issues such as insufficient inventory, Auto Scaling automatically adds a vSwitch in a new availability zone to the scaling group based on this setting.
        /// For example, if a scaling group is configured for the cn-hangzhou-h and cn-hangzhou-g availability zones and a scale-out fails in both zones, Auto Scaling may create a vSwitch in the cn-hangzhou-k availability zone and add it to the scaling group based on real-time inventory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowCrossAz")]
        [Validation(Required=false)]
        public bool? AllowCrossAz { get; set; }

        /// <summary>
        /// <para>Specifies whether to include instance types from other generations as candidates.</para>
        /// <list type="bullet">
        /// <item><description>For example, if the current instance type is ecs.c7.large, you can set this parameter to true to include instance types such as ecs.c6.large and ecs.c8.large in the list of candidates.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowDifferentGeneration")]
        [Validation(Required=false)]
        public bool? AllowDifferentGeneration { get; set; }

        /// <summary>
        /// <para>The data disk categories, ordered by priority from high to low. If Auto Scaling cannot create a data disk by using a higher-priority category, it tries the next one in the list.</para>
        /// </summary>
        [NameInMap("DataDiskCategories")]
        [Validation(Required=false)]
        public List<string> DataDiskCategories { get; set; }

        /// <summary>
        /// <para>The name of the image family. When specified, the latest image in this family is used to create instances. This parameter cannot be used with ImageId.</para>
        /// <remarks>
        /// <para>If you do not specify the scaling group ID, you must specify at least one of ImageId, ImageName, and ImageFamily.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou-daily-update</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image used to create instances.</para>
        /// <remarks>
        /// <para>If the specified image contains both a system disk and data disks, any existing data disk information in the scaling configuration is cleared.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be unique within a region. You cannot use this parameter to specify an image from Alibaba Cloud Marketplace.</para>
        /// <remarks>
        /// <para>This parameter is an alternative to the <c>ImageId</c> parameter. If you specify <c>ImageId</c>, <c>ImageName</c> is ignored.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis_20140703.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The specified ECS instance types.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The maximum price for a candidate instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxPrice")]
        [Validation(Required=false)]
        public float? MaxPrice { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the scaling group is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The bidding strategy for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NoSpot: a standard pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para>SpotWithPriceLimit: a spot instance with a user-defined maximum price.</para>
        /// </description></item>
        /// <item><description><para>SpotAsPriceGo: a spot instance where the system automatically bids at the market price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The system disk categories, ordered by priority from high to low. If Auto Scaling cannot create a system disk by using a higher-priority category, it tries the next one in the list.</para>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The specified availability zones.</para>
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
