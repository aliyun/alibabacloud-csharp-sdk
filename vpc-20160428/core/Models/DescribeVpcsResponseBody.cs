// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>C6532AA8-D0F7-497F-A8EE-094126D441F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The details about the VPC.</para>
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeVpcsResponseBodyVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeVpcsResponseBodyVpcsVpc : TeaModel {
                /// <summary>
                /// <para>The status of the Cloud Enterprise Network (CEN) instance to which the VPC is attached. <b>Attached</b> is returned only if the VPC is attached to a CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Attached</para>
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

                /// <summary>
                /// <para>The IPv4 CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.0.0/16</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the VPC was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-04-18T15:02:37Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is my VPC.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the DHCP options set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dopt-o6w0df4epg9zo8isy****</para>
                /// </summary>
                [NameInMap("DhcpOptionsSetId")]
                [Validation(Required=false)]
                public string DhcpOptionsSetId { get; set; }

                /// <summary>
                /// <para>The status of the DHCP options set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>InUse</b></description></item>
                /// <item><description><b>Deleted</b></description></item>
                /// <item><description><b>Pending</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("DhcpOptionsSetStatus")]
                [Validation(Required=false)]
                public string DhcpOptionsSetStatus { get; set; }

                [NameInMap("DnsHostnameStatus")]
                [Validation(Required=false)]
                public string DnsHostnameStatus { get; set; }

                [NameInMap("EnabledIpv6")]
                [Validation(Required=false)]
                public bool? EnabledIpv6 { get; set; }

                /// <summary>
                /// <para>The IPv6 CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:XXXX:0:a600::/56</para>
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                /// <summary>
                /// <para>The IPv6 CIDR block of the VPC.</para>
                /// </summary>
                [NameInMap("Ipv6CidrBlocks")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocks : TeaModel {
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public List<DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
                    public class DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                        /// <summary>
                        /// <para>The IPv6 CIDR block of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2408:XXXX:0:a600::/56</para>
                        /// </summary>
                        [NameInMap("Ipv6CidrBlock")]
                        [Validation(Required=false)]
                        public string Ipv6CidrBlock { get; set; }

                        /// <summary>
                        /// <para>The type of IPv6 CIDR block. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>BGP</b></description></item>
                        /// <item><description><b>ChinaMobile</b></description></item>
                        /// <item><description><b>ChinaUnicom</b></description></item>
                        /// <item><description><b>ChinaTelecom</b></description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> If your Alibaba Cloud account is allowed to activate single-ISP bandwidth, you can set this parameter to <b>ChinaTelecom</b>, <b>ChinaUnicom</b>, or <b>ChinaMobile</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>BGP</para>
                        /// </summary>
                        [NameInMap("Ipv6Isp")]
                        [Validation(Required=false)]
                        public string Ipv6Isp { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the VPC is the default VPC in the region. Valid values:</para>
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
                /// <para>The ID of the Internet NAT gateway.</para>
                /// </summary>
                [NameInMap("NatGatewayIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcNatGatewayIds NatGatewayIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcNatGatewayIds : TeaModel {
                    [NameInMap("NatGatewayIds")]
                    [Validation(Required=false)]
                    public List<string> NatGatewayIds { get; set; }

                }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>253460731706911258</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the VPC belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The information about the route table.</para>
                /// </summary>
                [NameInMap("RouterTableIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcRouterTableIds RouterTableIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcRouterTableIds : TeaModel {
                    [NameInMap("RouterTableIds")]
                    [Validation(Required=false)]
                    public List<string> RouterTableIds { get; set; }

                }

                /// <summary>
                /// <para>The information about the secondary CIDR block.</para>
                /// </summary>
                [NameInMap("SecondaryCidrBlocks")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcSecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcSecondaryCidrBlocks : TeaModel {
                    [NameInMap("SecondaryCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> SecondaryCidrBlock { get; set; }

                }

                /// <summary>
                /// <para>The status of the VPC. Valid values:</para>
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
                /// <para>The tag information about the VPC.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcTags Tags { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpcsResponseBodyVpcsVpcTagsTag> Tag { get; set; }
                    public class DescribeVpcsResponseBodyVpcsVpcTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>env</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>internal</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The list of user CIDR blocks.</para>
                /// </summary>
                [NameInMap("UserCidrs")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcUserCidrs UserCidrs { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcUserCidrs : TeaModel {
                    [NameInMap("UserCidr")]
                    [Validation(Required=false)]
                    public List<string> UserCidr { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vRouter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1jcg5cmxjbl9xgc****</para>
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// <para>The vSwitches in the VPC.</para>
                /// <para>You can query up to 300 vSwitches in the VPC. The information about the latest vSwitches is returned. If you want to query the information about all vSwitches in a VPC, call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcVSwitchIds VSwitchIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1qpo0kug3a20qqe****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc1</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
