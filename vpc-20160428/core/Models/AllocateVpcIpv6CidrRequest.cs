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
        /// <item><description><b>aliyun</b> (default): The system assigns an IPv6 CIDR block.</description></item>
        /// <item><description><b>custom</b>: A user-defined IPv6 CIDR block.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block to reserve.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The type of the IPv6 CIDR block of the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (multi-ISP).</description></item>
        /// <item><description><b>BGP_International</b>: BGP (multi-ISP)_International.</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (single-ISP).</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single-ISP).</description></item>
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single-ISP).</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile (single-ISP)_L2.</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom (single-ISP)_L2.</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom (single-ISP)_L2.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you are a user whose whitelist is activated, you can set this parameter to <b>ChinaTelecom</b> (China Telecom), <b>ChinaUnicom</b> (China Unicom), <b>ChinaMobile</b> (China Mobile), <b>ChinaTelecom_L2</b> (China L2 Telecom), <b>ChinaUnicom_L2</b> (China L2 Unicom), <b>ChinaMobile_L2</b> (China L2 Mobile), or <b>BGP_International</b> (BGP multi-ISP International).</description></item>
        /// <item><description>You can reserve only one IPv6 CIDR block of each type. You can reserve the next one only after the current one is assigned to a VPC.</description></item>
        /// </list>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
