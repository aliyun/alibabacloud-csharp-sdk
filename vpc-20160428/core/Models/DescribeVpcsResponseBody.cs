// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeVpcsResponseBodyVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeVpcsResponseBodyVpcsVpc : TeaModel {
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DhcpOptionsSetId")]
                [Validation(Required=false)]
                public string DhcpOptionsSetId { get; set; }

                [NameInMap("DhcpOptionsSetStatus")]
                [Validation(Required=false)]
                public string DhcpOptionsSetStatus { get; set; }

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

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVpcsResponseBodyVpcsVpcTags Tags { get; set; }
                public class DescribeVpcsResponseBodyVpcsVpcTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVpcsResponseBodyVpcsVpcTagsTag> Tag { get; set; }
                    public class DescribeVpcsResponseBodyVpcsVpcTagsTag : TeaModel {
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

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
