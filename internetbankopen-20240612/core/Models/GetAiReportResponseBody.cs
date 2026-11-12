// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class GetAiReportResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiReportResponseBodyData Data { get; set; }
        public class GetAiReportResponseBodyData : TeaModel {
            [NameInMap("Report")]
            [Validation(Required=false)]
            public GetAiReportResponseBodyDataReport Report { get; set; }
            public class GetAiReportResponseBodyDataReport : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-12-12T06:20:00Z</para>
                /// </summary>
                [NameInMap("ContentExpiresAt")]
                [Validation(Required=false)]
                public string ContentExpiresAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://reports.example.com/report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a.pdf">https://reports.example.com/report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a.pdf</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-12T06:25:00Z</para>
                /// </summary>
                [NameInMap("UrlExpiresAt")]
                [Validation(Required=false)]
                public string UrlExpiresAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9634F2B3-B59C-5475-BA9F-96D95271882C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
