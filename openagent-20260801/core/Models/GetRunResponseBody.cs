// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class GetRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRunResponseBodyData Data { get; set; }
        public class GetRunResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The run creation time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The run outcome.</para>
            /// </summary>
            [NameInMap("outcome")]
            [Validation(Required=false)]
            public GetRunResponseBodyDataOutcome Outcome { get; set; }
            public class GetRunResponseBodyDataOutcome : TeaModel {
                /// <summary>
                /// <para>The interrupt list.</para>
                /// </summary>
                [NameInMap("interrupts")]
                [Validation(Required=false)]
                public List<GetRunResponseBodyDataOutcomeInterrupts> Interrupts { get; set; }
                public class GetRunResponseBodyDataOutcomeInterrupts : TeaModel {
                    /// <summary>
                    /// <para>The interrupt data.</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public GetRunResponseBodyDataOutcomeInterruptsData Data { get; set; }
                    public class GetRunResponseBodyDataOutcomeInterruptsData : TeaModel {
                        /// <summary>
                        /// <para>The list of APIs pending approval.</para>
                        /// </summary>
                        [NameInMap("apiCalls")]
                        [Validation(Required=false)]
                        public List<GetRunResponseBodyDataOutcomeInterruptsDataApiCalls> ApiCalls { get; set; }
                        public class GetRunResponseBodyDataOutcomeInterruptsDataApiCalls : TeaModel {
                            /// <summary>
                            /// <para>The API name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ExampleAction</para>
                            /// </summary>
                            [NameInMap("action")]
                            [Validation(Required=false)]
                            public string Action { get; set; }

                            /// <summary>
                            /// <para>The operation description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Perform changes on the sample resource</para>
                            /// </summary>
                            [NameInMap("description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }

                        }

                        /// <summary>
                        /// <para>The approval ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>approval_example_001</para>
                        /// </summary>
                        [NameInMap("approvalId")]
                        [Validation(Required=false)]
                        public string ApprovalId { get; set; }

                        /// <summary>
                        /// <para>The approval URL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://example.com/approvals/approval_example_001">https://example.com/approvals/approval_example_001</a></para>
                        /// </summary>
                        [NameInMap("approvalUrl")]
                        [Validation(Required=false)]
                        public string ApprovalUrl { get; set; }

                        /// <summary>
                        /// <para>Indicates whether it can be canceled.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("cancellable")]
                        [Validation(Required=false)]
                        public bool? Cancellable { get; set; }

                        /// <summary>
                        /// <para>The change summary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-change-digest</para>
                        /// </summary>
                        [NameInMap("changeDigest")]
                        [Validation(Required=false)]
                        public string ChangeDigest { get; set; }

                        /// <summary>
                        /// <para>The approval title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Sample change approval</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <para>The interrupt expiration time in ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-01-02T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("expiresAt")]
                    [Validation(Required=false)]
                    public string ExpiresAt { get; set; }

                    /// <summary>
                    /// <para>The interrupt ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>interrupt_example_001</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The interrupt message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Specify the region of the target resource</para>
                    /// </summary>
                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <para>The extended information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("metadata")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Metadata { get; set; }

                    /// <summary>
                    /// <para>The interrupt reason. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>tool_call</c>: tool invocation requires handling</description></item>
                    /// <item><description><c>input_required</c>: user input is required</description></item>
                    /// <item><description><c>confirmation</c>: confirmation is required</description></item>
                    /// <item><description><c>out_of_band_approval</c>: waiting for out-of-band approval</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input_required</para>
                    /// </summary>
                    [NameInMap("reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    /// <summary>
                    /// <para>The JSON schema that the payload must comply with when resuming this interrupt.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;region&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;region&quot;]}</para>
                    /// </summary>
                    [NameInMap("responseSchema")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ResponseSchema { get; set; }

                    /// <summary>
                    /// <para>The tool invocation ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tool_call_example_001</para>
                    /// </summary>
                    [NameInMap("toolCallId")]
                    [Validation(Required=false)]
                    public string ToolCallId { get; set; }

                }

                /// <summary>
                /// <para>The result type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>success</c>: successfully completed</description></item>
                /// <item><description><c>interrupt</c>: waiting for interrupt handling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>interrupt</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run_example_001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session_example_001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The run status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>PENDING</c>: pending execution</description></item>
            /// <item><description><c>RUNNING</c>: running</description></item>
            /// <item><description><c>WAITING_USER</c>: waiting for interrupt handling</description></item>
            /// <item><description><c>COMPLETED</c>: completed</description></item>
            /// <item><description><c>FAILED</c>: failed</description></item>
            /// <item><description><c>CANCELLED</c>: canceled</description></item>
            /// <item><description><c>REJECTED</c>: rejected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time of the run in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:01:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
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
