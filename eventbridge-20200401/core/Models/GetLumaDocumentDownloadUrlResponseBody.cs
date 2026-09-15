// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class GetLumaDocumentDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of Success indicates that the call succeeds. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The pre-signed download URL information for the original document.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLumaDocumentDownloadUrlResponseBodyData Data { get; set; }
        public class GetLumaDocumentDownloadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pre-signed download URL for the original document. The URL is valid for a limited period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://my-bucket.oss-cn-hangzhou.aliyuncs.com/kb/doc-bp1xxxxxxxxxxxx?Expires=1788000000&Signature=xxxx">https://my-bucket.oss-cn-hangzhou.aliyuncs.com/kb/doc-bp1xxxxxxxxxxxx?Expires=1788000000&amp;Signature=xxxx</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The expiration time of the download URL in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-24T12:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireAt")]
            [Validation(Required=false)]
            public string ExpireAt { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the operation. The value is Operation success if the call succeeds, or a specific error description if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Operation success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. Use this ID for troubleshooting or when submitting a ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34AD682D-5B91-5773-8132-AA38C130****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates that the call succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
