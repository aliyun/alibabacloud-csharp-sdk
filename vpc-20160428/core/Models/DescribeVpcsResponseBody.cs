// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The details about the VPC.
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
                /// The status of the Cloud Enterprise Network (CEN) instance to which the VPC is attached. **Attached** is returned only if the VPC is attached to a CEN instance.
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

                /// <summary>
                /// The IPv4 CIDR block of the VPC.
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// The time when the VPC was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description of the VPC.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the DHCP options set.
                /// </summary>
                [NameInMap("DhcpOptionsSetId")]
                [Validation(Required=false)]
                public string DhcpOptionsSetId { get; set; }

                /// <summary>
                /// The status of the DHCP options set. Valid values:
                /// 
                /// *   **Available**
                /// *   **InUse**
                /// *   **Deleted**
                /// *   **Pending**
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
                /// The IPv6 CIDR block of the VPC.
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                /// <summary>
                /// The IPv6 CIDR block of the VPC.
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
                        /// The IPv6 CIDR block of the VPC.
                        /// </summary>
                        [NameInMap("Ipv6CidrBlock")]
                        [Validation(Required=false)]
                        public string Ipv6CidrBlock { get; set; }

                        /// <summary>
                        /// The type of IPv6 CIDR block. Valid values:
                        /// 
                        /// *   **BGP**
                        /// *   **ChinaMobile**
                        /// *   **ChinaUnicom**
                        /// *   **ChinaTelecom**
                        /// 
                        /// >  If your Alibaba Cloud account is allowed to activate single-ISP bandwidth, you can set this parameter to **ChinaTelecom**, **ChinaUnicom**, or **ChinaMobile**.
                        /// </summary>
                        [NameInMap("Ipv6Isp")]
                        [Validation(Required=false)]
                        public string Ipv6Isp { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the VPC is the default VPC in the region. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// The ID of the Internet NAT gateway.
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
                /// The ID of the Alibaba Cloud account to which the VPC belongs.
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                /// <summary>
                /// The ID of the region to which the VPC belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the VPC belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The information about the route table.
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
                /// The information about the secondary CIDR block.
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
                /// The status of the VPC. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag information about the VPC.
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
                        /// The key of tag N.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The list of user CIDR blocks.
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
                /// The ID of the vRouter.
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// The vSwitches in the VPC.
                /// 
                /// You can query up to 300 vSwitches in the VPC. The information about the latest vSwitches is returned. If you want to query the information about all vSwitches in a VPC, call the [DescribeVSwitches](https://help.aliyun.com/document_detail/35748.html) operation.
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
                /// The VPC ID.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The name of the VPC.
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
