// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateTransportLayerApplicationRequest : TeaModel {
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
        /// <para>The IP access rule switch. When enabled, IP access rules in WAF take effect for the Layer 4 application. Valid values:</para>
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
        /// <para>Specifies whether to enable IPv6. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
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
        /// <para>The domain name of the Layer 4 application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateTransportLayerApplicationRequestRules> Rules { get; set; }
        public class CreateTransportLayerApplicationRequestRules : TeaModel {
            /// <summary>
            /// <para>The client IP pass-through protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: disabled.</description></item>
            /// <item><description><b>PPv1</b>: PROXY Protocol v1. Supports client IP pass-through for TCP.</description></item>
            /// <item><description><b>PPv2</b>: PROXY Protocol v2. Supports client IP pass-through for TCP and UDP.</description></item>
            /// <item><description><b>SPP</b>: Simple Proxy Protocol. Supports client IP pass-through for UDP.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPP</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>The comment for the rule (optional).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The edge port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>A single port, such as 80.</description></item>
            /// <item><description>A port range, such as 81-85, which represents ports 81, 82, 83, 84, and 85.</description></item>
            /// <item><description>A combination of ports and port ranges separated by commas, such as 80,81-85,90, which represents ports 80, 81, 82, 83, 84, 85, and 90.</description></item>
            /// </list>
            /// <para>Edge ports within a single rule and across multiple rules must not overlap.</para>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The specific value of the origin, which must match the origin type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Origin Server Port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>A single port. When Origin Server Port is a single port, any valid edge port combination is supported.</description></item>
            /// <item><description>A port range. Origin Server Port can be set to a port range only when the edge port is also a port range, and the range size must match the edge port range. For example, if the edge port is 90-93, you cannot set Origin Server Port to 81-85 because Origin Server Port range size is 5 while the edge port range size is 4, which is inconsistent.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID. The site must be activated.</para>
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
