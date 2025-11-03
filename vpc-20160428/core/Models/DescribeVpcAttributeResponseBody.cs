// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Cloud Enterprise Network (CEN) instances to which the VPC is attached.</para>
        /// <para>If the VPC is not attached to a CEN instance, the parameter is not returned.</para>
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
                /// <para>The ID of the CEN instance to which the VPC is attached.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-7qthudw0ll6jmc****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The ID of the account to which the CEN instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>28311773240248****</para>
                /// </summary>
                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                /// <summary>
                /// <para>The status of the CEN instance.</para>
                /// <para><b>Attached</b> is returned only when the VPC is attached to a CEN instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Attached</para>
                /// </summary>
                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The route source associated with the VPC.</para>
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
                /// <para>Indicates whether routes are advertised to the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RoutePropagated")]
                [Validation(Required=false)]
                public bool? RoutePropagated { get; set; }

                /// <summary>
                /// <para>The instance ID of the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-dc4vwznpwbobrl****</para>
                /// </summary>
                [NameInMap("SourceInstanceId")]
                [Validation(Required=false)]
                public string SourceInstanceId { get; set; }

                /// <summary>
                /// <para>The account ID of the source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>153980532164****</para>
                /// </summary>
                [NameInMap("SourceOwnerId")]
                [Validation(Required=false)]
                public long? SourceOwnerId { get; set; }

                /// <summary>
                /// <para>The source type.</para>
                /// <list type="bullet">
                /// <item><description><b>CEN</b></description></item>
                /// <item><description><b>VPN</b></description></item>
                /// <item><description><b>TR</b></description></item>
                /// <item><description><b>ECR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CEN</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The binding status.</para>
                /// <list type="bullet">
                /// <item><description><b>Attaching</b></description></item>
                /// <item><description><b>Attached</b></description></item>
                /// <item><description><b>Detaching</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Attaching</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

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
        /// <para>Indicates whether the ClassicLink feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClassicLinkEnabled")]
        [Validation(Required=false)]
        public bool? ClassicLinkEnabled { get; set; }

        /// <summary>
        /// <para>The list of resources deployed in the VPC.</para>
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
                /// <para>The number of resources in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

                /// <summary>
                /// <para>The type of resource deployed in the VPC. Valid values: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VSwitch</b></description></item>
                /// <item><description><b>VRouter</b></description></item>
                /// <item><description><b>RouteTable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VSwitch</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the VPC was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-16T07:31:09Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The description of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
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

        /// <summary>
        /// <para>Indicates whether DNS hostname is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISABLED</para>
        /// </summary>
        [NameInMap("DnsHostnameStatus")]
        [Validation(Required=false)]
        public string DnsHostnameStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the VPC enables IPv6 .</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledIpv6")]
        [Validation(Required=false)]
        public bool? EnabledIpv6 { get; set; }

        /// <summary>
        /// <para>The ID of the IPv4 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4gw-5tsnc6s4ogsedtp3k****</para>
        /// </summary>
        [NameInMap("Ipv4GatewayId")]
        [Validation(Required=false)]
        public string Ipv4GatewayId { get; set; }

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
        public DescribeVpcAttributeResponseBodyIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
        public class DescribeVpcAttributeResponseBodyIpv6CidrBlocks : TeaModel {
            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
            public class DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                /// <summary>
                /// <para>The IPv6 CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:XXXX:0:6a::/56</para>
                /// </summary>
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

                /// <summary>
                /// <para>The IPv6 CIDR block type of the VPC. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BGP</b> (default)</description></item>
                /// <item><description><b>ChinaMobile</b></description></item>
                /// <item><description><b>ChinaUnicom</b></description></item>
                /// <item><description><b>ChinaTelecom</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> If you are allowed to use single-ISP bandwidth, valid values are <b>ChinaTelecom</b>, <b>ChinaUnicom</b>, and <b>ChinaMobile</b></para>
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
        /// <para>Indicates whether the VPC is the default VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the VPC belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28311773240248****</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7486AE4A-129D-43DB-A714-2432C074BA04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazbvgb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The secondary IPv4 CIDR block of the VPC.</para>
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
        /// <para>The status of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Available</b></description></item>
        /// <item><description><b>Pending</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the VPC supports IPv4 gateways.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportIpv4Gateway")]
        [Validation(Required=false)]
        public bool? SupportIpv4Gateway { get; set; }

        /// <summary>
        /// <para>The information about the tags.</para>
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
                /// <para>The key of tag N.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceDept</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N.</para>
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
        /// <para>The user CIDR block. Multiple CIDR blocks are separated by commas (,). At most three CIDR blocks are returned.</para>
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
        /// <para>The ID of the vRouter that belongs to the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1jso6ng1at0ajsc****</para>
        /// </summary>
        [NameInMap("VRouterId")]
        [Validation(Required=false)]
        public string VRouterId { get; set; }

        /// <summary>
        /// <para>The list of vSwitches deployed in the VPC.</para>
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
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp18sth14qii3pnvo****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The name of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest2</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
