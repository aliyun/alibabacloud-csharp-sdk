// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RuleCountInfo : TeaModel {
        /// <summary>
        /// <para>The review option.</para>
        /// <list type="bullet">
        /// <item><description><para>1: Manual review</para>
        /// </description></item>
        /// <item><description><para>3: Automatic review</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoReview")]
        [Validation(Required=false)]
        public int? AutoReview { get; set; }

        /// <summary>
        /// <para>A list of basic information about business categories.</para>
        /// </summary>
        [NameInMap("BusinessCategoryBasicInfoList")]
        [Validation(Required=false)]
        public List<BusinessCategoryBasicInfo> BusinessCategoryBasicInfoList { get; set; }

        /// <summary>
        /// <para>A list of business category names.</para>
        /// </summary>
        [NameInMap("BusinessCategoryNameList")]
        [Validation(Required=false)]
        public List<string> BusinessCategoryNameList { get; set; }

        /// <summary>
        /// <para>The business scope.</para>
        /// </summary>
        [NameInMap("BusinessRange")]
        [Validation(Required=false)]
        public List<int?> BusinessRange { get; set; }

        /// <summary>
        /// <para>The number of checked sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckNumber")]
        [Validation(Required=false)]
        public long? CheckNumber { get; set; }

        /// <summary>
        /// <para>The comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615133575000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>You can set this parameter to 1 to reject rule edits, or to 0 or null to allow rule edits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Deny")]
        [Validation(Required=false)]
        public int? Deny { get; set; }

        /// <summary>
        /// <para>Indicates if the rule is active. \<c>0\\</c>: No. \<c>1\\</c>: Yes.</para>
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
        /// <para>1662685868850</para>
        /// </summary>
        [NameInMap("EffectiveEndTime")]
        [Validation(Required=false)]
        public string EffectiveEndTime { get; set; }

        /// <summary>
        /// <para>The effective start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1662685868850</para>
        /// </summary>
        [NameInMap("EffectiveStartTime")]
        [Validation(Required=false)]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650092585176</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates if the rule is active for the entire lifecycle. \<c>0\\</c>: No. \<c>1\\</c>: Yes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FullCycle")]
        [Validation(Required=false)]
        public int? FullCycle { get; set; }

        /// <summary>
        /// <para>The flow canvas, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>较复杂，忽略</para>
        /// </summary>
        [NameInMap("GraphFlow")]
        [Validation(Required=false)]
        public object GraphFlow { get; set; }

        /// <summary>
        /// <para>The number of hit sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HitNumber")]
        [Validation(Required=false)]
        public long? HitNumber { get; set; }

        /// <summary>
        /// <para>The hit rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HitRate")]
        [Validation(Required=false)]
        public float? HitRate { get; set; }

        /// <summary>
        /// <para>The hit rate of actual violations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HitRealViolationRate")]
        [Validation(Required=false)]
        public float? HitRealViolationRate { get; set; }

        /// <summary>
        /// <para>Indicates if the rule is deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public int? IsDelete { get; set; }

        /// <summary>
        /// <para>Indicates if the rule is selected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSelect")]
        [Validation(Required=false)]
        public bool? IsSelect { get; set; }

        /// <summary>
        /// <para>The scheduled task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-1-20221012-105943</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The name of the user who last updated the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("LastUpdateEmpName")]
        [Validation(Required=false)]
        public string LastUpdateEmpName { get; set; }

        /// <summary>
        /// <para>The employee ID of the user who last updated the rule.</para>
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
        /// <para>1648200901000</para>
        /// </summary>
        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0801转封装测试</para>
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
        /// <para>The number of items pending review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PreReviewNumber")]
        [Validation(Required=false)]
        public long? PreReviewNumber { get; set; }

        /// <summary>
        /// <para>The number of problems found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProblemNumber")]
        [Validation(Required=false)]
        public long? ProblemNumber { get; set; }

        /// <summary>
        /// <para>The quality check type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: Offline</para>
        /// </description></item>
        /// <item><description><para>1: Real-time</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QualityCheckType")]
        [Validation(Required=false)]
        public int? QualityCheckType { get; set; }

        /// <summary>
        /// <para>The number of actual violations after review.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RealViolationNumber")]
        [Validation(Required=false)]
        public int? RealViolationNumber { get; set; }

        /// <summary>
        /// <para>The review accuracy rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReviewAccuracyRate")]
        [Validation(Required=false)]
        public float? ReviewAccuracyRate { get; set; }

        /// <summary>
        /// <para>The number of reviewed items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReviewNumber")]
        [Validation(Required=false)]
        public long? ReviewNumber { get; set; }

        /// <summary>
        /// <para>The review rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReviewRate")]
        [Validation(Required=false)]
        public float? ReviewRate { get; set; }

        /// <summary>
        /// <para>The review status name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>通过</para>
        /// </summary>
        [NameInMap("ReviewStatusName")]
        [Validation(Required=false)]
        public string ReviewStatusName { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>The scoring type. \<c>8\\</c>: No score is set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleScoreSingleType")]
        [Validation(Required=false)]
        public int? RuleScoreSingleType { get; set; }

        /// <summary>
        /// <para>Specifies if a score is calculated.</para>
        /// <list type="bullet">
        /// <item><description><para>1: No</para>
        /// </description></item>
        /// <item><description><para>3: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleScoreType")]
        [Validation(Required=false)]
        public int? RuleScoreType { get; set; }

        /// <summary>
        /// <para>The rule origin. For example, a built-in rule or a user-created rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

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
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1662685868850</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the rule.</para>
        /// <list type="bullet">
        /// <item><description><para>0: Pending</para>
        /// </description></item>
        /// <item><description><para>1: Active</para>
        /// </description></item>
        /// <item><description><para>2: Expired</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The rule category.</para>
        /// <list type="bullet">
        /// <item><description><para>10: Standard</para>
        /// </description></item>
        /// <item><description><para>11: Flow-based</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public int? TargetType { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The type name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>全部类别</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>The number of unreviewed items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UnReviewNumber")]
        [Validation(Required=false)]
        public long? UnReviewNumber { get; set; }

        /// <summary>
        /// <para>The user group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public string UserGroup { get; set; }

    }

}
