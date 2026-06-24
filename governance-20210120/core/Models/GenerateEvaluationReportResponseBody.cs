// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GenerateEvaluationReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The account ID for which the report is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103144549568****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The governance maturity evaluation score.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7684</para>
        /// </summary>
        [NameInMap("EvaluationScore")]
        [Validation(Required=false)]
        public double? EvaluationScore { get; set; }

        /// <summary>
        /// <para>The evaluation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-12T07:25:33Z</para>
        /// </summary>
        [NameInMap("EvaluationTime")]
        [Validation(Required=false)]
        public string EvaluationTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the report generation is complete.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>true: The report generation is complete.</description></item>
        /// <item><description>false: The report generation is not complete.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

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

        /// <summary>
        /// <para>The download URL of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://governance-prod-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/reports-html/">https://governance-prod-cn-hangzhou.oss-cn-hangzhou.aliyuncs.com/reports-html/</a>*****</para>
        /// </summary>
        [NameInMap("ReportUrl")]
        [Validation(Required=false)]
        public string ReportUrl { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DCF863F-CBBB-57C4-8AF2-5D4EE35D1EB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
