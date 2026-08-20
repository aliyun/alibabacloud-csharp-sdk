// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class UpdateResolverRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The IP addresses and ports of external DNS servers. DNS queries are forwarded to these servers. You can specify up to six servers. Both private and public IP addresses are supported.</para>
        /// <remarks>
        /// <para>If you specify a public IP address for an external DNS server, and the Elastic Compute Service (ECS) instances in the virtual private cloud (VPC) for the outbound endpoint do not have public IP addresses, enable a NAT Gateway and configure Source Network Address Translation (SNAT) entries for it.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ForwardIp")]
        [Validation(Required=false)]
        public List<UpdateResolverRuleRequestForwardIp> ForwardIp { get; set; }
        public class UpdateResolverRuleRequestForwardIp : TeaModel {
            /// <summary>
            /// <para>The IP address of the destination server.</para>
            /// <remarks>
            /// <para>The IP addresses in the following ranges are reserved by the system and cannot be used for external DNS servers:
            /// 100.100.2.136-100.100.2.138
            /// 100.100.2.116-100.100.2.118</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port number of the destination server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forwarding rule-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PriorityForwardConfigs")]
        [Validation(Required=false)]
        public List<UpdateResolverRuleRequestPriorityForwardConfigs> PriorityForwardConfigs { get; set; }
        public class UpdateResolverRuleRequestPriorityForwardConfigs : TeaModel {
            [NameInMap("AlidnsServiceAddresses")]
            [Validation(Required=false)]
            public List<string> AlidnsServiceAddresses { get; set; }

            [NameInMap("CustomAddresses")]
            [Validation(Required=false)]
            public List<string> CustomAddresses { get; set; }

            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The ID of the forwarding rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
