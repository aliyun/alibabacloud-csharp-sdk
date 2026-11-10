// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InvokeAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>done</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>你好</para>
        /// </summary>
        [NameInMap("delta")]
        [Validation(Required=false)]
        public string Delta { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请求失败</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>m-1</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>analysis_result</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;success&quot;}</para>
        /// </summary>
        [NameInMap("outcome")]
        [Validation(Required=false)]
        public InvokeAgentResponseBodyOutcome Outcome { get; set; }
        public class InvokeAgentResponseBodyOutcome : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;id&quot;:&quot;i-1&quot;,&quot;reason&quot;:&quot;tool_call_approve&quot;,&quot;toolCallId&quot;:&quot;call-1&quot;}]</para>
            /// </summary>
            [NameInMap("interrupts")]
            [Validation(Required=false)]
            public List<InvokeAgentResponseBodyOutcomeInterrupts> Interrupts { get; set; }
            public class InvokeAgentResponseBodyOutcomeInterrupts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-11-04T00:00:00Z</para>
                /// </summary>
                [NameInMap("expiresAt")]
                [Validation(Required=false)]
                public string ExpiresAt { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>是否执行？</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tool_call_approve</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;decision&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;enum&quot;:[&quot;yes&quot;,&quot;no&quot;]}},&quot;required&quot;:[&quot;decision&quot;]}</para>
                /// </summary>
                [NameInMap("responseSchema")]
                [Validation(Required=false)]
                public Dictionary<string, object> ResponseSchema { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>call-1</para>
                /// </summary>
                [NameInMap("toolCallId")]
                [Validation(Required=false)]
                public string ToolCallId { get; set; }

            }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>m-1</para>
        /// </summary>
        [NameInMap("parentMessageId")]
        [Validation(Required=false)]
        public string ParentMessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assistant</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>r-1</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;abcdef0123456789abcdef0123456789&quot;,&quot;requestId&quot;:&quot;req-1&quot;}</para>
        /// </summary>
        [NameInMap("snapshot")]
        [Validation(Required=false)]
        public object Snapshot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdef0123456789abcdef0123456789</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>call-1</para>
        /// </summary>
        [NameInMap("toolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example_tool</para>
        /// </summary>
        [NameInMap("toolCallName")]
        [Validation(Required=false)]
        public string ToolCallName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUN_STARTED</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;reference&quot;:null,&quot;actions&quot;:[],&quot;messageId&quot;:null}</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public object Value { get; set; }

    }

}
