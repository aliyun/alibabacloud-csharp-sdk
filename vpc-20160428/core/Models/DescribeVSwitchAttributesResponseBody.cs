// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The active IP address count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("AvailableIpAddressCount")]
        [Validation(Required=false)]
        public long? AvailableIpAddressCount { get; set; }

        /// <summary>
        /// <para>The private endpoint range of the vSwitch.</para>
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
        /// <para>Specifies whether DNS64 is enabled for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: DNS64 is enabled.</description></item>
        /// <item><description><b>false</b>: DNS64 is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDns64")]
        [Validation(Required=false)]
        public bool? EnableDns64 { get; set; }

        /// <summary>
        /// <para>Specifies whether the IPv6 CIDR block feature is enabled and configured for the vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
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
        /// <para>Specifies whether the vSwitch is an IPv6 single-stack vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The vSwitch is an IPv6 single-stack vSwitch.</description></item>
        /// <item><description>false: The vSwitch is not an IPv6 single-stack vSwitch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ipv6Only")]
        [Validation(Required=false)]
        public bool? Ipv6Only { get; set; }

        /// <summary>
        /// <para>Specifies whether the vSwitch is the default vSwitch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The vSwitch is the default vSwitch.</description></item>
        /// <item><description><b>false</b>: The vSwitch is not the default vSwitch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The network ACL rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the resource ownership.</para>
        /// <remarks>
        /// <para>Notice: This value is of the Long type. Precision loss may occur in some programming languages. Use it with caution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>28768383240243****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B48B4B9-1EAD-469F-B488-594DAB4B6A1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The route table information of the vSwitch.</para>
        /// </summary>
        [NameInMap("RouteTable")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyRouteTable RouteTable { get; set; }
        public class DescribeVSwitchAttributesResponseBodyRouteTable : TeaModel {
            /// <summary>
            /// <para>The ID of the route table associated with the vSwitch.</para>
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
            /// <item><description><para><b>System</b>: system route table.</para>
            /// </description></item>
            /// <item><description><para><b>Custom</b>: custom route table.</para>
            /// </description></item>
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
        /// <para>The sharing type of the vSwitch.</para>
        /// <list type="bullet">
        /// <item><description>If the value is empty, the vSwitch is a regular vSwitch.</description></item>
        /// <item><description><b>Shared</b>: The vSwitch is a shared vSwitch.</description></item>
        /// <item><description><b>Sharing</b>: The vSwitch is being shared with other users.</description></item>
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
        /// <item><description><para><b>Pending</b>: The vSwitch is being configured. </para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: The vSwitch is available.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVSwitchAttributesResponseBodyTags Tags { get; set; }
        public class DescribeVSwitchAttributesResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVSwitchAttributesResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVSwitchAttributesResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-25b7pv15t****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The name of the vSwitch.</para>
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
        /// <para>The zone to which the vSwitch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
