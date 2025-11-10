// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class CreateApiMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("urls")]
        [Validation(Required=false)]
        public CreateApiMcpServerResponseBodyUrls Urls { get; set; }
        public class CreateApiMcpServerResponseBodyUrls : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("mcp")]
            [Validation(Required=false)]
            public string Mcp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("sse")]
            [Validation(Required=false)]
            public string Sse { get; set; }

        }

    }

}
