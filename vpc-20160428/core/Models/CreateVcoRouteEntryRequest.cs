// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVcoRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-4266****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the destination route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters, request syntax, and business restrictions. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The next hop of the destination route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-p0w2jpkhi2eeop6q6****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The tunneling protocol. Set the value to <b>Ipsec</b> (default), which specifies the IPsec tunneling protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ipsec</para>
        /// </summary>
        [NameInMap("OverlayMode")]
        [Validation(Required=false)]
        public string OverlayMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// <para>The region ID of the IPsec-VPN connection.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
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

        /// <summary>
        /// <para>The destination CIDR block of the destination route entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("RouteDest")]
        [Validation(Required=false)]
        public string RouteDest { get; set; }

        /// <summary>
        /// <para>The ID of the IPsec-VPN connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vco-p0w2jpkhi2eeop6q6****</para>
        /// </summary>
        [NameInMap("VpnConnectionId")]
        [Validation(Required=false)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// <para>The weight of the destination route entry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: low priority.</description></item>
        /// <item><description><b>100</b>: high priority.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
