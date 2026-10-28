// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAgent20260801.Models
{
    public class ListMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The message history and pagination information.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The pagination token for the next page. A value of null indicates that no more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-next-token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The ID of the session to which the messages belong.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session_example_001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The message records returned in a timeline.</para>
            /// </summary>
            [NameInMap("timeline")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataTimeline> Timeline { get; set; }
            public class ListMessagesResponseBodyDataTimeline : TeaModel {
                /// <summary>
                /// <para>The message object. Different message types are distinguished by role, and each type uses the corresponding fields.</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public ListMessagesResponseBodyDataTimelineMessage Message { get; set; }
                public class ListMessagesResponseBodyDataTimelineMessage : TeaModel {
                    /// <summary>
                    /// <para>The type identifier of the activity message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example_activity</para>
                    /// </summary>
                    [NameInMap("activityType")]
                    [Validation(Required=false)]
                    public string ActivityType { get; set; }

                    /// <summary>
                    /// <para>The message content. The structure is determined by the message type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Query the status of the sample resource</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public object Content { get; set; }

                    /// <summary>
                    /// <para>The encrypted content. The example is an invalid placeholder value and does not contain real ciphertext.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>EXAMPLE_ENCRYPTED_VALUE</para>
                    /// </summary>
                    [NameInMap("encryptedValue")]
                    [Validation(Required=false)]
                    public string EncryptedValue { get; set; }

                    /// <summary>
                    /// <para>The error description when tool execution fails.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample tool execution failure</para>
                    /// </summary>
                    [NameInMap("error")]
                    [Validation(Required=false)]
                    public string Error { get; set; }

                    /// <summary>
                    /// <para>The message ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>message_example_001</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The result information of historical interrupts.</para>
                    /// </summary>
                    [NameInMap("interruptOutcome")]
                    [Validation(Required=false)]
                    public ListMessagesResponseBodyDataTimelineMessageInterruptOutcome InterruptOutcome { get; set; }
                    public class ListMessagesResponseBodyDataTimelineMessageInterruptOutcome : TeaModel {
                        /// <summary>
                        /// <para>The list of historical interrupts.</para>
                        /// </summary>
                        [NameInMap("interrupts")]
                        [Validation(Required=false)]
                        public List<ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterrupts> Interrupts { get; set; }
                        public class ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterrupts : TeaModel {
                            /// <summary>
                            /// <para>The supplementary business data for the interrupt.</para>
                            /// </summary>
                            [NameInMap("data")]
                            [Validation(Required=false)]
                            public ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterruptsData Data { get; set; }
                            public class ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterruptsData : TeaModel {
                                /// <summary>
                                /// <para>The list of API operations that require approval.</para>
                                /// </summary>
                                [NameInMap("apiCalls")]
                                [Validation(Required=false)]
                                public List<ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterruptsDataApiCalls> ApiCalls { get; set; }
                                public class ListMessagesResponseBodyDataTimelineMessageInterruptOutcomeInterruptsDataApiCalls : TeaModel {
                                    /// <summary>
                                    /// <para>The name of the API action.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>ExampleAction</para>
                                    /// </summary>
                                    [NameInMap("action")]
                                    [Validation(Required=false)]
                                    public string Action { get; set; }

                                    /// <summary>
                                    /// <para>The description of the operation pending approval.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>Execute changes on the sample resource</para>
                                    /// </summary>
                                    [NameInMap("description")]
                                    [Validation(Required=false)]
                                    public string Description { get; set; }

                                }

                                /// <summary>
                                /// <para>The associated approval ID.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>approval_example_001</para>
                                /// </summary>
                                [NameInMap("approvalId")]
                                [Validation(Required=false)]
                                public string ApprovalId { get; set; }

                                /// <summary>
                                /// <para>The URL of the approval page. The example URL cannot be used for actual approval.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="https://example.com/approvals/approval_example_001">https://example.com/approvals/approval_example_001</a></para>
                                /// </summary>
                                [NameInMap("approvalUrl")]
                                [Validation(Required=false)]
                                public string ApprovalUrl { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the approval can be canceled.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("cancellable")]
                                [Validation(Required=false)]
                                public bool? Cancellable { get; set; }

                                /// <summary>
                                /// <para>The digest identifier of the change pending approval.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>example-change-digest</para>
                                /// </summary>
                                [NameInMap("changeDigest")]
                                [Validation(Required=false)]
                                public string ChangeDigest { get; set; }

                                /// <summary>
                                /// <para>The title of the approval item.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Sample change approval</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The expiration time of the interrupt, in RFC 3339 format.</para>
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
                            /// <para>The interrupt prompt displayed to the user.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Specify the target region</para>
                            /// </summary>
                            [NameInMap("message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            /// <summary>
                            /// <para>The extended metadata of the interrupt.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{}</para>
                            /// </summary>
                            [NameInMap("metadata")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> Metadata { get; set; }

                            /// <summary>
                            /// <para>The reason for the interrupt. Valid values: <c>tool_call</c> (tool invocation requires processing), <c>input_required</c> (user input is required), <c>confirmation</c> (confirmation is required), and <c>out_of_band_approval</c> (waiting for out-of-band approval).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>input_required</para>
                            /// </summary>
                            [NameInMap("reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                            /// <summary>
                            /// <para>The JSON schema that the resume result payload must follow.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;region&quot;:{&quot;type&quot;:&quot;string&quot;}},&quot;required&quot;:[&quot;region&quot;]}</para>
                            /// </summary>
                            [NameInMap("responseSchema")]
                            [Validation(Required=false)]
                            public Dictionary<string, object> ResponseSchema { get; set; }

                            /// <summary>
                            /// <para>The ID of the tool invocation associated with the interrupt.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>tool_call_example_001</para>
                            /// </summary>
                            [NameInMap("toolCallId")]
                            [Validation(Required=false)]
                            public string ToolCallId { get; set; }

                        }

                        /// <summary>
                        /// <para>The type of the interrupt result. The value is fixed to <c>interrupt</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>interrupt</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The extended metadata of the message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("metadata")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Metadata { get; set; }

                    /// <summary>
                    /// <para>The name of the message sender.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example-user</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The resume input corresponding to the historical interrupt.</para>
                    /// </summary>
                    [NameInMap("resumeInput")]
                    [Validation(Required=false)]
                    public ListMessagesResponseBodyDataTimelineMessageResumeInput ResumeInput { get; set; }
                    public class ListMessagesResponseBodyDataTimelineMessageResumeInput : TeaModel {
                        /// <summary>
                        /// <para>The time when the interrupt processing was completed, in RFC 3339 format.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2026-01-01T00:01:00Z</para>
                        /// </summary>
                        [NameInMap("resolvedAt")]
                        [Validation(Required=false)]
                        public string ResolvedAt { get; set; }

                        /// <summary>
                        /// <para>The submitted processing results for each interrupt.</para>
                        /// </summary>
                        [NameInMap("resume")]
                        [Validation(Required=false)]
                        public List<ListMessagesResponseBodyDataTimelineMessageResumeInputResume> Resume { get; set; }
                        public class ListMessagesResponseBodyDataTimelineMessageResumeInputResume : TeaModel {
                            /// <summary>
                            /// <para>The ID of the processed interrupt.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>interrupt_example_001</para>
                            /// </summary>
                            [NameInMap("interruptId")]
                            [Validation(Required=false)]
                            public string InterruptId { get; set; }

                            /// <summary>
                            /// <para>The processing result for the corresponding interrupt, which must comply with the responseSchema of the interrupt.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;region&quot;:&quot;cn-hangzhou&quot;}</para>
                            /// </summary>
                            [NameInMap("payload")]
                            [Validation(Required=false)]
                            public object Payload { get; set; }

                            /// <summary>
                            /// <para>The response method for the current interrupt. Valid values: <c>resolved</c> (the answer, confirmation, or tool result required by the interrupt has been submitted, including the <c>payload</c>) and <c>cancelled</c> (the interrupt has been canceled, excluding the <c>payload</c>).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>resolved</para>
                            /// </summary>
                            [NameInMap("status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                        /// <summary>
                        /// <para>The ID of the original run that was resumed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>run_example_001</para>
                        /// </summary>
                        [NameInMap("runId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The source of the resume request. Valid values: <c>USER</c> (submitted by a user) and <c>INTERNAL</c> (submitted by an internal process).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>USER</para>
                        /// </summary>
                        [NameInMap("source")]
                        [Validation(Required=false)]
                        public string Source { get; set; }

                    }

                    /// <summary>
                    /// <para>The role of the message. Valid values: <c>user</c> (user message), <c>assistant</c> (assistant message), <c>tool</c> (tool result), <c>activity</c> (activity message), <c>reasoning</c> (reasoning message), and <c>interrupt</c> (interrupt record).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The ID of the tool invocation associated with the tool result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tool_call_example_001</para>
                    /// </summary>
                    [NameInMap("toolCallId")]
                    [Validation(Required=false)]
                    public string ToolCallId { get; set; }

                    /// <summary>
                    /// <para>The list of tool invocations initiated by the agent.</para>
                    /// </summary>
                    [NameInMap("toolCalls")]
                    [Validation(Required=false)]
                    public List<ListMessagesResponseBodyDataTimelineMessageToolCalls> ToolCalls { get; set; }
                    public class ListMessagesResponseBodyDataTimelineMessageToolCalls : TeaModel {
                        /// <summary>
                        /// <para>The encrypted content of the tool invocation. The example is only a placeholder value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EXAMPLE_ENCRYPTED_VALUE</para>
                        /// </summary>
                        [NameInMap("encryptedValue")]
                        [Validation(Required=false)]
                        public string EncryptedValue { get; set; }

                        /// <summary>
                        /// <para>The information about the function to be executed.</para>
                        /// </summary>
                        [NameInMap("function")]
                        [Validation(Required=false)]
                        public ListMessagesResponseBodyDataTimelineMessageToolCallsFunction Function { get; set; }
                        public class ListMessagesResponseBodyDataTimelineMessageToolCallsFunction : TeaModel {
                            /// <summary>
                            /// <para>The tool parameters in the form of a JSON string.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>{&quot;keyword&quot;:&quot;example&quot;}</para>
                            /// </summary>
                            [NameInMap("arguments")]
                            [Validation(Required=false)]
                            public string Arguments { get; set; }

                            /// <summary>
                            /// <para>The name of the function or tool.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>lookup_example</para>
                            /// </summary>
                            [NameInMap("name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The tool invocation ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tool_call_example_001</para>
                        /// </summary>
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The extended metadata of the tool invocation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("metadata")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Metadata { get; set; }

                        /// <summary>
                        /// <para>The type of the tool invocation. The value is fixed to <c>function</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>function</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the run to which the message belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>run_example_001</para>
                /// </summary>
                [NameInMap("runId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

            }

            /// <summary>
            /// <para>The number of timeline records on the current page, which is equal to the length of the timeline array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
