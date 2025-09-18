// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateTransportLayerApplicationRequest : TeaModel {
        /// <summary>
        /// <para>Transport layer application ID, which can be obtained by calling the <a href="~~ListTransportLayerApplications~~">ListTransportLayerApplications</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>165503967****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Whether to enable China mainland network access optimization, default is disabled. Value range:</para>
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
        /// <para>IP access rule switch. When enabled, the IP access rules in WAF will take effect on the transport layer application.</para>
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
        /// <para>Forwarding rule list. Details of each rule. Except for the comment, all other parameters are required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateTransportLayerApplicationRequestRules> Rules { get; set; }
        public class UpdateTransportLayerApplicationRequestRules : TeaModel {
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
            /// <para>SPP</para>
            /// </summary>
            [NameInMap("ClientIPPassThroughMode")]
            [Validation(Required=false)]
            public string ClientIPPassThroughMode { get; set; }

            /// <summary>
            /// <para>Comment information for the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
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
            /// <item><description>Edge ports within a single rule and between multiple rules must not overlap.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("EdgePort")]
            [Validation(Required=false)]
            public string EdgePort { get; set; }

            /// <summary>
            /// <para>Forwarding rule protocol, supports:</para>
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
            /// <para>Specific value of the source.</para>
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
            /// <item><description>A single port, when the source port is a single port, any valid edge port combination is supported.</description></item>
            /// <item><description>Port range, only when the edge port is a port range, the source port can be set as a port range, and the size of the range must match that of the edge port. For example, if the edge port is 90-93, the source port cannot be set to 81-85 because the source port range is 5 and the edge port range is 3, which do not match.</description></item>
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
            /// <item><description><b>ip</b>: IP address.</description></item>
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
        /// <para>Site ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> interface.</para>
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
