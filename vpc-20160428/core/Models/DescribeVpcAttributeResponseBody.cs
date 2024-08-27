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
                /// The ID of the account to which the CEN instance belongs.
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                /// <summary>
                /// The status of the CEN instance.
                /// 
                /// **Attached** is returned only when the VPC is attached to a CEN instance.
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

            }

        }

        /// <summary>
        /// The route source associated with the VPC.
        /// </summary>
        [NameInMap("AssociatedPropagationSources")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyAssociatedPropagationSources AssociatedPropagationSources { get; set; }
        public class DescribeVpcAttributeResponseBodyAssociatedPropagationSources : TeaModel {
            [NameInMap("AssociatedPropagationSources")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyAssociatedPropagationSourcesAssociatedPropagationSources> AssociatedPropagationSources { get; set; }
            public class DescribeVpcAttributeResponseBodyAssociatedPropagationSourcesAssociatedPropagationSources : TeaModel {
                /// <summary>
                /// Indicates whether routes are advertised to the VPC.
                /// </summary>
                [NameInMap("RoutePropagated")]
                [Validation(Required=false)]
                public bool? RoutePropagated { get; set; }

                /// <summary>
                /// The instance ID of the source.
                /// </summary>
                [NameInMap("SourceInstanceId")]
                [Validation(Required=false)]
                public string SourceInstanceId { get; set; }

                /// <summary>
                /// The account ID of the source.
                /// </summary>
                [NameInMap("SourceOwnerId")]
                [Validation(Required=false)]
                public long? SourceOwnerId { get; set; }

                /// <summary>
                /// The source type.
                /// 
                /// *   **CEN**
                /// *   **VPN**
                /// *   **TR**
                /// *   **ECR**
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// The binding status.
                /// 
                /// *   **Attaching**
                /// *   **Attached**
                /// *   **Detaching**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        /// *   **true**
        /// *   **false** (default)
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
                /// The number of resources in the VPC.
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// The type of resource deployed in the VPC. Valid values: Valid values:
                /// 
                /// *   **VSwitch**
                /// *   **VRouter**
                /// *   **RouteTable**
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

        /// <summary>
        /// Indicates whether the VPC enables IPv6 .
        /// - true
        /// - false
        /// </summary>
        [NameInMap("EnabledIpv6")]
        [Validation(Required=false)]
        public bool? EnabledIpv6 { get; set; }

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
        /// The IPv6 CIDR block of the VPC.
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
                /// The IPv6 CIDR block type of the VPC. Valid values:
                /// 
                /// *   **BGP** (default)
                /// *   **ChinaMobile**
                /// *   **ChinaUnicom**
                /// *   **ChinaTelecom**
                /// 
                /// >  If you are allowed to use single-ISP bandwidth, valid values are **ChinaTelecom**, **ChinaUnicom**, and **ChinaMobile**
                /// </summary>
                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the VPC is the default VPC. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
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
        /// The ID of the region to which the VPC belongs.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
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
        /// *   **Available**
        /// *   **Pending**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the VPC supports IPv4 gateways.
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("SupportIpv4Gateway")]
        [Validation(Required=false)]
        public bool? SupportIpv4Gateway { get; set; }

        /// <summary>
        /// The information about the tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyTags Tags { get; set; }
        public class DescribeVpcAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeVpcAttributeResponseBodyTagsTag : TeaModel {
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
