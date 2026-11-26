// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleInfo : TeaModel {
        /// <summary>
        /// <para>The review option. Valid values: 1: no automatic review. 3: automatic review. This field is used for 4.0 protocol compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoReview")]
        [Validation(Required=false)]
        public int? AutoReview { get; set; }

        /// <summary>
        /// <para>The list of business category names.</para>
        /// </summary>
        [NameInMap("BusinessCategoryNameList")]
        [Validation(Required=false)]
        public List<string> BusinessCategoryNameList { get; set; }

        /// <summary>
        /// <para>The check type. Valid values: 0: Service standard check. 1: Service attitude check. 2: Service professionalism check. 3: Customer attitude check. 4: Service process correctness check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public long? CheckType { get; set; }

        /// <summary>
        /// <para>The comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Violation</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The configuration type. This parameter is dedicated to the version 4.0 protocol. Valid values: 1: Simple condition configuration. 2: Advanced configuration. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public int? ConfigType { get; set; }

        /// <summary>
        /// <para>The name of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("CreateEmpName")]
        [Validation(Required=false)]
        public string CreateEmpName { get; set; }

        /// <summary>
        /// <para>The employee ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CreateEmpid")]
        [Validation(Required=false)]
        public string CreateEmpid { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The edit permission. Valid values: 1: Editing is denied. 0 or null: Editing is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Deny")]
        [Validation(Required=false)]
        public int? Deny { get; set; }

        /// <summary>
        /// <para>The test script.</para>
        /// </summary>
        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<RuleTestDialogue> Dialogues { get; set; }

        /// <summary>
        /// <para>The effective status. Valid values: 0: Not effective. 1: Effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Effective")]
        [Validation(Required=false)]
        public int? Effective { get; set; }

        /// <summary>
        /// <para>The effective end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OperationMode</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The effective start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OperationMode</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The external property.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExternalProperty")]
        [Validation(Required=false)]
        public int? ExternalProperty { get; set; }

        /// <summary>
        /// <para>The full lifecycle effective status. Valid values: 0: No. 1: Yes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FullCycle")]
        [Validation(Required=false)]
        public int? FullCycle { get; set; }

        /// <summary>
        /// <para>The graph flow canvas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("GraphFlow")]
        [Validation(Required=false)]
        public object GraphFlow { get; set; }

        /// <summary>
        /// <para>The deletion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public int? IsDelete { get; set; }

        /// <summary>
        /// <para>The online status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOnline")]
        [Validation(Required=false)]
        public int? IsOnline { get; set; }

        /// <summary>
        /// <para>The conditional expression, such as a&amp;&amp;b.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a&amp;&amp;b</para>
        /// </summary>
        [NameInMap("Lambda")]
        [Validation(Required=false)]
        public string Lambda { get; set; }

        /// <summary>
        /// <para>The name of the last updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("LastUpdateEmpName")]
        [Validation(Required=false)]
        public string LastUpdateEmpName { get; set; }

        /// <summary>
        /// <para>The employee ID of the last updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        /// <summary>
        /// <para>The last update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// <para>The rule level. Valid values: 0: Severe violation. 1: Moderate violation. 2: Minor violation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The fulfillment status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Meet")]
        [Validation(Required=false)]
        public int? Meet { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is modified in the quality inspection scheme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public int? ModifyType { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Greeting rule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operation mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public int? OperationMode { get; set; }

        /// <summary>
        /// <para>The prerequisite rule.</para>
        /// </summary>
        [NameInMap("PreqRule")]
        [Validation(Required=false)]
        public RuleInfoPreqRule PreqRule { get; set; }
        public class RuleInfoPreqRule : TeaModel {
            /// <summary>
            /// <para>The prerequisite rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }

        }

        /// <summary>
        /// <para>The quality check type. This parameter is used for compatibility with version 4.0 logic. Valid values: 0: Offline quality check. 1: Real-time quality check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public string Rid { get; set; }

        /// <summary>
        /// <para>The rule category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Positive rule</para>
        /// </summary>
        [NameInMap("RuleCategoryName")]
        [Validation(Required=false)]
        public string RuleCategoryName { get; set; }

        /// <summary>
        /// <para>Specifies whether to calculate the score. Valid values: 1: no scoring. 3: scoring. This field is used for 4.0 protocol compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RuleScoreType")]
        [Validation(Required=false)]
        public int? RuleScoreType { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values: 0: default. 1: user-created. This field is used for 4.0 logic compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The quality check dimension object.</para>
        /// </summary>
        [NameInMap("SchemeCheckType")]
        [Validation(Required=false)]
        public SchemeCheckType SchemeCheckType { get; set; }

        /// <summary>
        /// <para>The ID of the associated quality check scheme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        /// <summary>
        /// <para>The name of the quality check scheme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General scheme</para>
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// <para>The mapping ID between the quality check scheme and the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SchemeRuleMappingId")]
        [Validation(Required=false)]
        public long? SchemeRuleMappingId { get; set; }

        /// <summary>
        /// <para>The deletion status of the scoring item, which is used to gray out the item when it is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScoreDeleted")]
        [Validation(Required=false)]
        public bool? ScoreDeleted { get; set; }

        /// <summary>
        /// <para>The score category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreId")]
        [Validation(Required=false)]
        public long? ScoreId { get; set; }

        /// <summary>
        /// <para>The name of the main scoring item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Violation</para>
        /// </summary>
        [NameInMap("ScoreName")]
        [Validation(Required=false)]
        public string ScoreName { get; set; }

        /// <summary>
        /// <para>The score value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreNum")]
        [Validation(Required=false)]
        public float? ScoreNum { get; set; }

        /// <summary>
        /// <para>The score calculation type. This parameter is dedicated to the version 4.0 protocol. Valid values: 0: Add or deduct points after the rule is triggered. 1: Award a one-time score after the rule is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreNumType")]
        [Validation(Required=false)]
        public int? ScoreNumType { get; set; }

        /// <summary>
        /// <para>The score rule hit type. Valid values: 0: Score is calculated when a node is hit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScoreRuleHitType")]
        [Validation(Required=false)]
        public int? ScoreRuleHitType { get; set; }

        /// <summary>
        /// <para>The sub-item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreSubId")]
        [Validation(Required=false)]
        public long? ScoreSubId { get; set; }

        /// <summary>
        /// <para>The sub-scoring item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreSubName")]
        [Validation(Required=false)]
        public string ScoreSubName { get; set; }

        /// <summary>
        /// <para>The score adjustment type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreType")]
        [Validation(Required=false)]
        public int? ScoreType { get; set; }

        /// <summary>
        /// <para>The sort order within the quality inspection dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortIndex")]
        [Validation(Required=false)]
        public int? SortIndex { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The rule status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The rule category. This parameter is dedicated to the version 4.0 protocol. Valid values: 10: General rule for quality check scheme. 11: Process rule for quality check scheme.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// <para>The flow canvas ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("TaskFlowId")]
        [Validation(Required=false)]
        public long? TaskFlowId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The task flow type. Default value: -1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskFlowType")]
        [Validation(Required=false)]
        public int? TaskFlowType { get; set; }

        /// <summary>
        /// <para>The list of trigger conditions.</para>
        /// </summary>
        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<string> Triggers { get; set; }

        /// <summary>
        /// <para>The rule category. Valid values: 2: public opinion monitoring. 3: business. This field is used for 4.0 logic compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The weight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
