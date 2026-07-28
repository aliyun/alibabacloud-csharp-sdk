// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeForwardTableEntriesRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you query DNAT entries of an Internet NAT gateway, this parameter specifies the elastic IP address (EIP) that provides public network access in the DNAT entry.</para>
        /// </description></item>
        /// <item><description><para>If you query DNAT entries of a VPC NAT gateway, this parameter specifies the NAT IP address that is accessed by external networks.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>116.28.XX.XX</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you query DNAT entries of an Internet NAT gateway, this parameter specifies the external port or port range used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be within <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>To query a port range, separate the start and end ports with a forward slash (/), such as <c>10/20</c>.</description></item>
        /// <item><description>If <b>ExternalPort</b> is set to a port range, <b>InternalPort</b> must also be set to a port range with the same number of ports. For example, if <b>ExternalPort</b> is set to <c>10/20</c>, <b>InternalPort</b> must be set to <c>80/90</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you query DNAT entries of a VPC NAT gateway, this parameter specifies the port on the NAT IP address that is accessed by external networks. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-8vbn3bc8roygjp0gy****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The name of the DNAT entry.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ForwardEntry-1</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT table. </para>
        /// <remarks>
        /// <para>You must specify at least one of <b>ForwardTableId</b> and <b>NatGatewayId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ftb-bp1mbjubq34hlcqpa****</para>
        /// </summary>
        [NameInMap("ForwardTableId")]
        [Validation(Required=false)]
        public string ForwardTableId { get; set; }

        /// <summary>
        /// <para>The private IP address.</para>
        /// <list type="bullet">
        /// <item><description><para>If you query DNAT entries of an Internet NAT gateway, this parameter specifies the private IP address of the ECS instance that communicates with the Internet through the DNAT entry.</para>
        /// </description></item>
        /// <item><description><para>If you query DNAT entries of a VPC NAT gateway, this parameter specifies the private IP address that needs to communicate through the DNAT rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you query DNAT entries of an Internet NAT gateway, this parameter specifies the internal port or port range used for port forwarding. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// <item><description><para>If you query DNAT entries of a VPC NAT gateway, this parameter specifies the port of the destination ECS instance to be mapped. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tcp</b>: forwards TCP packets.</para>
        /// </description></item>
        /// <item><description><para><b>udp</b>: forwards UDP packets.</para>
        /// </description></item>
        /// <item><description><para><b>any</b>: forwards packets of all protocols.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway to query.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>ForwardTableId</b> and <b>NatGatewayId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the list. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
