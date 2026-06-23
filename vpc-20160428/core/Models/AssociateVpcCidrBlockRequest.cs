// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The specified IPv6 CIDR block of the VPC.</para>
        /// <remarks>
        /// <para>You cannot specify both <b>SecondaryCidrBlock</b> and <b>Ipv6CidrBlock</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:6a::/56</para>
        /// </summary>
        [NameInMap("IPv6CidrBlock")]
        [Validation(Required=false)]
        public string IPv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The version of the IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPV4</b>: IPv4 address.</description></item>
        /// <item><description><b>IPV6</b>: IPv6 address. When <b>IpVersion</b> is set to <b>IPV6</b> and <b>SecondaryCidrBlock</b> is not specified, a secondary IPv6 CIDR block is added to the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPAM pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-pool-sycmt3p2a9v63i****</para>
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// <para>The subnet mask used to add an IPv6 CIDR block from an IPAM pool to the VPC.</para>
        /// <remarks>
        /// <para>When you use an IPAM pool to add a secondary IPv6 CIDR block to the VPC, you must specify at least one of IPv6CidrBlock and Ipv6CidrMask.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("Ipv6CidrMask")]
        [Validation(Required=false)]
        public int? Ipv6CidrMask { get; set; }

        /// <summary>
        /// <para>The type of the IPv6 CIDR block of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): Alibaba Cloud BGP IPv6.</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (single ISP).</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single ISP).</description></item>
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single ISP).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If your account is included in the China single-ISP bandwidth whitelist, you can set this parameter to <b>ChinaTelecom</b> (China Telecom), <b>ChinaUnicom</b> (China Unicom), or <b>ChinaMobile</b> (China Mobile).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Ipv6Isp")]
        [Validation(Required=false)]
        public string Ipv6Isp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which you want to add a secondary CIDR block. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ch-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The secondary IPv4 CIDR block to add. The CIDR block must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Use a private IPv4 address specified in RFC 1918 as the secondary IPv4 CIDR block of the VPC. The subnet mask is recommended to be 16 to 28 bits in length. Examples: 10.0.0.0/16, 172.16.0.0/16, and 192.168.0.0/16.</description></item>
        /// <item><description>You can use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, or their subnets as the secondary IPv4 CIDR block of the virtual private cloud (VPC).</description></item>
        /// </list>
        /// <para>Configuration limits:</para>
        /// <list type="bullet">
        /// <item><description><para>The CIDR block cannot start with 0. The subnet mask is recommended to be 16 to 28 bits in length.</para>
        /// </description></item>
        /// <item><description><para>The secondary CIDR block cannot overlap with the primary CIDR block or existing secondary CIDR blocks of the VPC.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not use an IPAM pool to add a secondary CIDR block to the VPC, you must specify either the <b>SecondaryCidrBlock</b> parameter or the <b>Ipv6CidrBlock</b> parameter, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        /// <summary>
        /// <para>The subnet mask used to add a secondary IPv4 CIDR block from an IPAM pool to the VPC.</para>
        /// <remarks>
        /// <para>When you use an IPAM pool to add a secondary IPv4 CIDR block to the VPC, you must specify at least one of SecondaryCidrBlock and SecondaryCidrMask.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("SecondaryCidrMask")]
        [Validation(Required=false)]
        public int? SecondaryCidrMask { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which you want to add a secondary CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-o6wrloqsdqc9io3mg****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
