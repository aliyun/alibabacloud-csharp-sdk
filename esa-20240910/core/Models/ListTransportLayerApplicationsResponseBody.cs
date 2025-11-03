// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListTransportLayerApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of transport layer applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTransportLayerApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListTransportLayerApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>Layer 4 application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170997271816****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <para>CNAME domain name corresponding to the Layer 4 acceleration application. This field is not empty only when the site is accessed via CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.ialicdn.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>Whether to enable China mainland network access optimization. It is disabled by default. The value range is:</para>
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
            /// <para>IP access rule switch. When enabled, the IP access rules in WAF take effect on the Layer 4 application.</para>
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
            /// <para>IPv6 switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Ipv6")]
            [Validation(Required=false)]
            public string Ipv6 { get; set; }

            /// <summary>
            /// <para>Domain name of the Layer 4 application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>List of forwarding rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsRules> Rules { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsRules : TeaModel {
                /// <summary>
                /// <para>Client IP pass-through protocol, supports:</para>
                /// <list type="bullet">
                /// <item><description><b>off</b>: No pass-through.</description></item>
                /// <item><description><b>PPv1</b>: PROXY Protocol v1, supports client IP pass-through for TCP protocol.</description></item>
                /// <item><description><b>PPv2</b>: PROXY Protocol v2, supports client IP pass-through for TCP and UDP protocols.</description></item>
                /// <item><description><b>SPP</b>: Simple Proxy Protocol, supports client IP pass-through for UDP protocol.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("ClientIPPassThroughMode")]
                [Validation(Required=false)]
                public string ClientIPPassThroughMode { get; set; }

                /// <summary>
                /// <para>Comment information for the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>Edge port. Supports:</para>
                /// <list type="bullet">
                /// <item><description>A single port, e.g., 80.</description></item>
                /// <item><description>Port range, e.g., 81-85, representing ports 81, 82, 83, 84, 85.</description></item>
                /// <item><description>Combination of ports and port ranges, separated by commas, e.g., 80,81-85,90, representing ports 80, 81, 82, 83, 84, 85, 90.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("EdgePort")]
                [Validation(Required=false)]
                public string EdgePort { get; set; }

                /// <summary>
                /// <para>Forwarding rule protocol, with values:</para>
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
                /// <para>Layer 4 acceleration rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20258028****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>Specific value of the source, which needs to match the source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Source port. Supports:</para>
                /// <list type="bullet">
                /// <item><description>A single port, when the source port is a single port, any valid combination of edge ports is supported.</description></item>
                /// <item><description>Port range, only when the edge port is a port range, the source port can be set to a port range, and the range size must be consistent with the edge port. For example, if the edge port is 90-93, the source port cannot be set to 81-85 because the source port range is 5 and the edge port range is 3, which are inconsistent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("SourcePort")]
                [Validation(Required=false)]
                public string SourcePort { get; set; }

                /// <summary>
                /// <para>Source type, supports:</para>
                /// <list type="bullet">
                /// <item><description><b>ip</b>: IP.</description></item>
                /// <item><description><b>domain</b>: Domain name.</description></item>
                /// <item><description><b>OP</b>: Origin pool.</description></item>
                /// <item><description><b>LB</b>: Load balancer.</description></item>
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
            /// <para>Number of forwarding rules contained in the Layer 4 acceleration application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RulesCount")]
            [Validation(Required=false)]
            public int? RulesCount { get; set; }

            /// <summary>
            /// <para>Site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36556540048****</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            [NameInMap("StaticIp")]
            [Validation(Required=false)]
            public string StaticIp { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("StaticIpV4List")]
            [Validation(Required=false)]
            public List<ListTransportLayerApplicationsResponseBodyApplicationsStaticIpV4List> StaticIpV4List { get; set; }
            public class ListTransportLayerApplicationsResponseBodyApplicationsStaticIpV4List : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Status of the Layer 4 application</para>
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
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of transport layer applications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
