// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ProbeMcpOriginResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API operation. SUCCESS indicates that the operation completed normally. For the origin server result, see data.status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The read-only, one-time, and bounded probe result. It is not persisted and is not associated with subsequently created MCPs.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ProbeMcpOriginResponseBodyData Data { get; set; }
        public class ProbeMcpOriginResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The check coverage. It describes the target, protocol, or HTTP request conditions for this check and does not prove that the formal gateway and other APIs are available.</para>
            /// </summary>
            [NameInMap("coverage")]
            [Validation(Required=false)]
            public ProbeMcpOriginResponseBodyDataCoverage Coverage { get; set; }
            public class ProbeMcpOriginResponseBodyDataCoverage : TeaModel {
                /// <summary>
                /// <para>The evidence-verified legacy or modern protocol. This field is empty during HTTP interface checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>modern</para>
                /// </summary>
                [NameInMap("backendMcpProtocol")]
                [Validation(Required=false)]
                public string BackendMcpProtocol { get; set; }

                /// <summary>
                /// <para>Returns only non-sensitive names and excludes internal platform routing or network identities.</para>
                /// </summary>
                [NameInMap("headerNames")]
                [Validation(Required=false)]
                public List<string> HeaderNames { get; set; }

                /// <summary>
                /// <para>The selected HTTP method for this check. This field is empty for direct connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HEAD</para>
                /// </summary>
                [NameInMap("method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The redacted summary of the selected HTTP path for this check. This field is empty for direct connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mcp</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The evidence-verified MCP transport. This field is empty during HTTP interface checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamableHTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The summary of the origin server target for this check. It does not contain sensitive query parameters or credentials.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://mcp.example.com/mcp">https://mcp.example.com/mcp</a></para>
                /// </summary>
                [NameInMap("target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The origin server check before creation is fixed to false, which does not indicate that the resource is ready.</para>
                /// </summary>
                [NameInMap("viaGateway")]
                [Validation(Required=false)]
                public bool? ViaGateway { get; set; }

            }

            /// <summary>
            /// <para>Indicates origin server failures. This field is empty upon success. Origin server 401 errors or connection failures are not uniformly mapped to API exceptions.</para>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public ProbeMcpOriginResponseBodyDataError Error { get; set; }
            public class ProbeMcpOriginResponseBodyDataError : TeaModel {
                /// <summary>
                /// <para>Returns only bounded diagnostic codes. The original error body from the origin server is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROBE_TIMEOUT</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The trimmed and redacted diagnostic information. This excludes credentials or original responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The probe deadline was exceeded.</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Indicates whether the operation is suitable for retry under a restricted policy. This does not trigger automatic retries.</para>
                /// </summary>
                [NameInMap("retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

                /// <summary>
                /// <para>The error source, which can be MAGIC, ROUTER, NETWORK, ORIGIN, or UNKNOWN. This is determined solely based on actual evidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UNKNOWN</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The detection or publishing stage where the error occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INITIALIZE</para>
                /// </summary>
                [NameInMap("stage")]
                [Validation(Required=false)]
                public string Stage { get; set; }

            }

            /// <summary>
            /// <para>The HTTP check result. This is returned only for the HTTP type. The definition and actual request status are separated. This is null for direct connections. A 2xx status code only proves the success of this request and does not prove that business functions or other APIs are available.</para>
            /// </summary>
            [NameInMap("httpResult")]
            [Validation(Required=false)]
            public ProbeMcpOriginResponseBodyDataHttpResult HttpResult { get; set; }
            public class ProbeMcpOriginResponseBodyDataHttpResult : TeaModel {
                /// <summary>
                /// <para>The connection status of the target. Valid values: PASSED, FAILED, NOT_RUN, or UNKNOWN. This is judged only based on the actual target connection evidence for this check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("connectionStatus")]
                [Validation(Required=false)]
                public string ConnectionStatus { get; set; }

                /// <summary>
                /// <para>The check result of the API definition. Valid values: PASSED, FAILED, or NOT_RUN. The value is NOT_RUN when no OpenAPI specification is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PASSED</para>
                /// </summary>
                [NameInMap("definitionStatus")]
                [Validation(Required=false)]
                public string DefinitionStatus { get; set; }

                /// <summary>
                /// <para>The actual HTTP status code received. This is empty if the request was not executed or no response was received.</para>
                /// 
                /// <b>Example:</b>
                /// <para>405</para>
                /// </summary>
                [NameInMap("httpStatusCode")]
                [Validation(Required=false)]
                public int? HttpStatusCode { get; set; }

            }

            /// <summary>
            /// <para>The declared and actual test results for controlled endpoints of a single origin server. This is an empty array for the HTTP type.</para>
            /// </summary>
            [NameInMap("observations")]
            [Validation(Required=false)]
            public List<ProbeMcpOriginResponseBodyDataObservations> Observations { get; set; }
            public class ProbeMcpOriginResponseBodyDataObservations : TeaModel {
                /// <summary>
                /// <para>The backend MCP protocol policy. Valid values: legacy or modern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>modern</para>
                /// </summary>
                [NameInMap("backendMcpProtocol")]
                [Validation(Required=false)]
                public string BackendMcpProtocol { get; set; }

                /// <summary>
                /// <para>Indicates whether the origin server declares support for this combination. This is empty when there is no declaration evidence.</para>
                /// </summary>
                [NameInMap("declared")]
                [Validation(Required=false)]
                public bool? Declared { get; set; }

                /// <summary>
                /// <para>The list of declared versions. It retains only the date versions actually declared by the origin server and does not infer the full set from a single negotiation.</para>
                /// </summary>
                [NameInMap("declaredVersions")]
                [Validation(Required=false)]
                public List<string> DeclaredVersions { get; set; }

                /// <summary>
                /// <para>The desensitized origin server or controlled subsequent endpoint. Sensitive query parameters are not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://mcp.example.com/mcp">https://mcp.example.com/mcp</a></para>
                /// </summary>
                [NameInMap("endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The negotiated version. For legacy, it is the negotiated version. For modern, it is the selected and verified date version. This is empty when not confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-26</para>
                /// </summary>
                [NameInMap("negotiatedVersion")]
                [Validation(Required=false)]
                public string NegotiatedVersion { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values: SSE or StreamableHTTP. The modern policy is only combined with StreamableHTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamableHTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The session mode. Valid values: STATEFUL, STATELESS, NOT_APPLICABLE, or UNKNOWN. A direct legacy connection without a session is not automatically judged as failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STATELESS</para>
                /// </summary>
                [NameInMap("sessionMode")]
                [Validation(Required=false)]
                public string SessionMode { get; set; }

                /// <summary>
                /// <para>The protocol verification status. Valid values: VERIFIED, UNSUPPORTED, FAILED, or UNKNOWN. UNSUPPORTED requires protocol evidence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VERIFIED</para>
                /// </summary>
                [NameInMap("verificationStatus")]
                [Validation(Required=false)]
                public string VerificationStatus { get; set; }

            }

            /// <summary>
            /// <para>The ID used only to correlate desensitized logs. It is not used for queries, authorization, binding MCPs, or reusing check evidence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcpprobe-8f7a9d02-8e5b-4376-8d2b-6a9cb3a42b16</para>
            /// </summary>
            [NameInMap("probeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            /// <summary>
            /// <para>The observation time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-19T08:30:00Z</para>
            /// </summary>
            [NameInMap("probedAt")]
            [Validation(Required=false)]
            public string ProbedAt { get; set; }

            /// <summary>
            /// <para>The recommended protocol combination. It only includes verified combinations that the platform can access. This is empty when no combinations are available or for the HTTP type.</para>
            /// </summary>
            [NameInMap("recommendation")]
            [Validation(Required=false)]
            public ProbeMcpOriginResponseBodyDataRecommendation Recommendation { get; set; }
            public class ProbeMcpOriginResponseBodyDataRecommendation : TeaModel {
                /// <summary>
                /// <para>The backend MCP protocol policy. Valid values: legacy or modern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>modern</para>
                /// </summary>
                [NameInMap("backendMcpProtocol")]
                [Validation(Required=false)]
                public string BackendMcpProtocol { get; set; }

                /// <summary>
                /// <para>The actual negotiated or selected and verified origin server MCP date version in YYYY-MM-DD format. This is null when not confirmed. It only displays the origin server protocol date metadata. It can be specified during creation and modified during updates. If omitted during an update, the current value is retained. It does not control backend requests or the external protocol of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-26</para>
                /// </summary>
                [NameInMap("originProtocolVersion")]
                [Validation(Required=false)]
                public string OriginProtocolVersion { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values: SSE or StreamableHTTP. The modern policy is only combined with StreamableHTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamableHTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The combination actually used for tool queries. Specifying this does not mean verification passed. This is empty for the HTTP type.</para>
            /// </summary>
            [NameInMap("selectedConfiguration")]
            [Validation(Required=false)]
            public ProbeMcpOriginResponseBodyDataSelectedConfiguration SelectedConfiguration { get; set; }
            public class ProbeMcpOriginResponseBodyDataSelectedConfiguration : TeaModel {
                /// <summary>
                /// <para>The backend MCP protocol policy. Valid values: legacy or modern.</para>
                /// 
                /// <b>Example:</b>
                /// <para>modern</para>
                /// </summary>
                [NameInMap("backendMcpProtocol")]
                [Validation(Required=false)]
                public string BackendMcpProtocol { get; set; }

                /// <summary>
                /// <para>The actual negotiated or selected and verified origin server MCP date version in YYYY-MM-DD format. This is null when not confirmed. It only displays the origin server protocol date metadata. It can be specified during creation and modified during updates. If omitted during an update, the current value is retained. It does not control backend requests or the external protocol of the gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-03-26</para>
                /// </summary>
                [NameInMap("originProtocolVersion")]
                [Validation(Required=false)]
                public string OriginProtocolVersion { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values: SSE or StreamableHTTP. The modern policy is only combined with StreamableHTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamableHTTP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The stage of the check. Valid values: AUTHORIZE, VALIDATE, RATE_LIMIT, NETWORK, NETWORK_CONTEXT, CONNECT, DISCOVER, INITIALIZE, SESSION_CHECK, TOOLS_LIST, HTTP_DEFINITION, HTTP_REQUEST, CLEANUP, EXECUTION, or COMPLETE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>The check result of the origin server. Valid values: SUCCESS, PARTIAL, or FAILED. SUCCESS indicates that the protocol check passed but no capabilities were declared or no tools capability exists. A completely empty tool list also passes. PARTIAL indicates that the tool query failed or was truncated. For HTTP, PARTIAL indicates that only the definition was checked or required evidence is unknown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The restricted metadata list for this check. Tools are not executed. An empty array is returned if tools are not declared, the list is completely empty, or the type is HTTP. Refer to toolsStatus and toolsComplete for judgment.</para>
            /// </summary>
            [NameInMap("tools")]
            [Validation(Required=false)]
            public List<ProbeMcpOriginResponseBodyDataTools> Tools { get; set; }
            public class ProbeMcpOriginResponseBodyDataTools : TeaModel {
                /// <summary>
                /// <para>The input schema defined by the protocol, represented as a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{}}</para>
                /// </summary>
                [NameInMap("inputSchema")]
                [Validation(Required=false)]
                public string InputSchema { get; set; }

                /// <summary>
                /// <para>The output schema defined by the protocol, represented as a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;total&quot;:{&quot;type&quot;:&quot;integer&quot;}}}</para>
                /// </summary>
                [NameInMap("outputSchema")]
                [Validation(Required=false)]
                public string OutputSchema { get; set; }

                /// <summary>
                /// <para>The untrusted description text returned by the origin server. It is escaped when displayed and is not executed as an instruction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>List inventory items</para>
                /// </summary>
                [NameInMap("toolDescription")]
                [Validation(Required=false)]
                public string ToolDescription { get; set; }

                /// <summary>
                /// <para>The declared name of the tool. Only metadata is displayed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>list_inventory</para>
                /// </summary>
                [NameInMap("toolName")]
                [Validation(Required=false)]
                public string ToolName { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the tool list is complete. The value is true for COMPLETE or EMPTY, and false for TRUNCATED. The value is null if not queried, not declared, or failed. Completeness cannot be determined solely by an empty array.</para>
            /// </summary>
            [NameInMap("toolsComplete")]
            [Validation(Required=false)]
            public bool? ToolsComplete { get; set; }

            /// <summary>
            /// <para>The tool query status. Valid values: NOT_RUN, NOT_DECLARED, EMPTY, COMPLETE, TRUNCATED, or FAILED. If tools are not declared, the value is NOT_DECLARED and tools/list is not executed. For the HTTP type, the value is NOT_RUN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("toolsStatus")]
            [Validation(Required=false)]
            public string ToolsStatus { get; set; }

            /// <summary>
            /// <para>The coverage and completeness limitations of this check.</para>
            /// </summary>
            [NameInMap("warnings")]
            [Validation(Required=false)]
            public List<ProbeMcpOriginResponseBodyDataWarnings> Warnings { get; set; }
            public class ProbeMcpOriginResponseBodyDataWarnings : TeaModel {
                /// <summary>
                /// <para>The structured identifier for the detection limitation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TOOLS_TRUNCATED</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Explains limitations such as UNKNOWN, not executed, or truncated. This excludes credentials and original responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The tool preview limit was reached; protocol verification succeeded.</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code of the POP API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The processing result of the API operation, excluding the original response from the origin server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID used to correlate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8F7A9D02-8E5B-4376-8D2B-6A9CB3A42B16</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API operation was processed successfully. This means that authorization, parameter validation, and execution mechanisms completed normally, which does not equate to a successful origin server check.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
