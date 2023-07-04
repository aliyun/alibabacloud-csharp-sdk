// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        /// <summary>
        /// The name of the VPC.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the VPC belongs.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region to which the VPC belongs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the vRouter.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The status of the DHCP options set. Valid values:
        /// 
        /// *   **Available**: available
        /// *   **InUse**: in use
        /// *   **Deleted**: deleted
        /// *   **Pending**: being configured
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
                /// The list of user CIDR blocks.
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

                /// <summary>
                /// The IPv6 CIDR blocks of the VPC.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The IPv4 CIDR block of the VPC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The type of IPv6 CIDR block. Valid values:
                /// 
                /// - **BGP**: an IPv6 CIDR block provided by Alibaba Cloud over Border Gateway Protocol (BGP)
                /// - **ChinaMobile**: an IPv6 CIDR block provided by China Mobile (single ISP)
                /// - **ChinaUnicom**: an IPv6 CIDR block provided by China Unicom (single ISP)
                /// - **ChinaTelecom**: an IPv6 CIDR block provided by China Telecom (single ISP)
                /// 
                /// >  If your Alibaba Cloud account is allowed to activate single-ISP bandwidth, valid values are: **ChinaTelecom**, **ChinaUnicom**, and **ChinaMobile**.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The vSwitches in the VPC. 
                /// 
                /// You can query up to 300 vSwitches in the VPC. The information about the latest vSwitches is returned. If you want to query the information about all vSwitches in a VPC, call the [DescribeVSwitches](/help/en/virtual-private-cloud/latest/describevswitches) operation.
                /// </summary>
                [NameInMap("DhcpOptionsSetId")]
                [Validation(Required=false)]
                public string DhcpOptionsSetId { get; set; }

                /// <summary>
                /// The value of the tag that is added to the VPC.
                /// </summary>
                [NameInMap("DhcpOptionsSetStatus")]
                [Validation(Required=false)]
                public string DhcpOptionsSetStatus { get; set; }

                /// <summary>
                /// The secondary CIDR blocks of the VPC.
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                [NameInMap("Ipv6CidrBlocks")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocks : TeaModel {
                    [NameInMap("Ipv6CidrBlock")]
                    [Validation(Required=false)]
                    public List<DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
                    public class DescribeVpcsResponseBodyVpcsVpcIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                        [NameInMap("Ipv6CidrBlock")]
                        [Validation(Required=false)]
                        public string Ipv6CidrBlock { get; set; }

                        [NameInMap("Ipv6Isp")]
                        [Validation(Required=false)]
                        public string Ipv6Isp { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the DHCP options set.
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                [NameInMap("NatGatewayIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcNatGatewayIds NatGatewayIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcNatGatewayIds : TeaModel {
                    [NameInMap("NatGatewayIds")]
                    [Validation(Required=false)]
                    public List<string> NatGatewayIds { get; set; }

                }

                /// <summary>
                /// The IPv6 CIDR block of the VPC.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The status of the Cloud Enterprise Network (CEN) instance to which the VPC is attached.
                /// 
                /// **Attached** is returned only if the VPC is attached to a CEN instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The IPv6 CIDR block of the VPC.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("RouterTableIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcRouterTableIds RouterTableIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcRouterTableIds : TeaModel {
                    [NameInMap("RouterTableIds")]
                    [Validation(Required=false)]
                    public List<string> RouterTableIds { get; set; }

                }

                [NameInMap("SecondaryCidrBlocks")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcSecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcSecondaryCidrBlocks : TeaModel {
                    [NameInMap("SecondaryCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> SecondaryCidrBlock { get; set; }

                }

                /// <summary>
                /// The description of the VPC.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The IDs of the NAT gateways.
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
                        /// The IDs of the route tables.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("UserCidrs")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcUserCidrs UserCidrs { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcUserCidrs : TeaModel {
                    [NameInMap("UserCidr")]
                    [Validation(Required=false)]
                    public List<string> UserCidr { get; set; }

                }

                /// <summary>
                /// The key of the tag that is added to the VPC.
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcVSwitchIds VSwitchIds { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

                /// <summary>
                /// The ID of the resource group to which the VPC belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The tag information about the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
