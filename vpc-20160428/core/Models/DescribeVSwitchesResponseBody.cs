// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A572171-4E27-40D1-BD36-D26C9E71E29E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details about the vSwitch.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public DescribeVSwitchesResponseBodyVSwitches VSwitches { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitches : TeaModel {
            [NameInMap("VSwitch")]
            [Validation(Required=false)]
            public List<DescribeVSwitchesResponseBodyVSwitchesVSwitch> VSwitch { get; set; }
            public class DescribeVSwitchesResponseBodyVSwitchesVSwitch : TeaModel {
                /// <summary>
                /// <para>The number of available IP addresses in the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AvailableIpAddressCount")]
                [Validation(Required=false)]
                public long? AvailableIpAddressCount { get; set; }

                /// <summary>
                /// <para>The IPv4 CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the vSwitch was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-18T12:43:57Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitchDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled for the vSwitch. If you enable IPv6, you must configure an IPv6 CIDR block for the vSwitch. Valid values:</para>
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
                /// <para>2408:4002:10c4:4e03::/64</para>
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The ID of the network access control list (ACL).</para>
                /// 
                /// <b>Example:</b>
                /// <para>nacl-a2do9e413e0spzasx****</para>
                /// </summary>
                [NameInMap("NetworkAclId")]
                [Validation(Required=false)]
                public string NetworkAclId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25346073170691****</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph6aiy****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The information about the route table.</para>
                /// </summary>
                [NameInMap("RouteTable")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable RouteTable { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchRouteTable : TeaModel {
                    /// <summary>
                    /// <para>The ID of the route table that is associated with the vSwitch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vrt-bp145q7glnuzdv****</para>
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
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags of the vSwitch.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVSwitchesResponseBodyVSwitchesVSwitchTags Tags { get; set; }
                public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag> Tag { get; set; }
                    public class DescribeVSwitchesResponseBodyVSwitchesVSwitchTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>department</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dev</para>
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
                /// <para>vsw-25bcdxs7pv1****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The vSwitch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vSwitch</para>
                /// </summary>
                [NameInMap("VSwitchName")]
                [Validation(Required=false)]
                public string VSwitchName { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-257gcdcdq64****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the zone to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-d</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
