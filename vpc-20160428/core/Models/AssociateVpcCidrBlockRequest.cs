// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// <para>The IPv6 CIDR block to be added.</para>
        /// <remarks>
        /// <para> You must and can specify only one of <b>SecondaryCidrBlock</b> and <b>Ipv6CidrBlock</b>.</para>
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
        /// <item><description><b>IPV4</b>: the IPv4 address.</description></item>
        /// <item><description><b>IPV6</b>: the IPv6 address. If you set <b>IpVersion</b> to <b>IPV6</b> and do not specify <b>SecondaryCidrBlock</b>, you can add a secondary IPv6 CIDR block to the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The ID of the IP Address Manager (IPAM) pool that contains IPv4 addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-pool-sycmt3p2a9v63i****</para>
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// <para>The type of the IPv6 CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default)</description></item>
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

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which you want to add a secondary CIDR block.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The IPv4 CIDR block to be added. Take note of the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>You can specify one of the following standard IPv4 CIDR blocks or their subnets as the secondary IPv4 CIDR block of the VPC: 192.168.0.0/16, 172.16.0.0/12, and 10.0.0.0/8.</description></item>
        /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, or their subnets as the secondary IPv4 CIDR block of the VPC.</description></item>
        /// </list>
        /// <para>The CIDR block must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The CIDR block cannot start with 0. The subnet mask must be 8 to 28 bits in length.</description></item>
        /// <item><description>The CIDR block cannot overlap with the primary CIDR block or an existing secondary CIDR block of the VPC.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must and can specify only one of <b>SecondaryCidrBlock</b> and <b>Ipv6CidrBlock</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/16</para>
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

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
