// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GenerateEvaluationReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>103144549568****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.7684</para>
        /// </summary>
        [NameInMap("EvaluationScore")]
        [Validation(Required=false)]
        public double? EvaluationScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-01-12T07:25:33Z</para>
        /// </summary>
        [NameInMap("EvaluationTime")]
        [Validation(Required=false)]
        public string EvaluationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Finished")]
        [Validation(Required=false)]
        public string Finished { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EvaluationAccountExcelReport</para>
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
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
