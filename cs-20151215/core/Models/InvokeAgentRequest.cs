// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InvokeAgentRequest : TeaModel {
        /// <summary>
        /// <para>The AG-UI native context array. Each item contains description and value strings. Undeclared extension keys are still passed through. Currently, the downstream service only logs a warning and ignores them. The ACK resource context is carried by forwardedProps.ackContext. If omitted, it is processed as an empty array. Null values are not accepted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;description&quot;:&quot;cluster&quot;,&quot;value&quot;:&quot;c-1&quot;}]</para>
        /// </summary>
        [NameInMap("context")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestContext> Context { get; set; }
        public class InvokeAgentRequestContext : TeaModel {
            /// <summary>
            /// <para>The description of the orchestration template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The environment variable value.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The AG-UI ACK extension parameters, including language, enableThinking, and source. Unknown extensions are preserved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enableThinking&quot;:true}</para>
        /// </summary>
        [NameInMap("forwardedProps")]
        [Validation(Required=false)]
        public InvokeAgentRequestForwardedProps ForwardedProps { get; set; }
        public class InvokeAgentRequestForwardedProps : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable thinking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <para>The query language. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh: Chinese.</description></item>
            /// <item><description>en: English.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <para>The AG-UI message list. In the current phase, user input only declares plain text content. Historical assistant and tool messages, as well as toolCalls, are preserved. Only the text of the last user message is consumed. If omitted, it is processed as an empty array. Null values are not accepted. Undeclared extension fields are passed through.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;m-1&quot;,&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;Hello&quot;}]</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestMessages> Messages { get; set; }
        public class InvokeAgentRequestMessages : TeaModel {
            /// <summary>
            /// <para>The plain text content. This parameter can be omitted when the assistant only calls tools. Currently, only the text of the last user message is consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The encrypted content of the tool invocation. The example is only a placeholder value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("encryptedValue")]
            [Validation(Required=false)]
            public string EncryptedValue { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The message role. Valid values: user, developer, system, assistant, and tool. The user role requires text content. The assistant role can contain only toolCalls. The tool role requires content and toolCallId. Multimodal input is not declared in the current phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The sub-agent invocation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("subagentRunId")]
            [Validation(Required=false)]
            public string SubagentRunId { get; set; }

            /// <summary>
            /// <para>Required when role is set to tool. References the tool_call ID from the previous Mobile-Use Agent response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

            /// <summary>
            /// <para>A structured tool invocation in the historical messages of the assistant. The id, type, and function returned by the server are preserved.</para>
            /// </summary>
            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<InvokeAgentRequestMessagesToolCalls> ToolCalls { get; set; }
            public class InvokeAgentRequestMessagesToolCalls : TeaModel {
                /// <summary>
                /// <para>The encrypted content. The example is an invalid placeholder value and does not contain real ciphertext.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("encryptedValue")]
                [Validation(Required=false)]
                public string EncryptedValue { get; set; }

                /// <summary>
                /// <para>The function information of the historical tool invocation, including the name and arguments in JSON string format. The actual return values should be preserved in subsequent turns.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;: &quot;xxx&quot;, &quot;arguments&quot;: &quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public InvokeAgentRequestMessagesToolCallsFunction Function { get; set; }
                public class InvokeAgentRequestMessagesToolCallsFunction : TeaModel {
                    /// <summary>
                    /// <para>The JSON string of the tool invocation parameters, not an expanded object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    /// <summary>
                    /// <para>The function name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>navy</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The trigger ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <para>The tool invocation type. Fixed to function.</para>
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
        /// <para>The parent run ID. This parameter is optional and is currently not used by the downstream service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-0</para>
        /// </summary>
        [NameInMap("parentRunId")]
        [Validation(Required=false)]
        public string ParentRunId { get; set; }

        /// <summary>
        /// <para>The AG-UI interrupt resume response list. Independent of the private protocol approval parameters. A single request must answer the current complete approval batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;interruptId&quot;:&quot;i-1&quot;,&quot;status&quot;:&quot;resolved&quot;,&quot;payload&quot;:{&quot;decision&quot;:&quot;yes&quot;}}]</para>
        /// </summary>
        [NameInMap("resume")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestResume> Resume { get; set; }
        public class InvokeAgentRequestResume : TeaModel {
            /// <summary>
            /// <para>Corresponds to outcome.interrupts[].id, not toolCallId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-1</para>
            /// </summary>
            [NameInMap("interruptId")]
            [Validation(Required=false)]
            public string InterruptId { get; set; }

            /// <summary>
            /// <para>The arbitrary JSON response payload. Tool approval uses an object with decision=yes/no, and ask_human uses a string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;decision&quot;:&quot;yes&quot;}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public object Payload { get; set; }

            /// <summary>
            /// <para>The response status. Valid values: resolved and cancelled. Both approval and rejection use resolved, distinguished by payload.decision.</para>
            /// 
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The AG-UI current run ID. Must be explicitly provided as a string. Empty strings are allowed and will be generated by the downstream service. Missing or null values are rejected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run-1</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The AG-UI native state. Accepts any JSON value, including null. This parameter is currently not used by the downstream service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public object State { get; set; }

        /// <summary>
        /// <para>The AG-UI session ID. Must be explicitly provided as a string. If not empty, only 32 lowercase hexadecimal characters [0-9a-f]{32} are accepted. A standard run can be created or resumed by using this ID. If an empty string is provided, the server generates a session ID. A resume operation must use an existing session ID. Missing or null values are rejected. This API only accepts native requests and does not require the stream parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef0123456789abcdef0123456789</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>The AG-UI native tool definitions. The name and description are strings, and parameters is an opaque JSON Schema. Accepted and passed through. Currently, the downstream service only logs a warning and ignores them. Frontend tool injection is not supported. If omitted, it is processed as an empty array. Null values are not accepted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestTools> Tools { get; set; }
        public class InvokeAgentRequestTools : TeaModel {
            /// <summary>
            /// <para>The description of the check item.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The environment variable name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster-qa-icloud-edge-ohttp</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The optional JSON Schema for tool parameters. Cannot be null. The internal structure is defined by the tool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;region\&quot;: \&quot;cn-shanghai\&quot;, \&quot;vpcId\&quot;: \&quot;vpc-uf6bnhlxne8enjurxxjv4\&quot;, \&quot;functionName\&quot;: \&quot;filemgr-cn-shanghai-334a349cd2\&quot;, \&quot;mountPointsServerAddr\&quot;: \&quot;334a349cd2-umc45.cn-shanghai.nas.aliyuncs.com\&quot;}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public object Parameters { get; set; }

        }

    }

}
