// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyForwardEntryRequest : TeaModel {
        /// <summary>
        /// <para>The EIP in the DNAT entry. The public IP address is used to access the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121.XXX.XXX.28</para>
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// <para>The external port or port range that is used for port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20. The first port and the last port are included.</description></item>
        /// <item><description>If you set ExternalPort to a port range, you must also set InternalPort to a port range. The number of ports in the port ranges must be the same. For example, if you set ExternalPort to 10/20, you can set InternalPort to 80/90.</description></item>
        /// <item><description>The maximum port range is 1000.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// <para>The ID of the DNAT entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dnat-5tfjp3537mi6iokl59g5c****</para>
        /// </summary>
        [NameInMap("ForwardEntryId")]
        [Validation(Required=false)]
        public string ForwardEntryId { get; set; }

        /// <summary>
        /// <para>The name of the DNAT entry. The name must be 2 to 128 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>10.XXX.XXX.50</para>
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// <para>The private port or port range that is used in port forwarding.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 65535.</description></item>
        /// <item><description>To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20. The first port and the last port are included.</description></item>
        /// <item><description>If you set InternalPort to a port range, you must also set ExternalPort to a port range. The number of ports in the port ranges must be the same. For example, if you set ExternalPort to 10/20, you can set InternalPort to 80/90.</description></item>
        /// <item><description>The maximum port range is 1000.</description></item>
        /// </list>
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

    }

}
