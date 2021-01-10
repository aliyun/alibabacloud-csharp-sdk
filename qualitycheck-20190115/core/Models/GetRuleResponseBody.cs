// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRuleResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuleResponseBodyData Data { get; set; }
        public class GetRuleResponseBodyData : TeaModel {
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public GetRuleResponseBodyDataRules Rules { get; set; }
            public class GetRuleResponseBodyDataRules : TeaModel {
                [NameInMap("RuleInfo")]
                [Validation(Required=false)]
                public List<GetRuleResponseBodyDataRulesRuleInfo> RuleInfo { get; set; }
                public class GetRuleResponseBodyDataRulesRuleInfo : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("BusinessCategoryNameList")]
                    [Validation(Required=false)]
                    public GetRuleResponseBodyDataRulesRuleInfoBusinessCategoryNameList BusinessCategoryNameList { get; set; }
                    public class GetRuleResponseBodyDataRulesRuleInfoBusinessCategoryNameList : TeaModel {
                        [NameInMap("BusinessCategoryNameList")]
                        [Validation(Required=false)]
                        public List<string> BusinessCategoryNameList { get; set; }
                    };

                    [NameInMap("IsOnline")]
                    [Validation(Required=false)]
                    public int? IsOnline { get; set; }

                    [NameInMap("ScoreSubId")]
                    [Validation(Required=false)]
                    public int? ScoreSubId { get; set; }

                    [NameInMap("CreateEmpid")]
                    [Validation(Required=false)]
                    public string CreateEmpid { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("LastUpdateEmpid")]
                    [Validation(Required=false)]
                    public string LastUpdateEmpid { get; set; }

                    [NameInMap("IsDelete")]
                    [Validation(Required=false)]
                    public int? IsDelete { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public string Rid { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("RuleScoreType")]
                    [Validation(Required=false)]
                    public int? RuleScoreType { get; set; }

                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("RuleLambda")]
                    [Validation(Required=false)]
                    public string RuleLambda { get; set; }

                    [NameInMap("ScoreSubName")]
                    [Validation(Required=false)]
                    public string ScoreSubName { get; set; }

                    [NameInMap("AutoReview")]
                    [Validation(Required=false)]
                    public int? AutoReview { get; set; }

                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    [NameInMap("LastUpdateTime")]
                    [Validation(Required=false)]
                    public string LastUpdateTime { get; set; }

                    [NameInMap("ScoreName")]
                    [Validation(Required=false)]
                    public string ScoreName { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ScoreId")]
                    [Validation(Required=false)]
                    public int? ScoreId { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
