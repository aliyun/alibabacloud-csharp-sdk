// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadAgentSessionFileResponseBody : TeaModel {
        [NameInMap("JsonRpcResponse")]
        [Validation(Required=false)]
        public UploadAgentSessionFileResponseBodyJsonRpcResponse JsonRpcResponse { get; set; }
        public class UploadAgentSessionFileResponseBodyJsonRpcResponse : TeaModel {
            [NameInMap("Error")]
            [Validation(Required=false)]
            public UploadAgentSessionFileResponseBodyJsonRpcResponseError Error { get; set; }
            public class UploadAgentSessionFileResponseBodyJsonRpcResponseError : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0x4883300000000019</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>会话不存在或当前账号无权访问，请返回会话列表重新选择</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>attachment-rpc-001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("Jsonrpc")]
            [Validation(Required=false)]
            public string Jsonrpc { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public UploadAgentSessionFileResponseBodyJsonRpcResponseResult Result { get; set; }
            public class UploadAgentSessionFileResponseBodyJsonRpcResponseResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sample.csv</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>upload/session_bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb.csv</para>
                /// </summary>
                [NameInMap("RelativePath")]
                [Validation(Required=false)]
                public string RelativePath { get; set; }

                [NameInMap("Signature")]
                [Validation(Required=false)]
                public UploadAgentSessionFileResponseBodyJsonRpcResponseResultSignature Signature { get; set; }
                public class UploadAgentSessionFileResponseBodyJsonRpcResponseResultSignature : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-11-12T09:46:33.477365753Z</para>
                    /// </summary>
                    [NameInMap("ExpiresAt")]
                    [Validation(Required=false)]
                    public string ExpiresAt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;Content-Type&quot;:&quot;application/octet-stream&quot;,&quot;Content-MD5&quot;:&quot;sZRqySSS0jR8YjW00mERhA==&quot;,&quot;Content-Length&quot;:&quot;6&quot;,&quot;x-oss-object-acl&quot;:&quot;private&quot;,&quot;x-oss-forbid-overwrite&quot;:&quot;true&quot;}</para>
                    /// </summary>
                    [NameInMap("Headers")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> Headers { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://attachments.example.test/signed">https://attachments.example.test/signed</a></para>
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb</para>
                /// </summary>
                [NameInMap("UploadId")]
                [Validation(Required=false)]
                public string UploadId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1789549200000</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A0B6E0-E005-1465-B5DE-5CD17677426F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
