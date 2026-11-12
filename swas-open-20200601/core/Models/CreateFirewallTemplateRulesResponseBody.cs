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
            /// <para>The port range. Valid values: 1 to 65535. Separate the start port and the end port with a forward slash (/). For example, <c>1024/1055</c> indicates the port range from 1024 to 1055.</para>
            /// <remarks>
            /// <para>If you set the protocol to ICMP, the port must be set to -1/-1.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The description of the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The transport layer protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP: TCP.</description></item>
            /// <item><description>UDP: UDP.</description></item>
            /// <item><description>TCP+UDP: TCP and UDP.</description></item>
            /// <item><description>ICMP: ICMP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR address range for which you want to configure access Settings. Address ranges in CIDR format and IPv4 format are supported.</para>
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
