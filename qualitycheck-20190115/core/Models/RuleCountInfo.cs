// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleCountInfo : TeaModel {
        [NameInMap("AutoReview")]
        [Validation(Required=false)]
        public int? AutoReview { get; set; }

        [NameInMap("BusinessCategoryBasicInfoList")]
        [Validation(Required=false)]
        public List<BusinessCategoryBasicInfo> BusinessCategoryBasicInfoList { get; set; }

        [NameInMap("BusinessCategoryNameList")]
        [Validation(Required=false)]
        public List<string> BusinessCategoryNameList { get; set; }

        [NameInMap("BusinessRange")]
        [Validation(Required=false)]
        public List<int?> BusinessRange { get; set; }

        [NameInMap("CheckNumber")]
        [Validation(Required=false)]
        public long? CheckNumber { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

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

        [NameInMap("FullCycle")]
        [Validation(Required=false)]
        public int? FullCycle { get; set; }

        [NameInMap("GraphFlow")]
        [Validation(Required=false)]
        public object GraphFlow { get; set; }

        [NameInMap("HitNumber")]
        [Validation(Required=false)]
        public long? HitNumber { get; set; }

        [NameInMap("HitRate")]
        [Validation(Required=false)]
        public float? HitRate { get; set; }

        [NameInMap("HitRealViolationRate")]
        [Validation(Required=false)]
        public float? HitRealViolationRate { get; set; }

        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public int? IsDelete { get; set; }

        [NameInMap("IsSelect")]
        [Validation(Required=false)]
        public bool? IsSelect { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("LastUpdateEmpName")]
        [Validation(Required=false)]
        public string LastUpdateEmpName { get; set; }

        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperationMode")]
        [Validation(Required=false)]
        public int? OperationMode { get; set; }

        [NameInMap("PreReviewNumber")]
        [Validation(Required=false)]
        public long? PreReviewNumber { get; set; }

        [NameInMap("ProblemNumber")]
        [Validation(Required=false)]
        public long? ProblemNumber { get; set; }

        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        [NameInMap("RealViolationNumber")]
        [Validation(Required=false)]
        public int? RealViolationNumber { get; set; }

        [NameInMap("ReviewAccuracyRate")]
        [Validation(Required=false)]
        public float? ReviewAccuracyRate { get; set; }

        [NameInMap("ReviewNumber")]
        [Validation(Required=false)]
        public long? ReviewNumber { get; set; }

        [NameInMap("ReviewRate")]
        [Validation(Required=false)]
        public float? ReviewRate { get; set; }

        [NameInMap("ReviewStatusName")]
        [Validation(Required=false)]
        public string ReviewStatusName { get; set; }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        [NameInMap("RuleScoreSingleType")]
        [Validation(Required=false)]
        public int? RuleScoreSingleType { get; set; }

        [NameInMap("RuleScoreType")]
        [Validation(Required=false)]
        public int? RuleScoreType { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("ScoreSubId")]
        [Validation(Required=false)]
        public long? ScoreSubId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        [NameInMap("UnReviewNumber")]
        [Validation(Required=false)]
        public long? UnReviewNumber { get; set; }

        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
