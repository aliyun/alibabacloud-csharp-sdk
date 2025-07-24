// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpcRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the VPC.</para>
        /// <list type="bullet">
        /// <item><description>We recommend using the private IPv4 address specified in RFC 1918 as the primary IPv4 CIDR block of the VPC with a recommended mask length of 16 to 28 bits. For example, 10.0.0.0/16, 172.16.0.0/16, and 192.168.0.0/16.</description></item>
        /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, 169.254.0.0/16, or their subnets as the primary IPv4 CIDR block.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the VPC.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my first Vpc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Whether to enable the DNS hostname feature. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Not enabled. </description></item>
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDnsHostname")]
        [Validation(Required=false)]
        public bool? EnableDnsHostname { get; set; }

        /// <summary>
        /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): disabled.</description></item>
        /// <item><description><b>true</b>: enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIpv6")]
        [Validation(Required=false)]
        public bool? EnableIpv6 { get; set; }

        /// <summary>
        /// <para>Allocate VPC from the IPAM address pool by inputting a mask.</para>
        /// <remarks>
        /// <para>When creating a VPC with a specified IPAM address pool, at least one of the parameters CidrBlock or Ipv4CidrMask must be provided.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Ipv4CidrMask")]
        [Validation(Required=false)]
        public int? Ipv4CidrMask { get; set; }

        /// <summary>
        /// <para>The ID of the IP Address Manager (IPAM) pool of the IPv4 type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipam-pool-sycmt3p2a9v63i****</para>
        /// </summary>
        [NameInMap("Ipv4IpamPoolId")]
        [Validation(Required=false)]
        public string Ipv4IpamPoolId { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the VPC. If you enable IPv6 for a VPC, the system allocates an IPv6 CIDR block. To specify an IPv6 CIDR block, you must call the <a href="https://help.aliyun.com/document_detail/448916.html">AllocateVpcIpv6Cidr</a> operation to reserve the specified IPv6 CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:6a::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        [NameInMap("Ipv6CidrMask")]
        [Validation(Required=false)]
        public int? Ipv6CidrMask { get; set; }

        [NameInMap("Ipv6IpamPoolId")]
        [Validation(Required=false)]
        public string Ipv6IpamPoolId { get; set; }

        /// <summary>
        /// <para>The type of the IPv6 CIDR block of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default)</description></item>
        /// <item><description><b>ChinaMobile</b></description></item>
        /// <item><description><b>ChinaUnicom</b></description></item>
        /// <item><description><b>ChinaTelecom</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you are allowed to use single-ISP bandwidth, you can set the value to <b>ChinaTelecom</b>, <b>ChinaUnicom</b>, or <b>ChinaMobile</b>.</para>
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
        /// <para>The ID of the region to which the VPC belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcRequestTag> Tag { get; set; }
        public class CreateVpcRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be at most 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length, but cannot contain <c>http://</c> or <c>https://</c>. The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The user CIDR block. Separate user CIDR blocks with commas (,). You can specify up to three user CIDR blocks.</para>
        /// <para>For more information about user CIDR blocks, see the <c>What is a user CIDR block?</c> section in <a href="https://help.aliyun.com/document_detail/185311.html">VPC FAQ</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/12</para>
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

        /// <summary>
        /// <para>The name of the VPC.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
