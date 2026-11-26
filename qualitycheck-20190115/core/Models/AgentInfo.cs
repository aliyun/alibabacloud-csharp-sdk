// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AgentInfo : TeaModel {
        /// <summary>
        /// <para>The description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent for customer service session quality inspection</para>
        /// </summary>
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer service quality inspection assistant</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the agent configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The object type for analysis. Valid values: audio and text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("InputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// <para>The instruction type. Valid values: serviceInspection (service quality inspection), field (key property extraction), tagCategory (label classification), multiLevelTag (multi-level label recognition), and customPrompt (custom instruction).</para>
        /// 
        /// <b>Example:</b>
        /// <para>field</para>
        /// </summary>
        [NameInMap("InstructionType")]
        [Validation(Required=false)]
        public string InstructionType { get; set; }

        /// <summary>
        /// <para>The parameters corresponding to the instruction type. Different InstructionType values require different sub-parameters. Specify only the sub-parameters that correspond to the current InstructionType and leave the others empty.</para>
        /// </summary>
        [NameInMap("InstructionTypeParam")]
        [Validation(Required=false)]
        public AgentInfoInstructionTypeParam InstructionTypeParam { get; set; }
        public class AgentInfoInstructionTypeParam : TeaModel {
            /// <summary>
            /// <para>The custom instruction parameters. Used when InstructionType is set to customPrompt.</para>
            /// </summary>
            [NameInMap("CustomPromptParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamCustomPromptParam CustomPromptParam { get; set; }
            public class AgentInfoInstructionTypeParamCustomPromptParam : TeaModel {
                /// <summary>
                /// <para>The content of the user-defined prompt template. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Analyze the service attitude of the customer service representative in the following conversation</para>
                /// </summary>
                [NameInMap("CustomPrompt")]
                [Validation(Required=false)]
                public string CustomPrompt { get; set; }

                /// <summary>
                /// <para>The list of name-value pairs attached to the custom instruction.</para>
                /// </summary>
                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamCustomPromptParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamCustomPromptParamNameDescPairList : TeaModel {
                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Scenario</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>After-sales inquiry</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The key attribute extraction parameters. Used when InstructionType is set to field.</para>
            /// </summary>
            [NameInMap("FieldsParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamFieldsParam FieldsParam { get; set; }
            public class AgentInfoInstructionTypeParamFieldsParam : TeaModel {
                /// <summary>
                /// <para>The list of attribute dimensions to be extracted.</para>
                /// </summary>
                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamFieldsParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamFieldsParamNameDescPairList : TeaModel {
                    /// <summary>
                    /// <para>The attribute description. This parameter is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The specific request raised by the customer during the session</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The attribute name. This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Customer request</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The attribute value. In the key attribute extraction scenario, this is the extracted result value corresponding to the dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Refund</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The service quality inspection parameters. Used when InstructionType is set to serviceInspection.</para>
            /// </summary>
            [NameInMap("ServiceInspectionParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamServiceInspectionParam ServiceInspectionParam { get; set; }
            public class AgentInfoInstructionTypeParamServiceInspectionParam : TeaModel {
                /// <summary>
                /// <para>The list of quality inspection dimensions. This parameter is required.</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamServiceInspectionParamDimensions> Dimensions { get; set; }
                public class AgentInfoInstructionTypeParamServiceInspectionParamDimensions : TeaModel {
                    /// <summary>
                    /// <para>The dimension description. This parameter is optional.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Whether the customer service representative is polite and patient</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The dimension name. This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Service attitude</para>
                    /// </summary>
                    [NameInMap("Dimension")]
                    [Validation(Required=false)]
                    public string Dimension { get; set; }

                }

                /// <summary>
                /// <para>The description of the quality inspection scenario. This parameter is optional.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service quality inspection for after-sales customer service sessions</para>
                /// </summary>
                [NameInMap("SceneDescription")]
                [Validation(Required=false)]
                public string SceneDescription { get; set; }

                /// <summary>
                /// <para>The name of the quality inspection scenario. This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>After-sales service quality inspection</para>
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

            /// <summary>
            /// <para>The label classification parameters. Used when InstructionType is set to tagCategory.</para>
            /// </summary>
            [NameInMap("TagCategoryParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamTagCategoryParam TagCategoryParam { get; set; }
            public class AgentInfoInstructionTypeParamTagCategoryParam : TeaModel {
                /// <summary>
                /// <para>The list of label classification dimensions. This parameter is required.</para>
                /// </summary>
                [NameInMap("NameDescPairList")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamTagCategoryParamNameDescPairList> NameDescPairList { get; set; }
                public class AgentInfoInstructionTypeParamTagCategoryParamNameDescPairList : TeaModel {
                    /// <summary>
                    /// <para>The dimension description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The classification of the types of issues consulted by the customer</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The dimension name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Issue type</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The list of candidate tag values.</para>
                    /// </summary>
                    [NameInMap("ValueList")]
                    [Validation(Required=false)]
                    public List<string> ValueList { get; set; }

                }

            }

            /// <summary>
            /// <para>The multi-level tag recognition parameters. Used when InstructionType is set to multiLevelTag.</para>
            /// </summary>
            [NameInMap("TagTreeLevelParam")]
            [Validation(Required=false)]
            public AgentInfoInstructionTypeParamTagTreeLevelParam TagTreeLevelParam { get; set; }
            public class AgentInfoInstructionTypeParamTagTreeLevelParam : TeaModel {
                /// <summary>
                /// <para>The list of starting parent tag IDs at runtime. The first ID is treated as the matched parent tag, and recognition proceeds level by level from its child nodes, skipping the preceding levels. This field also takes effect when AgentId is specified.</para>
                /// </summary>
                [NameInMap("TagIds")]
                [Validation(Required=false)]
                public List<long?> TagIds { get; set; }

                /// <summary>
                /// <para>The recognition configuration for each level, arranged in hierarchical order. This parameter is required.</para>
                /// </summary>
                [NameInMap("TagTreeLevels")]
                [Validation(Required=false)]
                public List<AgentInfoInstructionTypeParamTagTreeLevelParamTagTreeLevels> TagTreeLevels { get; set; }
                public class AgentInfoInstructionTypeParamTagTreeLevelParamTagTreeLevels : TeaModel {
                    /// <summary>
                    /// <para>The analysis prompt for this level. It is concatenated with the tag data and sent to the large language model. This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Determine which tag category this conversation belongs to</para>
                    /// </summary>
                    [NameInMap("Prompt")]
                    [Validation(Required=false)]
                    public string Prompt { get; set; }

                    /// <summary>
                    /// <para>The list of candidate tag IDs for this level. A value of -1 indicates that all tags at this level are selected. This parameter is required.</para>
                    /// </summary>
                    [NameInMap("TagTreeIds")]
                    [Validation(Required=false)]
                    public List<long?> TagTreeIds { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The type of the large language model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

    }

}
