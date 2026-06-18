// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTransportLayerApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The transport layer application ID. You can obtain this ID by calling the <a href="~~ListTransportLayerApplications~~">ListTransportLayerApplications</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165503967****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-border optimization for network access from the Chinese mainland. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>off: Disables the feature.</para>
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
        /// <para>Specifies whether to enable IP access rules. If enabled, the IP access rules in WAF apply to the transport layer application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: Enables the feature.</para>
        /// </description></item>
        /// <item><description><para>off: Disables the feature.</para>
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
        /// <para>Specifies whether to enable IPv6. Valid values: <c>on</c> and <c>off</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        [NameInMap("KeepAliveProtection")]
        [Validation(Required=false)]
        public string KeepAliveProtection { get; set; }

        /// <summary>
        /// <para>A list of forwarding rules. For each rule, all parameters are required except for <c>Comment</c>.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateTransportLayerApplicationRequestRules> Rules { get; set; }
        public class UpdateTransportLayerApplicationRequestRules : TeaModel {
            /// <summary>
            /// <para>Specifies the protocol for client IP pass-through. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>off</b>: Disables client IP pass-through.</para>
            /// </description></item>
            /// <item><description><para><b>PPv1</b>: PROXY Protocol v1. Supports client IP pass-through for the TCP protocol.</para>
            /// </description></item>
            /// <item><description><para><b>PPv2</b>: PROXY Protocol v2. Supports client IP pass-through for both TCP and UDP protocols.</para>
            /// </description></item>
            /// <item><description><para><b>SPP</b>: Simple Proxy Protocol. Supports client IP pass-through for the UDP protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SPP</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>An optional comment for the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The edge port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>A single port, for example, <c>80</c>.</para>
            /// </description></item>
            /// <item><description><para>A port range, for example, <c>81-85</c>. This range includes ports 81, 82, 83, 84, and 85.</para>
            /// </description></item>
            /// <item><description><para>A combination of ports and port ranges separated by commas, for example, <c>80,81-85,90</c>. This includes ports 80, 81, 82, 83, 84, 85, and 90.</para>
            /// </description></item>
            /// <item><description><para>Edge ports cannot overlap within a single rule or across multiple rules.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para>TCP: Transmission Control Protocol.</para>
            /// </description></item>
            /// <item><description><para>UDP: User Datagram Protocol.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source, which must correspond to the specified <c>SourceType</c>. For example, if <c>SourceType</c> is <c>ip</c>, this parameter must be an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The source port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>A single port. When a single source port is used, any valid format can be used for the edge port.</para>
            /// </description></item>
            /// <item><description><para>A port range. You can specify a port range for the source port only if the edge port is also a port range, and their sizes must match. For example, if <c>EdgePort</c> is <c>90-93</c>, you cannot set <c>SourcePort</c> to <c>81-85</c> because their sizes (4 and 5 ports, respectively) do not match.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <para>The type of the source. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The site ID. You can obtain this ID by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
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
