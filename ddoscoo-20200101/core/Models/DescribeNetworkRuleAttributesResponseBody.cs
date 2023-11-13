// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRuleAttributesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the mitigation settings of the port forwarding rule for a non-website service. The mitigation settings include session persistence and DDoS mitigation policies.
        /// </summary>
        [NameInMap("NetworkRuleAttributes")]
        [Validation(Required=false)]
        public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes> NetworkRuleAttributes { get; set; }
        public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes : TeaModel {
            /// <summary>
            /// The mitigation settings of the port forwarding rule.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig Config { get; set; }
            public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig : TeaModel {
                /// <summary>
                /// The protection policy applied when the number of connections initiated from a source IP address frequently exceeds the limit.
                /// </summary>
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc Cc { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc : TeaModel {
                    /// <summary>
                    /// The protection policy that a source IP address is added to the blacklist when the number of connections initiated from the IP address frequently exceeds the limit.
                    /// </summary>
                    [NameInMap("Sblack")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack> Sblack { get; set; }
                    public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack : TeaModel {
                        /// <summary>
                        /// The threshold that the number of connections initiated from a source IP address can exceed the limit. Set the value to **5**. If the number of connections initiated from a source IP address exceeds the limit five times during the check, the source IP address is added to the blacklist.
                        /// </summary>
                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                        /// <summary>
                        /// The interval at which checks are performed. Set the value to **60**. Unit: seconds.
                        /// </summary>
                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        /// <summary>
                        /// The validity period of the IP address in the blacklist. Valid values: **60** to **604800**. Unit: seconds.
                        /// </summary>
                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        /// <summary>
                        /// The type of the limit that causes a source IP address to be added to the blacklist. Valid values:
                        /// 
                        /// *   **1**: Source New Connection Rate Limit
                        /// *   **2**: Source Concurrent Connection Rate Limit
                        /// *   **3**: PPS Limit for Source
                        /// *   **4**: Bandwidth Limit for Source
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                }

                /// <summary>
                /// The status of the Empty Connection switch. Valid values:
                /// 
                /// *   **on**: The switch is turned on.
                /// *   **off**: The switch is turned off.
                /// </summary>
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }

                /// <summary>
                /// The settings of the Packet Length Limit policy.
                /// </summary>
                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen PayloadLen { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen : TeaModel {
                    /// <summary>
                    /// The maximum length of a packet. Valid values: **0** to **6000**. Unit: bytes.
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// The minimum length of a packet. Valid values: **0** to **6000**. Unit: bytes.
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// The timeout period of session persistence. Valid values: **30** to **3600**. Unit: seconds. Default value: **0**, which indicates that session persistence is disabled.
                /// </summary>
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }

                /// <summary>
                /// The settings of the Speed Limit for Destination policy.
                /// </summary>
                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla Sla { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla : TeaModel {
                    /// <summary>
                    /// The maximum number of new connections per second that can be established over the port of the destination instance. Valid values: **100** to **100000**.
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// The status of the Destination New Connection Rate Limit switch. Valid values:
                    /// 
                    /// *   **0**: The switch is turned off.
                    /// *   **1**: The switch is turned on.
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// The maximum number of concurrent connections that can be established over the port of the destination instance. Valid values: **1000** to **1000000**.
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// The status of the Destination Concurrent Connection Rate Limit switch. Valid values:
                    /// 
                    /// *   **0**: The switch is turned off.
                    /// *   **1**: The switch is turned on.
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                }

                /// <summary>
                /// The settings of the Speed Limit for Source policy.
                /// </summary>
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit Slimit { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit : TeaModel {
                    /// <summary>
                    /// The bandwidth limit for a source IP address. Valid values: **1024** to **268435456**. Unit: bytes/s. Default value: **0**, which indicates that the bandwidth for a source IP address is unlimited.
                    /// </summary>
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    /// <summary>
                    /// The maximum number of new connections per second that can be initiated from a source IP address. Valid values: **1** to **500000**.
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// The status of the Source New Connection Rate Limit switch. Valid values:
                    /// 
                    /// *   **0**: The switch is turned off.
                    /// *   **1**: The switch is turned on.
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// The mode of the Source New Connection Rate Limit switch. Valid values:
                    /// 
                    /// *   **1**: the manual mode
                    /// *   **2**: the automatic mode
                    /// </summary>
                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                    /// <summary>
                    /// The maximum number of concurrent connections initiated from a source IP address. Valid values: **1** to **500000**.
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// The status of the Source Concurrent Connection Rate Limit switch. Valid values:
                    /// 
                    /// *   **0**: The switch is turned off.
                    /// *   **1**: The switch is turned on.
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    /// <summary>
                    /// The packets per second (pps) limit for a source IP address. Valid values: **1** to **100000**. Unit: packets/s. Default value: **0**, which indicates that the pps for a source IP address is unlimited.
                    /// </summary>
                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                }

                /// <summary>
                /// The status of the False Source switch. Valid values:
                /// 
                /// *   **on**: The switch is turned on.
                /// *   **off**: The switch is turned off.
                /// </summary>
                [NameInMap("Synproxy")]
                [Validation(Required=false)]
                public string Synproxy { get; set; }

            }

            /// <summary>
            /// The forwarding port.
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The forwarding protocol. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
