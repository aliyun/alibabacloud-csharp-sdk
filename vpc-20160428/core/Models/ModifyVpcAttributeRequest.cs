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
        /// <para>You can specify a larger or smaller IPv4 CIDR block than the IPv4 CIDR block of the VPC. The subnet mask must be 8 to 28 bits in length. If you specify a smaller IPv4 CIDR block and existing IP addresses do not fall within the CIDR block, the modification fails.</para>
        /// <remarks>
        /// <para> If you modify the CIDR block of a VPC, your existing services are not affected.</para>
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
        /// <para>The description must be 1 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my VPC.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableDnsHostname")]
        [Validation(Required=false)]
        public bool? EnableDnsHostname { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6 CIDR blocks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableIPv6")]
        [Validation(Required=false)]
        public bool? EnableIPv6 { get; set; }

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
        /// <para>The type of IPv6 CIDR block. Valid values:</para>
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
