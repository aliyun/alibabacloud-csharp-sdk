// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetReportFromTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DE9FFFE5-FCAD-4B24-9546-BF49273C562B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TemplateReport")]
        [Validation(Required=false)]
        public GetReportFromTemplateResponseBodyTemplateReport TemplateReport { get; set; }
        public class GetReportFromTemplateResponseBodyTemplateReport : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1478085326082xxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1763540426815</para>
            /// </summary>
            [NameInMap("ReportCreateEndTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateEndTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1763540421815</para>
            /// </summary>
            [NameInMap("ReportCreateStartTimestamp")]
            [Validation(Required=false)]
            public long? ReportCreateStartTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crt-xxx</para>
            /// </summary>
            [NameInMap("ReportTemplateId")]
            [Validation(Required=false)]
            public string ReportTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("ReportUrl")]
            [Validation(Required=false)]
            public string ReportUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crtr-xxx</para>
            /// </summary>
            [NameInMap("TemplateReportId")]
            [Validation(Required=false)]
            public string TemplateReportId { get; set; }

        }

    }

}
