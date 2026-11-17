// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadAgentSessionFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC response. Returns Result on success and Error on protocol errors.</para>
        /// </summary>
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public UploadAgentSessionFileResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class UploadAgentSessionFileResponseBodyJsonRpcResponse : TeaModel {
            /// <summary>
            /// <para>The JSON-RPC fault message. This field is not returned on success.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public UploadAgentSessionFileResponseBodyJsonRpcResponseError Error { get; set; }
            public class UploadAgentSessionFileResponseBodyJsonRpcResponseError : TeaModel {
                /// <summary>
                /// <para>The JSON-RPC error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The optional additional error information. The content depends on the error type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>The business error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_ATTACHMENT_OBJECT_MISMATCH</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_ATTACHMENT_OBJECT_MISMATCH</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The JSON-RPC correlation identifier for the current request, which is passed by the caller and returned as is.</para>
            /// 
            /// <b>Example:</b>
            /// <para>attachment-rpc-001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-RPC protocol version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            /// <summary>
            /// <para>Issues the staged upload URL or returns the attachment information after writing to the instance.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public UploadAgentSessionFileResponseBodyJsonRpcResponseResult Result { get; set; }
            public class UploadAgentSessionFileResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <para>The attachment identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The original file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sample.csv</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The relative path in the session working directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>upload/session_bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb.csv</para>
                /// </summary>
                [NameInMap("RelativePath")]
                [Validation(Required=false)]
                public string RelativePath { get; set; }

                /// <summary>
                /// <para>The time-limited object storage signature returned by prepare.</para>
                /// </summary>
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public UploadAgentSessionFileResponseBodyJsonRpcResponseResultSignature Signature { get; set; }
                public class UploadAgentSessionFileResponseBodyJsonRpcResponseResultSignature : TeaModel {
                    /// <summary>
                    /// <para>The expiration time of the current upload signature in ISO 8601 UTC string format. The trailing Z indicates UTC, and fractional seconds may be included. The signature is valid for 5 minutes. Signature expiration does not indicate that the staged object has been deleted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-12T09:46:33.477365753Z</para>
                    /// </summary>
                    [NameInMap("ExpiresAt")]
                    [Validation(Required=false)]
                    public string ExpiresAt { get; set; }

                    /// <summary>
                    /// <para>All signed request headers that must be included in the PUT request. The names and values must be used exactly as provided. This includes Content-Type, Content-MD5, Content-Length, x-oss-object-acl, and x-oss-forbid-overwrite.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;Content-Type&quot;:&quot;application/octet-stream&quot;,&quot;Content-MD5&quot;:&quot;sZRqySSS0jR8YjW00mERhA==&quot;,&quot;Content-Length&quot;:&quot;6&quot;,&quot;x-oss-object-acl&quot;:&quot;private&quot;,&quot;x-oss-forbid-overwrite&quot;:&quot;true&quot;}</para>
                    /// </summary>
                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Headers { get; set; }

                    /// <summary>
                    /// <para>The complete signed HTTPS PUT URL returned by prepare, which must be used exactly as provided for the upload. The example displayed for this field does not contain a valid signature. The actual request must use the complete signed URL returned by the current prepare call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://attachments.example.test/signed">https://attachments.example.test/signed</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <para>The number of file bytes saved in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The staged upload identifier issued by prepare.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
                /// </summary>
                [NameInMap("UploadId")]
                [Validation(Required=false)]
                public string UploadId { get; set; }

            }

            /// <summary>
            /// <para>The response time as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1789549200000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The server correlation ID for the current request. You can provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0B6E0-E005-1465-B5DE-5CD17677426F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
