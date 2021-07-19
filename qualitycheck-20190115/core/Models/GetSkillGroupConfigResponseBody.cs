// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSkillGroupConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillGroupConfigResponseBodyData Data { get; set; }
        public class GetSkillGroupConfigResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("AllContentQualityCheck")]
            [Validation(Required=false)]
            public int? AllContentQualityCheck { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("SkillGroupId")]
            [Validation(Required=false)]
            public string SkillGroupId { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("VocabId")]
            [Validation(Required=false)]
            public long? VocabId { get; set; }
            [NameInMap("SkillGroupFrom")]
            [Validation(Required=false)]
            public int? SkillGroupFrom { get; set; }
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }
            [NameInMap("SkillGroupName")]
            [Validation(Required=false)]
            public string SkillGroupName { get; set; }
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }
            [NameInMap("AllRids")]
            [Validation(Required=false)]
            public string AllRids { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public long? ModelId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("QualityCheckType")]
            [Validation(Required=false)]
            public int? QualityCheckType { get; set; }
            [NameInMap("VocabName")]
            [Validation(Required=false)]
            public string VocabName { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public GetSkillGroupConfigResponseBodyDataRuleList RuleList { get; set; }
            public class GetSkillGroupConfigResponseBodyDataRuleList : TeaModel {
                [NameInMap("RuleNameInfo")]
                [Validation(Required=false)]
                public List<GetSkillGroupConfigResponseBodyDataRuleListRuleNameInfo> RuleNameInfo { get; set; }
                public class GetSkillGroupConfigResponseBodyDataRuleListRuleNameInfo : TeaModel {
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                }

            }
            [NameInMap("AllRuleList")]
            [Validation(Required=false)]
            public GetSkillGroupConfigResponseBodyDataAllRuleList AllRuleList { get; set; }
            public class GetSkillGroupConfigResponseBodyDataAllRuleList : TeaModel {
                [NameInMap("RuleNameInfo")]
                [Validation(Required=false)]
                public List<GetSkillGroupConfigResponseBodyDataAllRuleListRuleNameInfo> RuleNameInfo { get; set; }
                public class GetSkillGroupConfigResponseBodyDataAllRuleListRuleNameInfo : TeaModel {
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    [NameInMap("Rid")]
                    [Validation(Required=false)]
                    public long? Rid { get; set; }

                }

            }
        };

    }

}
