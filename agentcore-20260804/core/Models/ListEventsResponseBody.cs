// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The results on the current page.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListEventsResponseBodyItems> Items { get; set; }
        public class ListEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The event-specific data. Use the corresponding fields based on the type. For conditional requirements, refer to the description of each field.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public ListEventsResponseBodyItemsData Data { get; set; }
            public class ListEventsResponseBodyItemsData : TeaModel {
                /// <summary>
                /// <para>The call ID, which is required for tool_call, tool_result, or messages with role=tool. It associates the call intent, actual execution, and feedback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>call-001</para>
                /// </summary>
                [NameInMap("callId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>The ordered content blocks, which are required for message and tool_result events. Use a text block for plain text. This can be an empty array if the tool has no output.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public List<ListEventsResponseBodyItemsDataContent> Content { get; set; }
                public class ListEventsResponseBodyItemsDataContent : TeaModel {
                    /// <summary>
                    /// <para>The JSON parameter values, which are required for tool_call blocks. Unparsed raw strings can be retained.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;city&quot;:&quot;Hangzhou&quot;}</para>
                    /// </summary>
                    [NameInMap("arguments")]
                    [Validation(Required=false)]
                    public object Arguments { get; set; }

                    /// <summary>
                    /// <para>The logical call ID, which is required for tool_call blocks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>call-001</para>
                    /// </summary>
                    [NameInMap("callId")]
                    [Validation(Required=false)]
                    public string CallId { get; set; }

                    /// <summary>
                    /// <para>The access format identifier, which is required for opaque blocks. Saving the format does not mean its content can be interpreted or used across platforms.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    /// <summary>
                    /// <para>The tool name, which is required for tool_call blocks. This content block only expresses the call intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The actual text, which is required for text and reasoning blocks.</para>
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
                    /// <para>The JSON value, which is required for json and opaque blocks. The data field is not used for opaque blocks.</para>
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
                /// <para>The parent session anchor, which is required for session_fork events. The child session continues from the valid context at this anchor and does not inherit interactions after the anchor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>evt-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("parentEventId")]
                [Validation(Required=false)]
                public string ParentEventId { get; set; }

                /// <summary>
                /// <para>The business positioning of the parent session, which is required for session_fork events. The event is written to the child session, and the requested scope is the child session.</para>
                /// </summary>
                [NameInMap("parentScope")]
                [Validation(Required=false)]
                public ListEventsResponseBodyItemsDataParentScope ParentScope { get; set; }
                public class ListEventsResponseBodyItemsDataParentScope : TeaModel {
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
                /// <para>The message role, which is required for message events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The readable summary, which is optional for context_update events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The user plans to go hiking on the weekend</para>
                /// </summary>
                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

            }

            /// <summary>
            /// <para>The stable event ID generated by the server. It is used for referencing, locating, and deleting events. It does not represent the business sequence, and no separate messageId is provided.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evt-2f5f9c5a8d0e4c3b</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The time when the event reaches the server, in Unix milliseconds. It is used for asynchronous processing and not for historical business sorting.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758614401000</para>
            /// </summary>
            [NameInMap("receivedAt")]
            [Validation(Required=false)]
            public long? ReceivedAt { get; set; }

            /// <summary>
            /// <para>The session to which the event belongs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public ListEventsResponseBodyItemsScope Scope { get; set; }
            public class ListEventsResponseBodyItemsScope : TeaModel {
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
            /// <para>The actual occurrence time provided by the client, in Unix milliseconds. This is the only source for business sorting. Identical values do not indicate a known sequence, and the array position does not imply a business sequence.</para>
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
        /// <para>The maximum number of entries per page used in the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The request processing message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The next page token. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjIwMH0=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. For batch operations, you must still check the result of each item.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records. This field is empty if the exact total count is not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
