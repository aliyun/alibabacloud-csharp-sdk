// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListQualityRuleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The paged query conditions.</para>
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
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CONSISTENT: consistency</description></item>
            /// <item><description>EFFECTIVE: validity</description></item>
            /// <item><description>TIMELINESE: timeliness</description></item>
            /// <item><description>ACCURATE: accuracy</description></item>
            /// <item><description>UNIQUENESS: uniqueness</description></item>
            /// <item><description>COMPLETENESS: completeness</description></item>
            /// <item><description>STABILITY: stability</description></item>
            /// <item><description>CUSTOM: custom.</description></item>
            /// </list>
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
            /// <para>The rule strength. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>STRONG: strong</description></item>
            /// <item><description>WEAK: weak.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RuleStrengthList")]
            [Validation(Required=false)]
            public List<string> RuleStrengthList { get; set; }

            /// <summary>
            /// <para>The rule label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEFAULT: default label</description></item>
            /// <item><description>DATA_STANDARD_MANUAL: standard rule manually created</description></item>
            /// <item><description>DATA_STANDARD_AUTO: quality rule created by automatic creation from a standard</description></item>
            /// <item><description>PIPELINE: rule created by a pipeline</description></item>
            /// <item><description>DATA_MODELING: data modeling diagnostics.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RuleTagList")]
            [Validation(Required=false)]
            public List<string> RuleTagList { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: not executed</description></item>
            /// <item><description>WAITING: waiting</description></item>
            /// <item><description>RUNNING: running</description></item>
            /// <item><description>SUCCESS: succeeded</description></item>
            /// <item><description>FAILED: failed</description></item>
            /// <item><description>CANCEL: canceled</description></item>
            /// <item><description>TIMEOUT: timed out</description></item>
            /// <item><description>OFFLINE: offline.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The validation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_RUN: not executed</description></item>
            /// <item><description>WAITING: waiting for execution</description></item>
            /// <item><description>RUNNING: running</description></item>
            /// <item><description>PASS: passed</description></item>
            /// <item><description>NOT_PASS: not passed</description></item>
            /// <item><description>FAILED: execution failed</description></item>
            /// <item><description>OFFLINE: offline and needs to be restarted</description></item>
            /// <item><description>CANCEL: task canceled</description></item>
            /// <item><description>TIMEOUT: task timed out.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ValidateResultList")]
            [Validation(Required=false)]
            public List<string> ValidateResultList { get; set; }

            /// <summary>
            /// <para>The ID of the quality watchtask.</para>
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

    }

}
