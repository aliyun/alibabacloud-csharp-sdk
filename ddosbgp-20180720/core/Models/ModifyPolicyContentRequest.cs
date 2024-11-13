// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyContentRequest : TeaModel {
        /// <summary>
        /// <para>The policy content.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ModifyPolicyContentRequestContent Content { get; set; }
        public class ModifyPolicyContentRequestContent : TeaModel {
            /// <summary>
            /// <para>The validity period of the IP address blacklist. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716878000</para>
            /// </summary>
            [NameInMap("BlackIpListExpireAt")]
            [Validation(Required=false)]
            public long? BlackIpListExpireAt { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable ICMP blocking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDropIcmp")]
            [Validation(Required=false)]
            public bool? EnableDropIcmp { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable intelligent protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligence")]
            [Validation(Required=false)]
            public bool? EnableIntelligence { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable port-specific mitigation.</para>
            /// </summary>
            [NameInMap("EnableL4Defense")]
            [Validation(Required=false)]
            public bool? EnableL4Defense { get; set; }

            /// <summary>
            /// <para>The byte-match filter rules.</para>
            /// </summary>
            [NameInMap("FingerPrintRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentFingerPrintRuleList> FingerPrintRuleList { get; set; }
            public class ModifyPolicyContentRequestContentFingerPrintRuleList : TeaModel {
                /// <summary>
                /// <para>The end of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// <para>The start of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The action triggered if the rule is matched. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>permit</b>: allows the traffic that matches the conditions in the byte-match filter rule.</description></item>
                /// <item><description><b>drop</b>: discards the traffic that matches the conditions in the byte-match filter rule.</description></item>
                /// <item><description><b>ip_rate</b>: limits rates on the source IP address whose traffic matches the conditions in the byte-match filter rule. The rate limit is specified by <b>RateValue</b>.</description></item>
                /// <item><description><b>session_rate</b>: limits the number of sessions from the source IP address whose traffic matches the conditions in the byte-match filter rule. The rate limit is specified by <b>RateValue</b>.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drop</para>
                /// </summary>
                [NameInMap("MatchAction")]
                [Validation(Required=false)]
                public string MatchAction { get; set; }

                /// <summary>
                /// <para>The maximum packet length. Valid values: <b>1</b> to <b>1500</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1500</para>
                /// </summary>
                [NameInMap("MaxPktLen")]
                [Validation(Required=false)]
                public int? MaxPktLen { get; set; }

                /// <summary>
                /// <para>The minimum packet length. Valid values: <b>1</b> to <b>1500</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinPktLen")]
                [Validation(Required=false)]
                public int? MinPktLen { get; set; }

                /// <summary>
                /// <para>The offset. Valid values: <b>0</b> to <b>1500</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The payload. The value is a hexadecimal string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("PayloadBytes")]
                [Validation(Required=false)]
                public string PayloadBytes { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>tcp</b></description></item>
                /// <item><description><b>udp</b></description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The rate limit. Valid values: <b>1</b> to <b>100000</b>.</para>
                /// <remarks>
                /// <para> This parameter is required when <b>MatchAction</b> is set to <b>ip_rate</b> or <b>session_rate</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RateValue")]
                [Validation(Required=false)]
                public int? RateValue { get; set; }

                /// <summary>
                /// <para>The sequence number that indicates the order for the rule to take effect. The value is an integer.</para>
                /// <remarks>
                /// <para> A smaller number indicates a higher priority.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// <para>The end of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// <para>The start of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SrcPortStart")]
                [Validation(Required=false)]
                public int? SrcPortStart { get; set; }

            }

            /// <summary>
            /// <para>The level of intelligent protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: normal.</description></item>
            /// <item><description><b>hard</b>: strict.</description></item>
            /// <item><description><b>weak</b>: loose.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("IntelligenceLevel")]
            [Validation(Required=false)]
            public string IntelligenceLevel { get; set; }

            /// <summary>
            /// <para>The port-specific mitigation rules.</para>
            /// </summary>
            [NameInMap("L4RuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentL4RuleList> L4RuleList { get; set; }
            public class ModifyPolicyContentRequestContentL4RuleList : TeaModel {
                /// <summary>
                /// <para>The action that is specified in the rule. Valid value:</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: The traffic is discarded.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The match conditions.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<ModifyPolicyContentRequestContentL4RuleListConditionList> ConditionList { get; set; }
                public class ModifyPolicyContentRequestContentL4RuleListConditionList : TeaModel {
                    /// <summary>
                    /// <para>The term that is used for matching.</para>
                    /// <remarks>
                    /// <para> If Method is set to <b>char</b>, the value of this parameter must be ASCII strings. If Method is set to <b>hex</b>, the value of this parameter must be hexadecimal strings. Maximum length: 2,048.</para>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abcd</para>
                    /// </summary>
                    [NameInMap("Arg")]
                    [Validation(Required=false)]
                    public string Arg { get; set; }

                    /// <summary>
                    /// <para>The number of bytes from the start position for matching. Valid values: <b>1</b> to <b>2048</b>.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("Depth")]
                    [Validation(Required=false)]
                    public int? Depth { get; set; }

                    /// <summary>
                    /// <para>The start position for matching. Valid values: <b>0</b> to <b>2047</b>.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }

                /// <summary>
                /// <para>The minimum number of bytes in a session to trigger matching. Valid values: <b>0</b> to <b>2048</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Limited")]
                [Validation(Required=false)]
                public int? Limited { get; set; }

                /// <summary>
                /// <para>The condition based on which an action is performed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: If the rule is matched, the action specified in the rule is performed.</description></item>
                /// <item><description><b>1</b>: If the rule is not matched, the action specified in the rule is performed.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public string Match { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>char</b>: string match.</description></item>
                /// <item><description><b>hex</b>: hexadecimal string match.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>char</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test**</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The priority of the rule. Valid values: 1 to 100.</para>
                /// <remarks>
                /// <para> A smaller value indicates a higher priority.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The port blocking rules.</para>
            /// </summary>
            [NameInMap("PortRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentPortRuleList> PortRuleList { get; set; }
            public class ModifyPolicyContentRequestContentPortRuleList : TeaModel {
                /// <summary>
                /// <para>The end of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// <para>The start of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// <para>The ID of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>412a7312-58ff-4e32-a202-0ab0*******</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The action triggered if the rule is matched. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>drop</b>: The traffic is discarded.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>drop</para>
                /// </summary>
                [NameInMap("MatchAction")]
                [Validation(Required=false)]
                public string MatchAction { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>tcp</b></description></item>
                /// <item><description><b>udp</b></description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The sequence number that indicates the order for the rule to take effect. The value is an integer.</para>
                /// <remarks>
                /// <para> A smaller number indicates a higher priority.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// <para>The end of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// <para>The start of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SrcPortStart")]
                [Validation(Required=false)]
                public int? SrcPortStart { get; set; }

            }

            /// <summary>
            /// <para>The ports whose traffic is filtered out by the filtering policies for UDP reflection attacks.</para>
            /// </summary>
            [NameInMap("ReflectBlockUdpPortList")]
            [Validation(Required=false)]
            public List<int?> ReflectBlockUdpPortList { get; set; }

            /// <summary>
            /// <para>The countries in the location blacklist.</para>
            /// </summary>
            [NameInMap("RegionBlockCountryList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockCountryList { get; set; }

            /// <summary>
            /// <para>The provinces in the location blacklist.</para>
            /// </summary>
            [NameInMap("RegionBlockProvinceList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockProvinceList { get; set; }

            /// <summary>
            /// <para>The source IP addresses that are added to the blacklist.</para>
            /// </summary>
            [NameInMap("SourceBlockList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentSourceBlockList> SourceBlockList { get; set; }
            public class ModifyPolicyContentRequestContentSourceBlockList : TeaModel {
                /// <summary>
                /// <para>The validity period of the blacklist to which the source IP address is added. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("BlockExpireSeconds")]
                [Validation(Required=false)]
                public int? BlockExpireSeconds { get; set; }

                /// <summary>
                /// <para>The statistical period during which the system collects data on source IP addresses to determine whether to add the source IP addresses to the blacklist. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("EverySeconds")]
                [Validation(Required=false)]
                public int? EverySeconds { get; set; }

                /// <summary>
                /// <para>The number of times that the source IP address exceeds a limit in a statistical period.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ExceedLimitTimes")]
                [Validation(Required=false)]
                public int? ExceedLimitTimes { get; set; }

                /// <summary>
                /// <para>The type of the source rate limit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>3</b>: the pps limit on source IP addresses.</description></item>
                /// <item><description><b>4</b>: the bandwidth limit on source IP addresses.</description></item>
                /// <item><description><b>5</b>: the pps limit on source SYN packets.</description></item>
                /// <item><description><b>6</b>: the bandwidth limit on source SYN packets.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <para>The settings for source rate limiting.</para>
            /// </summary>
            [NameInMap("SourceLimit")]
            [Validation(Required=false)]
            public ModifyPolicyContentRequestContentSourceLimit SourceLimit { get; set; }
            public class ModifyPolicyContentRequestContentSourceLimit : TeaModel {
                /// <summary>
                /// <para>The bandwidth limit on source IP addresses. Unit: bytes per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public int? Bps { get; set; }

                /// <summary>
                /// <para>The packets per second (pps) limit on source IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Pps")]
                [Validation(Required=false)]
                public int? Pps { get; set; }

                /// <summary>
                /// <para>The bandwidth limit on source SYN packets. Unit: bytes per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("SynBps")]
                [Validation(Required=false)]
                public int? SynBps { get; set; }

                /// <summary>
                /// <para>The pps limit on source SYN packets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("SynPps")]
                [Validation(Required=false)]
                public int? SynPps { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to add back-to-origin CIDR blocks of Anti-DDoS Proxy to the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WhitenGfbrNets")]
            [Validation(Required=false)]
            public bool? WhitenGfbrNets { get; set; }

        }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
