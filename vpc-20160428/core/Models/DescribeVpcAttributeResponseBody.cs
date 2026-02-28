// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpcAttributeResponseBody : TeaModel {
        [NameInMap("AssociatedCens")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyAssociatedCens AssociatedCens { get; set; }
        public class DescribeVpcAttributeResponseBodyAssociatedCens : TeaModel {
            [NameInMap("AssociatedCen")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen> AssociatedCen { get; set; }
            public class DescribeVpcAttributeResponseBodyAssociatedCensAssociatedCen : TeaModel {
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CenOwnerId")]
                [Validation(Required=false)]
                public long? CenOwnerId { get; set; }

                [NameInMap("CenStatus")]
                [Validation(Required=false)]
                public string CenStatus { get; set; }

            }

        }

        [NameInMap("AssociatedPropagationSources")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyAssociatedPropagationSources AssociatedPropagationSources { get; set; }
        public class DescribeVpcAttributeResponseBodyAssociatedPropagationSources : TeaModel {
            [NameInMap("AssociatedPropagationSources")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyAssociatedPropagationSourcesAssociatedPropagationSources> AssociatedPropagationSources { get; set; }
            public class DescribeVpcAttributeResponseBodyAssociatedPropagationSourcesAssociatedPropagationSources : TeaModel {
                [NameInMap("RoutePropagated")]
                [Validation(Required=false)]
                public bool? RoutePropagated { get; set; }

                [NameInMap("SourceInstanceId")]
                [Validation(Required=false)]
                public string SourceInstanceId { get; set; }

                [NameInMap("SourceOwnerId")]
                [Validation(Required=false)]
                public long? SourceOwnerId { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

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

        /// <term><b>Obsolete</b></term>
        /// 
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
        [Obsolete]
        public bool? ClassicLinkEnabled { get; set; }

        [NameInMap("CloudResources")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyCloudResources CloudResources { get; set; }
        public class DescribeVpcAttributeResponseBodyCloudResources : TeaModel {
            [NameInMap("CloudResourceSetType")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType> CloudResourceSetType { get; set; }
            public class DescribeVpcAttributeResponseBodyCloudResourcesCloudResourceSetType : TeaModel {
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public int? ResourceCount { get; set; }

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

        [NameInMap("Ipv6CidrBlocks")]
        [Validation(Required=false)]
        public DescribeVpcAttributeResponseBodyIpv6CidrBlocks Ipv6CidrBlocks { get; set; }
        public class DescribeVpcAttributeResponseBodyIpv6CidrBlocks : TeaModel {
            [NameInMap("Ipv6CidrBlock")]
            [Validation(Required=false)]
            public List<DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock> Ipv6CidrBlock { get; set; }
            public class DescribeVpcAttributeResponseBodyIpv6CidrBlocksIpv6CidrBlock : TeaModel {
                [NameInMap("Ipv6CidrBlock")]
                [Validation(Required=false)]
                public string Ipv6CidrBlock { get; set; }

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
