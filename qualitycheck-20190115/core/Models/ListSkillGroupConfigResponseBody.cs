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
        public ListSkillGroupConfigResponseBodyData Data { get; set; }
        public class ListSkillGroupConfigResponseBodyData : TeaModel {
            [NameInMap("SkillGroupConfig")]
            [Validation(Required=false)]
            public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfig> SkillGroupConfig { get; set; }
            public class ListSkillGroupConfigResponseBodyDataSkillGroupConfig : TeaModel {
                public int? Type { get; set; }
                public int? Status { get; set; }
                public string UpdateTime { get; set; }
                public int? AllContentQualityCheck { get; set; }
                public string CreateTime { get; set; }
                public string SkillGroupId { get; set; }
                public bool? ScreenSwitch { get; set; }
                public string InstanceId { get; set; }
                public long? VocabId { get; set; }
                public int? SkillGroupFrom { get; set; }
                public string Rid { get; set; }
                public string SkillGroupName { get; set; }
                public string ModelName { get; set; }
                public string AllRids { get; set; }
                public string Name { get; set; }
                public long? ModelId { get; set; }
                public long? Id { get; set; }
                public int? QualityCheckType { get; set; }
                public string VocabName { get; set; }
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList RuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigRuleListRuleNameInfo : TeaModel {
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                    }

                }
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList AllRuleList { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleList : TeaModel {
                    [NameInMap("RuleNameInfo")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo> RuleNameInfo { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigAllRuleListRuleNameInfo : TeaModel {
                        [NameInMap("RuleName")]
                        [Validation(Required=false)]
                        public string RuleName { get; set; }

                        [NameInMap("Rid")]
                        [Validation(Required=false)]
                        public long? Rid { get; set; }

                    }

                }
                public ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens SkillGroupScreens { get; set; }
                public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreens : TeaModel {
                    [NameInMap("SkillGroupScreen")]
                    [Validation(Required=false)]
                    public List<ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen> SkillGroupScreen { get; set; }
                    public class ListSkillGroupConfigResponseBodyDataSkillGroupConfigSkillGroupScreensSkillGroupScreen : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public int? DataType { get; set; }

                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public int? Symbol { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
            }
        };

    }

}
