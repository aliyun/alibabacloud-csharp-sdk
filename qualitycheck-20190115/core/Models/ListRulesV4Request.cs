// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListRulesV4Request : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Name of the business that owns the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>所有业务</para>
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// <para>Top-level business category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("BusinessRange")]
        [Validation(Required=false)]
        public int? BusinessRange { get; set; }

        /// <summary>
        /// <para>Category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>分类名称A</para>
        /// </summary>
        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// <para>Whether to count the total number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CountTotal")]
        [Validation(Required=false)]
        public bool? CountTotal { get; set; }

        /// <summary>
        /// <para>ID of the rule creator. Same as CreateUserId. Specify one only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CreateEmpid")]
        [Validation(Required=false)]
        public string CreateEmpid { get; set; }

        /// <summary>
        /// <para>ID of the rule creator. Same as CreateEmpId. Specify one only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Filter by creation time (right boundary).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-29 19:11:09</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>ID of the rule updater. Same as UpdateUserId. Specify one only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Required fields.</para>
        /// </summary>
        [NameInMap("RequireInfos")]
        [Validation(Required=false)]
        public List<string> RequireInfos { get; set; }

        /// <summary>
        /// <para>Search by rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>895EAD5312634F5AA708E3B3FA79662E</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>Search by rule ID or rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("RuleIdOrRuleName")]
        [Validation(Required=false)]
        public string RuleIdOrRuleName { get; set; }

        /// <summary>
        /// <para>Scoring type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleScoreSingleType")]
        [Validation(Required=false)]
        public int? RuleScoreSingleType { get; set; }

        /// <summary>
        /// <para>Rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>Quality inspection scheme ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000090</para>
        /// </summary>
        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        /// <summary>
        /// <para>Source type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public int? SourceType { get; set; }

        /// <summary>
        /// <para>Filter by creation time (left boundary).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-29 18:11:09</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Rule status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Type value of the rule category that the rule belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>Name of the rule category that the rule belongs to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>所有类型</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>Filter by update time (right boundary).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-29 18:11:09</para>
        /// </summary>
        [NameInMap("UpdateEndTime")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        /// <summary>
        /// <para>Filter by update time (left boundary).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-29 16:11:09</para>
        /// </summary>
        [NameInMap("UpdateStartTime")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        /// <summary>
        /// <para>ID of the rule updater. Same as LastUpdateEmpId. Specify one only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UpdateUserId")]
        [Validation(Required=false)]
        public long? UpdateUserId { get; set; }

    }

}
