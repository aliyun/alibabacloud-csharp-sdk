// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class McpConfig : TeaModel {
        /// <summary>
        /// <para>工具的绑定配置，定义工具与 HTTP 路径和方法的映射关系</para>
        /// </summary>
        [NameInMap("boundConfiguration")]
        [Validation(Required=false)]
        public BoundConfiguration BoundConfiguration { get; set; }

        /// <summary>
        /// <para>MCP 代理的详细配置，包括钩子函数等，用于在 MCP 请求处理过程中执行自定义逻辑</para>
        /// </summary>
        [NameInMap("mcpProxyConfiguration")]
        [Validation(Required=false)]
        public McpProxyConfiguration McpProxyConfiguration { get; set; }

        /// <summary>
        /// <para>是否启用 MCP 代理功能，启用后可以通过代理配置对 MCP 请求进行拦截和处理</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("proxyEnabled")]
        [Validation(Required=false)]
        public bool? ProxyEnabled { get; set; }

        /// <summary>
        /// <para>会话亲和性策略，用于控制请求的路由方式。NONE：无亲和性，MCP_SSE：基于 SSE 的会话亲和性，MCP_STREAMABLE：基于流式 HTTP 的会话亲和性</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP_STREAMABLE</para>
        /// </summary>
        [NameInMap("sessionAffinity")]
        [Validation(Required=false)]
        public string SessionAffinity { get; set; }

        /// <summary>
        /// <para>会话亲和性的详细配置信息，JSON 格式字符串，包含会话保持的具体参数</para>
        /// </summary>
        [NameInMap("sessionAffinityConfig")]
        [Validation(Required=false)]
        public string SessionAffinityConfig { get; set; }

    }

}
