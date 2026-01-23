// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleInfo : TeaModel {
        [NameInMap("AutoReview")]
        [Validation(Required=false)]
        public int? AutoReview { get; set; }

        [NameInMap("BusinessCategoryNameList")]
        [Validation(Required=false)]
        public List<string> BusinessCategoryNameList { get; set; }

        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public long? CheckType { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public int? ConfigType { get; set; }

        [NameInMap("CreateEmpName")]
        [Validation(Required=false)]
        public string CreateEmpName { get; set; }

        [NameInMap("CreateEmpid")]
        [Validation(Required=false)]
        public string CreateEmpid { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Deny")]
        [Validation(Required=false)]
        public int? Deny { get; set; }

        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<RuleTestDialogue> Dialogues { get; set; }

        [NameInMap("Effective")]
        [Validation(Required=false)]
        public int? Effective { get; set; }

        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public string EffectiveEndTime { get; set; }

        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExternalProperty")]
        [Validation(Required=false)]
        public int? ExternalProperty { get; set; }

        [NameInMap("FullCycle")]
        [Validation(Required=false)]
        public int? FullCycle { get; set; }

        [NameInMap("GraphFlow")]
        [Validation(Required=false)]
        public object GraphFlow { get; set; }

        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public int? IsDelete { get; set; }

        [NameInMap("IsOnline")]
        [Validation(Required=false)]
        public int? IsOnline { get; set; }

        [NameInMap("Lambda")]
        [Validation(Required=false)]
        public string Lambda { get; set; }

        [NameInMap("LastUpdateEmpName")]
        [Validation(Required=false)]
        public string LastUpdateEmpName { get; set; }

        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("Meet")]
        [Validation(Required=false)]
        public int? Meet { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public int? ModifyType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public int? OperationMode { get; set; }

        [NameInMap("PreqRule")]
        [Validation(Required=false)]
        public List<RuleInfoPreqRule> PreqRule { get; set; }
        public class RuleInfoPreqRule : TeaModel {
            [NameInMap("Rid")]
            [Validation(Required=false)]
            public string Rid { get; set; }

        }

        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public string Rid { get; set; }

        [NameInMap("RuleCategoryName")]
        [Validation(Required=false)]
        public string RuleCategoryName { get; set; }

        [NameInMap("RuleScoreType")]
        [Validation(Required=false)]
        public int? RuleScoreType { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("SchemeCheckType")]
        [Validation(Required=false)]
        public SchemeCheckType SchemeCheckType { get; set; }

        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

        [NameInMap("SchemeRuleMappingId")]
        [Validation(Required=false)]
        public long? SchemeRuleMappingId { get; set; }

        [NameInMap("ScoreDeleted")]
        [Validation(Required=false)]
        public bool? ScoreDeleted { get; set; }

        [NameInMap("ScoreId")]
        [Validation(Required=false)]
        public long? ScoreId { get; set; }

        [NameInMap("ScoreName")]
        [Validation(Required=false)]
        public string ScoreName { get; set; }

        [NameInMap("ScoreNum")]
        [Validation(Required=false)]
        public int? ScoreNum { get; set; }

        [NameInMap("ScoreNumType")]
        [Validation(Required=false)]
        public int? ScoreNumType { get; set; }

        [NameInMap("ScoreRuleHitType")]
        [Validation(Required=false)]
        public int? ScoreRuleHitType { get; set; }

        [NameInMap("ScoreSubId")]
        [Validation(Required=false)]
        public long? ScoreSubId { get; set; }

        [NameInMap("ScoreSubName")]
        [Validation(Required=false)]
        public string ScoreSubName { get; set; }

        [NameInMap("ScoreType")]
        [Validation(Required=false)]
        public int? ScoreType { get; set; }

        [NameInMap("SortIndex")]
        [Validation(Required=false)]
        public int? SortIndex { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        [NameInMap("TaskFlowId")]
        [Validation(Required=false)]
        public long? TaskFlowId { get; set; }

        [NameInMap("TaskFlowType")]
        [Validation(Required=false)]
        public int? TaskFlowType { get; set; }

        [NameInMap("Triggers")]
        [Validation(Required=false)]
        public List<string> Triggers { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
