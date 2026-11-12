// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the firewall template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The firewall rules.</para>
        /// </summary>
        [NameInMap("FirewallRule")]
        [Validation(Required=false)]
        public List<CreateFirewallTemplateRequestFirewallRule> FirewallRule { get; set; }
        public class CreateFirewallTemplateRequestFirewallRule : TeaModel {
            /// <summary>
            /// <para>The port range. Valid values: 1 to 65535. Use a forward slash (/) to separate the start port and the end port. For example, <c>1024/1055</c> indicates a port range from 1024 to 1055.</para>
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
            /// <para>The remark for the firewall rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom rule</para>
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
            /// <para>The source IPv4 CIDR block for which to set access permissions. Both CIDR and IPv4 formats are supported for the IP address range.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>223.166.XX.XX</para>
            /// </summary>
            [NameInMap("SourceCidrIp")]
            [Validation(Required=false)]
            public string SourceCidrIp { get; set; }

        }

        /// <summary>
        /// <para>The name of the firewall template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID of the Simple Application Server instance. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the list of supported Alibaba Cloud regions.</para>
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
