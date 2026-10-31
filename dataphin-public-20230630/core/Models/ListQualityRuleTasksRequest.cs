// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRuleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The paging query conditions.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityRuleTasksRequestListQuery ListQuery { get; set; }
        public class ListQualityRuleTasksRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The business date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>The rule types. Valid values: CONSISTENT (consistency), EFFECTIVE (effectiveness), TIMELINESE (timeliness), ACCURATE (accuracy), UNIQUENESS (uniqueness), COMPLETENESS (completeness), STABILITY (stability), and CUSTOM (custom).</para>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>The search keyword. You can search by field name or rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The page number. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The rule strengths. Valid values: STRONG (strong) and WEAK (weak).</para>
            /// </summary>
            [NameInMap("RuleStrengthList")]
            [Validation(Required=false)]
            public List<string> RuleStrengthList { get; set; }

            /// <summary>
            /// <para>The rule labels. Valid values: DEFAULT (default label), DATA_STANDARD_MANUAL (manually created standard rules), DATA_STANDARD_AUTO (standard quality rules created by automatic creation), PIPELINE (rules created by pipelines), and DATA_MODELING (data modeling).</para>
            /// </summary>
            [NameInMap("RuleTagList")]
            [Validation(Required=false)]
            public List<string> RuleTagList { get; set; }

            /// <summary>
            /// <para>The task statuses. Valid values: NOT_RUN (not run), WAITING (waiting), RUNNING (running), SUCCESS (successful), FAILED (failed), CANCEL (canceled), TIMEOUT (timed out), and OFFLINE (offline).</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The validation results. Valid values: NOT_RUN (not run), WAITING (waiting), RUNNING (running), PASS (passed), NOT_PASS (not passed), FAILED (failed), OFFLINE (offline and requires restart), CANCEL (canceled), and TIMEOUT (timed out).</para>
            /// </summary>
            [NameInMap("ValidateResultList")]
            [Validation(Required=false)]
            public List<string> ValidateResultList { get; set; }

            /// <summary>
            /// <para>The quality watchtask ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchTaskId")]
            [Validation(Required=false)]
            public long? WatchTaskId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
