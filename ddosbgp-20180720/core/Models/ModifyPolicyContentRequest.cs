// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyContentRequest : TeaModel {
        /// <summary>
        /// The content of the policy.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ModifyPolicyContentRequestContent Content { get; set; }
        public class ModifyPolicyContentRequestContent : TeaModel {
            /// <summary>
            /// The validity period of the IP address blacklist. The value is a UNIX timestamp.
            /// </summary>
            [NameInMap("BlackIpListExpireAt")]
            [Validation(Required=false)]
            public long? BlackIpListExpireAt { get; set; }

            /// <summary>
            /// Specifies whether to enable ICMP blocking.
            /// </summary>
            [NameInMap("EnableDropIcmp")]
            [Validation(Required=false)]
            public bool? EnableDropIcmp { get; set; }

            /// <summary>
            /// Specifies whether to enable intelligent protection.
            /// </summary>
            [NameInMap("EnableIntelligence")]
            [Validation(Required=false)]
            public bool? EnableIntelligence { get; set; }

            /// <summary>
            /// Specifies whether to enable port-specific mitigation.
            /// </summary>
            [NameInMap("EnableL4Defense")]
            [Validation(Required=false)]
            public bool? EnableL4Defense { get; set; }

            /// <summary>
            /// The byte-match filter rules.
            /// </summary>
            [NameInMap("FingerPrintRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentFingerPrintRuleList> FingerPrintRuleList { get; set; }
            public class ModifyPolicyContentRequestContentFingerPrintRuleList : TeaModel {
                /// <summary>
                /// The end of the destination port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// The start of the destination port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The action triggered if the rule is matched. Valid values:
                /// 
                /// *   **permit**: allows the traffic that matches the conditions in the byte-match filter rule.
                /// *   **drop**: discards the traffic that matches the conditions in the byte-match filter rule.
                /// *   **ip_rate**: limits rates on the source IP address whose traffic matches the conditions in the byte-match filter rule. The rate limit is specified by **RateValue**.
                /// *   **session_rate**: limits the number of sessions from the source IP address whose traffic matches the conditions in the byte-match filter rule. The rate limit is specified by **RateValue**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("MatchAction")]
                [Validation(Required=false)]
                public string MatchAction { get; set; }

                /// <summary>
                /// The maximum packet length. Valid values: **1** to **1500**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("MaxPktLen")]
                [Validation(Required=false)]
                public int? MaxPktLen { get; set; }

                /// <summary>
                /// The minimum packet length. Valid values: **1** to **1500**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("MinPktLen")]
                [Validation(Required=false)]
                public int? MinPktLen { get; set; }

                /// <summary>
                /// The offset. Valid values: **0** to **1500**.
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// The payload. The value is a hexadecimal string.
                /// </summary>
                [NameInMap("PayloadBytes")]
                [Validation(Required=false)]
                public string PayloadBytes { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   **tcp**
                /// *   **udp**
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The rate limit. Valid values: **1** to **100000**.
                /// 
                /// >  This parameter is required when **MatchAction** is set to **ip_rate** or **session_rate**.
                /// </summary>
                [NameInMap("RateValue")]
                [Validation(Required=false)]
                public int? RateValue { get; set; }

                /// <summary>
                /// The sequence number that indicates the order for the rule to take effect. The value is an integer.
                /// 
                /// >  A smaller number indicates a higher priority.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// The end of the source port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// The start of the source port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SrcPortStart")]
                [Validation(Required=false)]
                public int? SrcPortStart { get; set; }

            }

            /// <summary>
            /// The level of intelligent protection. Valid values:
            /// 
            /// *   **default**: normal.
            /// *   **hard**: strict.
            /// *   **weak**: loose.
            /// </summary>
            [NameInMap("IntelligenceLevel")]
            [Validation(Required=false)]
            public string IntelligenceLevel { get; set; }

            /// <summary>
            /// The port-specific mitigation rules.
            /// </summary>
            [NameInMap("L4RuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentL4RuleList> L4RuleList { get; set; }
            public class ModifyPolicyContentRequestContentL4RuleList : TeaModel {
                /// <summary>
                /// The action that is specified in the rule. Valid value:
                /// 
                /// *   **2**: The traffic is discarded.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The match conditions.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<ModifyPolicyContentRequestContentL4RuleListConditionList> ConditionList { get; set; }
                public class ModifyPolicyContentRequestContentL4RuleListConditionList : TeaModel {
                    /// <summary>
                    /// The term that is used for matching.
                    /// 
                    /// >  If Method is set to **char**, the value of this parameter must be ASCII strings. If Method is set to **hex**, the value of this parameter must be hexadecimal strings. Maximum length: 2,048.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Arg")]
                    [Validation(Required=false)]
                    public string Arg { get; set; }

                    /// <summary>
                    /// The number of bytes from the start position for matching. Valid values: **1** to **2048**.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Depth")]
                    [Validation(Required=false)]
                    public int? Depth { get; set; }

                    /// <summary>
                    /// The start position for matching. Valid values: **0** to **2047**.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }

                /// <summary>
                /// The minimum number of bytes in a session to trigger matching. Valid values: **0** to **2048**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Limited")]
                [Validation(Required=false)]
                public int? Limited { get; set; }

                /// <summary>
                /// The condition based on which an action is performed. Valid values:
                /// 
                /// *   **0**: If the rule is matched, the action specified in the rule is performed.
                /// *   **1**: If the rule is not matched, the action specified in the rule is performed.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public string Match { get; set; }

                /// <summary>
                /// The type of the rule. Valid values:
                /// 
                /// *   **char**: string match.
                /// *   **hex**: hexadecimal string match.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The name of the rule.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The priority of the rule. Valid values: 1 to 100.
                /// 
                /// >  A smaller value indicates a higher priority.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// The port blocking rules.
            /// </summary>
            [NameInMap("PortRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentPortRuleList> PortRuleList { get; set; }
            public class ModifyPolicyContentRequestContentPortRuleList : TeaModel {
                /// <summary>
                /// The end of the destination port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// The start of the destination port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// The ID of the rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The action triggered if the rule is matched. Valid value:
                /// 
                /// *   **drop**: The traffic is discarded.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("MatchAction")]
                [Validation(Required=false)]
                public string MatchAction { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   **tcp**
                /// *   **udp**
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// The sequence number that indicates the order for the rule to take effect. The value is an integer.
                /// 
                /// >  A smaller number indicates a higher priority.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// The end of the source port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// The start of the source port range. Valid values: **0** to **65535**.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("SrcPortStart")]
                [Validation(Required=false)]
                public int? SrcPortStart { get; set; }

            }

            /// <summary>
            /// The ports whose traffic is filtered out by the filtering policies for UDP reflection attacks.
            /// </summary>
            [NameInMap("ReflectBlockUdpPortList")]
            [Validation(Required=false)]
            public List<int?> ReflectBlockUdpPortList { get; set; }

            /// <summary>
            /// The countries in the location blacklist.
            /// </summary>
            [NameInMap("RegionBlockCountryList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockCountryList { get; set; }

            /// <summary>
            /// The provinces in the location blacklist.
            /// </summary>
            [NameInMap("RegionBlockProvinceList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockProvinceList { get; set; }

            /// <summary>
            /// The source IP addresses that are added to the blacklist.
            /// </summary>
            [NameInMap("SourceBlockList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentSourceBlockList> SourceBlockList { get; set; }
            public class ModifyPolicyContentRequestContentSourceBlockList : TeaModel {
                /// <summary>
                /// The validity period of the blacklist to which the source IP address is added. Unit: seconds.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("BlockExpireSeconds")]
                [Validation(Required=false)]
                public int? BlockExpireSeconds { get; set; }

                /// <summary>
                /// The statistical period during which the system collects data on source IP addresses to determine whether to add the source IP addresses to the blacklist. Unit: seconds.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("EverySeconds")]
                [Validation(Required=false)]
                public int? EverySeconds { get; set; }

                /// <summary>
                /// The number of times that the source IP address exceeds a limit in a statistical period.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("ExceedLimitTimes")]
                [Validation(Required=false)]
                public int? ExceedLimitTimes { get; set; }

                /// <summary>
                /// The type of the source rate limit. Valid values:
                /// 
                /// *   **3**: the PPS limit on source IP addresses.
                /// *   **4**: the bandwidth limit on source IP addresses.
                /// *   **5**: the PPS limit on source SYN packets.
                /// *   **6**: the bandwidth limit on source SYN packets.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// The settings for source rate limiting.
            /// </summary>
            [NameInMap("SourceLimit")]
            [Validation(Required=false)]
            public ModifyPolicyContentRequestContentSourceLimit SourceLimit { get; set; }
            public class ModifyPolicyContentRequestContentSourceLimit : TeaModel {
                /// <summary>
                /// The bandwidth limit on source IP addresses. Unit: bytes per second.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public int? Bps { get; set; }

                /// <summary>
                /// The packets per second (PPS) limit on source IP addresses.
                /// </summary>
                [NameInMap("Pps")]
                [Validation(Required=false)]
                public int? Pps { get; set; }

                /// <summary>
                /// The bandwidth limit on source SYN packets. Unit: bytes per second.
                /// </summary>
                [NameInMap("SynBps")]
                [Validation(Required=false)]
                public int? SynBps { get; set; }

                /// <summary>
                /// The PPS limit on source SYN packets.
                /// </summary>
                [NameInMap("SynPps")]
                [Validation(Required=false)]
                public int? SynPps { get; set; }

            }

            /// <summary>
            /// Specifies whether to add back-to-origin CIDR blocks of Anti-DDoS Proxy to the whitelist.
            /// </summary>
            [NameInMap("WhitenGfbrNets")]
            [Validation(Required=false)]
            public bool? WhitenGfbrNets { get; set; }

        }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
