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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
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
        /// <para>The description must be 2 to 256 characters in length, and must start with a letter or a Chinese character. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the route in the gateway route table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX/16</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run and does not modify the gateway route table. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the gateway route table is modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("GatewayRouteTableId")]
        [Validation(Required=false)]
        public string GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway route table to be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-5ts0ohchwkp3dydt2****</para>
        /// </summary>
        [NameInMap("IPv4GatewayRouteTableId")]
        [Validation(Required=false)]
        public string IPv4GatewayRouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the gateway route table.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The instance ID of the next hop to be modified.</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextHopType</b> is set to <b>Instance</b>, <b>NextHopId</b> is the ID of the ECS instance.</description></item>
        /// <item><description>If <b>NextHopType</b> is set to <b>NetworkInterface</b>, <b>NextHopId</b> is the ID of the elastic network interface controller (NIC).</description></item>
        /// <item><description>If <b>NextHopType</b> is set to <b>Local</b>, <b>NextHopId</b> is empty, which indicates local.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the next hop type of the routing entry is <b>Instance</b> or <b>NetworkInterface</b> and you want to modify the next hop, you must first change <b>NextHopType</b> to <b>Local</b>, and then change <b>NextHopType</b> back to <b>Instance</b> or <b>NetworkInterface</b> before modifying the specific <b>NextHopId</b>. You cannot directly change the next hop from an elastic network interface controller (NIC) or an ECS instance to another elastic network interface controller (NIC) or ECS instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18xq9yguxoxe7m****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The next hop type of the routing entry to be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b>: an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>NetworkInterface</b>: an elastic network interface controller (NIC).</para>
        /// </description></item>
        /// <item><description><para><b>Local</b>: local.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
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
        /// <para>The region ID of the gateway route table to be modified.</para>
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

    }

}
