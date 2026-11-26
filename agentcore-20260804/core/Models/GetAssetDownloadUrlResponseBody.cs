// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAssetDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The stable result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time-limited presigned GET URL and file information for the published original file. A status conflict is returned if no published result is available.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAssetDownloadUrlResponseBodyData Data { get; set; }
        public class GetAssetDownloadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the target asset to download.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The MIME type of the published original file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>application/pdf</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The short-term presigned GET URL authorized only for downloading the published original object, using a unified OSS public endpoint. Long-term credentials are not returned, and the URL is not recorded in common logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/tenants/1234567890123456/workspaces/ws-001/kb/kb-001/assets/asset-001/original/upload-001/source?signature=REDACTED">https://example.com/tenants/1234567890123456/workspaces/ws-001/kb/kb-001/assets/asset-001/original/upload-001/source?signature=REDACTED</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The expiration time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:15:00Z</para>
            /// </summary>
            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public string ExpiresAt { get; set; }

            /// <summary>
            /// <para>The file name of the published original file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guide.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>The actual HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the data masking result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
