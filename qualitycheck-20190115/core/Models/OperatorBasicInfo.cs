// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class OperatorBasicInfo : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Oid")]
        [Validation(Required=false)]
        public string Oid { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public OperatorBasicInfoParam Param { get; set; }
        public class OperatorBasicInfoParam : TeaModel {
            [NameInMap("AnswerThreshold")]
            [Validation(Required=false)]
            public string AnswerThreshold { get; set; }

            [NameInMap("AntModelInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> AntModelInfo { get; set; }

            [NameInMap("Average")]
            [Validation(Required=false)]
            public bool? Average { get; set; }

            [NameInMap("BeginType")]
            [Validation(Required=false)]
            public string BeginType { get; set; }

            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            [NameInMap("Case_sensitive")]
            [Validation(Required=false)]
            public bool? CaseSensitive { get; set; }

            [NameInMap("CategoryPathCode")]
            [Validation(Required=false)]
            public string CategoryPathCode { get; set; }

            [NameInMap("CheckFirstSentence")]
            [Validation(Required=false)]
            public bool? CheckFirstSentence { get; set; }

            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public int? CheckType { get; set; }

            [NameInMap("CompareOperator")]
            [Validation(Required=false)]
            public string CompareOperator { get; set; }

            [NameInMap("ContextChatMatch")]
            [Validation(Required=false)]
            public bool? ContextChatMatch { get; set; }

            [NameInMap("CustomerParam")]
            [Validation(Required=false)]
            public JudgeNodeMetaDesc CustomerParam { get; set; }

            [NameInMap("DelayTime")]
            [Validation(Required=false)]
            public int? DelayTime { get; set; }

            [NameInMap("Different_role")]
            [Validation(Required=false)]
            public bool? DifferentRole { get; set; }

            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<OperatorBasicInfoParamDimensions> Dimensions { get; set; }
            public class OperatorBasicInfoParamDimensions : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("ExcludeCondition")]
                [Validation(Required=false)]
                public string ExcludeCondition { get; set; }

                [NameInMap("IncludeCondition")]
                [Validation(Required=false)]
                public string IncludeCondition { get; set; }

            }

            [NameInMap("EndType")]
            [Validation(Required=false)]
            public string EndType { get; set; }

            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public List<string> Excludes { get; set; }

            [NameInMap("From")]
            [Validation(Required=false)]
            public int? From { get; set; }

            [NameInMap("From_end")]
            [Validation(Required=false)]
            public bool? FromEnd { get; set; }

            [NameInMap("HitCondition")]
            [Validation(Required=false)]
            public string HitCondition { get; set; }

            [NameInMap("Hit_time")]
            [Validation(Required=false)]
            public int? HitTime { get; set; }

            [NameInMap("In_sentence")]
            [Validation(Required=false)]
            public bool? InSentence { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            [NameInMap("IntervalEnd")]
            [Validation(Required=false)]
            public int? IntervalEnd { get; set; }

            [NameInMap("KeywordExtension")]
            [Validation(Required=false)]
            public int? KeywordExtension { get; set; }

            [NameInMap("KeywordMatchSize")]
            [Validation(Required=false)]
            public int? KeywordMatchSize { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public List<string> Keywords { get; set; }

            [NameInMap("KnowledgeInfo")]
            [Validation(Required=false)]
            public string KnowledgeInfo { get; set; }

            [NameInMap("KnowledgeSentenceNum")]
            [Validation(Required=false)]
            public int? KnowledgeSentenceNum { get; set; }

            [NameInMap("KnowledgeTargetId")]
            [Validation(Required=false)]
            public string KnowledgeTargetId { get; set; }

            [NameInMap("KnowledgeTargetName")]
            [Validation(Required=false)]
            public string KnowledgeTargetName { get; set; }

            [NameInMap("KnowledgeTargetType")]
            [Validation(Required=false)]
            public int? KnowledgeTargetType { get; set; }

            [NameInMap("Knowledges")]
            [Validation(Required=false)]
            public string Knowledges { get; set; }

            [NameInMap("LgfSentences")]
            [Validation(Required=false)]
            public List<string> LgfSentences { get; set; }

            [NameInMap("LlmModelCode")]
            [Validation(Required=false)]
            public string LlmModelCode { get; set; }

            [NameInMap("MaxEmotionChangeValue")]
            [Validation(Required=false)]
            public int? MaxEmotionChangeValue { get; set; }

            [NameInMap("MinWordSize")]
            [Validation(Required=false)]
            public int? MinWordSize { get; set; }

            [NameInMap("Near_dialogue")]
            [Validation(Required=false)]
            public bool? NearDialogue { get; set; }

            [NameInMap("NotRegex")]
            [Validation(Required=false)]
            public string NotRegex { get; set; }

            [NameInMap("Phrase")]
            [Validation(Required=false)]
            public string Phrase { get; set; }

            [NameInMap("Pkey")]
            [Validation(Required=false)]
            public string Pkey { get; set; }

            [NameInMap("Poutput_type")]
            [Validation(Required=false)]
            public int? PoutputType { get; set; }

            [NameInMap("Pvalues")]
            [Validation(Required=false)]
            public List<string> Pvalues { get; set; }

            [NameInMap("QuestionThreshold")]
            [Validation(Required=false)]
            public string QuestionThreshold { get; set; }

            [NameInMap("References")]
            [Validation(Required=false)]
            public List<string> References { get; set; }

            [NameInMap("Regex")]
            [Validation(Required=false)]
            public string Regex { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public int? RoleId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("Similarity_threshold")]
            [Validation(Required=false)]
            public double? SimilarityThreshold { get; set; }

            [NameInMap("SimilarlySentences")]
            [Validation(Required=false)]
            public List<string> SimilarlySentences { get; set; }

            [NameInMap("Synonyms")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Synonyms { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public int? Target { get; set; }

            [NameInMap("Target_role")]
            [Validation(Required=false)]
            public string TargetRole { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

            [NameInMap("UseEasAlgorithm")]
            [Validation(Required=false)]
            public bool? UseEasAlgorithm { get; set; }

            [NameInMap("Velocity")]
            [Validation(Required=false)]
            public double? Velocity { get; set; }

            [NameInMap("VelocityInMint")]
            [Validation(Required=false)]
            public int? VelocityInMint { get; set; }

        }

        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
