// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the vSwitch. The CIDR block of the vSwitch must meet the following requirements: </para>
        /// <list type="bullet">
        /// <item><description><para>The mask length of the vSwitch CIDR block ranges from 16 to 29 bits.  </para>
        /// </description></item>
        /// <item><description><para>The vSwitch CIDR block must be a subset of the VPC CIDR block. </para>
        /// </description></item>
        /// <item><description><para>The vSwitch CIDR block cannot be the same as the destination CIDR block of a route in the VPC. However, it can be a subset of the destination CIDR block. </para>
        /// </description></item>
        /// <item><description><para>The vSwitch CIDR block cannot fall within the following reserved address ranges: 100.64.0.0/10, 127.0.0.0/8, 169.254.0.0/16, and 224.0.0.0/4.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After a vSwitch is created, you cannot modify its CIDR block.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR block mask of the vSwitch.</para>
        /// <remarks>
        /// <para>The mask length of the IPv4 CIDR block of the vSwitch ranges from 16 to 29 bits. You must specify at least one of CidrBlock and CidrMask.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("CidrMask")]
        [Validation(Required=false)]
        public int? CidrMask { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the vSwitch.  </para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vSwitch</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The last 8 bits of the IPv6 CIDR block of the vSwitch. Valid values: <b>0</b> to <b>255</b>.
        /// You can specify this parameter to assign an IPv6 CIDR block to the vSwitch only when IPv6 is enabled for the VPC to which the vSwitch belongs. After the IPv6 CIDR block is assigned, you cannot modify it. Make sure that the IPv6 CIDR block does not overlap with the CIDR blocks of other vSwitches in the same VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public int? Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The subnet mask of the IPv6 CIDR block of the vSwitch. You can specify this parameter to assign an IPv6 CIDR block to the vSwitch only when IPv6 is enabled for the VPC to which the vSwitch belongs.</para>
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

        /// <summary>
        /// <para>Specifies whether to create an IPv6-only vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): creates a regular vSwitch (not IPv6-only).</para>
        /// </description></item>
        /// <item><description><para>true: creates an IPv6-only vSwitch.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ipv6Only")]
        [Validation(Required=false)]
        public bool? Ipv6Only { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the vSwitch to be created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVSwitchRequestTag> Tag { get; set; }
        public class CreateVSwitchRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify at most 20 tag keys. If you specify this parameter, you cannot specify an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify at most 20 tag values. If you specify this parameter, you can specify an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the vSwitch. </para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vSwitch-1</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the vSwitch to be created belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-257gqcdfvx6n****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the VPC. If the VPC to which the vSwitch belongs has multiple IPv6 CIDR blocks, you can specify this parameter to specify the IPv6 CIDR block to which the vSwitch belongs. If you do not specify this parameter, the IPv6 CIDR block assigned when IPv6 is enabled for the VPC is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:6a::/56</para>
        /// </summary>
        [NameInMap("VpcIpv6CidrBlock")]
        [Validation(Required=false)]
        public string VpcIpv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The zone ID of the vSwitch to be created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36064.html">DescribeZones</a> operation to query zone IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
