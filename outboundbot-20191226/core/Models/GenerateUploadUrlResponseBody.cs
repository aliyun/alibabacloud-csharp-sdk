// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GenerateUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateUploadUrlResponseBodyData Data { get; set; }
        public class GenerateUploadUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <para>OSS access ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>LBA******</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>Time-to-live (TTL) in seconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742960933</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }

            /// <summary>
            /// <para>Upload folder path</para>
            /// 
            /// <b>Example:</b>
            /// <para>pload/file/874d7371-791b-4281-935c-637630a37785/874d7371-791b-4281-935c-637630a37785_9bd7916d-a340-4925-a911-92390cbe0f33.json</para>
            /// </summary>
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public string Folder { get; set; }

            /// <summary>
            /// <para>Upload server URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cloudagentbot-online.oss-cn-hangzhou.aliyuncs.com">https://cloudagentbot-online.oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>API message for the upload</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Upload policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wMy0yNlQwMzo0ODo1My4wMzVaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNTI0Mjg4MF0sWyJzdGFydHMtd2l0aCIsIiRrZXkiLCJ1cGxvYWQvZmlsZS84NzRkNzM3MS03OTFiLTQyODEtOTM1Yy02Mzc2MzBhMzc3ODUvIl1dfQ==&quot;,</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Signature</para>
            /// 
            /// <b>Example:</b>
            /// <para>I6d1ONWVuTj5i0Kz4Vn+V0lC6v4=</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            /// <summary>
            /// <para>Indicates whether the upload succeeded</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
