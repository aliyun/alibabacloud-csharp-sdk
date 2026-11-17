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
        /// <item><description><b>aliyun</b> (default): The IPv6 CIDR block is allocated by the system.</description></item>
        /// <item><description><b>custom</b>: The IPv6 CIDR block is customized by the user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("AddressPoolType")]
        [Validation(Required=false)]
        public string AddressPoolType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IPv6 CIDR block to be reserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2408:XXXX:0:a600::/56</para>
        /// </summary>
        [NameInMap("Ipv6CidrBlock")]
        [Validation(Required=false)]
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// <para>The ISP type of the IPv6 CIDR block for the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP).</description></item>
        /// <item><description><b>BGP_International</b>: BGP (Multi-ISP) International.</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile (single ISP).</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single ISP).</description></item>
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single ISP).</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile (single ISP) L2.</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom (single ISP) L2.</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom (single ISP) L2.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If your account is added to the corresponding whitelist, you can set this parameter to <b>ChinaTelecom</b> (China Telecom), <b>ChinaUnicom</b> (China Unicom), <b>ChinaMobile</b> (China Mobile), <b>ChinaTelecom_L2</b> (China Telecom L2), <b>ChinaUnicom_L2</b> (China Unicom L2), <b>ChinaMobile_L2</b> (China Mobile L2), or <b>BGP_International</b> (BGP Multi-ISP International).</description></item>
        /// <item><description>You can reserve only one IPv6 CIDR block of each ISP type. You can reserve the next IPv6 CIDR block only after the current one is allocated to a VPC.</description></item>
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
        /// <para>The ID of the region where the VPC is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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
