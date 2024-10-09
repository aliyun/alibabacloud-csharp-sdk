// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplateRulesApplyResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplateRulesApplyResultResponseBodyData> Data { get; set; }
        public class DescribeFirewallTemplateRulesApplyResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error codes when the firewall template rule fails to be applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message that is displayed when the firewall template rule fails to be applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An error occurred while processing your request.</para>
            /// </summary>
            [NameInMap("ErrorInfo")]
            [Validation(Required=false)]
            public string ErrorInfo { get; set; }

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
            /// <item><description>ICMP</description></item>
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
            /// <para>119.145.XX.XX</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The status of applying the firewall template rule to the simple application servers.</para>
            /// <list type="bullet">
            /// <item><description>Pending: The template rule does not start to be applied to the simple application servers.</description></item>
            /// <item><description>Applying: The template rule is being applied to the simple application servers.</description></item>
            /// <item><description>Success: The template rule is successfully applied to the simple application servers.</description></item>
            /// <item><description>PartFailed: The template rule fails to be applied to some simple application servers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
