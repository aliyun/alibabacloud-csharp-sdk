// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetVirtualMcpToolValidationResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The validation result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetVirtualMcpToolValidationResponseBodyData Data { get; set; }
        public class GetVirtualMcpToolValidationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The validation submission time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-25T10:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>Returned only when the status is FAILED. Workspace.NotFound indicates that the workspace no longer exists during execution. ValidationFailed indicates a task execution exception. Source MCP read failures are returned through items.sources.reasonCode, and the corresponding task status is PARTIAL_FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValidationFailed</para>
            /// </summary>
            [NameInMap("failureCode")]
            [Validation(Required=false)]
            public string FailureCode { get; set; }

            /// <summary>
            /// <para>The security reason description returned only when the status is FAILED. It does not contain internal exceptions, credentials, or upstream raw responses. When you query a failed task, the API operation itself still succeeds. You need to read data.status and this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to validate virtual MCP tools.</para>
            /// </summary>
            [NameInMap("failureMessage")]
            [Validation(Required=false)]
            public string FailureMessage { get; set; }

            /// <summary>
            /// <para>The validation completion time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-25T10:00:05Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The itemized validation report. It does not modify tool selection.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetVirtualMcpToolValidationResponseBodyDataItems> Items { get; set; }
            public class GetVirtualMcpToolValidationResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The revision number of this check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("checkedRevision")]
                [Validation(Required=false)]
                public long? CheckedRevision { get; set; }

                /// <summary>
                /// <para>The results returned by source.</para>
                /// </summary>
                [NameInMap("sources")]
                [Validation(Required=false)]
                public List<GetVirtualMcpToolValidationResponseBodyDataItemsSources> Sources { get; set; }
                public class GetVirtualMcpToolValidationResponseBodyDataItemsSources : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the virtual MCPs that reference this source. This field is for display purposes only.</para>
                    /// </summary>
                    [NameInMap("affectedVirtualMcps")]
                    [Validation(Required=false)]
                    public List<string> AffectedVirtualMcps { get; set; }

                    /// <summary>
                    /// <para>The source check time in UTC ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-11-25T10:00:03Z</para>
                    /// </summary>
                    [NameInMap("checkedAt")]
                    [Validation(Required=false)]
                    public string CheckedAt { get; set; }

                    /// <summary>
                    /// <para>The source MCP ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mcp-server-source-1</para>
                    /// </summary>
                    [NameInMap("mcpServerId")]
                    [Validation(Required=false)]
                    public string McpServerId { get; set; }

                    /// <summary>
                    /// <para>The reason code for an unreadable source. A read failure is not treated as tool deletion.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SourceUnavailable</para>
                    /// </summary>
                    [NameInMap("reasonCode")]
                    [Validation(Required=false)]
                    public string ReasonCode { get; set; }

                    /// <summary>
                    /// <para>The source read status. Valid values: AVAILABLE and UNKNOWN.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AVAILABLE</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The validation results of the selected tools.</para>
                    /// </summary>
                    [NameInMap("tools")]
                    [Validation(Required=false)]
                    public List<GetVirtualMcpToolValidationResponseBodyDataItemsSourcesTools> Tools { get; set; }
                    public class GetVirtualMcpToolValidationResponseBodyDataItemsSourcesTools : TeaModel {
                        /// <summary>
                        /// <para>The current definition. This field is not returned if the read operation fails or the tool does not exist.</para>
                        /// </summary>
                        [NameInMap("currentDefinition")]
                        [Validation(Required=false)]
                        public GetVirtualMcpToolValidationResponseBodyDataItemsSourcesToolsCurrentDefinition CurrentDefinition { get; set; }
                        public class GetVirtualMcpToolValidationResponseBodyDataItemsSourcesToolsCurrentDefinition : TeaModel {
                            /// <summary>
                            /// <para>The JSON Schema for input parameters.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{}}</para>
                            /// </summary>
                            [NameInMap("inputSchema")]
                            [Validation(Required=false)]
                            public string InputSchema { get; set; }

                            /// <summary>
                            /// <para>The JSON Schema for output results.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;time&quot;:{&quot;type&quot;:&quot;string&quot;}}}</para>
                            /// </summary>
                            [NameInMap("outputSchema")]
                            [Validation(Required=false)]
                            public string OutputSchema { get; set; }

                            /// <summary>
                            /// <para>The tool description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Get the current time</para>
                            /// </summary>
                            [NameInMap("toolDescription")]
                            [Validation(Required=false)]
                            public string ToolDescription { get; set; }

                            /// <summary>
                            /// <para>The tool name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>get-current-time</para>
                            /// </summary>
                            [NameInMap("toolName")]
                            [Validation(Required=false)]
                            public string ToolName { get; set; }

                        }

                        /// <summary>
                        /// <para>The digest of the current definition.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                        /// </summary>
                        [NameInMap("currentDigest")]
                        [Validation(Required=false)]
                        public string CurrentDigest { get; set; }

                        /// <summary>
                        /// <para>The name of the source tool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>get-current-time</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The digest saved upon selection.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855</para>
                        /// </summary>
                        [NameInMap("savedDigest")]
                        [Validation(Required=false)]
                        public string SavedDigest { get; set; }

                        /// <summary>
                        /// <para>The tool status. Valid values: UNCHANGED, CHANGED, REMOVED, and UNKNOWN.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>UNCHANGED</para>
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the checked virtual MCP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mcp-server-virtual-1</para>
                /// </summary>
                [NameInMap("virtualMcpServerId")]
                [Validation(Required=false)]
                public string VirtualMcpServerId { get; set; }

            }

            /// <summary>
            /// <para>The validation status. Valid values: PENDING, RUNNING, COMPLETED, PARTIAL_FAILED, and FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The validation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>val-1234567890</para>
            /// </summary>
            [NameInMap("validationId")]
            [Validation(Required=false)]
            public string ValidationId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
