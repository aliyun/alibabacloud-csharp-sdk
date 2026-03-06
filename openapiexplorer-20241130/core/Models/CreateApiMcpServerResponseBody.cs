// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class CreateApiMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the successfully created API MCP service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v6ZZ7ftCzEILW***</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BFC4AC1-6BE4-5405-BDEC-CA288D404812</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connection information for the API MCP service.</para>
        /// </summary>
        [NameInMap("urls")]
        [Validation(Required=false)]
        public CreateApiMcpServerResponseBodyUrls Urls { get; set; }
        public class CreateApiMcpServerResponseBodyUrls : TeaModel {
            /// <summary>
            /// <para>The connection information for the streamable HTTP protocol. This is the recommended protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("mcp")]
            [Validation(Required=false)]
            public string Mcp { get; set; }

            /// <summary>
            /// <para>The connection information for the Server-Sent Events (SSE) protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://mcpserverinner-pre.cn-zhangjiakou.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("sse")]
            [Validation(Required=false)]
            public string Sse { get; set; }

            /// <summary>
            /// <para>The endpoint of the streamable HTTP protocol in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp">https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/mcp</a></para>
            /// </summary>
            [NameInMap("vpcMcp")]
            [Validation(Required=false)]
            public string VpcMcp { get; set; }

            /// <summary>
            /// <para>The endpoint of the SSE protocol in a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse">https://openapi-mcp-cn.vpc-proxy.aliyuncs.com/accounts/xxxx/custom/xxx/id/xxxx/sse</a></para>
            /// </summary>
            [NameInMap("vpcSse")]
            [Validation(Required=false)]
            public string VpcSse { get; set; }

        }

    }

}
