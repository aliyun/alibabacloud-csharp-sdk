// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyForwardEntryRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
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
        /// <item><description><b>true</b>: performs a dry run without modifying the DNAT entry. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the DNAT entry is modified.</description></item>
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
        /// <item><description><para>If you modify a DNAT entry of an Internet NAT gateway, this parameter specifies the public IP address used to provide public network access.</para>
        /// </description></item>
        /// <item><description><para>If you modify a DNAT entry of a VPC NAT gateway, this parameter specifies the NAT IP address accessed by the external network.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>116.85.XX.XX</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you modify a DNAT entry of an Internet NAT gateway, this parameter specifies the external port or port range used for port forwarding in the DNAT entry.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be within <b>1</b> to <b>65535</b>.</description></item>
        /// <item><description>To specify a port range, separate the start and end ports with a forward slash (/), such as <c>10/20</c>.</description></item>
        /// <item><description>If you modify both <b>ExternalPort</b> and <b>InternalPort</b>, and <b>ExternalPort</b> is set to a port range, <b>InternalPort</b> must also be set to a port range with the same number of ports. For example, if <b>ExternalPort</b> is set to <c>10/20</c>, <b>InternalPort</b> must be set to <c>80/90</c>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you modify a DNAT entry of a VPC NAT gateway, this parameter specifies the port accessed by the external network. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT entry to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fwd-8vbn3bc8roygjp0gy****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The new name of the DNAT entry.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT table to which the DNAT entry belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ftb-8vbx8xu2lqj9qb334****</para>
        /// </summary>
        [NameInMap("ForwardTableId")]
        [Validation(Required=false)]
        public string ForwardTableId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you modify a DNAT entry of an Internet NAT gateway, this parameter specifies the private IP address of the ECS instance that communicates with the Internet through the DNAT entry.</para>
        /// </description></item>
        /// <item><description><para>If you modify a DNAT entry of a VPC NAT gateway, this parameter specifies the private IP address that needs to communicate through the DNAT rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.78</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If you modify a DNAT entry of an Internet NAT gateway, this parameter specifies the internal port or port range used for port forwarding in the DNAT entry. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// </description></item>
        /// <item><description><para>If you modify a DNAT entry of a VPC NAT gateway, this parameter specifies the port of the destination ECS instance to be mapped. Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <item><description><para><b>TCP</b>: forwards TCP packets.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: forwards UDP packets.</para>
        /// </description></item>
        /// <item><description><para><b>Any</b>: forwards packets of all protocols.</para>
        /// </description></item>
        /// </list>
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
        /// <item><description><b>true</b>: enables port breaking.</description></item>
        /// <item><description><b>false</b>: does not enable port breaking. If a DNAT entry and an SNAT entry use the same public IP address and you want to configure a port number greater than <c>1024</c>, set <c>PortBreak</c> to <c>true</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PortBreak")]
        [Validation(Required=false)]
        public bool? PortBreak { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
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

    }

}
