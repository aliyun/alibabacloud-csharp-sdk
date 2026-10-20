// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTransportLayerApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Layer 4 applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTransportLayerApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListTransportLayerApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the Layer 4 application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170997271816****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <para>The CNAME domain name corresponding to the Layer 4 acceleration application. This field is not empty only when the site is onboarded by using a CNAME record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.ialicdn.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable network access optimization for the Chinese mainland. Default value: off. Valid values:</para>
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
            /// <para>Specifies whether to enable the IP access rule. After this feature is enabled, the IP access rules in WAF take effect for the Layer 4 application. Valid values:</para>
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
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
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
            /// <para>Specifies whether to enable connection keep-alive protection. Default value: off. Valid values:</para>
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
            /// <para>The list of forwarding rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsRules> Rules { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsRules : TeaModel {
                /// <summary>
                /// <para>The protocol used to pass through the client IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>off</b>: Does not pass through the client IP address.</description></item>
                /// <item><description><b>PPv1</b>: PROXY protocol version 1, which supports passing through the client IP address over TCP.</description></item>
                /// <item><description><b>PPv2</b>: PROXY protocol version 2, which supports passing through the client IP address over TCP and UDP.</description></item>
                /// <item><description><b>SPP</b>: Simple Proxy Protocol, which supports passing through the client IP address over UDP.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ClientIPPassThroughMode")]
                [Validation(Required=false)]
                public string ClientIPPassThroughMode { get; set; }

                /// <summary>
                /// <para>The description of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The edge port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>A single port, such as 80.</description></item>
                /// <item><description>A port range, such as 81-85, which represents ports 81, 82, 83, 84, and 85.</description></item>
                /// <item><description>A combination of ports and port ranges, separated by commas, such as 80,81-85,90, which represents ports 80, 81, 82, 83, 84, 85, and 90.</description></item>
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
                /// <item><description>TCP: TCP</description></item>
                /// <item><description>UDP: UDP</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The ID of the Layer 4 acceleration rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20258028****</para>
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
                /// <para>The origin server port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>A single port. If the origin server port is a single port, any valid combination of edge ports is supported.</description></item>
                /// <item><description>A port range. The origin server port can be set to a port range only when the edge port is a port range, and the range size must be the same as that of the edge port. For example, if the edge port is 90-93, you cannot set the origin server port to 81-85 because the origin server port range includes 5 ports and the edge port range includes 4 ports, which do not match.</description></item>
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
            /// <para>The number of forwarding rules included in the Layer 4 acceleration application.</para>
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
            /// <para>36556540048****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the static IP address feature. Default value: off. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Enabled.</description></item>
            /// <item><description>off: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("StaticIp")]
            [Validation(Required=false)]
            public string StaticIp { get; set; }

            /// <summary>
            /// <para>The list of static IPv4 addresses assigned to the Layer 4 application after the static IP address feature is enabled.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StaticIpV4List")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsStaticIpV4List> StaticIpV4List { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsStaticIpV4List : TeaModel {
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
            /// <para>The status of the Layer 4 application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>deploying</b>: Deploying. In this state, modification and deletion are not allowed.</description></item>
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

        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Layer 4 applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
