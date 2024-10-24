// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateNetworkRulesRequest : TeaModel {
        /// <summary>
        /// <para>The details of the port forwarding rule. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: the ID of the instance. This field is required and must be of the STRING type.</description></item>
        /// <item><description><b>Protocol</b>: the forwarding protocol. This field is required and must be of the STRING type. Valid values: <b>tcp</b> and <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: the forwarding port. This field is required and must be of the INTEGER type.</description></item>
        /// <item><description><b>BackendPort</b>: the port of the origin server. This field is required and must be of the INTEGER type.</description></item>
        /// <item><description><b>RealServers</b>: the IP addresses of the origin server. This field is required and must be a JSON array. You can specify up to 20 IP addresses.</description></item>
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
