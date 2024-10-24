// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RulePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The port forwarding rule that you want to manage.</para>
        /// <para>This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates a port forwarding rule. You can perform this operation only on one port forwarding rule at a time.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157484.html">DescribeNetworkRules</a> to query existing port forwarding rules.</para>
        /// </remarks>
        /// <para>Each port forwarding rule contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>InstanceId</b>: the ID of the instance. This field is required and must be of the STRING type.</para>
        /// </description></item>
        /// <item><description><para><b>Protocol</b>: the forwarding protocol. This field is required and must be of the STRING type. Valid values: <b>tcp</b> and <b>udp</b>.</para>
        /// </description></item>
        /// <item><description><para><b>FrontendPort</b>: the forwarding port. This field is required and must be of the INTEGER type.</para>
        /// </description></item>
        /// <item><description><para><b>BackendPort</b>: the port of the origin server. This field is required and must be of the INTEGER type.</para>
        /// </description></item>
        /// <item><description><para><b>PriRealServers</b>: the IP addresses of the primary origin server. This field is required and must be a JSON array. Each element in a JSON array indicates an IP address of the primary origin server. You can configure a maximum of 20 IP addresses.</para>
        /// <para>Each element in the JSON array contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><b>RealServer</b>: the IP address of the primary origin server. This field is required and must be of the STRING type.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SecRealServers</b>: the IP addresses of the secondary origin server. This field is required and must be a JSON array. Each element in a JSON array indicates an IP address of the secondary origin server. You can configure a maximum of 20 IP addresses.</para>
        /// <para>Each element in the JSON array contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><b>RealServer</b>: the IP address of the secondary origin server. This field is required and must be of the STRING type.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>CurrentRsIndex</b>: the origin server that you want to use to receive service traffic. This field is required and must be of the INTEGER type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.</description></item>
        /// <item><description><b>2</b>: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.</description></item>
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
