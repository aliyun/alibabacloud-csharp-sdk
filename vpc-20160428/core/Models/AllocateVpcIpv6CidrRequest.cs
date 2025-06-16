// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateVpcIpv6CidrRequest : TeaModel {
        /// <summary>
        /// <para>The type of the IPv6 address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>aliyun</b> (default): IPv6 CIDR block is allocated by the system.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: custom IPv6 CIDR block.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
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
        /// <para>The IPv6 CIDR block that you want to reserve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The type of IPv6 CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP)</description></item>
        /// <item><description><b>BGP_International</b>: BGP (Multi-ISP) International</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (Single-ISP)</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (Single-ISP)</description></item>
        /// <item><description><b>ChinaTelecom</b>: China Telecom (Single-ISP)</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile (Single-ISP)_L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom (Single-ISP)_L2</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom (Single-ISP)_L2<remarks>
        /// <list type="bullet">
        /// <item><description>If your account is included in the whitelist, you can set this parameter to one of the following values: <b>ChinaTelecom</b>, <b>ChinaUnicom</b>, <b>ChinaMobile</b>, <b>ChinaTelecom_L2</b>, <b>ChinaUnicom_L2</b>, <b>ChinaMobile_L2</b>, and <b>BGP_International</b>.</description></item>
        /// <item><description>You can reserve only one IPv6 CIDR block of each type. You can reserve another IPv6 CIDR block only after the existing one is allocated to a VPC.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>This parameter is required.</para>
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

    }

}
