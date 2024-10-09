// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListFirewallRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of firewall rules.</para>
        /// </summary>
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public List<ListFirewallRulesResponseBodyFirewallRules> FirewallRules { get; set; }
        public class ListFirewallRulesResponseBodyFirewallRules : TeaModel {
            /// <summary>
            /// <para>The firewall policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>accept: Access is allowed.</description></item>
            /// <item><description>drop: Access is refused.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>accept</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The port range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The remarks of the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TEST</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The ID of the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eeea34d9867b4d55a4ff8d5fcfbd****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The transport layer protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP</description></item>
            /// <item><description>UDP</description></item>
            /// <item><description>TCP+UDP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.0.0/0</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

            /// <summary>
            /// <para>The tags of the firewall rule.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListFirewallRulesResponseBodyFirewallRulesTags> Tags { get; set; }
            public class ListFirewallRulesResponseBodyFirewallRulesTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N to be added to the firewall rule. Valid values of N: 1 to 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of tag N to be added to the firewall rule. Valid values of N: 1 to 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
