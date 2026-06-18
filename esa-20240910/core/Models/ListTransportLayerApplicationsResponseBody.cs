// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTransportLayerApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of transport layer applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTransportLayerApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListTransportLayerApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The transport layer application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170997271816****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <para>The CNAME for the transport layer application. This parameter is returned only when the site is onboarded by using a CNAME record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.ialicdn.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>Specifies whether cross-border optimization is enabled for Chinese mainland network access. By default, this feature is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
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
            /// <para>Specifies whether the IP access rule feature is enabled. When enabled, the IP access rules in WAF apply to this transport layer application.</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
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
            /// <para>Specifies whether IPv6 is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public string Ipv6 { get; set; }

            /// <summary>
            /// <para>Specifies whether keep-alive protection is enabled.</para>
            /// </summary>
            [NameInMap("KeepAliveProtection")]
            [Validation(Required=false)]
            public string KeepAliveProtection { get; set; }

            /// <summary>
            /// <para>The domain name of the transport layer application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>A list of forwarding rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsRules> Rules { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsRules : TeaModel {
                /// <summary>
                /// <para>Specifies whether and how to pass the client\&quot;s IP address to the origin server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>off</b>: Disables client IP pass-through.</para>
                /// </description></item>
                /// <item><description><para><b>PPv1</b>: The PROXY Protocol v1, which supports client IP pass-through for TCP traffic.</para>
                /// </description></item>
                /// <item><description><para><b>PPv2</b>: The PROXY Protocol v2, which supports client IP pass-through for both TCP and UDP traffic.</para>
                /// </description></item>
                /// <item><description><para><b>SPP</b>: The Simple Proxy Protocol, which supports client IP pass-through for UDP traffic.</para>
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
                /// <item><description><para>A single port, for example, <c>80</c>.</para>
                /// </description></item>
                /// <item><description><para>A port range, for example, <c>81-85</c>, which includes ports 81, 82, 83, 84, and 85.</para>
                /// </description></item>
                /// <item><description><para>A combination of ports and port ranges separated by commas, for example, <c>80,81-85,90</c>, which includes ports 80, 81, 82, 83, 84, 85, and 90.</para>
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
                /// <para>The protocol of the forwarding rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>TCP</b>: The TCP protocol.</para>
                /// </description></item>
                /// <item><description><para><b>UDP</b>: The UDP protocol.</para>
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
                /// <para>The unique ID of the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20258028****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The origin address. The value of this parameter must match the <c>SourceType</c>.</para>
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
                /// <item><description><para>A single port. If you specify a single origin port, you can use any valid combination of edge ports.</para>
                /// </description></item>
                /// <item><description><para>A port range. The origin port can be a port range only if the edge port is also a port range. The number of ports in the origin port range must be the same as that in the edge port range. For example, if the edge port range is <c>90-93</c> (which contains 4 ports), you cannot set the origin port range to <c>81-85</c> (which contains 5 ports) because their sizes do not match.</para>
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
            /// <para>The number of forwarding rules in the transport layer application.</para>
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
            /// <para>Specifies whether the static IP feature is enabled. By default, this feature is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: Enabled.</para>
            /// </description></item>
            /// <item><description><para>off: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("StaticIp")]
            [Validation(Required=false)]
            public string StaticIp { get; set; }

            /// <summary>
            /// <para>A list of static IPv4 addresses assigned to the application when the static IP feature is enabled.</para>
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
                /// <para>The health status of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>healthy: The IP address is passing health checks.</para>
                /// </description></item>
                /// <item><description><para>unhealthy: The IP address is failing health checks.</para>
                /// </description></item>
                /// <item><description><para>unknown: The IP address is being provisioned.</para>
                /// </description></item>
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
            /// <para>The status of the transport layer application. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>deploying</b>: The application is being deployed. You cannot modify or delete the application in this state.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The application is running.</para>
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

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>The total number of transport layer applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
