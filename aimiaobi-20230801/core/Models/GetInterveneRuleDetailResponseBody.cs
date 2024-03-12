// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetInterveneRuleDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInterveneRuleDetailResponseBodyData Data { get; set; }
        public class GetInterveneRuleDetailResponseBodyData : TeaModel {
            [NameInMap("InterveneRuleDetail")]
            [Validation(Required=false)]
            public GetInterveneRuleDetailResponseBodyDataInterveneRuleDetail InterveneRuleDetail { get; set; }
            public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetail : TeaModel {
                [NameInMap("AnswerConfig")]
                [Validation(Required=false)]
                public List<GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailAnswerConfig> AnswerConfig { get; set; }
                public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailAnswerConfig : TeaModel {
                    [NameInMap("AnswerType")]
                    [Validation(Required=false)]
                    public int? AnswerType { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                [NameInMap("EffectConfig")]
                [Validation(Required=false)]
                public GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailEffectConfig EffectConfig { get; set; }
                public class GetInterveneRuleDetailResponseBodyDataInterveneRuleDetailEffectConfig : TeaModel {
                    [NameInMap("EffectType")]
                    [Validation(Required=false)]
                    public int? EffectType { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                [NameInMap("InterveneType")]
                [Validation(Required=false)]
                public int? InterveneType { get; set; }

                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<string> NamespaceList { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
