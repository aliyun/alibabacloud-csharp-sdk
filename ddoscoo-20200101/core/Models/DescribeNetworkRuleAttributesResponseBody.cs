// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRuleAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the mitigation settings of the port forwarding rule for a non-website service. The mitigation settings include session persistence and DDoS mitigation policies.</para>
        /// </summary>
        [NameInMap("NetworkRuleAttributes")]
        [Validation(Required=false)]
        public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes> NetworkRuleAttributes { get; set; }
        public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes : TeaModel {
            /// <summary>
            /// <para>The mitigation settings of the port forwarding rule.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig Config { get; set; }
            public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig : TeaModel {
                /// <summary>
                /// <para>The protection policy applied when the number of connections initiated from a source IP address frequently exceeds the limit.</para>
                /// </summary>
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc Cc { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc : TeaModel {
                    /// <summary>
                    /// <para>The protection policy that a source IP address is added to the blacklist when the number of connections initiated from the IP address frequently exceeds the limit.</para>
                    /// </summary>
                    [NameInMap("Sblack")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack> Sblack { get; set; }
                    public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack : TeaModel {
                        /// <summary>
                        /// <para>The threshold that the number of connections initiated from a source IP address can exceed the limit. Set the value to <b>5</b>. If the number of connections initiated from a source IP address exceeds the limit five times during the check, the source IP address is added to the blacklist.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                        /// <summary>
                        /// <para>The interval at which checks are performed. Set the value to <b>60</b>. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        /// <summary>
                        /// <para>The validity period of the IP address in the blacklist. Valid values: <b>60</b> to <b>604800</b>. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>600</para>
                        /// </summary>
                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        /// <summary>
                        /// <para>The type of the limit that causes a source IP address to be added to the blacklist. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>1</b>: Source New Connection Rate Limit</description></item>
                        /// <item><description><b>2</b>: Source Concurrent Connection Rate Limit</description></item>
                        /// <item><description><b>3</b>: PPS Limit for Source</description></item>
                        /// <item><description><b>4</b>: Bandwidth Limit for Source</description></item>
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
                /// <para>The status of the Empty Connection switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: The switch is turned on.</description></item>
                /// <item><description><b>off</b>: The switch is turned off.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }

                /// <summary>
                /// <para>The settings of the Packet Length Limit policy.</para>
                /// </summary>
                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen PayloadLen { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen : TeaModel {
                    /// <summary>
                    /// <para>The maximum length of a packet. Valid values: <b>0</b> to <b>6000</b>. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6000</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <para>The minimum length of a packet. Valid values: <b>0</b> to <b>6000</b>. Unit: bytes.</para>
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
                /// <para>The settings of the Speed Limit for Destination policy.</para>
                /// </summary>
                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla Sla { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of new connections per second that can be established over the port of the destination instance. Valid values: <b>100</b> to <b>100000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100000</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <para>The status of the Destination New Connection Rate Limit switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The switch is turned off.</description></item>
                    /// <item><description><b>1</b>: The switch is turned on.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent connections that can be established over the port of the destination instance. Valid values: <b>1000</b> to <b>1000000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <para>The status of the Destination Concurrent Connection Rate Limit switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The switch is turned off.</description></item>
                    /// <item><description><b>1</b>: The switch is turned on.</description></item>
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
                /// <para>The settings of the Speed Limit for Source policy.</para>
                /// </summary>
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit Slimit { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit : TeaModel {
                    /// <summary>
                    /// <para>The bandwidth limit for a source IP address. Valid values: <b>1024</b> to <b>268435456</b>. Unit: bytes/s. Default value: <b>0</b>, which indicates that the bandwidth for a source IP address is unlimited.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    /// <summary>
                    /// <para>The maximum number of new connections per second that can be initiated from a source IP address. Valid values: <b>1</b> to <b>500000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <para>The status of the Source New Connection Rate Limit switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The switch is turned off.</description></item>
                    /// <item><description><b>1</b>: The switch is turned on.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <para>The mode of the Source New Connection Rate Limit switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: the manual mode</description></item>
                    /// <item><description><b>2</b>: the automatic mode</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent connections initiated from a source IP address. Valid values: <b>1</b> to <b>500000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <para>The status of the Source Concurrent Connection Rate Limit switch. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: The switch is turned off.</description></item>
                    /// <item><description><b>1</b>: The switch is turned on.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    /// <summary>
                    /// <para>The packets per second (pps) limit for a source IP address. Valid values: <b>1</b> to <b>100000</b>. Unit: packets/s. Default value: <b>0</b>, which indicates that the pps for a source IP address is unlimited.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                }

                /// <summary>
                /// <para>The status of the False Source switch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: The switch is turned on.</description></item>
                /// <item><description><b>off</b>: The switch is turned off.</description></item>
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
            /// <para>The ID of the instance.</para>
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
