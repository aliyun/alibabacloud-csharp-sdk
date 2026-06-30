// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetRulesCountListRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID.</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Business name to which the rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>电话业务</para>
        /// </summary>
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// <para>Broad business category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>Whether to count the total number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CountTotal")]
        [Validation(Required=false)]
        public bool? CountTotal { get; set; }

        /// <summary>
        /// <para>Rule creator ID. Same as CreateUserId. Use either one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("CreateEmpid")]
        [Validation(Required=false)]
        public string CreateEmpid { get; set; }

        /// <summary>
        /// <para>Rule creator ID. Same as CreateEmpid. Use either one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
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
        /// <para>Filter by creation time (start of range).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-08 23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Rule updater ID. Same as UpdateUserId. Use either one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        /// <summary>
        /// <para>Page number of the rule list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of entries per page.</para>
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
        /// <para>123</para>
        /// </summary>
        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        /// <summary>
        /// <para>Search by rule ID or rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
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
        /// <para>123</para>
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
        /// <para>Filter by creation time (end of range).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-07 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Rule status:</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>Type value of the rule category to which the rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>Name of the rule category to which the rule belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>全部类别</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>Filter by update time (end of range).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-08 23:59:59</para>
        /// </summary>
        [NameInMap("UpdateEndTime")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        /// <summary>
        /// <para>Filter by update time (start of range).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-07 00:00:00</para>
        /// </summary>
        [NameInMap("UpdateStartTime")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        /// <summary>
        /// <para>Rule updater ID. Same as LastUpdateEmpid. Use either one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("UpdateUserId")]
        [Validation(Required=false)]
        public long? UpdateUserId { get; set; }

    }

}
