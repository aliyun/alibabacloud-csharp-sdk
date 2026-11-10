// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InvokeAgentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;description&quot;:&quot;cluster&quot;,&quot;value&quot;:&quot;c-1&quot;}]</para>
        /// </summary>
        [NameInMap("context")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestContext> Context { get; set; }
        public class InvokeAgentRequestContext : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>{&quot;enableThinking&quot;:true}</para>
        /// </summary>
        [NameInMap("forwardedProps")]
        [Validation(Required=false)]
        public InvokeAgentRequestForwardedProps ForwardedProps { get; set; }
        public class InvokeAgentRequestForwardedProps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableThinking")]
            [Validation(Required=false)]
            public bool? EnableThinking { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;m-1&quot;,&quot;role&quot;:&quot;user&quot;,&quot;content&quot;:&quot;你好&quot;}]</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestMessages> Messages { get; set; }
        public class InvokeAgentRequestMessages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("encryptedValue")]
            [Validation(Required=false)]
            public string EncryptedValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("subagentRunId")]
            [Validation(Required=false)]
            public string SubagentRunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
            /// </summary>
            [NameInMap("toolCallId")]
            [Validation(Required=false)]
            public string ToolCallId { get; set; }

            [NameInMap("toolCalls")]
            [Validation(Required=false)]
            public List<InvokeAgentRequestMessagesToolCalls> ToolCalls { get; set; }
            public class InvokeAgentRequestMessagesToolCalls : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("encryptedValue")]
                [Validation(Required=false)]
                public string EncryptedValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;: &quot;xxx&quot;, &quot;arguments&quot;: &quot;xxx&quot;}</para>
                /// </summary>
                [NameInMap("function")]
                [Validation(Required=false)]
                public InvokeAgentRequestMessagesToolCallsFunction Function { get; set; }
                public class InvokeAgentRequestMessagesToolCallsFunction : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("arguments")]
                    [Validation(Required=false)]
                    public string Arguments { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>navy</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64ea4d94937a4c5c84e2b3b814d14696</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, object> Metadata { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>function</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>r-0</para>
        /// </summary>
        [NameInMap("parentRunId")]
        [Validation(Required=false)]
        public string ParentRunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;interruptId&quot;:&quot;i-1&quot;,&quot;status&quot;:&quot;resolved&quot;,&quot;payload&quot;:{&quot;decision&quot;:&quot;yes&quot;}}]</para>
        /// </summary>
        [NameInMap("resume")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestResume> Resume { get; set; }
        public class InvokeAgentRequestResume : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>i-1</para>
            /// </summary>
            [NameInMap("interruptId")]
            [Validation(Required=false)]
            public string InterruptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;decision&quot;:&quot;yes&quot;}</para>
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public object Payload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>resolved</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>run-1</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public object State { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdef0123456789abcdef0123456789</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public List<InvokeAgentRequestTools> Tools { get; set; }
        public class InvokeAgentRequestTools : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>cluster-qa-icloud-edge-ohttp</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;region\&quot;: \&quot;cn-shanghai\&quot;, \&quot;vpcId\&quot;: \&quot;vpc-uf6bnhlxne8enjurxxjv4\&quot;, \&quot;functionName\&quot;: \&quot;filemgr-cn-shanghai-334a349cd2\&quot;, \&quot;mountPointsServerAddr\&quot;: \&quot;334a349cd2-umc45.cn-shanghai.nas.aliyuncs.com\&quot;}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public object Parameters { get; set; }

        }

    }

}
