// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RuleBakModeRequest : TeaModel {
        /// <summary>
        /// <para>The back-to-origin mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The default back-to-origin mode. Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the origin server IP address that you specified when you called <a href="https://help.aliyun.com/document_detail/157482.html">CreateNetworkRules</a> to create the port forwarding rule.</description></item>
        /// <item><description><b>1</b>: The origin redundancy mode. Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the primary origin server IP address or secondary origin server IP address that you configured by calling <a href="https://help.aliyun.com/document_detail/312684.html">ConfigLayer4RulePolicy</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BakMode")]
        [Validation(Required=false)]
        public string BakMode { get; set; }

        /// <summary>
        /// <para>The port forwarding rule to configure.</para>
        /// <para>This parameter is a string converted from a JSON array. Each element in the JSON array represents a created port forwarding rule. You can configure up to one port forwarding rule at a time.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/157484.html">DescribeNetworkRules</a> to query all created port forwarding rules.</para>
        /// </remarks>
        /// <para>Each port forwarding rule contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>InstanceId</b>: String type. Required. The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</description></item>
        /// <item><description><b>Protocol</b>: String type. Required. The forwarding protocol type. Valid values: <b>tcp</b>, <b>udp</b>.</description></item>
        /// <item><description><b>FrontendPort</b>: Integer type. Required. The Redirection Port.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;InstanceId\&quot;:\&quot;ddosDip-sg-4hr2b3l****\&quot;,\&quot;FrontendPort\&quot;:2020,\&quot;Protocol\&quot;:\&quot;udp\&quot;}]</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
