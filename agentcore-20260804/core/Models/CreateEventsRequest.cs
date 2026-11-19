// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateEventsRequest : TeaModel {
        /// <summary>
        /// <para>The JSON request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateEventsRequestBody Body { get; set; }
        public class CreateEventsRequestBody : TeaModel {
            /// <summary>
            /// <para>A list of 1 to 100 events. The request body cannot exceed 1 MiB.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("events")]
            [Validation(Required=false)]
            public List<CreateEventsRequestBodyEvents> Events { get; set; }
            public class CreateEventsRequestBodyEvents : TeaModel {
                /// <summary>
                /// <para>The event-specific data. Use the corresponding fields based on the type. For conditional requirements, refer to the description of each field.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("data")]
                [Validation(Required=false)]
                public CreateEventsRequestBodyEventsData Data { get; set; }
                public class CreateEventsRequestBodyEventsData : TeaModel {
                    /// <summary>
                    /// <para>The call ID. This field is required for tool_call and tool_result events, or message events with the role set to tool. It associates the call intent, actual execution, and feedback.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>call-001</para>
                    /// </summary>
                    [NameInMap("callId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    /// <summary>
                    /// <para>The ordered content blocks. This field is required for message and tool_result events. Use a text block for plain text. This can be an empty array if the tool has no output.</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public List<CreateEventsRequestBodyEventsDataContent> Content { get; set; }
                    public class CreateEventsRequestBodyEventsDataContent : TeaModel {
                        /// <summary>
                        /// <para>The JSON parameter values. This field is required for tool_call blocks. Unparsed raw strings can be retained.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;city&quot;:&quot;Hangzhou&quot;}</para>
                        /// </summary>
                        [NameInMap("arguments")]
                        [Validation(Required=false)]
                        public object Arguments { get; set; }

                        /// <summary>
                        /// <para>The logical call ID. This field is required for tool_call blocks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>call-001</para>
                        /// </summary>
                        [NameInMap("callId")]
                        [Validation(Required=false)]
                        public string CallId { get; set; }

                        /// <summary>
                        /// <para>The access format identifier. This field is required for opaque blocks. Saving the format does not mean that its content can be interpreted or used across platforms.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>application/json</para>
                        /// </summary>
                        [NameInMap("format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The tool name. This field is required for tool_call blocks. This content block only expresses the call intent.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>get_weather</para>
                        /// </summary>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The actual text. This field is required for text and reasoning blocks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The user likes hiking</para>
                        /// </summary>
                        [NameInMap("text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// <para>The content block type. This field determines the required fields.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The JSON value. This field is required for json and opaque blocks. The data field is not used for opaque blocks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;preference&quot;:&quot;hiking&quot;}</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public object Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of visible event IDs referenced by the summary. This list cannot be empty.</para>
                    /// </summary>
                    [NameInMap("eventIds")]
                    [Validation(Required=false)]
                    public List<string> EventIds { get; set; }

                    /// <summary>
                    /// <para>The anchor event ID of the parent session. This field is required for session_fork events. The child session continues from the valid context at this anchor and does not inherit interactions after the anchor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>evt-2f5f9c5a8d0e4c3b</para>
                    /// </summary>
                    [NameInMap("parentEventId")]
                    [Validation(Required=false)]
                    public string ParentEventId { get; set; }

                    /// <summary>
                    /// <para>The business scope of the parent session. This field is required for session_fork events. The event is written to the child session, and the requested scope is the child session.</para>
                    /// </summary>
                    [NameInMap("parentScope")]
                    [Validation(Required=false)]
                    public CreateEventsRequestBodyEventsDataParentScope ParentScope { get; set; }
                    public class CreateEventsRequestBodyEventsDataParentScope : TeaModel {
                        /// <summary>
                        /// <para>The business agent ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>agent-001</para>
                        /// </summary>
                        [NameInMap("agentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <para>The exact session ID.</para>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>session-001</para>
                        /// </summary>
                        [NameInMap("sessionId")]
                        [Validation(Required=false)]
                        public string SessionId { get; set; }

                        /// <summary>
                        /// <para>The business team ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>team-001</para>
                        /// </summary>
                        [NameInMap("teamId")]
                        [Validation(Required=false)]
                        public string TeamId { get; set; }

                        /// <summary>
                        /// <para>The business user ID. This is not the platform tenant identity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>user-001</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>The message role. This field is required for message events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user</para>
                    /// </summary>
                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The human-readable summary. This field is optional for context_update events.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The user plans to go hiking on the weekend</para>
                    /// </summary>
                    [NameInMap("summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                }

                /// <summary>
                /// <para>The actual occurrence time provided by the client as a Unix timestamp in milliseconds. This is the only source for business sorting. Identical values do not indicate a known sequence, and the array position does not imply a business order.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1758614400000</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The event type. This determines the applicable fields and conditional requirements for the data.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>message</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The exact session to which all events belong.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public CreateEventsRequestBodyScope Scope { get; set; }
            public class CreateEventsRequestBodyScope : TeaModel {
                /// <summary>
                /// <para>The business agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-001</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The exact session ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>session-001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The business team ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team-001</para>
                /// </summary>
                [NameInMap("teamId")]
                [Validation(Required=false)]
                public string TeamId { get; set; }

                /// <summary>
                /// <para>The business user ID. This is not the platform tenant identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user-001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The information saved when the first event is successfully written. It is not overwritten by subsequent writes.</para>
            /// </summary>
            [NameInMap("session")]
            [Validation(Required=false)]
            public CreateEventsRequestBodySession Session { get; set; }
            public class CreateEventsRequestBodySession : TeaModel {
                /// <summary>
                /// <para>The JSON metadata of the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;topic&quot;:&quot;hiking&quot;}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                /// <summary>
                /// <para>The session title. It can be up to 256 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Travel plan</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
