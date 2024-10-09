// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Details about the firewall rules.</para>
        /// </summary>
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public List<CreateFirewallRulesRequestFirewallRules> FirewallRules { get; set; }
        public class CreateFirewallRulesRequestFirewallRules : TeaModel {
            /// <summary>
            /// <para>The port number.</para>
            /// <list type="bullet">
            /// <item><description>When the transport layer protocol is TCP and/or UDP, the port number range is 1 to 65535. Specify a port range in the format of \<Start port number>/\<End port number>. Example: 1/200.</description></item>
            /// <item><description>When the transport layer protocol is ICMP, the port number range is -1/-1, which indicates all ports.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The description of the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The transport layer protocol. Valid values:</para>
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
            /// <para>The IP address or CIDR block that is allowed in the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.101.XX.XX</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ace0706b2ac4454d984295a94213****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application server. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tags that you want to add to the firewall. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFirewallRulesRequestTag> Tag { get; set; }
        public class CreateFirewallRulesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20.</para>
            /// <para>The tag value can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
