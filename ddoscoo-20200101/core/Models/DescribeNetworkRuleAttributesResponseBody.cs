// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRuleAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The protection settings of port forwarding rules for non-website services, including session persistence and DDoS mitigation policies.</para>
        /// </summary>
        [NameInMap("NetworkRuleAttributes")]
        [Validation(Required=false)]
        public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes> NetworkRuleAttributes { get; set; }
        public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes : TeaModel {
            /// <summary>
            /// <para>The protection settings of the port forwarding rules.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig Config { get; set; }
            public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig : TeaModel {
                /// <summary>
                /// <para>The policy for controlling sources that frequently exceed connection limits.</para>
                /// </summary>
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc Cc { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc : TeaModel {
                    /// <summary>
                    /// <para>The policy for adding a source IP address to the blacklist when the source connection exceeds the limit multiple times.</para>
                    /// </summary>
                    [NameInMap("Sblack")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack> Sblack { get; set; }
                    public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack : TeaModel {
                        /// <summary>
                        /// <para>The number of times the source connection exceeds the limit. The value is fixed at <b>5</b>, which indicates that if the source connection exceeds the limit 5 times within the check interval, the source IP address is added to the blacklist.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                        /// <summary>
                        /// <para>The check interval. The value is fixed at <b>60</b>. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        /// <summary>
                        /// <para>The validity period of the blacklist entry. Valid values: <b>60</b> to <b>604800</b>. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        /// <summary>
                        /// <para>The type of the source IP address blacklist configuration. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>1</b>: IP blacklist for the maximum number of new connections from a source IP address.</description></item>
                        /// <item><description><b>2</b>: IP blacklist for the maximum number of concurrent connections from a source IP address.</description></item>
                        /// <item><description><b>3</b>: IP blacklist for source PPS rate limiting.</description></item>
                        /// <item><description><b>4</b>: IP blacklist for source bandwidth throttling.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The status of the Empty Connection filter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enabled.</description></item>
                /// <item><description><b>off</b>: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }

                /// <summary>
                /// <para>The Packet Length Limit configuration.</para>
                /// </summary>
                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen PayloadLen { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen : TeaModel {
                    /// <summary>
                    /// <para>The maximum packet length. Valid values: <b>0</b> to <b>6000</b>. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6000</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <para>The minimum packet length. Valid values: <b>0</b> to <b>6000</b>. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <para>The timeout period of session persistence. Valid values: <b>30</b> to <b>3600</b>. Unit: seconds. Default value: <b>0</b>, which indicates that session persistence is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }

                /// <summary>
                /// <para>The Speed Limit for Destination configuration.</para>
                /// </summary>
                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla Sla { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of new connections to a destination IP address. Valid values: <b>100</b> to <b>100000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <para>The status of the maximum number of new connections to a destination IP address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent connections to a destination IP address. Valid values: <b>1000</b> to <b>1000000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <para>The status of the maximum number of concurrent connections to a destination IP address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                }

                /// <summary>
                /// <para>The source rate limiting configuration.</para>
                /// </summary>
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit Slimit { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit : TeaModel {
                    /// <summary>
                    /// <para>The source bandwidth throttling value. Valid values: <b>1024</b> to <b>268435456</b>. Unit: Byte/s. Default value: <b>0</b>, which indicates that source bandwidth throttling is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    /// <summary>
                    /// <para>The maximum number of new connections from a source IP address. Valid values: <b>1</b> to <b>500000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <para>The status of the maximum number of new connections from a source IP address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <para>The mode of the maximum number of new connections from a source IP address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: manual.</description></item>
                    /// <item><description><b>2</b>: automatic.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent connections from a source IP address. Valid values: <b>1</b> to <b>500000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <para>The status of the maximum number of concurrent connections from a source IP address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    /// <summary>
                    /// <para>The source packets per second (PPS) rate limit. Valid values: <b>1</b> to <b>100000</b>. Unit: Packet/s. Default value: <b>0</b>, which indicates that source PPS rate limiting is disabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                }

                /// <summary>
                /// <para>The status of the False Source filter. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enabled.</description></item>
                /// <item><description><b>off</b>: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Synproxy")]
                [Validation(Required=false)]
                public string Synproxy { get; set; }

            }

            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9F2F77D-307C-4F15-8D02-AB5957EEBF97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
