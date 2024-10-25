// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateForwardEntryRequest : TeaModel {
        /// <summary>
        /// <para>The elastic IP address (EIP) that is used to access the Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.11.36.28</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range that is used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.</description></item>
        /// <item><description>If you set ExternalPort to a port range, you must also set InternalPort to a port range. The number of ports in the port ranges must be the same. For example, if you set ExternalPort to 10/20, you can set InternalPort to 80/90.</description></item>
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
        /// <para>The name of the DNAT entry. The name must be 2 to 128 characters in length. The name cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// <para>The probe port. The port must be within the internal port range. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance that uses the DNAT entry for Internet communication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.13</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The internal port or port range that is used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.</description></item>
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
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b>: forwards TCP packets.</description></item>
        /// <item><description><b>UDP</b>: forwards UDP packets.</description></item>
        /// <item><description><b>Any</b> (default): forwards all packets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Any</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the Network Address Translation (NAT) gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr383xpo</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The secondary EIP that is used to access the Internet. You need to select a secondary EIP that is bound to NAT. After the DNAT entry is created, the secondary EIP takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

    }

}
