// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ChatAiAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether this text segment is complete (the last segment of the message it belongs to).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("completed")]
        [Validation(Required=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// <para>The localized display name of the tool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The error message when the tool call fails (only when success is false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIMEOUT</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The error type when the tool call fails (only when success is false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TIMEOUT</para>
        /// </summary>
        [NameInMap("errorType")]
        [Validation(Required=false)]
        public string ErrorType { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The tool input key-value pairs. The structure varies depending on the toolName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;namespace&quot;: &quot;vvp-dev-team&quot;, &quot;jobId&quot;: &quot;aa91ec66-...&quot;, &quot;deploymentId&quot;: &quot;b78aae4c-...&quot; }</para>
        /// </summary>
        [NameInMap("input")]
        [Validation(Required=false)]
        public object Input { get; set; }

        /// <summary>
        /// <para>The list of items pending approval.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ChatAiAgentResponseBodyItems> Items { get; set; }
        public class ChatAiAgentResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The original tool parameter key-value pairs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("args")]
            [Validation(Required=false)]
            public object Args { get; set; }

            /// <summary>
            /// <para>The display name of the tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The approval item ID, used when returning hitlDecisions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("hitlId")]
            [Validation(Required=false)]
            public string HitlId { get; set; }

            /// <summary>
            /// <para>The name of the intercepted tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("toolName")]
            [Validation(Required=false)]
            public string ToolName { get; set; }

        }

        /// <summary>
        /// <para>The error message (for error events).</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The session ID for this conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>462E2707-590E-51B6-9940-0AB33044828B-deliverData-202603020950-WCSN4MEC8T</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Indicates whether the tool calling invoke is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The text output from the assistant.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The tool calling ID, used to pair the invoke call and result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;c1&quot;</para>
        /// </summary>
        [NameInMap("toolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <para>The tool function name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;get_job_events&quot;</para>
        /// </summary>
        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

        /// <summary>
        /// <para>The token usage.</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public ChatAiAgentResponseBodyUsage Usage { get; set; }
        public class ChatAiAgentResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The number of output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The total number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

        }

    }

}
