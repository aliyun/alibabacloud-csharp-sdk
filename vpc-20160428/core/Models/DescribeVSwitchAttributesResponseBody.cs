// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of available IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AvailableIpAddressCount")]
        [Validation(Required=false)]
        public long? AvailableIpAddressCount { get; set; }

        /// <summary>
        /// <para>The CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The time when the vSwitch was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-22T10:40:25Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether IPv6 is enabled for the vSwitch. If you enable IPv6, you must configure the IPv6 CIDR block of the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnabledIpv6")]
        [Validation(Required=false)]
        public bool? EnabledIpv6 { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:3c5:44e::/64</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>Indicates whether the vSwitch is the default vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The network access control list (ACL) rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>287683832402436789</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B48B4B9-1EAD-469F-B488-594DAB4B6A1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the ACL belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The information about the route table that is associated with the vSwitch.</para>
        /// </summary>
        [NameInMap("RouteTable")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyRouteTable RouteTable { get; set; }
        public class DescribeVSwitchAttributesResponseBodyRouteTable : TeaModel {
            /// <summary>
            /// <para>The ID of the route table that is associated with the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-bp145q7glnuzdv****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

            /// <summary>
            /// <para>The type of the route table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>System</b></description></item>
            /// <item><description><b>Custom</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("RouteTableType")]
            [Validation(Required=false)]
            public string RouteTableType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the vSwitch is shared.</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned, the vSwitch is a regular vSwitch.</description></item>
        /// <item><description>If <b>Shared</b> is returned, the vSwitch is shared.</description></item>
        /// <item><description>If <b>Sharing</b> is returned, the vSwitch is being shared.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Shared</para>
        /// </summary>
        [NameInMap("ShareType")]
        [Validation(Required=false)]
        public string ShareType { get; set; }

        /// <summary>
        /// <para>The status of the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b></description></item>
        /// <item><description><b>Available</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyTags Tags { get; set; }
        public class DescribeVSwitchAttributesResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVSwitchAttributesResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVSwitchAttributesResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// <para>The key of tag N added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N added to the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25b7pv15t****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The vSwitch name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-257gq642n****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
