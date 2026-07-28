// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVSwitchAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The new description of the vSwitch.  </para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my vswitch.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6 for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables IPv6. The VPC to which the vSwitch belongs must have IPv6 enabled. You must also specify Ipv6CidrBlock to assign an IPv6 CIDR block to the vSwitch.</description></item>
        /// <item><description><b>false</b> (default): disables IPv6. When you disable IPv6 for the vSwitch, make sure that no IPv6 addresses are in use. You cannot specify Ipv6CidrBlock at the same time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

        /// <summary>
        /// <para>The last 8 bits of the IPv6 CIDR block of the vSwitch. Valid values: <b>0</b> to <b>255</b>.</para>
        /// <para>You can specify this parameter only when the VPC to which the vSwitch belongs has IPv6 enabled. This parameter is used to assign an IPv6 CIDR block to the vSwitch. After the IPv6 CIDR block is allocated, it cannot be changed to another CIDR block. Make sure that the CIDR block does not overlap with those of other vSwitches in the same VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public int? Ipv6CidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch. You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The ID of the vSwitch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25nacdfvue4****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The new name of the vSwitch.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VSwitch-1</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the VPC to which the vSwitch belongs.
        /// If the VPC has multiple IPv6 CIDR blocks, you can specify this parameter to indicate the IPv6 CIDR block range for the vSwitch. If you do not specify this parameter, the IPv6 CIDR block assigned when IPv6 was enabled for the VPC is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:312:3e00::/56</para>
        /// </summary>
        [NameInMap("VpcIpv6CidrBlock")]
        [Validation(Required=false)]
        public string VpcIpv6CidrBlock { get; set; }

    }

}
