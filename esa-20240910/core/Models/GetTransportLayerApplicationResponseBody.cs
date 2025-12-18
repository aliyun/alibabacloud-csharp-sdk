// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetTransportLayerApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>Specific value of the origin, which needs to match the type of the origin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17099311410****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Whether to enable China mainland network access optimization, default is off. Value range:</para>
        /// <list type="bullet">
        /// <item><description>on: Enabled.</description></item>
        /// <item><description>off: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com.ialicdn.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("CrossBorderOptimization")]
        [Validation(Required=false)]
        public string CrossBorderOptimization { get; set; }

        /// <summary>
        /// <para>#/components/schemas/WafRuleMatch2</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("IpAccessRule")]
        [Validation(Required=false)]
        public string IpAccessRule { get; set; }

        /// <summary>
        /// <para>Ipv6 switch</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// <para>Query Transport Layer Acceleration Application</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB635996-1FD6-5DFD-BA57-27A849599940</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Edge port. Supports:</para>
        /// <list type="bullet">
        /// <item><description>A single port, such as 80.</description></item>
        /// <item><description>Port range, such as 81-85, representing ports 81, 82, 83, 84, 85.</description></item>
        /// <item><description>Combination of ports and port ranges, separated by commas, for example 80,81-85,90, representing ports 80, 81, 82, 83, 84, 85, 90.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<GetTransportLayerApplicationResponseBodyRules> Rules { get; set; }
        public class GetTransportLayerApplicationResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The domain name of the transport layer application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>Switch for IP access rules. When turned on, the IP access rules in WAF take effect on the transport layer application.</para>
            /// <list type="bullet">
            /// <item><description>on: Turned on.</description></item>
            /// <item><description>off: Turned off.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv6 switch.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Comment information of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EdgePort")]
            [Validation(Required=false)]
            public string EdgePort { get; set; }

            /// <summary>
            /// <para>Client IP pass-through protocol, supporting:</para>
            /// <list type="bullet">
            /// <item><description><b>off</b>: No pass-through.</description></item>
            /// <item><description><b>PPv1</b>: PROXY Protocol v1, supports client IP pass-through for TCP protocol.</description></item>
            /// <item><description><b>PPv2</b>: PROXY Protocol v2, supports client IP pass-through for TCP and UDP protocols.</description></item>
            /// <item><description><b>SPP</b>: Simple Proxy Protocol, supports client IP pass-through for UDP protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Status of the transport layer application</para>
            /// <list type="bullet">
            /// <item><description><b>deploying</b>: Deploying. In this state, modification and deletion are not allowed.</description></item>
            /// <item><description><b>active</b>: Active.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1234323***</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>Origin port. Supports:</para>
            /// <list type="bullet">
            /// <item><description>A single port, when the origin port is a single port, any valid edge port combination is supported.</description></item>
            /// <item><description>Port range, only when the edge port is a port range, the origin port can be set as a port range and the size of the range must be consistent with the edge port. For example, if the edge port is 90-93, the origin port cannot be set to 81-85 because the origin port range is 5 and the edge port range is 3, which are inconsistent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The CNAME domain corresponding to the transport layer acceleration application. This field is not empty only when the site is accessed via CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public string SourcePort { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// <para>Forwarding rule protocol, with values:</para>
        /// <list type="bullet">
        /// <item><description>TCP: TCP protocol.</description></item>
        /// <item><description>UDP: UDP protocol.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RulesCount")]
        [Validation(Required=false)]
        public int? RulesCount { get; set; }

        /// <summary>
        /// <para>Details of the forwarding rule.</para>
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
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
