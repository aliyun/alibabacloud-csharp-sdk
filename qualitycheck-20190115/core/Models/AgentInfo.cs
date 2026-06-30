// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AgentInfo : TeaModel {
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        [NameInMap("InstructionType")]
        [Validation(Required=false)]
        public string InstructionType { get; set; }

        [NameInMap("InstructionTypeParam")]
        [Validation(Required=false)]
        public AgentInfoInstructionTypeParam InstructionTypeParam { get; set; }
        public class AgentInfoInstructionTypeParam : TeaModel {
            [NameInMap("CustomPromptParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamCustomPromptParam CustomPromptParam { get; set; }
            public class AgentInfoInstructionTypeParamCustomPromptParam : TeaModel {
                [NameInMap("CustomPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamCustomPromptParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamCustomPromptParamNameDescPairList : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("FieldsParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamFieldsParam FieldsParam { get; set; }
            public class AgentInfoInstructionTypeParamFieldsParam : TeaModel {
                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamFieldsParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamFieldsParamNameDescPairList : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("ServiceInspectionParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamServiceInspectionParam ServiceInspectionParam { get; set; }
            public class AgentInfoInstructionTypeParamServiceInspectionParam : TeaModel {
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamServiceInspectionParamDimensions> Dimensions { get; set; }
                public class AgentInfoInstructionTypeParamServiceInspectionParamDimensions : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public string Dimension { get; set; }

                }

                [NameInMap("SceneDescription")]
                [Validation(Required=false)]
                public string SceneDescription { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            [NameInMap("TagCategoryParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamTagCategoryParam TagCategoryParam { get; set; }
            public class AgentInfoInstructionTypeParamTagCategoryParam : TeaModel {
                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamTagCategoryParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamTagCategoryParamNameDescPairList : TeaModel {
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ValueList")]
                    [Validation(Required=false)]
                    public List<string> ValueList { get; set; }

                }

            }

        }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
