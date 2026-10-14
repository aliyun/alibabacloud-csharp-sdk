// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigNetworkRulesRequest : TeaModel {
        /// <summary>
        /// <para>The details of the port forwarding rules. The value is a JSON format character string that contains the following structure:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: String. Required. The instance ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>Protocol</b>: String. Required. The forwarding protocol type. Valid values: <b>tcp</b>, <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: Integer. Required. The Redirection Port.</description></item>
        /// <item><description><b>BackendPort</b>: Integer. Required. The origin server port.</description></item>
        /// <item><description><b>RealServers</b>: JSON array. Required. The list of origin server IP addresses. A maximum of 20 IP addresses are supported.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you edit port forwarding rules, you can modify only <b>RealServers</b>, which specifies the origin server IP addresses.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;InstanceId&quot;:&quot;ddoscoo-cn-mp91j1ao****&quot;,&quot;Protocol&quot;:&quot;tcp&quot;,&quot;FrontendPort&quot;:8080,&quot;BackendPort&quot;:8080,&quot;RealServers&quot;:[&quot;1.1.1.1&quot;,&quot;2.2.2.2&quot;,&quot;3.3.3.3&quot;]}]</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public string NetworkRules { get; set; }

    }

}
