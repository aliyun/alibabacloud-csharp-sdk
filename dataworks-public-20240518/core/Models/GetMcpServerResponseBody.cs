// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetMcpServerResponseBody : TeaModel {
        [NameInMap("McpServer")]
        [Validation(Required=false)]
        public GetMcpServerResponseBodyMcpServer McpServer { get; set; }
        public class GetMcpServerResponseBodyMcpServer : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetMcpServerResponseBodyMcpServerConfig Config { get; set; }
            public class GetMcpServerResponseBodyMcpServerConfig : TeaModel {
                [NameInMap("CustomHeaders")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomHeaders { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SSE</para>
                /// </summary>
                [NameInMap("Transport")]
                [Validation(Required=false)]
                public string Transport { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/mcp/sse">https://example.com/mcp/sse</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-mcp-server</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
