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
            /// <para>The expiration time of the IP blacklist (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1716878000</para>
            /// </summary>
            [NameInMap("BlackIpListExpireAt")]
            [Validation(Required=false)]
            public long? BlackIpListExpireAt { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the ICMP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableDropIcmp")]
            [Validation(Required=false)]
            public bool? EnableDropIcmp { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable AI-based intelligent protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIntelligence")]
            [Validation(Required=false)]
            public bool? EnableIntelligence { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable port protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableL4Defense")]
            [Validation(Required=false)]
            public bool? EnableL4Defense { get; set; }

            /// <summary>
            /// <para>The list of byte-match filter rules.</para>
            /// </summary>
            [NameInMap("FingerPrintRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentFingerPrintRuleList> FingerPrintRuleList { get; set; }
            public class ModifyPolicyContentRequestContentFingerPrintRuleList : TeaModel {
                /// <summary>
                /// <para>The end value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// <para>The start value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The action to take when a fingerprint match is found. Valid values:</para>
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
                /// <para>The detection payload, expressed in hexadecimal string format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("PayloadBytes")]
                [Validation(Required=false)]
                public string PayloadBytes { get; set; }

                /// <summary>
                /// <para>The protocol type. Valid values:</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The rate limit value. Valid values: <b>1</b> to <b>100000</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RateValue")]
                [Validation(Required=false)]
                public int? RateValue { get; set; }

                /// <summary>
                /// <para>The priority number, expressed as an integer.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// <para>The end value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// <para>The start value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
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
            /// <para>The protection level of AI-based intelligent protection. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("IntelligenceLevel")]
            [Validation(Required=false)]
            public string IntelligenceLevel { get; set; }

            /// <summary>
            /// <para>The list of port-specific mitigation rules.</para>
            /// </summary>
            [NameInMap("L4RuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentL4RuleList> L4RuleList { get; set; }
            public class ModifyPolicyContentRequestContentL4RuleList : TeaModel {
                /// <summary>
                /// <para>The action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of detection conditions.</para>
                /// </summary>
                [NameInMap("ConditionList")]
                [Validation(Required=false)]
                public List<ModifyPolicyContentRequestContentL4RuleListConditionList> ConditionList { get; set; }
                public class ModifyPolicyContentRequestContentL4RuleListConditionList : TeaModel {
                    /// <summary>
                    /// <para>The detection content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abcd</para>
                    /// </summary>
                    [NameInMap("Arg")]
                    [Validation(Required=false)]
                    public string Arg { get; set; }

                    /// <summary>
                    /// <para>The matching content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test**</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The detection window length. Valid values: <b>1</b> to <b>2048</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("Depth")]
                    [Validation(Required=false)]
                    public int? Depth { get; set; }

                    /// <summary>
                    /// <para>The character type. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>str</para>
                    /// </summary>
                    [NameInMap("Encode")]
                    [Validation(Required=false)]
                    public string Encode { get; set; }

                    /// <summary>
                    /// <para>The matching range.</para>
                    /// </summary>
                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public ModifyPolicyContentRequestContentL4RuleListConditionListOffset Offset { get; set; }
                    public class ModifyPolicyContentRequestContentL4RuleListConditionListOffset : TeaModel {
                        /// <summary>
                        /// <para>The end position. Valid values: <b>0</b> to <b>1499</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1499</para>
                        /// </summary>
                        [NameInMap("End")]
                        [Validation(Required=false)]
                        public int? End { get; set; }

                        /// <summary>
                        /// <para>The start position. Valid values: <b>0</b> to <b>1499</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Start")]
                        [Validation(Required=false)]
                        public int? Start { get; set; }

                    }

                    /// <summary>
                    /// <para>The matching pattern. Valid values:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>contain</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    /// <summary>
                    /// <para>The detection start position. Valid values: <b>0</b> to <b>2047</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }

                /// <summary>
                /// <para>The minimum number of bytes in a session flow that triggers rule matching. Valid values: <b>0</b> to <b>2048</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Limited")]
                [Validation(Required=false)]
                public int? Limited { get; set; }

                /// <summary>
                /// <para>The logical operator. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Match")]
                [Validation(Required=false)]
                public string Match { get; set; }

                /// <summary>
                /// <para>The rule type. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>char</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The rule name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test**</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The rule priority. Valid values: 1 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of port blocking rules.</para>
            /// </summary>
            [NameInMap("PortRuleList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentPortRuleList> PortRuleList { get; set; }
            public class ModifyPolicyContentRequestContentPortRuleList : TeaModel {
                /// <summary>
                /// <para>The end value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("DstPortEnd")]
                [Validation(Required=false)]
                public int? DstPortEnd { get; set; }

                /// <summary>
                /// <para>The start value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DstPortStart")]
                [Validation(Required=false)]
                public int? DstPortStart { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>412a7312-58ff-4e32-a202-0ab0*******</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The match action. Valid values:</para>
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tcp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The priority number, expressed as an integer.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNo")]
                [Validation(Required=false)]
                public int? SeqNo { get; set; }

                /// <summary>
                /// <para>The end value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535</para>
                /// </summary>
                [NameInMap("SrcPortEnd")]
                [Validation(Required=false)]
                public int? SrcPortEnd { get; set; }

                /// <summary>
                /// <para>The start value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
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
            /// <para>The list of ports filtered by reflection attack prevention.</para>
            /// </summary>
            [NameInMap("ReflectBlockUdpPortList")]
            [Validation(Required=false)]
            public List<int?> ReflectBlockUdpPortList { get; set; }

            /// <summary>
            /// <para>The list of countries for location blacklist.</para>
            /// </summary>
            [NameInMap("RegionBlockCountryList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockCountryList { get; set; }

            /// <summary>
            /// <para>The list of provinces for location blacklist.</para>
            /// </summary>
            [NameInMap("RegionBlockProvinceList")]
            [Validation(Required=false)]
            public List<int?> RegionBlockProvinceList { get; set; }

            /// <summary>
            /// <para>The SIP Protection Settings.</para>
            /// </summary>
            [NameInMap("SipDefense")]
            [Validation(Required=false)]
            public ModifyPolicyContentRequestContentSipDefense SipDefense { get; set; }
            public class ModifyPolicyContentRequestContentSipDefense : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable SIP protection. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The SIP protection level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable SIP defense mode.</para>
                /// </summary>
                [NameInMap("SipDefend")]
                [Validation(Required=false)]
                public bool? SipDefend { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable SIP learning mode.</para>
                /// </summary>
                [NameInMap("SipLearn")]
                [Validation(Required=false)]
                public bool? SipLearn { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the SIP source rate limiting module.</para>
                /// </summary>
                [NameInMap("SipModule")]
                [Validation(Required=false)]
                public bool? SipModule { get; set; }

                /// <summary>
                /// <para>The SIP protection port. Valid values: <b>1</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5060</para>
                /// </summary>
                [NameInMap("SipPort")]
                [Validation(Required=false)]
                public string SipPort { get; set; }

                /// <summary>
                /// <para>The SIP source rate limit value in PPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SipRate")]
                [Validation(Required=false)]
                public long? SipRate { get; set; }

                /// <summary>
                /// <para>The SIP activation threshold in Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SipStartMbps")]
                [Validation(Required=false)]
                public long? SipStartMbps { get; set; }

                /// <summary>
                /// <para>The SIP activation threshold in PPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("SipStartPps")]
                [Validation(Required=false)]
                public long? SipStartPps { get; set; }

            }

            /// <summary>
            /// <para>The source rate limiting blacklist.</para>
            /// </summary>
            [NameInMap("SourceBlockList")]
            [Validation(Required=false)]
            public List<ModifyPolicyContentRequestContentSourceBlockList> SourceBlockList { get; set; }
            public class ModifyPolicyContentRequestContentSourceBlockList : TeaModel {
                /// <summary>
                /// <para>The duration for which the source IP address is added to the blacklist. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("BlockExpireSeconds")]
                [Validation(Required=false)]
                public int? BlockExpireSeconds { get; set; }

                /// <summary>
                /// <para>The statistical period for source rate limiting blacklisting. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("EverySeconds")]
                [Validation(Required=false)]
                public int? EverySeconds { get; set; }

                /// <summary>
                /// <para>The number of times the source IP address exceeds the rate limit within one statistical period.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ExceedLimitTimes")]
                [Validation(Required=false)]
                public int? ExceedLimitTimes { get; set; }

                /// <summary>
                /// <para>The source rate limiting type. Valid values:</para>
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
            /// <para>The source rate limiting configuration.</para>
            /// </summary>
            [NameInMap("SourceLimit")]
            [Validation(Required=false)]
            public ModifyPolicyContentRequestContentSourceLimit SourceLimit { get; set; }
            public class ModifyPolicyContentRequestContentSourceLimit : TeaModel {
                /// <summary>
                /// <para>The source bandwidth throttling value, in bytes per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public int? Bps { get; set; }

                /// <summary>
                /// <para>The source PPS rate limit, in packets per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("Pps")]
                [Validation(Required=false)]
                public int? Pps { get; set; }

                /// <summary>
                /// <para>The source SYN bandwidth throttling value, in bytes per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("SynBps")]
                [Validation(Required=false)]
                public int? SynBps { get; set; }

                /// <summary>
                /// <para>The source SYN PPS rate limit, in packets per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("SynPps")]
                [Validation(Required=false)]
                public int? SynPps { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to whitelist the back-to-origin IP addresses of Anti-DDoS Pro and Anti-DDoS Premium (the Chinese mainland &amp; outside the Chinese mainland).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("WhitenGfbrNets")]
            [Validation(Required=false)]
            public bool? WhitenGfbrNets { get; set; }

        }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83967609-7ea5-4f6d-a6ea-380b09e****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
