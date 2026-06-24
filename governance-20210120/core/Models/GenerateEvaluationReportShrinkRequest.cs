// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GenerateEvaluationReportShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The account ID. If this parameter is not specified, the report is generated for the current account by default. A management account (MA) can pass in a member account ID to generate a report for the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103144549568****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The list of member account IDs for which to generate reports.
        /// Note: This parameter is required only when you generate a multi-account report and want to specify the scope of accounts.</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

        /// <summary>
        /// <para>RegionId</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EvaluationAccountHtmlReport: single-account HTML report.</description></item>
        /// <item><description>EvaluationAccountExcelReport: single-account Excel report.</description></item>
        /// <item><description>EvaluationMultiAccountExcelReport: multi-account Excel report.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EvaluationAccountExcelReport</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

    }

}
