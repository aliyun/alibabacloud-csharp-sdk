// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListSkillGroupConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSkillGroupConfigResponseBodyData Data { get; set; }
        public class ListSkillGroupConfigResponseBodyData : TeaModel {
            [NameInMap("SkillGroupConfig")]
            [Validation(Required=false)]
            public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfig> SkillGroupConfig { get; set; }
            public class ListSkillGroupConfigResponseBodyDataSkillGroupConfig : TeaModel {
                [NameInMap("AllContentQualityCheck")]
                [Validation(Required=false)]
                public int? AllContentQualityCheck { get; set; }

                [NameInMap("AllRids")]
                [Validation(Required=false)]
                public string AllRids { get; set; }

                [NameInMap("AllRuleList")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList AllRuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo : TeaModel {
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public long? ModelId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("QualityCheckType")]
                [Validation(Required=false)]
                public int? QualityCheckType { get; set; }

                [NameInMap("Rid")]
                [Validation(Required=false)]
                public string Rid { get; set; }

                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList RuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo : TeaModel {
                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                    }

                }

                [NameInMap("ScreenSwitch")]
                [Validation(Required=false)]
                public bool? ScreenSwitch { get; set; }

                [NameInMap("SkillGroupFrom")]
                [Validation(Required=false)]
                public int? SkillGroupFrom { get; set; }

                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                [NameInMap("SkillGroupScreens")]
                [Validation(Required=false)]
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens SkillGroupScreens { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens : TeaModel {
                    [NameInMap("SkillGroupScreen")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen> SkillGroupScreen { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen : TeaModel {
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public int? DataType { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public int? Symbol { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public long? VocabId { get; set; }

                [NameInMap("VocabName")]
                [Validation(Required=false)]
                public string VocabName { get; set; }

            }

        }

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
