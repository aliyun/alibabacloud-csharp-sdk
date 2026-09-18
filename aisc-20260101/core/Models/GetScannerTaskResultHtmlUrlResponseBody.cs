// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GetScannerTaskResultHtmlUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result, which contains the temporary download URL for the HTML result report.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScannerTaskResultHtmlUrlResponseBodyData Data { get; set; }
        public class GetScannerTaskResultHtmlUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary download URL for the HTML result report. The URL is valid for 2 hours. After the URL expires, call this operation again to obtain a new URL. If the report has not been generated, this value is an empty string. The actual value is a signed temporary URL from object storage that includes signature parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/result.task-abc123def4567.report.html">https://example.com/result.task-abc123def4567.report.html</a></para>
            /// </summary>
            [NameInMap("ScannerTaskResultHtmlDownloadUrl")]
            [Validation(Required=false)]
            public string ScannerTaskResultHtmlDownloadUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
