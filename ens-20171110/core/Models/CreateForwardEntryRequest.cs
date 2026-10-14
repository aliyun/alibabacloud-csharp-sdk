// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateForwardEntryRequest : TeaModel {
        /// <summary>
        /// <para>The Elastic IP Address (EIP) that provides public network access.</para>
        /// <para>The EIP must not be occupied by an SNAT rule of the same NAT gateway. You can check the IpLists.UsingStatus field returned by DescribeNatGateways to confirm that the EIP is in the Idle state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.XXX.XXX.28</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be within 1 to 65535.</description></item>
        /// <item><description>To forward traffic within a port range, separate the start and end ports with a forward slash (/), such as 10/20.</description></item>
        /// <item><description>If ExternalPort is set to a port range, InternalPort must also be set to a port range with the same number of ports. For example, if ExternalPort is set to 10/20, InternalPort must be set to 80/90.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The name of the DNAT rule. The name must be 2 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The health check port for DNAT. The port must be within the internal port range. Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that communicates with the Internet through the DNAT entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XXX.XXX</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port or port range for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>The port range must be within 1 to 65535.</description></item>
        /// <item><description>To forward traffic within a port range, separate the start and end ports with a forward slash (/), such as 10/20.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
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
        /// <item><description><para><b>Any</b> (default): forwards all packets.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Any</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The standby EIP that provides public network access. The standby EIP must be bound to the NAT gateway. After the DNAT entry is created, the standby EIP takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

    }

}
