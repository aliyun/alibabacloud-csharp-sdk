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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe6****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating a DNAT entry. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a Normal request. If the check succeeds, a 2xx HTTP status code is returned and the DNAT entry is created.</para>
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
        /// <list type="bullet">
        /// <item><description>If you add a DNAT entry for an Internet NAT gateway, this parameter specifies the elastic IP address (EIP) that provides public network access.</description></item>
        /// <item><description>If you add a DNAT entry for a VPC NAT gateway, this parameter specifies the NAT IP address that provides external network access.</description></item>
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
        /// <item><description><para>If you add a DNAT entry for an Internet NAT gateway, this parameter specifies the external port or port range for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid port values: <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>To specify a port range, separate the start and end ports with a forward slash (/), such as <c>10/20</c>.</description></item>
        /// <item><description>If <b>ExternalPort</b> is set to a port range, <b>InternalPort</b> must also be set to a port range with the same number of ports. For example, if <b>ExternalPort</b> is set to <c>10/20</c>, <b>InternalPort</b> can be set to <c>80/90</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you add a DNAT entry for a VPC NAT gateway, this parameter specifies the port on the NAT IP address that is accessed by the external network. Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <para>The name of the DNAT rule.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description><para>If you add a DNAT entry for an Internet NAT gateway, this parameter specifies the private IP address of the ECS instance that needs to communicate over the Internet. The private IP address must meet the following conditions: </para>
        /// <list type="bullet">
        /// <item><description><para>It must belong to the CIDR block of the VPC in which the NAT gateway resides. </para>
        /// </description></item>
        /// <item><description><para>The DNAT entry takes effect only when the IP address is used by an ECS instance that is not associated with an EIP.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you add a DNAT entry for a VPC NAT gateway, this parameter specifies the private IP address that communicates through the DNAT rule.</para>
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
        /// <item><description><para>If you add a DNAT entry for an Internet NAT gateway, this parameter specifies the internal port or port range for port forwarding. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// <item><description><para>If you add a DNAT entry for a VPC NAT gateway, this parameter specifies the destination port of the ECS instance to which traffic is mapped. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
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
        /// <para>The protocol type. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>TCP</b>: forwards TCP packets.   </para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: forwards UDP packets.   </para>
        /// </description></item>
        /// <item><description><para><b>Any</b>: forwards packets of all protocols. If <b>IpProtocol</b> is set to <b>Any</b>, <b>ExternalPort</b> and <b>InternalPort</b> must also be set to <b>Any</b> to implement DNAT IP mapping.</para>
        /// </description></item>
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
        /// <para>Specifies whether to enable port breaking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables port breaking.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables port breaking.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If a DNAT entry and an SNAT entry use the same public IP address, and you want to configure a port number greater than 1024, set <b>PortBreak</b> to <b>true</b>.</para>
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
