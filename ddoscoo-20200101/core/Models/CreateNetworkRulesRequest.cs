// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateNetworkRulesRequest : TeaModel {
        [NameInMap("IpMode")]
        [Validation(Required=false)]
        public string IpMode { get; set; }

        /// <summary>
        /// <para>The details of the port forwarding rules, expressed as a character string in JSON format with the following structure:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: String. Required. The Anti-DDoS Pro or Anti-DDoS Premium instance ID.</description></item>
        /// <item><description><b>Protocol</b>: String. Required. The forwarding protocol type. Valid values: <b>tcp</b>, <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: Integer. Required. The Redirection Port.</description></item>
        /// <item><description><b>BackendPort</b>: Integer. Required. The origin server port.</description></item>
        /// <item><description><b>RealServers</b>: JSON array. Required. The list of origin server IP addresses. A maximum of 20 IP addresses are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;InstanceId&quot;:&quot;ddoscoo-cn-mp91j1ao****&quot;,&quot;Protocol&quot;:&quot;tcp&quot;,&quot;FrontendPort&quot;:8080,&quot;BackendPort&quot;:8080,&quot;RealServers&quot;:[&quot;1.1.1.1&quot;,&quot;2.2.2.2&quot;]}]</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public string NetworkRules { get; set; }

    }

}
