// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleInfo : TeaModel {
        /// <summary>
        /// <para>The review option. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>1</c> (Manual review) and <c>3</c> (Automatic review).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoReview")]
        [Validation(Required=false)]
        public int? AutoReview { get; set; }

        /// <summary>
        /// <para>A list of business category names.</para>
        /// </summary>
        [NameInMap("BusinessCategoryNameList")]
        [Validation(Required=false)]
        public List<string> BusinessCategoryNameList { get; set; }

        /// <summary>
        /// <para>The check type. Valid values: <c>0</c> (Service compliance check), <c>1</c> (Service attitude check), <c>2</c> (Service professionalism check), <c>3</c> (Customer attitude check), and <c>4</c> (Service process correctness check).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public long? CheckType { get; set; }

        /// <summary>
        /// <para>Remarks on the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>违规</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The configuration type. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>1</c> (Simple condition configuration) and <c>2</c> (Advanced configuration). Default: <c>1</c>.</para>
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
        /// <para>张三</para>
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
        /// <para>The creation time. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether editing the rule is denied. Valid values: <c>1</c> (denied), <c>0</c> or <c>null</c> (allowed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Deny")]
        [Validation(Required=false)]
        public int? Deny { get; set; }

        /// <summary>
        /// <para>A list of test dialogues.</para>
        /// </summary>
        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<RuleTestDialogue> Dialogues { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is in effect. Valid values: <c>0</c> (No) and <c>1</c> (Yes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Effective")]
        [Validation(Required=false)]
        public int? Effective { get; set; }

        /// <summary>
        /// <para>The effective end time of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OperationMode</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The effective start time of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OperationMode</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The end time. This value is a Unix timestamp in milliseconds.</para>
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
        /// <para>Indicates whether the rule is effective throughout its lifecycle. Valid values: <c>0</c> (No) and <c>1</c> (Yes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FullCycle")]
        [Validation(Required=false)]
        public int? FullCycle { get; set; }

        /// <summary>
        /// <para>The graph flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("GraphFlow")]
        [Validation(Required=false)]
        public object GraphFlow { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public int? IsDelete { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is online.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOnline")]
        [Validation(Required=false)]
        public int? IsOnline { get; set; }

        /// <summary>
        /// <para>The conditional expression, such as <c>a&amp;&amp;b</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a&amp;&amp;b</para>
        /// </summary>
        [NameInMap("Lambda")]
        [Validation(Required=false)]
        public string Lambda { get; set; }

        /// <summary>
        /// <para>The name of the employee who last updated the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("LastUpdateEmpName")]
        [Validation(Required=false)]
        public string LastUpdateEmpName { get; set; }

        /// <summary>
        /// <para>The ID of the employee who last updated the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        /// <summary>
        /// <para>The last update time. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// <para>The severity level of the rule. Valid values: <c>0</c> (Severe violation), <c>1</c> (Moderate violation), and <c>2</c> (Minor violation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>Indicates whether the conditions are met.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Meet")]
        [Validation(Required=false)]
        public int? Meet { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule has been modified within the quality check scheme.</para>
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
        /// <para>开头语规则</para>
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

        [NameInMap("PreqRule")]
        [Validation(Required=false)]
        public RuleInfoPreqRule PreqRule { get; set; }
        public class RuleInfoPreqRule : TeaModel {
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }

        }

        /// <summary>
        /// <para>The quality check type. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>0</c> (offline quality check) and <c>1</c> (real-time quality check).</para>
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
        /// <para>The name of the rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>正向规则</para>
        /// </summary>
        [NameInMap("RuleCategoryName")]
        [Validation(Required=false)]
        public string RuleCategoryName { get; set; }

        /// <summary>
        /// <para>Specifies whether to score the rule. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>1</c> (Do not score) and <c>3</c> (Score).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RuleScoreType")]
        [Validation(Required=false)]
        public int? RuleScoreType { get; set; }

        /// <summary>
        /// <para>The rule type. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>0</c> (Default) and <c>1</c> (User-created).</para>
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
        /// <para>The ID of the quality check scheme to which the rule belongs.</para>
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
        /// <para>通用方案</para>
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
        /// <para>Indicates whether the scoring item is deleted. A deleted item may be displayed as grayed out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScoreDeleted")]
        [Validation(Required=false)]
        public bool? ScoreDeleted { get; set; }

        /// <summary>
        /// <para>The ID of the main scoring item.</para>
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
        /// <para>违规</para>
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
        /// <para>The scoring method. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>0</c> (Add/deduct points when the rule is triggered) and <c>1</c> (Assign a one-time score when the rule is triggered).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreNumType")]
        [Validation(Required=false)]
        public int? ScoreNumType { get; set; }

        /// <summary>
        /// <para>The scoring trigger. Valid values: <c>0</c> (Score when a node is hit).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScoreRuleHitType")]
        [Validation(Required=false)]
        public int? ScoreRuleHitType { get; set; }

        /// <summary>
        /// <para>The ID of the scoring subitem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreSubId")]
        [Validation(Required=false)]
        public long? ScoreSubId { get; set; }

        /// <summary>
        /// <para>The name of the scoring subitem.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreSubName")]
        [Validation(Required=false)]
        public string ScoreSubName { get; set; }

        /// <summary>
        /// <para>Indicates whether to add or deduct points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScoreType")]
        [Validation(Required=false)]
        public int? ScoreType { get; set; }

        /// <summary>
        /// <para>The sort order of the rule in the quality check dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortIndex")]
        [Validation(Required=false)]
        public int? SortIndex { get; set; }

        /// <summary>
        /// <para>The start time. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1641277321000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The rule category. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>10</c> (General rule for quality check schemes) and <c>11</c> (Flow rule for quality check schemes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// <para>The ID of the flowchart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>111111111</para>
        /// </summary>
        [NameInMap("TaskFlowId")]
        [Validation(Required=false)]
        public long? TaskFlowId { get; set; }

        /// <summary>
        /// <para>The type of the flowchart. This parameter is deprecated. The default value is <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskFlowType")]
        [Validation(Required=false)]
        public int? TaskFlowType { get; set; }

        /// <summary>
        /// <para>A list of triggers.</para>
        /// </summary>
        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<string> Triggers { get; set; }

        /// <summary>
        /// <para>The rule category. This parameter is used for compatibility with the v4.0 protocol. Valid values: <c>2</c> (Public opinion monitoring) and <c>3</c> (Business).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The weight of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
