// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class OperatorBasicInfo : TeaModel {
        /// <summary>
        /// <para>The primary key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The operator name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The primary key ID or the frontend-generated ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Oid")]
        [Validation(Required=false)]
        public string Oid { get; set; }

        /// <summary>
        /// <para>The operator parameters.</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public OperatorBasicInfoParam Param { get; set; }
        public class OperatorBasicInfoParam : TeaModel {
            /// <summary>
            /// <para>The answer hit threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("AnswerThreshold")]
            [Validation(Required=false)]
            public string AnswerThreshold { get; set; }

            /// <summary>
            /// <para>The Ant model information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("AntModelInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> AntModelInfo { get; set; }

            /// <summary>
            /// <para>Specifies whether to calculate the average speech rate for the entire conversation during speech rate detection. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Average")]
            [Validation(Required=false)]
            public bool? Average { get; set; }

            /// <summary>
            /// <para>The start type for duration calculation in the duration operator. Specifies whether the calculation starts from the beginning of the recording or the beginning of a specific dialogue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BeginType")]
            [Validation(Required=false)]
            public string BeginType { get; set; }

            /// <summary>
            /// <para>The bot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-xxx</para>
            /// </summary>
            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            /// <summary>
            /// <para>Specifies whether the match is case-sensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Case_sensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            /// <summary>
            /// <para>The knowledge category path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("CategoryPathCode")]
            [Validation(Required=false)]
            public string CategoryPathCode { get; set; }

            /// <summary>
            /// <para>Specifies whether to check the first sentence for silence detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CheckFirstSentence")]
            [Validation(Required=false)]
            public bool? CheckFirstSentence { get; set; }

            /// <summary>
            /// <para>The check type. Default value: 1. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Energy fluctuation between adjacent sentences.</description></item>
            /// <item><description>2: Maximum energy span.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            /// <summary>
            /// <para>The comparison operator. Valid values: gt: Greater than. lt: Less than.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gt</para>
            /// </summary>
            [NameInMap("CompareOperator")]
            [Validation(Required=false)]
            public string CompareOperator { get; set; }

            /// <summary>
            /// <para>Specifies whether single-sentence matching is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContextChatMatch")]
            [Validation(Required=false)]
            public bool? ContextChatMatch { get; set; }

            /// <summary>
            /// <para>The operator parameters for call variables.</para>
            /// </summary>
            [NameInMap("CustomerParam")]
            [Validation(Required=false)]
            public JudgeNodeMetaDesc CustomerParam { get; set; }

            /// <summary>
            /// <para>The delay duration for the barge-in operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public int? DelayTime { get; set; }

            /// <summary>
            /// <para>Used for the time interval operator to determine the time interval. If set to true, the target sentence is excluded from the calculation if it is spoken by the same role as the current sentence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Different_role")]
            [Validation(Required=false)]
            public bool? DifferentRole { get; set; }

            /// <summary>
            /// <para>The quality check dimensions.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<OperatorBasicInfoParamDimensions> Dimensions { get; set; }
            public class OperatorBasicInfoParamDimensions : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Checks whether impolite or non-standard opening remarks are used in customer service conversations, which affects service professionalism</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The quality check dimensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inappropriate opening remarks</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <para>The exclusion condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Customer service representatives must use the official standard dialect during service</para>
                /// </summary>
                [NameInMap("ExcludeCondition")]
                [Validation(Required=false)]
                public string ExcludeCondition { get; set; }

                /// <summary>
                /// <para>The hit condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Non-standard and impolite greetings such as &quot;Hey&quot; appear at the beginning of the conversation</para>
                /// </summary>
                [NameInMap("IncludeCondition")]
                [Validation(Required=false)]
                public string IncludeCondition { get; set; }

            }

            /// <summary>
            /// <para>The end type for duration calculation in the duration operator. Specifies whether the calculation ends at the end of the recording or the end of a specific dialogue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EndType")]
            [Validation(Required=false)]
            public string EndType { get; set; }

            /// <summary>
            /// <para>The dialogues excluded from the context repetition operator.</para>
            /// </summary>
            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public List<string> Excludes { get; set; }

            /// <summary>
            /// <para>The number of preceding sentences to check for repetition in the context repetition operator. A value of 0 indicates all preceding sentences.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public int? From { get; set; }

            /// <summary>
            /// <para>Used for the time interval operator to determine the time interval. Specifies whether the time interval is calculated by subtracting the end time of the target sentence from the end time of the current sentence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("From_end")]
            [Validation(Required=false)]
            public bool? FromEnd { get; set; }

            /// <summary>
            /// <para>The hit condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hit condition</para>
            /// </summary>
            [NameInMap("HitCondition")]
            [Validation(Required=false)]
            public string HitCondition { get; set; }

            /// <summary>
            /// <para>The number of repetitions for the context repetition operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Hit_time")]
            [Validation(Required=false)]
            public int? HitTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the rule applies to a single sentence or multiple sentences. Valid values: true: A single sentence. false: Multiple sentences.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("In_sentence")]
            [Validation(Required=false)]
            public bool? InSentence { get; set; }

            /// <summary>
            /// <para>The start of the interval range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The end of the interval range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IntervalEnd")]
            [Validation(Required=false)]
            public int? IntervalEnd { get; set; }

            /// <summary>
            /// <para>The keyword extension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeywordExtension")]
            [Validation(Required=false)]
            public int? KeywordExtension { get; set; }

            /// <summary>
            /// <para>The number of matched keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KeywordMatchSize")]
            [Validation(Required=false)]
            public int? KeywordMatchSize { get; set; }

            /// <summary>
            /// <para>The keywords.</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            /// <summary>
            /// <para>The knowledge information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Place an order</para>
            /// </summary>
            [NameInMap("KnowledgeInfo")]
            [Validation(Required=false)]
            public string KnowledgeInfo { get; set; }

            /// <summary>
            /// <para>The number of sentences within which the answer is detected after a question is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KnowledgeSentenceNum")]
            [Validation(Required=false)]
            public int? KnowledgeSentenceNum { get; set; }

            /// <summary>
            /// <para>The knowledge category or knowledge ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KnowledgeTargetId")]
            [Validation(Required=false)]
            public string KnowledgeTargetId { get; set; }

            /// <summary>
            /// <para>The knowledge category name or knowledge name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Order</para>
            /// </summary>
            [NameInMap("KnowledgeTargetName")]
            [Validation(Required=false)]
            public string KnowledgeTargetName { get; set; }

            /// <summary>
            /// <para>The knowledge target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Category.</description></item>
            /// <item><description>1: Knowledge.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("KnowledgeTargetType")]
            [Validation(Required=false)]
            public int? KnowledgeTargetType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> This field is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("Knowledges")]
            [Validation(Required=false)]
            public string Knowledges { get; set; }

            /// <summary>
            /// <para>The LGF sentences.</para>
            /// </summary>
            [NameInMap("LgfSentences")]
            [Validation(Required=false)]
            public List<string> LgfSentences { get; set; }

            /// <summary>
            /// <para>The large language model code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TYXM_PLUS</para>
            /// </summary>
            [NameInMap("LlmModelCode")]
            [Validation(Required=false)]
            public string LlmModelCode { get; set; }

            /// <summary>
            /// <para>The emotion change value. Default value: 3. Valid values: 1 to 9.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxEmotionChangeValue")]
            [Validation(Required=false)]
            public int? MaxEmotionChangeValue { get; set; }

            /// <summary>
            /// <para>The minimum number of words in a sentence. Sentences with fewer words than this value are not checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MinWordSize")]
            [Validation(Required=false)]
            public int? MinWordSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to use adjacent sentences spoken by different roles. Valid values: true: Uses adjacent sentences spoken by different roles. false: Uses the first sentences spoken by different roles to compare the response time. This is the default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Near_dialogue")]
            [Validation(Required=false)]
            public bool? NearDialogue { get; set; }

            /// <summary>
            /// <para>The excluded regular expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excellent.*</para>
            /// </summary>
            [NameInMap("NotRegex")]
            [Validation(Required=false)]
            public string NotRegex { get; set; }

            /// <summary>
            /// <para>The phrase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hello, may I ask</para>
            /// </summary>
            [NameInMap("Phrase")]
            [Validation(Required=false)]
            public string Phrase { get; set; }

            /// <summary>
            /// <para>The variable required for external properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Pkey")]
            [Validation(Required=false)]
            public string Pkey { get; set; }

            /// <summary>
            /// <para>The poutput type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Poutput_type")]
            [Validation(Required=false)]
            public int? PoutputType { get; set; }

            /// <summary>
            /// <para>The model detection type.</para>
            /// </summary>
            [NameInMap("Pvalues")]
            [Validation(Required=false)]
            public List<string> Pvalues { get; set; }

            /// <summary>
            /// <para>The question hit threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("QuestionThreshold")]
            [Validation(Required=false)]
            public string QuestionThreshold { get; set; }

            /// <summary>
            /// <para>The references.</para>
            /// </summary>
            [NameInMap("References")]
            [Validation(Required=false)]
            public List<string> References { get; set; }

            /// <summary>
            /// <para>The regular expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Question.*</para>
            /// </summary>
            [NameInMap("Regex")]
            [Validation(Required=false)]
            public string Regex { get; set; }

            /// <summary>
            /// <para>The role used in the operator. Currently used for the context repetition operator and used together with target_role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public int? RoleId { get; set; }

            /// <summary>
            /// <para>The scene name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Polite language detection</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The similarity threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Similarity_threshold")]
            [Validation(Required=false)]
            public double? SimilarityThreshold { get; set; }

            /// <summary>
            /// <para>The similar questions.</para>
            /// </summary>
            [NameInMap("SimilarlySentences")]
            [Validation(Required=false)]
            public List<string> SimilarlySentences { get; set; }

            /// <summary>
            /// <para>The synonyms.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deprecated field</para>
            /// </summary>
            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Synonyms { get; set; }

            /// <summary>
            /// <para>Specifies the number of sentences before the current sentence to use as the target sentence. If the value is 0, the time interval is calculated by subtracting the start time of the current sentence from its end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public int? Target { get; set; }

            /// <summary>
            /// <para>Used for the repetition operator. If the current sentence matches the regular expression, the matched part is searched in the preceding sentences spoken by the role specified by target_role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agent</para>
            /// </summary>
            [NameInMap("Target_role")]
            [Validation(Required=false)]
            public string TargetRole { get; set; }

            /// <summary>
            /// <para>The threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            /// <summary>
            /// <para>Specifies whether the EAS algorithm is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseEasAlgorithm")]
            [Validation(Required=false)]
            public bool? UseEasAlgorithm { get; set; }

            /// <summary>
            /// <para>Used for the speech rate operator. Specifies the speech rate value per unit of time to determine whether the speech rate of the current sentence exceeds the specified value. The time unit depends on the time units of the passed start and end parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("Velocity")]
            [Validation(Required=false)]
            public double? Velocity { get; set; }

            /// <summary>
            /// <para>Used for the speech rate operator. Specifies the speech rate value per minute to determine whether the speech rate of the current sentence exceeds the specified value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VelocityInMint")]
            [Validation(Required=false)]
            public int? VelocityInMint { get; set; }

        }

        /// <summary>
        /// <para>The quality check type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Offline quality check.</description></item>
        /// <item><description>1: Real-time quality check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        /// <summary>
        /// <para>The operator type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIT_ANY_KEYWORDS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
