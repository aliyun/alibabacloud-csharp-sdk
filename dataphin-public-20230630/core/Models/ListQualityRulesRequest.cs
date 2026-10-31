// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRulesRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions, including paging parameters.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListQualityRulesRequestListQuery ListQuery { get; set; }
        public class ListQualityRulesRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The rule type. Valid values: CONSISTENT (Consistency), EFFECTIVE (Effectiveness), TIMELINESE (Timeliness), ACCURATE (Accuracy), UNIQUENESS (Uniqueness), COMPLETENESS (Completeness), STABILITY (Stability), and CUSTOM (Custom).</para>
            /// </summary>
            [NameInMap("CatalogList")]
            [Validation(Required=false)]
            public List<string> CatalogList { get; set; }

            /// <summary>
            /// <para>The search keyword. Supports searching by rule name and validation object.</para>
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
            /// <para>The rule strength. Valid values: STRONG (Strong) and WEAK (Weak).</para>
            /// </summary>
            [NameInMap("RuleStrengthList")]
            [Validation(Required=false)]
            public List<string> RuleStrengthList { get; set; }

            /// <summary>
            /// <para>The effective status of the rule. Valid values: ENABLE (Enabled) and DISABLE (Disabled).</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The rule template.</para>
            /// </summary>
            [NameInMap("TemplateIdList")]
            [Validation(Required=false)]
            public List<long?> TemplateIdList { get; set; }

            /// <summary>
            /// <para>The task status. Valid values: NOT_RUN (Not run), WAITING (Waiting), RUNNING (Running), SUCCESS (Succeeded), FAILED (Failed), CANCEL (Canceled), TIMEOUT (Timed out), and OFFLINE (Offline).</para>
            /// </summary>
            [NameInMap("TestRunTaskStatusList")]
            [Validation(Required=false)]
            public List<string> TestRunTaskStatusList { get; set; }

            /// <summary>
            /// <para>The validation result of the rule test run. Valid values: NOT_RUN (Not run), WAITING (Waiting), RUNNING (Running), PASS (Passed), NOT_PASS (Not passed), FAILED (Failed), OFFLINE (Offline, requires restart), CANCEL (Canceled), and TIMEOUT (Timed out).</para>
            /// </summary>
            [NameInMap("TestRunTaskValidateResultList")]
            [Validation(Required=false)]
            public List<string> TestRunTaskValidateResultList { get; set; }

            /// <summary>
            /// <para>The monitoring ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

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
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
