// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchAtiAgentRegisterInfoMarketRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a unique parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The keyword for searching. Matches against agent name, domain name, and description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries per batch query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number. Minimum value: <b>1</b>. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the paged query. Settings: maximum value: 100. Default value: 20. This parameter controls paging behavior.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The communication protocol that the agent endpoint follows, which determines how callers interact with the agent.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MCP: Model Context Protocol, an agent tool calling protocol developed by Anthropic.</description></item>
        /// <item><description>A2A: Agent-to-Agent Protocol, a cross-agent communication protocol developed by Google.</description></item>
        /// <item><description>OpenAPI: Standard RESTful API specification (Swagger/OpenAPI).</description></item>
        /// </list>
        /// <para>Other agents or clients use this protocol identifier to determine how to communicate with the agent. For example, MCP uses the MCP SDK, A2A uses the A2A SDK, and OpenAPI uses standard HTTP requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcp</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>Queries agents based on the agent status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>活跃</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Queries agents based on the trust level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>基础认证</para>
        /// </summary>
        [NameInMap("TrustLevel")]
        [Validation(Required=false)]
        public string TrustLevel { get; set; }

    }

}
