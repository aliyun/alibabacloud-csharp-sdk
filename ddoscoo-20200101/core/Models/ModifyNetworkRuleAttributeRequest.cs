// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyNetworkRuleAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The advanced settings for the port forwarding rule. Specify the settings as a JSON string. The structure is described below.
        /// The structure of \<c>TcpConfig\\</c> is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PersistenceTimeout</b>: An integer. This parameter is required. The timeout period for session persistence. Unit: seconds. Valid values: <b>30</b> to <b>3600</b>. The default value is <b>0</b>, which disables session persistence.</para>
        /// </description></item>
        /// <item><description><para><b>Synproxy</b>: A string. This parameter is required. The status of the False Source setting for the DDoS mitigation policy. Valid values: \<c>off\\</c> and \<c>on\\</c>.</para>
        /// </description></item>
        /// <item><description><para><b>NodataConn</b>: A string. This parameter is required. The status of the Empty Connection setting for the DDoS mitigation policy. Valid values: \<c>off\\</c> and \<c>on\\</c>.</para>
        /// </description></item>
        /// <item><description><para><b>Sla</b>: A struct. This parameter is required. The configuration for destination rate limiting. For more information, see the \<c>Sla\\</c> section below.</para>
        /// </description></item>
        /// <item><description><para><b>Slimit</b>: A struct. This parameter is required. The configuration for source rate limiting. For more information, see the \<c>Slimit\\</c> section below.</para>
        /// </description></item>
        /// <item><description><para><b>PayloadLen</b>: A struct. This parameter is required. The packet length filter configuration. For more information, see the \<c>PayloadLen\\</c> section below.</para>
        /// </description></item>
        /// </list>
        /// <para>The structure of \<c>Sla\\</c> is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cps</b>: An integer. This parameter is required. The maximum number of new connections per second to a destination IP address. Valid values: 100 to 100,000.</para>
        /// </description></item>
        /// <item><description><para><b>Maxconn</b>: An integer. This parameter is required. The maximum number of concurrent connections to a destination IP address. Valid values: 1,000 to 1,000,000.</para>
        /// </description></item>
        /// <item><description><para><b>CpsEnable</b>: An integer. This parameter is required. Specifies whether to enable the limit on new connections. Valid values: 0 (disabled) and 1 (enabled). The default value is 1.</para>
        /// </description></item>
        /// <item><description><para><b>MaxconnEnable</b>: An integer. This parameter is required. Specifies whether to enable the limit on concurrent connections. Valid values: 0 (disabled) and 1 (enabled). The default value is 1.</para>
        /// </description></item>
        /// </list>
        /// <para>The structure of \<c>Slimit\\</c> is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cps</b>: An integer. This parameter is required. The maximum number of new connections per second from a source IP address. Valid values: 1 to 50,000.</para>
        /// </description></item>
        /// <item><description><para><b>Maxconn</b>: An integer. This parameter is required. The maximum number of concurrent connections from a source IP address. Valid values: 1 to 50,000.</para>
        /// </description></item>
        /// <item><description><para><b>CpsEnable</b>: An integer. This parameter is required. Specifies whether to enable the limit on new connections. Valid values: 0 (disabled) and 1 (enabled). The default value is 1.</para>
        /// </description></item>
        /// <item><description><para><b>MaxconnEnable</b>: An integer. This parameter is required. Specifies whether to enable the limit on concurrent connections. Valid values: 0 (disabled) and 1 (enabled). The default value is 1.</para>
        /// </description></item>
        /// <item><description><para><b>CpsMode</b>: An integer. This parameter is required. The mode for the new connection rate limit from a source IP address. Valid values: 1 (off) and 2 (auto).</para>
        /// </description></item>
        /// </list>
        /// <para>The structure of \<c>PayloadLen\\</c> is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Min</b>: An integer. This parameter is required. The minimum packet length. Valid values: 0 to 1,500.</para>
        /// </description></item>
        /// <item><description><para><b>Max</b>: An integer. This parameter is required. The maximum packet length. Valid values: 0 to 1,500.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Slimit&quot;:{&quot;CpsEnable&quot;:1,&quot;MaxconnEnable&quot;:1,&quot;Cps&quot;:1,&quot;Maxconn&quot;:1},&quot;Sla&quot;:{&quot;CpsEnable&quot;:1,&quot;MaxconnEnable&quot;:1,&quot;Cps&quot;:100,&quot;Maxconn&quot;:1000},&quot;PayloadLen&quot;:{&quot;Min&quot;:0,&quot;Max&quot;:1500}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The forwarding protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tcp</b></para>
        /// </description></item>
        /// <item><description><para><b>udp</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// <para>The forwarding port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> to query the IDs of all Anti-DDoS Pro and Anti-DDoS Premium instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The module for Layer 7 port support. The default value is sla. Valid value:</para>
        /// <para><b>sla</b>: Speed Limit for Destination</para>
        /// 
        /// <b>Example:</b>
        /// <para>sla</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
