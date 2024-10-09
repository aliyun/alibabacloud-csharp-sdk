// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The firewall template rules.</para>
        /// </summary>
        [NameInMap("FirewallTemplateRules")]
        [Validation(Required=false)]
        public List<CreateFirewallTemplateRulesResponseBodyFirewallTemplateRules> FirewallTemplateRules { get; set; }
        public class CreateFirewallTemplateRulesResponseBodyFirewallTemplateRules : TeaModel {
            /// <summary>
            /// <para>The ID of the firewall template rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ft-bcf1a7hrdq717****</para>
            /// </summary>
            [NameInMap("FirewallTemplateRuleId")]
            [Validation(Required=false)]
            public string FirewallTemplateRuleId { get; set; }

            /// <summary>
            /// <para>The port range. Valid values: 1 to 65535. Specify a port range in the format of \<start port number>/\<end port number>. Example: <c>1024/1055</c>, which indicates that the port range of 1024 to 1055.</para>
            /// <remarks>
            /// <para> If you set RuleProtocol to ICMP, you must set Port to -1/-1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The remarks of the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The transport layer protocol that the rule supports. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>TCP+UDP</description></item>
            /// <item><description>ICMP: the ICMP protocol</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// <para>The source address to which you want to grant access permissions. CIDR blocks and IPv4 addresses are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171.233.XX.XX</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
