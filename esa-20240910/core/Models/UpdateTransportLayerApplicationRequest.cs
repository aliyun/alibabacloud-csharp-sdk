// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTransportLayerApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The Layer 4 application ID. You can call the <a href="~~ListTransportLayerApplications~~">ListTransportLayerApplications</a> operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165503967****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable network access optimization for the Chinese mainland. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimization { get; set; }

        /// <summary>
        /// <para>The IP access rule switch. When enabled, WAF IP access rules take effect for the Layer 4 application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("IpAccessRule")]
        [Validation(Required=false)]
        public string IpAccessRule { get; set; }

        /// <summary>
        /// <para>The IPv6 switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable keep-alive protection. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("KeepAliveProtection")]
        [Validation(Required=false)]
        public string KeepAliveProtection { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules. For each rule, all parameters except the comment are required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateTransportLayerApplicationRequestRules> Rules { get; set; }
        public class UpdateTransportLayerApplicationRequestRules : TeaModel {
            /// <summary>
            /// <para>The client IP pass-through protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: disabled.</description></item>
            /// <item><description><b>PPv1</b>: PROXY Protocol v1, which supports client IP pass-through for TCP.</description></item>
            /// <item><description><b>PPv2</b>: PROXY Protocol v2, which supports client IP pass-through for TCP and UDP.</description></item>
            /// <item><description><b>SPP</b>: Simple Proxy Protocol, which supports client IP pass-through for UDP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SPP</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>The comment for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The edge port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>A single port, such as 80.</description></item>
            /// <item><description>A port range, such as 81-85, which represents ports 81, 82, 83, 84, and 85.</description></item>
            /// <item><description>A combination of ports and port ranges separated by commas, such as 80,81-85,90, which represents ports 80, 81, 82, 83, 84, 85, and 90.</description></item>
            /// <item><description>Edge ports within a single rule and across multiple rules cannot overlap.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EdgePort")]
            [Validation(Required=false)]
            public string EdgePort { get; set; }

            /// <summary>
            /// <para>The forwarding rule protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TCP: TCP protocol.</description></item>
            /// <item><description>UDP: UDP protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The specific value of the origin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Origin Server Port. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>A single port. When Origin Server Port is a single port, any valid edge port combination is supported.</description></item>
            /// <item><description>A port range. Origin Server Port can be set to a port range only when the edge port is a port range, and the range size must match the edge port range. For example, if the edge port is 90-93, you cannot set Origin Server Port to 81-85 because Origin Server Port range is 5 while the edge port range is 4, which are inconsistent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <para>The origin type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: IP address.</description></item>
            /// <item><description><b>domain</b>: domain name.</description></item>
            /// <item><description><b>OP</b>: origin IPAM pool.</description></item>
            /// <item><description><b>LB</b>: load balancing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable static IP. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StaticIp")]
        [Validation(Required=false)]
        public string StaticIp { get; set; }

    }

}
