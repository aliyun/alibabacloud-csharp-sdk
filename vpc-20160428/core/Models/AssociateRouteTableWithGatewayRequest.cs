// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateRouteTableWithGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>The client generates the value. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may vary for each API request.</para>
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
        /// <item><description><b>true</b>: performs a dry run without associating the gateway route table with the IPv4 gateway instance. The system checks the required parameters, request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP 2xx status code is returned and the gateway route table is associated with the IPv4 gateway instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the IPv4 gateway to associate.</para>
        /// <para>The IPv4 gateway instance to associate must be in the <b>Activated</b> state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4gw-5tsnc6s4ogsedtp3k****</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The type of the gateway instance to associate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ipv4Gateway</para>
        /// </summary>
        [NameInMap("GatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the gateway route table and IPv4 gateway instance to associate.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-6</para>
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
        /// <para>The ID of the gateway route table to associate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
