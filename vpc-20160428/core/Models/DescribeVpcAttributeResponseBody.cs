// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcAttributeResponseBody : TeaModel {
        /// <summary>
        /// The list of Cloud Enterprise Network (CEN) instances to which the VPC is attached.
        /// 
        /// If the VPC is not attached to a CEN instance, the parameter is not returned.
        /// </summary>
        [NameInMap("AssociatedCens")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyAssociatedCens AssociatedCens { get; set; }
        public class DescribeVpcAttributeResponseBodyAssociatedCens : TeaModel {
            [NameInMap("AssociatedCen")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen> AssociatedCen { get; set; }
            public class DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen : TeaModel {
                /// <summary>
                /// The ID of the CEN instance to which the VPC is attached.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the CEN instance belongs.
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                /// <summary>
                /// The status of the CEN instance to which the VPC is attached.
                /// 
                /// **Attached** is returned only if the VPC is attached to a CEN instance.
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

            }

        }

        /// <summary>
        /// The IPv4 CIDR block of the VPC.
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// Indicates whether the ClassicLink feature is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("ClassicLinkEnabled")]
        [Validation(Required=false)]
        public bool? ClassicLinkEnabled { get; set; }

        /// <summary>
        /// The list of resources deployed in the VPC.
        /// </summary>
        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeVpcAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                /// <summary>
                /// The number of resources deployed in the VPC.
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// The type of resources deployed in the VPC. Valid values:
                /// 
                /// - **VSwitch**: vSwitches
                /// - **VRouter**: vRouters
                /// - **RouteTable**: route tables
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

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
        /// *   **Available**: available
        /// *   **InUse**: in use
        /// *   **Deleted**: deleted
        /// *   **Pending**: being configured
        /// </summary>
        [NameInMap("DhcpOptionsSetStatus")]
        [Validation(Required=false)]
        public string DhcpOptionsSetStatus { get; set; }

        /// <summary>
        /// The ID of the IPv4 gateway.
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

        /// <summary>
        /// The IPv6 CIDR block of the VPC.
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// The information about the IPv6 CIDR blocks of the VPC.
        /// </summary>
        [NameInMap("Ipv6CidrBlocks")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
        public class DescribeVpcAttributeResponseBodyIpv6CidrBlocks : TeaModel {
            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
            public class DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                /// <summary>
                /// The IPv6 CIDR block of the VPC.
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                /// <summary>
                /// The type of the IPv6 CIDR block. Valid values:
                /// 
                /// - **BGP** (default): an IPv6 CIDR block provided by Alibaba Cloud over Border Gateway Protocol (BGP)
                /// - **ChinaMobile**: an IPv6 CIDR block provided by China Mobile (single ISP)
                /// - **ChinaUnicom**: an IPv6 CIDR block provided by China Unicom (single ISP)
                /// - **ChinaTelecom**: an IPv6 CIDR block provided by China Telecom (single ISP)
                /// 
                /// >  If your Alibaba Cloud account is allowed to activate single-ISP bandwidth, valid values are: **ChinaTelecom**, **ChinaUnicom**, and **ChinaMobile**.
                /// </summary>
                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the VPC is the default VPC. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the VPC belongs.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the VPC.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The secondary IPv4 CIDR block of the VPC.
        /// </summary>
        [NameInMap("SecondaryCidrBlocks")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodySecondaryCidrBlocks SecondaryCidrBlocks { get; set; }
        public class DescribeVpcAttributeResponseBodySecondaryCidrBlocks : TeaModel {
            [NameInMap("SecondaryCidrBlock")]
            [Validation(Required=false)]
            public List<string> SecondaryCidrBlock { get; set; }

        }

        /// <summary>
        /// The status of the VPC. Valid values:
        /// 
        /// *   **Available**: available
        /// *   **Pending**: being configured
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the VPC supports IPv4 gateways. 
        /// 
        /// - **true**: yes
        /// - **false**: no
        /// </summary>
        [NameInMap("SupportIpv4Gateway")]
        [Validation(Required=false)]
        public bool? SupportIpv4Gateway { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyTags Tags { get; set; }
        public class DescribeVpcAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpcAttributeResponseBodyTagsTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The user CIDR block. Multiple CIDR blocks are separated by commas (,). At most three CIDR blocks are returned.
        /// </summary>
        [NameInMap("UserCidrs")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyUserCidrs UserCidrs { get; set; }
        public class DescribeVpcAttributeResponseBodyUserCidrs : TeaModel {
            [NameInMap("UserCidr")]
            [Validation(Required=false)]
            public List<string> UserCidr { get; set; }

        }

        /// <summary>
        /// The ID of the vRouter that belongs to the VPC.
        /// </summary>
        [NameInMap("VRouterId")]
        [Validation(Required=false)]
        public string VRouterId { get; set; }

        /// <summary>
        /// The list of vSwitches deployed in the VPC.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyVSwitchIds VSwitchIds { get; set; }
        public class DescribeVpcAttributeResponseBodyVSwitchIds : TeaModel {
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public List<string> VSwitchId { get; set; }

        }

        /// <summary>
        /// The ID of the VPC.
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
