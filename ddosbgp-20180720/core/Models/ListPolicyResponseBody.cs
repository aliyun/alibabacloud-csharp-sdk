// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyResponseBody : TeaModel {
        [NameInMap("PolicyList")]
        [Validation(Required=false)]
        public List<ListPolicyResponseBodyPolicyList> PolicyList { get; set; }
        public class ListPolicyResponseBodyPolicyList : TeaModel {
            [NameInMap("AttachedCount")]
            [Validation(Required=false)]
            public int? AttachedCount { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public ListPolicyResponseBodyPolicyListContent Content { get; set; }
            public class ListPolicyResponseBodyPolicyListContent : TeaModel {
                [NameInMap("BlackIpListExpireAt")]
                [Validation(Required=false)]
                public long? BlackIpListExpireAt { get; set; }

                [NameInMap("EnableDropIcmp")]
                [Validation(Required=false)]
                public bool? EnableDropIcmp { get; set; }

                [NameInMap("EnableIntelligence")]
                [Validation(Required=false)]
                public bool? EnableIntelligence { get; set; }

                [NameInMap("EnableL4Defense")]
                [Validation(Required=false)]
                public bool? EnableL4Defense { get; set; }

                [NameInMap("FingerPrintRuleList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentFingerPrintRuleList> FingerPrintRuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentFingerPrintRuleList : TeaModel {
                    [NameInMap("DstPortEnd")]
                    [Validation(Required=false)]
                    public int? DstPortEnd { get; set; }

                    [NameInMap("DstPortStart")]
                    [Validation(Required=false)]
                    public int? DstPortStart { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MatchAction")]
                    [Validation(Required=false)]
                    public string MatchAction { get; set; }

                    [NameInMap("MaxPktLen")]
                    [Validation(Required=false)]
                    public int? MaxPktLen { get; set; }

                    [NameInMap("MinPktLen")]
                    [Validation(Required=false)]
                    public int? MinPktLen { get; set; }

                    [NameInMap("Offset")]
                    [Validation(Required=false)]
                    public int? Offset { get; set; }

                    [NameInMap("PayloadBytes")]
                    [Validation(Required=false)]
                    public string PayloadBytes { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("RateValue")]
                    [Validation(Required=false)]
                    public int? RateValue { get; set; }

                    [NameInMap("SeqNo")]
                    [Validation(Required=false)]
                    public int? SeqNo { get; set; }

                    [NameInMap("SrcPortEnd")]
                    [Validation(Required=false)]
                    public int? SrcPortEnd { get; set; }

                    [NameInMap("SrcPortStart")]
                    [Validation(Required=false)]
                    public int? SrcPortStart { get; set; }

                }

                [NameInMap("IntelligenceLevel")]
                [Validation(Required=false)]
                public string IntelligenceLevel { get; set; }

                [NameInMap("L4RuleList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentL4RuleList> L4RuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentL4RuleList : TeaModel {
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    [NameInMap("ConditionList")]
                    [Validation(Required=false)]
                    public List<ListPolicyResponseBodyPolicyListContentL4RuleListConditionList> ConditionList { get; set; }
                    public class ListPolicyResponseBodyPolicyListContentL4RuleListConditionList : TeaModel {
                        [NameInMap("Arg")]
                        [Validation(Required=false)]
                        public string Arg { get; set; }

                        [NameInMap("Depth")]
                        [Validation(Required=false)]
                        public int? Depth { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                    }

                    [NameInMap("Limited")]
                    [Validation(Required=false)]
                    public int? Limited { get; set; }

                    [NameInMap("Match")]
                    [Validation(Required=false)]
                    public string Match { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public int? Priority { get; set; }

                }

                [NameInMap("PortRuleList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentPortRuleList> PortRuleList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentPortRuleList : TeaModel {
                    [NameInMap("DstPortEnd")]
                    [Validation(Required=false)]
                    public int? DstPortEnd { get; set; }

                    [NameInMap("DstPortStart")]
                    [Validation(Required=false)]
                    public int? DstPortStart { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MatchAction")]
                    [Validation(Required=false)]
                    public string MatchAction { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("SeqNo")]
                    [Validation(Required=false)]
                    public int? SeqNo { get; set; }

                    [NameInMap("SrcPortEnd")]
                    [Validation(Required=false)]
                    public int? SrcPortEnd { get; set; }

                    [NameInMap("SrcPortStart")]
                    [Validation(Required=false)]
                    public int? SrcPortStart { get; set; }

                }

                [NameInMap("ReflectBlockUdpPortList")]
                [Validation(Required=false)]
                public List<int?> ReflectBlockUdpPortList { get; set; }

                [NameInMap("RegionBlockCountryList")]
                [Validation(Required=false)]
                public List<int?> RegionBlockCountryList { get; set; }

                [NameInMap("RegionBlockProvinceList")]
                [Validation(Required=false)]
                public List<int?> RegionBlockProvinceList { get; set; }

                [NameInMap("SourceBlockList")]
                [Validation(Required=false)]
                public List<ListPolicyResponseBodyPolicyListContentSourceBlockList> SourceBlockList { get; set; }
                public class ListPolicyResponseBodyPolicyListContentSourceBlockList : TeaModel {
                    [NameInMap("BlockExpireSeconds")]
                    [Validation(Required=false)]
                    public int? BlockExpireSeconds { get; set; }

                    [NameInMap("EverySeconds")]
                    [Validation(Required=false)]
                    public int? EverySeconds { get; set; }

                    [NameInMap("ExceedLimitTimes")]
                    [Validation(Required=false)]
                    public int? ExceedLimitTimes { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                }

                [NameInMap("SourceLimit")]
                [Validation(Required=false)]
                public ListPolicyResponseBodyPolicyListContentSourceLimit SourceLimit { get; set; }
                public class ListPolicyResponseBodyPolicyListContentSourceLimit : TeaModel {
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public int? Bps { get; set; }

                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public int? Pps { get; set; }

                    [NameInMap("SynBps")]
                    [Validation(Required=false)]
                    public int? SynBps { get; set; }

                    [NameInMap("SynPps")]
                    [Validation(Required=false)]
                    public int? SynPps { get; set; }

                }

                [NameInMap("WhitenGfbrNets")]
                [Validation(Required=false)]
                public bool? WhitenGfbrNets { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
