// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateRulesRequest : TeaModel {
        /// <summary>
        /// <para>The firewall rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FirewallRule")]
        [Validation(Required=false)]
        public List<CreateFirewallTemplateRulesRequestFirewallRule> FirewallRule { get; set; }
        public class CreateFirewallTemplateRulesRequestFirewallRule : TeaModel {
            /// <summary>
            /// <para>The port range. Valid values: 1 to 65535. Separate the start port and the end port with a forward slash (/). For example, <c>1024/1055</c> indicates the port range from 1024 to 1055.</para>
            /// <remarks>
            /// <para>If you set the protocol to ICMP, the port must be set to -1/-1.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("RuleProtocol")]
            [Validation(Required=false)]
            public string RuleProtocol { get; set; }

            /// <summary>
            /// <para>The source IPv4 CIDR address range for which you want to configure access Settings. Address ranges in CIDR format and IPv4 format are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222.70.XX.XX</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The ID of the firewall template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ft-bcf1a7hrdq717****</para>
        /// </summary>
        [NameInMap("FirewallTemplateId")]
        [Validation(Required=false)]
        public string FirewallTemplateId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the available regions for Simple Application Server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
