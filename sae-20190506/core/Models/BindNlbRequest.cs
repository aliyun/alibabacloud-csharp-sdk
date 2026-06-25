// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BindNlbRequest : TeaModel {
        /// <summary>
        /// <para>The address type of the NLB instance.</para>
        /// <list type="bullet">
        /// <item><description><para><c>Internet</c>: a public IP address.</para>
        /// </description></item>
        /// <item><description><para><c>Intranet</c>: a private IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the target application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The listeners, specified as a JSON-formatted string. Each listener object contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Port</b>: Integer. Required. The listener port. Valid values: 0 to 65535.</para>
        /// </description></item>
        /// <item><description><para><b>TargetPort</b>: Integer. Required. The port on the application instance that receives traffic. Valid values: 0 to 65535.</para>
        /// </description></item>
        /// <item><description><para><b>Protocol</b>: String. Required. The listener protocol. Valid values: <c>TCP</c>, <c>UDP</c>, and <c>TCPSSL</c>.</para>
        /// </description></item>
        /// <item><description><para><b>CertIds</b>: String. Optional. The server certificate IDs. This parameter is required only for <c>TCPSSL</c> listeners.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

        /// <summary>
        /// <para>The ID of the NLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-7z7jjbzz44d82c9***</para>
        /// </summary>
        [NameInMap("NlbId")]
        [Validation(Required=false)]
        public string NlbId { get; set; }

        /// <summary>
        /// <para>The mappings between zones and vSwitches, specified as a JSON-formatted string. You can add up to 10 zones. If the current region supports two or more zones, you must specify at least two zones. Each <c>ZoneMapping</c> object contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VSwitchId</b>: String. The ID of the vSwitch in the specified zone. Each zone can have only one vSwitch and one subnet.</para>
        /// </description></item>
        /// <item><description><para>ZoneId, String, the zone ID of the Network Load Balancer instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-sersdf****
        /// cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public string ZoneMappings { get; set; }

    }

}
