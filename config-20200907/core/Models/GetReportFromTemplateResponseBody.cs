// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetReportFromTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE9FFFE5-FCAD-4B24-9546-BF49273C562B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The report generated from the template.</para>
        /// </summary>
        [NameInMap("TemplateReport")]
        [Validation(Required=false)]
        public GetReportFromTemplateResponseBodyTemplateReport TemplateReport { get; set; }
        public class GetReportFromTemplateResponseBodyTemplateReport : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1478085326082xxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The timestamp when the report was generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763540426815</para>
            /// </summary>
            [NameInMap("ReportCreateEndTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateEndTimestamp { get; set; }

            /// <summary>
            /// <para>The timestamp when the report started to be generated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1763540421815</para>
            /// </summary>
            [NameInMap("ReportCreateStartTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateStartTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the report template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crt-xxx</para>
            /// </summary>
            [NameInMap("ReportTemplateId")]
            [Validation(Required=false)]
            public string ReportTemplateId { get; set; }

            /// <summary>
            /// <para>The download URL of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

            /// <summary>
            /// <para>The status of the report. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>COMPLETE: The report is generated.</para>
            /// </description></item>
            /// <item><description><para>CREATING: The report is being generated.</para>
            /// </description></item>
            /// <item><description><para>FAILED: The report failed to be generated.</para>
            /// </description></item>
            /// <item><description><para>TIMEOUT: The request timed out.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the report generated from the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crtr-xxx</para>
            /// </summary>
            [NameInMap("TemplateReportId")]
            [Validation(Required=false)]
            public string TemplateReportId { get; set; }

        }

    }

}
