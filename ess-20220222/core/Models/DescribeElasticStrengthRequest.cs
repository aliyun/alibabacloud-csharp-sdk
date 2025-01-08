// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeElasticStrengthRequest : TeaModel {
        /// <summary>
        /// <para>The disk categories of the data disks. The disk categories that do not match the specified criteria are returned after you call this operation.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataDiskCategories")]
        [Validation(Required=false)]
        public List<string> DataDiskCategories { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can specify the ImageFamily request parameter to obtain the most recent available images in the current image family for instance creation. If you specify ImageId, you cannot specify ImageFamily.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify at least one of ImageId, ImageName, and ImageFamily.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS7</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image file that provides the image resource for Auto Scaling to create instances.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify at least one of ImageId, ImageName, and ImageFamily.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. Each image name must be unique in a region. If you specify ImageId, ImageName is ignored.</para>
        /// <para>You cannot use ImageName to specify an Alibaba Cloud Marketplace image.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify at least one of ImageId, ImageName, and ImageFamily.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ubuntu_18_04_x64_20G_alibase_20231225.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The instance types. The instance types specified by this parameter overwrite the instance types specified in the scaling configuration.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses. If the instance type that you specified does meet the requirement for the number of IPv6 addresses, the scaling strength is weak.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>**</para>
        /// <para><b>Warning</b> This parameter is deprecated. We recommend that you use SpotStrategy.</para>
        /// <para>The preemption policy that you want to apply to pay-as-you-go instances. The preemption policy specified by this parameter overwrites the preemption policy specified in the scaling configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are created as regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is automatically used as the bidding price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the scaling groups that you want to query.</para>
        /// </summary>
        [NameInMap("ScalingGroupIds")]
        [Validation(Required=false)]
        public List<string> ScalingGroupIds { get; set; }

        /// <summary>
        /// <para>The instance bidding policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are created as pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instances are created as preemptible instances with a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instances are created as preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
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
        /// <para>The categories of the system disks. The categories of the system disks specified by this parameter overwrite the categories of the system disks specified in the scaling configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic disk.</description></item>
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// <remarks>
        /// <para> If you do not specify the scaling group ID, you must specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
