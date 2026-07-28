// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateIpv6InternetBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>The Internet bandwidth of the IPv6 address. Unit: Mbit/s.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByTraffic</b>, the valid values are <b>1</b> to <b>1000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, the valid values are <b>1</b> to <b>2000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByOld95</b>, the valid values are <b>1</b> to <b>2000</b>.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByTraffic</b>, the valid values are <b>1</b> to <b>1000</b>.</description></item>
        /// <item><description>If <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, the valid values are <b>1</b> to <b>2000</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned. The system does not associate a prefix list with a route table.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, a 2xx HTTP status code is returned and the system associates the prefix list with a route table. The system checks whether the AccessKey pair is valid, whether the Resource Access Management (RAM) user has the required authorization, and whether the required parameters are specified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The billable methods of the IPv6 Internet bandwidth. Valid values:</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer.</description></item>
        /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
        /// <item><description><b>PayByOld95</b>: traditional 95th percentile billing. IPv6 Internet bandwidth does not support traditional 95th percentile billing by default. To use this billing method, contact your account manager.</description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b>: pay-by-data-transfer.</description></item>
        /// <item><description><b>PayByBandwidth</b> (default): pay-by-bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6gw-uf6hcyzu65v98v3du****</para>
        /// </summary>
        [NameInMap("Ipv6GatewayId")]
        [Validation(Required=false)]
        public string Ipv6GatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the IPv6 gateway. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
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
