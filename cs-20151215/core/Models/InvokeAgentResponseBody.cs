// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InvokeAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code for the RUN_ERROR event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The tool output text for the TOOL_CALL_RESULT event. The text may be truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>done</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The incremental fragment of text, reasoning, or tool parameters. Fragments with the same ID are concatenated in order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello</para>
        /// </summary>
        [NameInMap("delta")]
        [Validation(Required=false)]
        public string Delta { get; set; }

        /// <summary>
        /// <para>The error description for the RUN_ERROR event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request failed</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the message to which the text, reasoning, or tool result belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-1</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The name of the CUSTOM extension event, such as analysis_result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis_result</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The completion reason for the RUN_FINISHED event. A value of success indicates normal completion, and interrupt indicates waiting for a response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;success&quot;}</para>
        /// </summary>
        [NameInMap("outcome")]
        [Validation(Required=false)]
        public InvokeAgentResponseBodyOutcome Outcome { get; set; }
        public class InvokeAgentResponseBodyOutcome : TeaModel {
            /// <summary>
            /// <para>The list of interrupts waiting for a response. This field appears only when outcome.type is interrupt and contains at least one item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;i-1&quot;,&quot;reason&quot;:&quot;tool_call_approve&quot;,&quot;toolCallId&quot;:&quot;call-1&quot;}]</para>
            /// </summary>
            [NameInMap("interrupts")]
            [Validation(Required=false)]
            public List<InvokeAgentResponseBodyOutcomeInterrupts> Interrupts { get; set; }
            public class InvokeAgentResponseBodyOutcomeInterrupts : TeaModel {
                /// <summary>
                /// <para>The optional expiration time string of the interrupt. This field is not output for current tool approvals.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-04T00:00:00Z</para>
                /// </summary>
                [NameInMap("expiresAt")]
                [Validation(Required=false)]
                public string ExpiresAt { get; set; }

                /// <summary>
                /// <para>The ID of the interrupt. It is used as resume[].interruptId when resuming the run.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The approval description or follow-up question text displayed to the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Proceed with execution?</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The optional extension information of the interrupt. It cannot replace tool events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The reason for the interrupt. The value is tool_call_approve for tool approval and ask_human for follow-up questions.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tool_call_approve</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The JSON Schema for the response. Tool approval requires decision=yes/no, and follow-up questions use strings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;decision&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;enum&quot;:[&quot;yes&quot;,&quot;no&quot;]}},&quot;required&quot;:[&quot;decision&quot;]}</para>
                /// </summary>
                [NameInMap("responseSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResponseSchema { get; set; }

                /// <summary>
                /// <para>The optional associated tool invoke ID. It is the same as the toolCallId of the preceding TOOL_CALL_START event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call-1</para>
                /// </summary>
                [NameInMap("toolCallId")]
                [Validation(Required=false)]
                public string ToolCallId { get; set; }

            }

            /// <summary>
            /// <para>The outcome type. A value of success indicates normal completion. A value of interrupt indicates waiting for a response, in which case the interrupts array contains at least one item.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>interrupt</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The optional parent message ID for the TOOL_CALL_START event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-1</para>
        /// </summary>
        [NameInMap("parentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <para>The role of the message. The role is assistant for text messages and tool for tool results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The run ID of the current run for RUN_STARTED and RUN_FINISHED events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-1</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The thread snapshot for the STATE_SNAPSHOT event, including sessionId and requestId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;abcdef0123456789abcdef0123456789&quot;,&quot;requestId&quot;:&quot;req-1&quot;}</para>
        /// </summary>
        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public object Snapshot { get; set; }

        /// <summary>
        /// <para>The thread ID for RUN_STARTED and RUN_FINISHED events. It is consistent with the request and the thread snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef0123456789abcdef0123456789</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The tool invoke ID. It associates TOOL_CALL_START/ARGS/END/RESULT events with approval interrupts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>call-1</para>
        /// </summary>
        [NameInMap("toolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <para>The name of the tool for the TOOL_CALL_START event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example_tool</para>
        /// </summary>
        [NameInMap("toolCallName")]
        [Validation(Required=false)]
        public string ToolCallName { get; set; }

        /// <summary>
        /// <para>The event type of the SSE data object. For the required fields of each event type, see the response description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUN_STARTED</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The extension value of the CUSTOM event. It can be any JSON object or null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;reference&quot;:null,&quot;actions&quot;:[],&quot;messageId&quot;:null}</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
