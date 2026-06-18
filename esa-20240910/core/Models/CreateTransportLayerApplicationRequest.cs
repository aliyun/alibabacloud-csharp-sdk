// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateTransportLayerApplicationRequest : TeaModel {
        /// <summary>
        /// <para>Enables or disables network optimization for access from the Chinese mainland. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the optimization.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the optimization.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimization { get; set; }

        /// <summary>
        /// <para>Applies IP access rules from Web Application Firewall (WAF) to this Transport Layer Application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>on</c>: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para><c>off</c>: Disables the feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("IpAccessRule")]
        [Validation(Required=false)]
        public string IpAccessRule { get; set; }

        /// <summary>
        /// <para>Enables or disables IPv6 support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// <para>Enables or disables keep-alive protection.</para>
        /// </summary>
        [NameInMap("KeepAliveProtection")]
        [Validation(Required=false)]
        public string KeepAliveProtection { get; set; }

        /// <summary>
        /// <para>The domain name of the Transport Layer Application.</para>
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
            /// <para>The client IP passthrough protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>off</b>: Disables client IP passthrough.</para>
            /// </description></item>
            /// <item><description><para><b>PPv1</b>: PROXY Protocol v1. Preserves the client IP address for TCP connections.</para>
            /// </description></item>
            /// <item><description><para><b>PPv2</b>: PROXY Protocol v2. Preserves the client IP address for TCP and UDP connections.</para>
            /// </description></item>
            /// <item><description><para><b>SPP</b>: Simple Proxy Protocol. Preserves the client IP address for UDP connections.</para>
            /// </description></item>
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
            /// <para>An optional comment for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The edge port. Supported formats:</para>
            /// <list type="bullet">
            /// <item><description><para>A single port, for example, <c>80</c>.</para>
            /// </description></item>
            /// <item><description><para>A port range, for example, <c>81-85</c>, which includes ports 81, 82, 83, 84, and 85.</para>
            /// </description></item>
            /// <item><description><para>A combination of ports and port ranges separated by commas, for example, <c>80,81-85,90</c>, which includes ports 80, 81, 82, 83, 84, 85, and 90.</para>
            /// </description></item>
            /// </list>
            /// <para>Edge ports cannot overlap within a single rule or across multiple rules.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EdgePort")]
            [Validation(Required=false)]
            public string EdgePort { get; set; }

            /// <summary>
            /// <para>The forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>TCP</c>: The TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><c>UDP</c>: The UDP protocol.</para>
            /// </description></item>
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
            /// <para>The origin address. The value must match the specified <c>SourceType</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The origin port. Supported formats:</para>
            /// <list type="bullet">
            /// <item><description><para>A single port, which supports any valid combination of edge ports.</para>
            /// </description></item>
            /// <item><description><para>A port range. You can specify a port range only if the edge port is also a port range. The origin and edge port ranges must be the same size. For example, if the edge port range is <c>90-93</c> (4 ports), the origin port range cannot be <c>81-85</c> (5 ports).</para>
            /// </description></item>
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
            /// <item><description><para><b>ip</b>: An IP address.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: A domain name.</para>
            /// </description></item>
            /// <item><description><para><b>OP</b>: An origin pool.</para>
            /// </description></item>
            /// <item><description><para><b>LB</b>: A load balancer.</para>
            /// </description></item>
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
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("StaticIp")]
        [Validation(Required=false)]
        public string StaticIp { get; set; }

    }

}
