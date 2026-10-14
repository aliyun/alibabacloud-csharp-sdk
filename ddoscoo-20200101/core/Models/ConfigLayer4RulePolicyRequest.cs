// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RulePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The port forwarding rules.</para>
        /// <para>This parameter is a string that represents a JSON array converted from a character string. Each element in the JSON array represents a created port forwarding rule. You can specify up to one port forwarding rule at a time.</para>
        /// <remarks>
        /// <para>You can invoke <a href="https://help.aliyun.com/document_detail/157484.html">DescribeNetworkRules</a> to query all created port forwarding rules.</para>
        /// </remarks>
        /// <para>Each port forwarding rule contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>InstanceId</b>: string. Required. The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// </description></item>
        /// <item><description><para><b>Protocol</b>: string. Required. The forwarding protocol type. Valid values: <b>tcp</b>, <b>udp</b>.</para>
        /// </description></item>
        /// <item><description><para><b>FrontendPort</b>: integer. Required. The Redirection Port.</para>
        /// </description></item>
        /// <item><description><para><b>BackendPort</b>: integer. Required. The origin server port.</para>
        /// </description></item>
        /// <item><description><para><b>PriRealServers</b>: JSON array. Required. The list of primary origin server IP addresses. Each element in the JSON array represents a primary origin server IP address. You can specify up to 20 primary origin server IP addresses.</para>
        /// <para>  Each primary origin server IP address contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>RealServer</b>: string. Required. The primary origin server IP address.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SecRealServers</b>: JSON array. Required. The list of secondary origin server IP addresses. Each element in the JSON array represents a secondary origin server IP address. You can specify up to 20 secondary origin server IP addresses.</para>
        /// <para>  Each secondary origin server IP address contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>RealServer</b>: string. Required. The secondary origin server IP address.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CurrentRsIndex</b>: integer. Required. The type of origin server to activate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The primary origin server settings take effect. Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the primary origin server IP addresses.</description></item>
        /// <item><description><b>2</b>: The secondary origin server settings take effect. Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the secondary origin server IP addresses.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;InstanceId\&quot;:\&quot;ddosDip-sg-4hr2b3l****\&quot;,\&quot;Protocol\&quot;:\&quot;udp\&quot;,\&quot;FrontendPort\&quot;:2020,\&quot;BackendPort\&quot;:2022,\&quot;PriRealServers\&quot;:[{\&quot;RealServer\&quot;:\&quot;192.0.2.1\&quot;},{\&quot;RealServer\&quot;:\&quot;192.0.2.2\&quot;}],\&quot;SecRealServers\&quot;:[{\&quot;RealServer\&quot;:\&quot;192.0.2.3\&quot;},{\&quot;RealServer\&quot;:\&quot;192.0.2.4\&quot;}],\&quot;CurrentRsIndex\&quot;:1}]</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
