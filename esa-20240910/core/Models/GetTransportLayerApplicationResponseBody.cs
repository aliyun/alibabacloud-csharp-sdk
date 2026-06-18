// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetTransportLayerApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Transport Layer Application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17099311410****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>The CNAME domain name of the Transport Layer Application. This parameter is returned only if the Site was added using the CNAME method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com.ialicdn.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>Indicates whether network optimization for access from the Chinese mainland is enabled. This feature is disabled by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
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
        /// <para>Indicates whether the IP Access Rule feature is enabled. If enabled, IP Access Rules in Web Application Firewall (WAF) take effect for the Transport Layer Application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
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
        /// <para>Indicates whether IPv6 is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// <para>Indicates whether keep-alive protection is enabled.</para>
        /// </summary>
        [NameInMap("KeepAliveProtection")]
        [Validation(Required=false)]
        public string KeepAliveProtection { get; set; }

        /// <summary>
        /// <para>The domain name of the Transport Layer Application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB635996-1FD6-5DFD-BA57-27A849599940</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of forwarding rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<GetTransportLayerApplicationResponseBodyRules> Rules { get; set; }
        public class GetTransportLayerApplicationResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The client IP pass-through mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>off</b>: Client IP pass-through is disabled.</para>
            /// </description></item>
            /// <item><description><para><b>PPv1</b>: PROXY Protocol v1, which supports client IP pass-through for TCP.</para>
            /// </description></item>
            /// <item><description><para><b>PPv2</b>: PROXY Protocol v2, which supports client IP pass-through for both TCP and UDP.</para>
            /// </description></item>
            /// <item><description><para><b>SPP</b>: Simple Proxy Protocol, which supports client IP pass-through for UDP.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>A comment about the forwarding rule.</para>
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
            /// <item><description><para>A single port, for example, <c>80</c>.</para>
            /// </description></item>
            /// <item><description><para>A port range, such as <c>81-85</c> (ports 81 to 85).</para>
            /// </description></item>
            /// <item><description><para>A comma-separated list of ports and port ranges, such as <c>80,81-85,90</c>.</para>
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
            /// <para>The protocol for the forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: For TCP traffic.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: For UDP traffic.</para>
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
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234323***</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The origin. This value must be consistent with the specified origin type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The origin port. The following formats are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>A single port. A single origin port can be mapped to one or more edge ports.</para>
            /// </description></item>
            /// <item><description><para>A port range. When mapping a range of edge ports to a range of origin ports, both ranges must contain the same number of ports. For example, you cannot map edge ports <c>90-93</c> (4 ports) to origin ports <c>81-85</c> (5 ports).</para>
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
            /// <para>The origin type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ip</b>: An IP address.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: A domain name.</para>
            /// </description></item>
            /// <item><description><para><b>OP</b>: An origin address pool.</para>
            /// </description></item>
            /// <item><description><para><b>LB</b>: A load balancer.</para>
            /// </description></item>
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
        /// <para>The number of forwarding rules in the Transport Layer Application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RulesCount")]
        [Validation(Required=false)]
        public int? RulesCount { get; set; }

        /// <summary>
        /// <para>The ID of the Site.</para>
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

        [NameInMap("StaticIpV4List")]
        [Validation(Required=false)]
        public List<GetTransportLayerApplicationResponseBodyStaticIpV4List> StaticIpV4List { get; set; }
        public class GetTransportLayerApplicationResponseBodyStaticIpV4List : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status of the Transport Layer Application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>deploying</b>: The application is deploying. You cannot modify or delete the application in this state.</para>
        /// </description></item>
        /// <item><description><para><b>active</b>: The application is active.</para>
        /// </description></item>
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
