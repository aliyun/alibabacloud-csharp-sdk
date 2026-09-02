// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<ListPolicyResponseBodyPolicyList> PolicyList { get; set; }
        public class ListPolicyResponseBodyPolicyList : TeaModel {
            /// <summary>
            /// <para>The number of protected objects that are associated with the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AttachedCount")]
            [Validation(Required=false)]
            public int? AttachedCount { get; set; }

            /// <summary>
            /// <para>The policy content.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public ListPolicyResponseBodyPolicyListContent Content { get; set; }
            public class ListPolicyResponseBodyPolicyListContent : TeaModel {
                /// <summary>
                /// <para>The expiration time of the IP blacklist. The value is a UNIX timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1716878000</para>
                /// </summary>
                [NameInMap("BlackIpListExpireAt")]
                [Validation(Required=false)]
                public long? BlackIpListExpireAt { get; set; }

                /// <summary>
                /// <para>Indicates whether ICMP Blocking is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableDropIcmp")]
                [Validation(Required=false)]
                public bool? EnableDropIcmp { get; set; }

                /// <summary>
                /// <para>Indicates whether AI-based intelligent analysis is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableIntelligence")]
                [Validation(Required=false)]
                public bool? EnableIntelligence { get; set; }

                /// <summary>
                /// <para>Indicates whether port-specific mitigation is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableL4Defense")]
                [Validation(Required=false)]
                public bool? EnableL4Defense { get; set; }

                /// <summary>
                /// <para>The list of Byte-Match Filter rules.</para>
                /// </summary>
                [NameInMap("FingerPrintRuleList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentFingerPrintRuleList> FingerPrintRuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentFingerPrintRuleList : TeaModel {
                    /// <summary>
                    /// <para>The remarks of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>comment</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <para>The end value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("DstPortEnd")]
                    [Validation(Required=false)]
                    public int? DstPortEnd { get; set; }

                    /// <summary>
                    /// <para>The start value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
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
                    /// <para>2c0b09cd-a565-4481-9acb-418b********</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The match action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>accept</b>: Allow traffic that matches the fingerprint.</description></item>
                    /// <item><description><b>drop</b>: Drop traffic that matches the fingerprint.</description></item>
                    /// <item><description><b>ip_rate</b>: Apply rate limiting to the source IP address of traffic that matches the fingerprint. The rate limit is specified by the <b>RateValue</b> parameter.</description></item>
                    /// <item><description><b>session_rate</b>: Apply rate limiting to the source session of traffic that matches the fingerprint. The rate limit is specified by the <b>RateValue</b> parameter.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drop</para>
                    /// </summary>
                    [NameInMap("MatchAction")]
                    [Validation(Required=false)]
                    public string MatchAction { get; set; }

                    /// <summary>
                    /// <para>The maximum packet length. Valid values: <b>1</b> to <b>1500</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1500</para>
                    /// </summary>
                    [NameInMap("MaxPktLen")]
                    [Validation(Required=false)]
                    public int? MaxPktLen { get; set; }

                    /// <summary>
                    /// <para>The minimum packet length. Valid values: <b>1</b> to <b>1500</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinPktLen")]
                    [Validation(Required=false)]
                    public int? MinPktLen { get; set; }

                    /// <summary>
                    /// <para>The rule mode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public int? Mode { get; set; }

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
                    /// <para>The detection payload, represented as a hexadecimal string.</para>
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
                    /// <item><description><b>tcp</b>: Transmission Control Protocol.</description></item>
                    /// <item><description><b>udp</b>: User Datagram Protocol.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>udp</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The rate limit. Valid values: <b>1</b> to <b>100000</b>.</para>
                    /// <remarks>
                    /// <para>This parameter is required when the match action is source IP rate limiting or source session rate limiting (<b>MatchAction</b> is <b>ip_rate</b> or <b>session_rate</b>).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("RateValue")]
                    [Validation(Required=false)]
                    public int? RateValue { get; set; }

                    /// <summary>
                    /// <para>The rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>(ip.version == 4)</para>
                    /// </summary>
                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public string Rule { get; set; }

                    /// <summary>
                    /// <para>The priority of the rule, represented as an integer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SeqNo")]
                    [Validation(Required=false)]
                    public int? SeqNo { get; set; }

                    /// <summary>
                    /// <para>The end value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("SrcPortEnd")]
                    [Validation(Required=false)]
                    public int? SrcPortEnd { get; set; }

                    /// <summary>
                    /// <para>The start value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SrcPortStart")]
                    [Validation(Required=false)]
                    public int? SrcPortStart { get; set; }

                    /// <summary>
                    /// <para>The type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                /// <summary>
                /// <para>The protection level of AI-based intelligent analysis. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>default</b>: Normal.</description></item>
                /// <item><description><b>hard</b>: Strict.</description></item>
                /// <item><description><b>weak</b>: Loose.</description></item>
                /// </list>
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
                public List<ListPolicyResponseBodyPolicyListContentL4RuleList> L4RuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentL4RuleList : TeaModel {
                    /// <summary>
                    /// <para>The action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>2</b>: Drop.</description></item>
                    /// </list>
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
                    public List<ListPolicyResponseBodyPolicyListContentL4RuleListConditionList> ConditionList { get; set; }
                    public class ListPolicyResponseBodyPolicyListContentL4RuleListConditionList : TeaModel {
                        /// <summary>
                        /// <para>The detection content.</para>
                        /// <remarks>
                        /// <para>If the rule type is <b>char</b>, the value must be an ASCII string. If the rule type is <b>hex</b>, the value must be a hexadecimal string. Maximum length: 2048.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Arg")]
                        [Validation(Required=false)]
                        public string Arg { get; set; }

                        /// <summary>
                        /// <para>The match content.</para>
                        /// <ol>
                        /// <item><description>When <b>Encode</b> is set to <b>str</b>, the following requirements must be met:</description></item>
                        /// </ol>
                        /// <list type="bullet">
                        /// <item><description><para>The length of <b>Content</b> cannot exceed 1500.</para>
                        /// </description></item>
                        /// <item><description><para><b>End</b> - <b>Start</b> &gt;= the length of <b>Content</b>.</para>
                        /// </description></item>
                        /// </list>
                        /// <ol start="2">
                        /// <item><description>When <b>Encode</b> is set to <b>hex</b>, the following requirements must be met:</description></item>
                        /// </ol>
                        /// <list type="bullet">
                        /// <item><description><para><b>Content</b> must be hexadecimal characters.</para>
                        /// </description></item>
                        /// <item><description><para>The length of <b>Content</b> must be an even number.</para>
                        /// </description></item>
                        /// <item><description><para>The length of <b>Content</b> cannot exceed 3000.</para>
                        /// </description></item>
                        /// <item><description><para><b>End</b> - <b>Start</b> + 1 &gt;= the length of <b>Content</b> / 2.</para>
                        /// </description></item>
                        /// </list>
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
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("Depth")]
                        [Validation(Required=false)]
                        public int? Depth { get; set; }

                        /// <summary>
                        /// <para>The character type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>str</b>: string.</para>
                        /// </description></item>
                        /// <item><description><para><b>hex</b>: hexadecimal.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>str</para>
                        /// </summary>
                        [NameInMap("Encode")]
                        [Validation(Required=false)]
                        public string Encode { get; set; }

                        /// <summary>
                        /// <para>The match range.</para>
                        /// </summary>
                        [NameInMap("Offset")]
                        [Validation(Required=false)]
                        public ListPolicyResponseBodyPolicyListContentL4RuleListConditionListOffset Offset { get; set; }
                        public class ListPolicyResponseBodyPolicyListContentL4RuleListConditionListOffset : TeaModel {
                            /// <summary>
                            /// <para>The end position. Valid values: <b>0</b> to <b>1499</b>.</para>
                            /// <remarks>
                            /// <para>The end position must be greater than or equal to the start position.</para>
                            /// </remarks>
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
                        /// <para>The match pattern. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>contain</b>: contains.</para>
                        /// </description></item>
                        /// <item><description><para><b>not_contain</b>: does not contain.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contain</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>The start position of detection. Valid values: <b>0</b> to <b>2047</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                    }

                    /// <summary>
                    /// <para>The minimum number of bytes in a session flow to trigger rule matching. Valid values: <b>0</b> to <b>2048</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Limited")]
                    [Validation(Required=false)]
                    public int? Limited { get; set; }

                    /// <summary>
                    /// <para>The logical operator. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>0</b>: Execute the action when the rule is matched.</para>
                    /// </description></item>
                    /// <item><description><para><b>1</b>: Execute the action when the rule is not matched.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Match")]
                    [Validation(Required=false)]
                    public string Match { get; set; }

                    /// <summary>
                    /// <para>The rule type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>char</b>: string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>hex</b>: hexadecimal match.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>char</para>
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test**</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The rule priority.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                }

                /// <summary>
                /// <para>The list of Port Blocking rules.</para>
                /// </summary>
                [NameInMap("PortRuleList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentPortRuleList> PortRuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentPortRuleList : TeaModel {
                    /// <summary>
                    /// <para>The end value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("DstPortEnd")]
                    [Validation(Required=false)]
                    public int? DstPortEnd { get; set; }

                    /// <summary>
                    /// <para>The start value of the destination port range. Valid values: <b>0</b> to <b>65535</b>.</para>
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
                    /// <para>8f3c3062-6c20-425d-8405-2bd1********</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The match action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>drop</b>: Drop.</description></item>
                    /// </list>
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
                    /// <item><description><b>tcp</b>: Transmission Control Protocol.</description></item>
                    /// <item><description><b>udp</b>: User Datagram Protocol.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>udp</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The priority of the rule, represented as an integer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SeqNo")]
                    [Validation(Required=false)]
                    public int? SeqNo { get; set; }

                    /// <summary>
                    /// <para>The end value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>65535</para>
                    /// </summary>
                    [NameInMap("SrcPortEnd")]
                    [Validation(Required=false)]
                    public int? SrcPortEnd { get; set; }

                    /// <summary>
                    /// <para>The start value of the source port range. Valid values: <b>0</b> to <b>65535</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SrcPortStart")]
                    [Validation(Required=false)]
                    public int? SrcPortStart { get; set; }

                }

                /// <summary>
                /// <para>The version of the port-specific mitigation policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Empty</b>: the default surf protection engine policy.</description></item>
                /// <item><description><b>2</b>: the new stream protection engine policy.<remarks>
                /// <para>Only port-specific mitigation policies are supported.</para>
                /// </remarks>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PortVersion")]
                [Validation(Required=false)]
                public string PortVersion { get; set; }

                /// <summary>
                /// <para>The list of ports filtered by the reflection attack prevention feature.</para>
                /// </summary>
                [NameInMap("ReflectBlockUdpPortList")]
                [Validation(Required=false)]
                public List<int?> ReflectBlockUdpPortList { get; set; }

                /// <summary>
                /// <para>The list of countries for the location blacklist.</para>
                /// </summary>
                [NameInMap("RegionBlockCountryList")]
                [Validation(Required=false)]
                public List<int?> RegionBlockCountryList { get; set; }

                /// <summary>
                /// <para>The list of provinces for the location blacklist.</para>
                /// </summary>
                [NameInMap("RegionBlockProvinceList")]
                [Validation(Required=false)]
                public List<int?> RegionBlockProvinceList { get; set; }

                /// <summary>
                /// <para>The SIP protection settings.</para>
                /// </summary>
                [NameInMap("SipDefense")]
                [Validation(Required=false)]
                public ListPolicyResponseBodyPolicyListContentSipDefense SipDefense { get; set; }
                public class ListPolicyResponseBodyPolicyListContentSipDefense : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether SIP protection is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enabled.</description></item>
                    /// <item><description><b>false</b>: Disabled.</description></item>
                    /// </list>
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
                    /// <para>Indicates whether SIP defense mode is enabled.</para>
                    /// </summary>
                    [NameInMap("SipDefend")]
                    [Validation(Required=false)]
                    public bool? SipDefend { get; set; }

                    /// <summary>
                    /// <para>Indicates whether SIP learning mode is enabled.</para>
                    /// </summary>
                    [NameInMap("SipLearn")]
                    [Validation(Required=false)]
                    public bool? SipLearn { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the SIP source rate limiting module is enabled.</para>
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
                    /// <para>The SIP source rate limit value (PPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("SipRate")]
                    [Validation(Required=false)]
                    public long? SipRate { get; set; }

                    /// <summary>
                    /// <para>The SIP activation threshold (Mbit/s).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SipStartMbps")]
                    [Validation(Required=false)]
                    public long? SipStartMbps { get; set; }

                    /// <summary>
                    /// <para>The SIP activation threshold (PPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("SipStartPps")]
                    [Validation(Required=false)]
                    public long? SipStartPps { get; set; }

                }

                /// <summary>
                /// <para>The list of source rate limiting and blacklisting rules.</para>
                /// </summary>
                [NameInMap("SourceBlockList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentSourceBlockList> SourceBlockList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentSourceBlockList : TeaModel {
                    /// <summary>
                    /// <para>The duration for which the source IP address is added to the blacklist. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("BlockExpireSeconds")]
                    [Validation(Required=false)]
                    public int? BlockExpireSeconds { get; set; }

                    /// <summary>
                    /// <para>The statistical period for source rate limiting and blacklisting. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("EverySeconds")]
                    [Validation(Required=false)]
                    public int? EverySeconds { get; set; }

                    /// <summary>
                    /// <para>The number of times that the source IP address exceeds the rate limit within a single statistical period.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ExceedLimitTimes")]
                    [Validation(Required=false)]
                    public int? ExceedLimitTimes { get; set; }

                    /// <summary>
                    /// <para>The type of source rate limiting. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>3</b>: source PPS rate limiting.</para>
                    /// </description></item>
                    /// <item><description><para><b>4</b>: source bandwidth throttling.</para>
                    /// </description></item>
                    /// <item><description><para><b>5</b>: source SYN PPS rate limiting.</para>
                    /// </description></item>
                    /// <item><description><para><b>6</b>: source SYN bandwidth throttling.</para>
                    /// </description></item>
                    /// </list>
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
                public ListPolicyResponseBodyPolicyListContentSourceLimit SourceLimit { get; set; }
                public class ListPolicyResponseBodyPolicyListContentSourceLimit : TeaModel {
                    /// <summary>
                    /// <para>The source bandwidth throttling value. Unit: bytes per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public int? Bps { get; set; }

                    /// <summary>
                    /// <para>The source PPS rate limit. Unit: packets per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public int? Pps { get; set; }

                    /// <summary>
                    /// <para>The source SYN bandwidth throttling value. Unit: bytes per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("SynBps")]
                    [Validation(Required=false)]
                    public int? SynBps { get; set; }

                    /// <summary>
                    /// <para>The source SYN PPS rate limit. Unit: packets per second.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("SynPps")]
                    [Validation(Required=false)]
                    public int? SynPps { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the back-to-origin CIDR blocks of Anti-DDoS Pro and Anti-DDoS Premium (the Chinese mainland &amp; outside the Chinese mainland) are added to the whitelist.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>877afbdf-3982-4d36-9886-f043********</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test**</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The remarks of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>default</b>: default mitigation policy.</description></item>
            /// <item><description><b>l3</b>: IP-specific mitigation policy.</description></item>
            /// <item><description><b>l4</b>: port-specific mitigation policy.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>l3</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B379C2-9319-4C6B-B579-FE36831B09F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
