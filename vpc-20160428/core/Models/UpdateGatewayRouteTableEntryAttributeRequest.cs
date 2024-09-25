// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UpdateGatewayRouteTableEntryAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>The description of the gateway route table.</para>
        /// <para>The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route entry in the gateway route table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX/16</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to precheck only this request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without modifying the gateway route table. The system checks the required parameters, request format, and service limits. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: sends the request. This is the default value. If the request passes the precheck, a 2xx HTTP status code is returned and the gateway route table is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("GatewayRouteTableId")]
        [Validation(Required=false)]
        public string GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table that you want to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("IPv4GatewayRouteTableId")]
        [Validation(Required=false)]
        public string IPv4GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the gateway route table.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain letter, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The new next hop ID of the route entry.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>NextHopType</b> to <b>Instance</b>, specify an ECS instance ID for <b>NextHopId</b>.</description></item>
        /// <item><description>If you set <b>NextHopType</b> to <b>NetworkInterface</b>, specify an ENI ID for <b>NextHopId</b>.</description></item>
        /// <item><description>If you set <b>NextHopType</b> to <b>Local</b>, leave <b>NextHopId</b> empty. This indicates a local next hop.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the value of NextHopType is <b>Instance</b> or <b>NetworkInterface</b>, and you want to modify the next hop, you must set <b>NextHopType</b> to <b>Local</b> first. Then, set <b>NextHopType</b> to <b>Instance</b> or <b>NetworkInterface</b> and specify <b>NextHopId</b> based on your requirements. If the next hop type of a route entry is Instance or NetworkInterface, you cannot directly specify a different ENI ID or ECS instance ID for the NextHopId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18xq9yguxoxe7m****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The new next hop type of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI)</description></item>
        /// <item><description><b>Local</b>: local next hop</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EcsInstance</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the gateway route table that you want to modify belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
