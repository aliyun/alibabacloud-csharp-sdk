// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyIpv6InternetBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>The Internet bandwidth value of the IPv6 address. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method is pay-by-data-transfer, valid values are <b>1</b> to <b>1000</b>.</description></item>
        /// <item><description>If the billing method is pay-by-bandwidth, valid values are <b>1</b> to <b>2000</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

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
        /// <para>Specifies whether to perform a dry run, without sending the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: pre-checks the request but does not create the IPv4 gateway. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the API request. After the request passes the check, an HTTP 2xx status code is returned and the IPv4 gateway is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the IPv6 address.</para>
        /// <remarks>
        /// <para> You must specify one of <b>Ipv6AddressId</b> and <b>Ipv6InternetBandwidthId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
        /// </summary>
        [NameInMap("Ipv6AddressId")]
        [Validation(Required=false)]
        public string Ipv6AddressId { get; set; }

        /// <summary>
        /// <para>The instance ID of the Internet bandwidth of the IPv6 address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6bw-uf6hcyzu65v98v3du****</para>
        /// </summary>
        [NameInMap("Ipv6InternetBandwidthId")]
        [Validation(Required=false)]
        public string Ipv6InternetBandwidthId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the IPv6 gateway is deployed. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
