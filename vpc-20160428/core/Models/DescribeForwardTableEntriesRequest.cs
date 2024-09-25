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
        /// <item><description>The elastic IP addresses (EIPs) that can be accessed over the Internet when you query DNAT entries of Internet NAT gateways.</description></item>
        /// <item><description>The NAT IP addresses that can be accessed by external networks when you query DNAT entries of Virtual Private Cloud (VPC) NAT gateways.</description></item>
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
        /// <item><description><para>The external port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>If you want to query a port range, separate the first port and last port with a forward slash (/), such as <c>10/20</c>.</description></item>
        /// <item><description>If you set <b>ExternalPort</b> to a port range, you must also set <b>InternalPort</b> to a port range, and the number of ports specified by these parameters must be the same. For example, if you set <b>ExternalPort</b> to <c>10/20</c>, you can set <b>InternalPort</b> to <c>80/90</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The port that is used when the NAT IP address can be accessed by external networks when you query DNAT entries of VPC NAT gateways. Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <para>The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ForwardEntry-1</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT table.</para>
        /// <para>**</para>
        /// <para><b>Description</b> You must specify at least one of <b>ForwardTableId</b> and <b>NatGatewayId</b>.</para>
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
        /// <item><description>The private IP address of the ECS instance that uses DNAT entries to communicate with the Internet when you query DNAT entries of Internet NAT gateways.</description></item>
        /// <item><description>The private IP address that uses DNAT entries for communication when you query DNAT entries of VPC NAT gateways.</description></item>
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
        /// <item><description>The internal port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways. Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>The port of the destination ECS instance to be mapped when you query DNAT entries of VPC NAT gateways. Valid values: <b>1</b> to <b>65535</b>.</description></item>
        /// </list>
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
        /// <item><description><b>Any</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>**</para>
        /// <para><b>Description</b> You must specify at least one of <b>ForwardTableId</b> and <b>NatGatewayId</b>.</para>
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
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to create the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
