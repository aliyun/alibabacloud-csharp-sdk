// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeElasticStrengthRequest : TeaModel {
        /// <summary>
        /// <para>A list of data disk categories used to evaluate elastic strength. If a category is incompatible, the response identifies the specific mismatched category.</para>
        /// <remarks>
        /// <para>You can specify this parameter if <c>ScalingGroupId</c> is not specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DataDiskCategories")]
        [Validation(Required=false)]
        public List<string> DataDiskCategories { get; set; }

        /// <summary>
        /// <para>The name of the image family. You can set this parameter to use the latest available image from the specified image family to create instances. If you specify ImageId, this parameter is ignored.</para>
        /// <remarks>
        /// <para>If <c>ScalingGroupId</c> is not specified, you must specify at least one of <c>ImageId</c>, <c>ImageName</c>, or <c>ImageFamily</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CentOS7</para>
        /// </summary>
        [NameInMap("ImageFamily")]
        [Validation(Required=false)]
        public string ImageFamily { get; set; }

        /// <summary>
        /// <para>The ID of the image used to create instances.</para>
        /// <remarks>
        /// <para>If <c>ScalingGroupId</c> is not specified, you must specify at least one of <c>ImageId</c>, <c>ImageName</c>, or <c>ImageFamily</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos6u5_64_20G_aliaegis****.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The name of the image. The name must be unique within a region. If you specify <c>ImageId</c>, this parameter is ignored.</para>
        /// <para>You cannot use this parameter to specify a Marketplace image.</para>
        /// <remarks>
        /// <para>If <c>ScalingGroupId</c> is not specified, you must specify at least one of <c>ImageId</c>, <c>ImageName</c>, or <c>ImageFamily</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ubuntu_18_04_x64_20G_alibase_20231225.vhd</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>A list of ECS instance types. If specified, this parameter overrides the instance types in the scaling configuration.</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to be configured for each instance. The elastic strength is lowered for instance types that do not support the specified number of IPv6 addresses.</para>
        /// <remarks>
        /// <para>You can specify this parameter if <c>ScalingGroupId</c> is not specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Warning: This parameter is deprecated. Use <c>SpotStrategy</c> instead.
        /// The spot strategy for pay-as-you-go instances. If specified, this parameter overrides the spot strategy in the scaling configuration. Valid values:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><c>NoSpot</c>: A regular pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para><c>SpotWithPriceLimit</c>: A spot instance with a specified maximum price.</para>
        /// </description></item>
        /// <item><description><para><c>SpotAsPriceGo</c>: A spot instance where the system automatically bids at the current market price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NoSpot</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the region where the scaling group is located.</para>
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
        /// <para>The IDs of one or more scaling groups to query in a batch operation.</para>
        /// </summary>
        [NameInMap("ScalingGroupIds")]
        [Validation(Required=false)]
        public List<string> ScalingGroupIds { get; set; }

        /// <summary>
        /// <para>The spot strategy for instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NoSpot</c>: A regular pay-as-you-go instance.</para>
        /// </description></item>
        /// <item><description><para><c>SpotWithPriceLimit</c>: A spot instance with a specified maximum price.</para>
        /// </description></item>
        /// <item><description><para><c>SpotAsPriceGo</c>: A spot instance where the system automatically bids at the current market price.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>NoSpot</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>A list of system disk categories. If specified, this parameter overrides the system disk categories in the scaling configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud</c>: Basic Cloud Disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_efficiency</c>: Ultra Cloud Disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if <c>ScalingGroupId</c> is not specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SystemDiskCategories")]
        [Validation(Required=false)]
        public List<string> SystemDiskCategories { get; set; }

        /// <summary>
        /// <para>A list of VSwitch IDs.</para>
        /// <remarks>
        /// <para>This parameter is required if <c>ScalingGroupId</c> is not specified.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

    }

}
