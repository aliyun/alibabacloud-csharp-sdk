// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class GetScannerTaskHitDataUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The query result, which contains the task identifier and the temporary download URL for the hit data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScannerTaskHitDataUrlResponseBodyData Data { get; set; }
        public class GetScannerTaskHitDataUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary download URL for the attack hit data (hits.csv). The URL is valid for 2 hours. After the URL expires, call this operation again to obtain a new URL. If the task is an existing task or the agent execution mode does not produce hit data, this parameter is an empty string. The actual value is a signed temporary URL of Object Storage Service (OSS) that contains signature parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/result.task-abc123def4567.hits.csv">https://example.com/result.task-abc123def4567.hits.csv</a></para>
            /// </summary>
            [NameInMap("ScannerTaskHitDataDownloadUrl")]
            [Validation(Required=false)]
            public string ScannerTaskHitDataDownloadUrl { get; set; }

            /// <summary>
            /// <para>The scan task identifier echoed from the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-abc123def4567</para>
            /// </summary>
            [NameInMap("ScannerTaskId")]
            [Validation(Required=false)]
            public string ScannerTaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID for troubleshooting and log tracing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EBD0C05-6C1F-4C95-9C63-B7AB7B5A9C8E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
