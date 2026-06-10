// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetJobDataUploadParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>Response message</para>
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
        /// <para>Is successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>List of upload parameters</para>
        /// </summary>
        [NameInMap("UploadParams")]
        [Validation(Required=false)]
        public GetJobDataUploadParamsResponseBodyUploadParams UploadParams { get; set; }
        public class GetJobDataUploadParamsResponseBodyUploadParams : TeaModel {
            /// <summary>
            /// <para>OSS access ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>LTAI****************</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>Expiration time (seconds)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741855527</para>
            /// </summary>
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }

            /// <summary>
            /// <para>Upload folder</para>
            /// <remarks>
            /// <para>This parameter\&quot;s value is used in request parameters for many APIs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>UPLOADED/SCRIPT/136a055e-***-46c6-853a-731b3a2973de/18dc6d79-338f-413c-a5a8-dcce5f05b41a_9bd7916d-a340-4925-a911-92390cbe0f33.json</para>
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
            /// <para>Upload policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJleHBpcmF0aW9uIjoiMjAyNS0wMy0xM1QwODo0NToyNy4zMzFaIiwiY29uZGl0aW9ucyI6W1siY29udGVudC1sZW5ndGgtcmFuZ2UiLDAsNTI0Mjg4MDBdLFsic3RhcnRzLXdpdGgiLCIka2V5IiwiVVBMT0FERUQvU0NSSVBULzEzNmEwNTVlLTNkMDctNDZjNi04NTNhLTczMWIzYTI5NzNkZS8iXV19</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>Signature information</para>
            /// 
            /// <b>Example:</b>
            /// <para>MD4CHQCiECtjdsP+fstJDcqsPt+GbWxSWPzGQxeQiblzAh0AuidaKc5JY5AkHFIE+qiQI3izJQQbpUoG0paPTw==</para>
            /// </summary>
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

    }

}
