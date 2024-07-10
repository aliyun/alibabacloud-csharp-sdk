// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractResultGenerationRequest : TeaModel {
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunContractResultGenerationRequestAssistant Assistant { get; set; }
        public class RunContractResultGenerationRequestAssistant : TeaModel {
            [NameInMap("metaData")]
            [Validation(Required=false)]
            public RunContractResultGenerationRequestAssistantMetaData MetaData { get; set; }
            public class RunContractResultGenerationRequestAssistantMetaData : TeaModel {
                [NameInMap("customRuleConfig")]
                [Validation(Required=false)]
                public RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfig CustomRuleConfig { get; set; }
                public class RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfig : TeaModel {
                    [NameInMap("customRules")]
                    [Validation(Required=false)]
                    public List<RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfigCustomRules> CustomRules { get; set; }
                    public class RunContractResultGenerationRequestAssistantMetaDataCustomRuleConfigCustomRules : TeaModel {
                        [NameInMap("riskLevel")]
                        [Validation(Required=false)]
                        public string RiskLevel { get; set; }

                        [NameInMap("ruleDesc")]
                        [Validation(Required=false)]
                        public string RuleDesc { get; set; }

                        [NameInMap("ruleTitle")]
                        [Validation(Required=false)]
                        public string RuleTitle { get; set; }

                    }

                }

                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

                [NameInMap("ruleTaskId")]
                [Validation(Required=false)]
                public string RuleTaskId { get; set; }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public List<RunContractResultGenerationRequestAssistantMetaDataRules> Rules { get; set; }
                public class RunContractResultGenerationRequestAssistantMetaDataRules : TeaModel {
                    [NameInMap("riskLevel")]
                    [Validation(Required=false)]
                    public string RiskLevel { get; set; }

                    [NameInMap("ruleSequence")]
                    [Validation(Required=false)]
                    public string RuleSequence { get; set; }

                    [NameInMap("ruleTag")]
                    [Validation(Required=false)]
                    public string RuleTag { get; set; }

                    [NameInMap("ruleTitle")]
                    [Validation(Required=false)]
                    public string RuleTitle { get; set; }

                }

            }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
