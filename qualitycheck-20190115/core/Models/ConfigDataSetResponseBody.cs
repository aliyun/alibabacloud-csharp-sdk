// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ConfigDataSetResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConfigDataSetResponseBodyData Data { get; set; }
        public class ConfigDataSetResponseBodyData : TeaModel {
            [NameInMap("RuleInfo")]
            [Validation(Required=false)]
            public ConfigDataSetResponseBodyDataRuleInfo RuleInfo { get; set; }
            public class ConfigDataSetResponseBodyDataRuleInfo : TeaModel {
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public ConfigDataSetResponseBodyDataRuleInfoConditions Conditions { get; set; }
                public class ConfigDataSetResponseBodyDataRuleInfoConditions : TeaModel {
                    [NameInMap("ConditionBasicInfo")]
                    [Validation(Required=false)]
                    public List<ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfo> ConditionBasicInfo { get; set; }
                    public class ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfo : TeaModel {
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfoRange Range { get; set; }
                        public class ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfoRange : TeaModel {
                            [NameInMap("From")]
                            [Validation(Required=false)]
                            public int? From { get; set; }
                            [NameInMap("To")]
                            [Validation(Required=false)]
                            public int? To { get; set; }
                        };

                        [NameInMap("Anchor")]
                        [Validation(Required=false)]
                        public ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfoAnchor Anchor { get; set; }
                        public class ConfigDataSetResponseBodyDataRuleInfoConditionsConditionBasicInfoAnchor : TeaModel {
                            [NameInMap("Cid")]
                            [Validation(Required=false)]
                            public string Cid { get; set; }
                            [NameInMap("HitTime")]
                            [Validation(Required=false)]
                            public int? HitTime { get; set; }
                            [NameInMap("Location")]
                            [Validation(Required=false)]
                            public string Location { get; set; }
                        };

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                        [NameInMap("RoleId")]
                        [Validation(Required=false)]
                        public int? RoleId { get; set; }

                    }
                };

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public ConfigDataSetResponseBodyDataRuleInfoRules Rules { get; set; }
                public class ConfigDataSetResponseBodyDataRuleInfoRules : TeaModel {
                    [NameInMap("RuleBasicInfo")]
                    [Validation(Required=false)]
                    public List<ConfigDataSetResponseBodyDataRuleInfoRulesRuleBasicInfo> RuleBasicInfo { get; set; }
                    public class ConfigDataSetResponseBodyDataRuleInfoRulesRuleBasicInfo : TeaModel {
                        public int? ExternalProperty { get; set; }
                        public string Lambda { get; set; }
                        public string Rid { get; set; }
                    }
                };

            }
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public int? ChannelType { get; set; }
            [NameInMap("SetId")]
            [Validation(Required=false)]
            public long? SetId { get; set; }
            [NameInMap("RoleConfigStatus")]
            [Validation(Required=false)]
            public int? RoleConfigStatus { get; set; }
            [NameInMap("JudgeType")]
            [Validation(Required=false)]
            public int? JudgeType { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
