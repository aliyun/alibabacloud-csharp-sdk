// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class CreateAtiAgentRegisterInfoRequest : TeaModel {
        /// <summary>
        /// <para>The description of the agent capabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>支付服务</para>
        /// </summary>
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        /// <summary>
        /// <para>The display name of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试Agent</para>
        /// </summary>
        [NameInMap("AgentDisplayName")]
        [Validation(Required=false)]
        public string AgentDisplayName { get; set; }

        /// <summary>
        /// <para>The endpoint domain name through which the agent provides services.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The version of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>Provides idempotency. Within 3 minutes, the same value takes effect only once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The endpoint information of the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;EndpointValue\&quot;:\&quot;<a href="http://www.baidu.com%5C%5C%22,%5C%5C%22EndpointType%5C%5C%22:%5C%5C%22http%5C%5C%22%7D%5D">http://www.baidu.com\\&quot;,\\&quot;EndpointType\\&quot;:\\&quot;http\\&quot;}]</a></para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateAtiAgentRegisterInfoRequestEndpoints> Endpoints { get; set; }
        public class CreateAtiAgentRegisterInfoRequestEndpoints : TeaModel {
            /// <summary>
            /// <para>The actual service address of the agent endpoint, which is the HTTPS entry point where the agent runs online. This is a required field with a maximum of 500 characters.</para>
            /// <para>Example: <a href="https://my-agent.example.com/mcp">https://my-agent.example.com/mcp</a></para>
            /// <para>After a caller discovers this agent through DNS, it can use this URL to initiate a connection directly. This is the address where the agent is actually online.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.example.com/mcp">https://www.example.com/mcp</a></para>
            /// </summary>
            [NameInMap("AgentUrl")]
            [Validation(Required=false)]
            public string AgentUrl { get; set; }

            /// <summary>
            /// <para>An optional URL that points to the metadata description file of the agent (typically in JSON format). This allows other agents or clients to automatically discover the agent capabilities before connecting, including:</para>
            /// <list type="bullet">
            /// <item><description>Functions supported by the agent</description></item>
            /// <item><description>Input/output formats</description></item>
            /// <item><description>Version information</description></item>
            /// <item><description>Other capability declarations</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>// <a href="https://my-agent.example.com/.well-known/agent.json">https://my-agent.example.com/.well-known/agent.json</a>
            /// {
            ///   &quot;name&quot;: &quot;智能客服助手&quot;,
            ///   &quot;version&quot;: &quot;1.2.0&quot;,
            ///   &quot;protocol&quot;: &quot;MCP&quot;,
            ///   &quot;description&quot;: &quot;提供产品咨询、订单查询、售后服务的智能客服Agent&quot;,
            ///   &quot;capabilities&quot;: {
            ///     &quot;tools&quot;: [
            ///       { &quot;name&quot;: &quot;order_query&quot;, &quot;description&quot;: &quot;查询订单状态&quot; },
            ///       { &quot;name&quot;: &quot;product_search&quot;, &quot;description&quot;: &quot;搜索产品信息&quot; },
            ///       { &quot;name&quot;: &quot;refund_request&quot;, &quot;description&quot;: &quot;发起退款申请&quot; }
            ///     ],
            ///     &quot;resources&quot;: [
            ///       { &quot;uri&quot;: &quot;faq://knowledge-base&quot;, &quot;description&quot;: &quot;FAQ知识库&quot; }
            ///     ]
            ///   },
            ///   &quot;endpoint&quot;: {
            ///     &quot;url&quot;: &quot;<a href="https://my-agent.example.com/mcp">https://my-agent.example.com/mcp</a>&quot;,
            ///     &quot;transport&quot;: [&quot;STREAMABLE-HTTP&quot;, &quot;SSE&quot;]
            ///   },
            ///   &quot;policy&quot;: {
            ///     &quot;authentication&quot;: &quot;mTLS&quot;,
            ///     &quot;rateLimit&quot;: &quot;100/min&quot;
            ///   }
            /// }</para>
            /// </summary>
            [NameInMap("MetadataUrl")]
            [Validation(Required=false)]
            public string MetadataUrl { get; set; }

            /// <summary>
            /// <para>The communication protocol standard that the agent endpoint follows. This determines how the invoker interacts with the agent.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MCP: Model Context Protocol, an agent tool invocation protocol developed by Anthropic.</description></item>
            /// <item><description>A2A: Agent-to-Agent Protocol, a cross-agent communication protocol developed by Google.</description></item>
            /// <item><description>OpenAPI: Standard RESTful API specification (Swagger/OpenAPI).</description></item>
            /// </list>
            /// <para>When other agents or clients see this protocol identity, they know which method to use to communicate with the agent. For example, MCP uses the MCP SDK, A2A uses the A2A SDK, and OpenAPI uses standard HTTP requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A2A</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The transport methods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STREAMABLE-HTTP</para>
            /// </summary>
            [NameInMap("Transports")]
            [Validation(Required=false)]
            public List<string> Transports { get; set; }

        }

        /// <summary>
        /// <para>The ID of the verified registrant. Obtain this ID by invoking the identity verification API operation or from the ATS console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

    }

}
