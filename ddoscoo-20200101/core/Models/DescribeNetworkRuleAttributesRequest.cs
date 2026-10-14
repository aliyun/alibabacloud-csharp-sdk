// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRuleAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The port forwarding rules to query. This parameter is a JSON string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: String type. Required. The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>Protocol</b>: String type. Required. The forwarding protocol type. Valid values: <b>tcp</b>, <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: Integer type. Required. The forwarding port.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;InstanceId&quot;:&quot;ddoscoo-cn-mp91j1ao****&quot;,&quot;Protocol&quot;:&quot;tcp&quot;,&quot;FrontendPort&quot;:8080}]</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public string NetworkRules { get; set; }

    }

}
