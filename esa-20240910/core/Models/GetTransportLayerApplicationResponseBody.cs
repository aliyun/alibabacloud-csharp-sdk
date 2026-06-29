// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetTransportLayerApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The Layer 4 application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17099311410****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>The CNAME domain name of the Layer 4 acceleration application. This field is non-empty only when the site is connected by using the CNAME method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com.ialicdn.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable network access optimization for the Chinese mainland. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
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
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
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
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
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
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB635996-1FD6-5DFD-BA57-27A849599940</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<GetTransportLayerApplicationResponseBodyRules> Rules { get; set; }
        public class GetTransportLayerApplicationResponseBodyRules : TeaModel {
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
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>The comment for the rule.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EdgePort")]
            [Validation(Required=false)]
            public string EdgePort { get; set; }

            /// <summary>
            /// <para>The protocol of the forwarding rule. Valid values:</para>
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
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234323***</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The specific value of the origin server, which must match the origin server type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The origin server port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description>A single port. When the origin server port is a single port, any valid edge port combination is supported.</description></item>
            /// <item><description>A port range. The origin server port can be set to a port range only when the edge port is a port range, and the range size must be the same as the edge port range. For example, if the edge port is 90-93, you cannot set the origin server port to 81-85 because the origin server port range is 5 while the edge port range is 4, which are inconsistent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <para>The origin server type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ip</b>: IP address.</description></item>
            /// <item><description><b>domain</b>: domain name.</description></item>
            /// <item><description><b>OP</b>: IPAM pool.</description></item>
            /// <item><description><b>LB</b>: load balancing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>The number of forwarding rules in the Layer 4 acceleration application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RulesCount")]
        [Validation(Required=false)]
        public int? RulesCount { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
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
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("StaticIp")]
        [Validation(Required=false)]
        public string StaticIp { get; set; }

        /// <summary>
        /// <para>The list of static IPv4 addresses assigned to this Layer 4 application after the static IP feature is enabled.</para>
        /// </summary>
        [NameInMap("StaticIpV4List")]
        [Validation(Required=false)]
        public List<GetTransportLayerApplicationResponseBodyStaticIpV4List> StaticIpV4List { get; set; }
        public class GetTransportLayerApplicationResponseBodyStaticIpV4List : TeaModel {
            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.2</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The status of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>healthy: Healthy.</description></item>
            /// <item><description>unhealthy: Unhealthy.</description></item>
            /// <item><description>unknown: The IP address is being prepared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The Layer 4 application status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>deploying</b>: Being deployed. Modifications and deletions are not allowed in this state.</description></item>
        /// <item><description><b>active</b>: Active.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
