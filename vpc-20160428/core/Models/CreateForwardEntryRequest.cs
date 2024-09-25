// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateForwardEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe6****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The EIP that can be accessed over the Internet when you configure a DNAT entry for an Internet NAT gateway.</description></item>
        /// <item><description>The NAT IP address that can be accessed by external networks when you configure a DNAT entry for a VPC NAT gateway.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.28.XX.XX</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The external port range that is used for port forwarding when you configure a DNAT entry for an Internet NAT gateway.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), for example, <c>10/20</c>.</description></item>
        /// <item><description>If you set <b>ExternalPort</b> to a port range, you must also set <b>InternalPort</b> to a port range, and the number of ports specified by these parameters must be the same. For example, if you set <b>ExternalPort</b> to <c>10/20</c>, you can set <b>InternalPort</b> to <c>80/90</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The port that can be accessed by external networks when you configure a DNAT entry for a VPC NAT gateway. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The name of the DNAT entry.</para>
        /// <para>The name must be 2 to 128 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ForwardEntry-1</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ftb-bp1mbjubq34hlcqpa****</para>
        /// </summary>
        [NameInMap("ForwardTableId")]
        [Validation(Required=false)]
        public string ForwardTableId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>The private IP address of the ECS instance that needs to communicate with the Internet when you configure a DNAT entry for an Internet NAT gateway. The private IP address must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>It must belong to the CIDR block of the VPC where the NAT gateway is deployed.</description></item>
        /// <item><description>The DNAT entry takes effect only if the private IP address is assigned to an ECS instance and the ECS instance is not associated with an EIP.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The private IP address that uses DNAT when you add a DNAT entry to a VPC NAT gateway.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The internal port or port range that is used for port forwarding when you configure a DNAT entry for an Internet NAT gateway. Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>The port of the destination ECS instance to be mapped when you configure a DNAT entry for a VPC NAT gateway. Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>Any</b> If you set <b>IpProtocol</b> to <b>Any</b>, you must also set <b>ExternalPort</b> and <b>InternalPort</b> to <b>Any</b> to implement DNAT IP mapping.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove limits on the port range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> If a DNAT entry and an SNAT entry have the same public IP address, ou must specify a port that is larger that 1024, and set <b>PortBreak</b> to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PortBreak")]
        [Validation(Required=false)]
        public bool? PortBreak { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
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
