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
        /// <para>Specifies whether to enable DNS64 for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables DNS64. IPv6 must be enabled for the vSwitch.</description></item>
        /// <item><description><b>false</b>: disables DNS64.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDns64")]
        [Validation(Required=false)]
        public bool? EnableDns64 { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6 for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables IPv6. IPv6 must be enabled for the VPC to which the vSwitch belongs, and you must also specify Ipv6CidrBlock to assign an IPv6 CIDR block to the vSwitch.</description></item>
        /// <item><description><b>false</b> (default): disables IPv6. When you disable IPv6 for the vSwitch, make sure that no IPv6 addresses are in use, and do not specify Ipv6CidrBlock at the same time.</description></item>
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
        /// <para>You can specify this parameter to assign an IPv6 CIDR block to the vSwitch only when IPv6 is enabled for the VPC to which the vSwitch belongs. After an IPv6 CIDR block is assigned, it cannot be changed to another CIDR block. Make sure that the IPv6 CIDR block does not overlap with the CIDR blocks of other vSwitches in the same VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public int? Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The mask of the IPv6 CIDR block of the vSwitch. You can specify this parameter to assign an IPv6 CIDR block to the vSwitch only when IPv6 is enabled for the VPC to which the vSwitch belongs.</para>
        /// <remarks>
        /// <para>Only 64 is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("Ipv6CidrMask")]
        [Validation(Required=false)]
        public int? Ipv6CidrMask { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// If the VPC has multiple IPv6 CIDR blocks, you can specify this parameter to specify the IPv6 CIDR block range to which the vSwitch belongs. If you do not specify this parameter, the IPv6 CIDR block assigned when IPv6 is enabled for the VPC is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:312:3e00::/56</para>
        /// </summary>
        [NameInMap("VpcIpv6CidrBlock")]
        [Validation(Required=false)]
        public string VpcIpv6CidrBlock { get; set; }

    }

}
