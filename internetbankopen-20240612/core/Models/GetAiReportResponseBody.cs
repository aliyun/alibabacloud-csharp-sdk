// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.InternetBankOpen20240612.Models
{
    public class GetAiReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The report query result, which contains ReportStatus. The Report object is included only when the report is available.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiReportResponseBodyData Data { get; set; }
        public class GetAiReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The download information of the available report, which is returned only when ReportStatus is AVAILABLE. The report ownership and the corresponding object version are verified before the download.</para>
            /// </summary>
            [NameInMap("Report")]
            [Validation(Required=false)]
            public GetAiReportResponseBodyDataReport Report { get; set; }
            public class GetAiReportResponseBodyDataReport : TeaModel {
                /// <summary>
                /// <para>The expiration time of the report content retention period. The time is in UTC RFC 3339 format, ends with Z, and may contain fractional seconds. No download URL is issued after this time. If the delivery is not suspended, EXPIRED is returned. If the delivery is also suspended, UNAVAILABLE is returned preferentially. This is the content expiration time, not the expiration time of a single URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-12T06:20:00Z</para>
                /// </summary>
                [NameInMap("ContentExpiresAt")]
                [Validation(Required=false)]
                public string ContentExpiresAt { get; set; }

                /// <summary>
                /// <para>The temporary signed download URL. Use the URL before UrlExpiresAt. The validity period of the signed URL does not exceed 300 seconds and is no later than ContentExpiresAt. If the URL expires but the content has not expired, you can query again to obtain a new URL. The example only shows the URL format and is not a real downloadable link. Use the complete URL in the actual response. Do not concatenate the URL yourself or share it publicly.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://reports.example.com/report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a.pdf">https://reports.example.com/report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a.pdf</a></para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>The unique ID of the report. You can use this ID as the reportId parameter to query the report again. This is the report asset ID, not an internal task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>report-3f2b8c1e-6d4a-4b7e-9a1c-2e5f7d8b9c0a</para>
                /// </summary>
                [NameInMap("ReportId")]
                [Validation(Required=false)]
                public string ReportId { get; set; }

                /// <summary>
                /// <para>The expiration time of the current DownloadUrl. The time is in UTC RFC 3339 format, ends with Z, and may contain fractional seconds. You cannot use the URL after it expires, and this time is no later than ContentExpiresAt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-12T06:25:00Z</para>
                /// </summary>
                [NameInMap("UrlExpiresAt")]
                [Validation(Required=false)]
                public string UrlExpiresAt { get; set; }

            }

            /// <summary>
            /// <para>The report status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_APPLICABLE: The product does not include a report.</description></item>
            /// <item><description>WAITING_DATA: The data call result is not determined.</description></item>
            /// <item><description>NO_DATA: No data is found, and no per-use report is generated.</description></item>
            /// <item><description>WAITING_PERIOD: The query result for the callId of a periodic product. You must obtain the ReportId by calling ListProductReports and then query the report.</description></item>
            /// <item><description>QUEUED: The report task is queued.</description></item>
            /// <item><description>RUNNING: The report task is being processed.</description></item>
            /// <item><description>AVAILABLE: The report is available, and the Report object is returned in this response.</description></item>
            /// <item><description>FAILED: The data call or report generation failed.</description></item>
            /// <item><description>EXPIRED: The report content has expired.</description></item>
            /// <item><description>UNAVAILABLE: The delivery of the report is suspended.</description></item>
            /// </list>
            /// <para>You can query again later by using the same ID when the status is WAITING_DATA, QUEUED, or RUNNING. Repeated queries do not regenerate the report when the status is FAILED. The Report object is not returned unless the status is AVAILABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("ReportStatus")]
            [Validation(Required=false)]
            public string ReportStatus { get; set; }

        }

        /// <summary>
        /// <para>The unique identity of the request, which is used for Tracing Analysis and troubleshooting. Provide this ID when you troubleshoot exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9634F2B3-B59C-5475-BA9F-96D95271882C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
