// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyVpcAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The new IPv4 CIDR block of the VPC.</para>
        /// <para>You can expand or shrink the CIDR block within the original IPv4 CIDR block of the VPC. The recommended subnet mask is 16 to 28 bits. If you shrink the IPv4 CIDR block of the VPC and IP addresses that are already in use fall outside the target CIDR block, the modification fails.</para>
        /// <remarks>
        /// <para>Modifying the IPv4 CIDR block of a VPC does not affect existing services.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The new description of the VPC.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my VPC.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the DNS hostname feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Disabled.</description></item>
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
        /// <para>Specifies whether to enable IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Disabled.</description></item>
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block of the VPC.
        /// When you enable IPv6 for a VPC, the system will assign an IPv6 CIDR block. To specify an IPv6 CIDR block, invoke the <a href="https://help.aliyun.com/document_detail/448916.html">AllocateVpcIpv6Cidr</a> operation to reserve a specific IPv6 CIDR block first, and then pass it in.</para>
        /// <remarks>
        /// <para>For a VPC that already has IPv6 enabled, you cannot modify the IPv6 CIDR block by passing in this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:6a::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The type of the IPv6 CIDR block of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): Alibaba Cloud BGP IPv6.</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (single ISP).</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single ISP).</description></item>
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single ISP).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are a user who has the single-ISP bandwidth whitelist enabled, you can set this parameter to <b>ChinaTelecom</b> (China Telecom), <b>ChinaUnicom</b> (China Unicom), or <b>ChinaMobile</b> (China Mobile).</para>
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
        /// <para>The region ID of the VPC.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The ID of the VPC that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1qtbach57ywecf****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The new name of the VPC.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc-1</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

    }

}
