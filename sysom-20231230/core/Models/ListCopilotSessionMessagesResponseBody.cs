// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListCopilotSessionMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code. Success indicates that the request is successful. Other values indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListCopilotSessionMessagesResponseBodyData Data { get; set; }
        public class ListCopilotSessionMessagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cursor of the last event on the current page, returned as a decimal string. The value is 0 for an empty page. This is not the pagination nextToken and does not indicate that a round of execution has finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("cursor")]
            [Validation(Required=false)]
            public string Cursor { get; set; }

            /// <summary>
            /// <para>Indicates whether there are subsequent historical events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The page size used for the current request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>The history event records on the current page, sorted in ascending order by eventId. A record does not necessarily represent a complete chat message and may be a chunk of text or a tool calling (invoke) event.</para>
            /// </summary>
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<ListCopilotSessionMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListCopilotSessionMessagesResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>The human-readable content summary of the event. To restore the complete interactive interface, use the original event in metadata.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public List<ListCopilotSessionMessagesResponseBodyDataMessagesContent> Content { get; set; }
                public class ListCopilotSessionMessagesResponseBodyDataMessagesContent : TeaModel {
                    /// <summary>
                    /// <para>The readable text content in the event. This field is empty if no readable string is available.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Checking</para>
                    /// </summary>
                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The event type, such as USER_MESSAGE, TEXT_MESSAGE_CONTENT, or TOOL_CALL_ARGS. This is not fixed to text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEXT_MESSAGE_CONTENT</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The time when the historical event record was created, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The position of the event within the session, used for sorting and deduplication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>Currently, an empty string is returned. This field is not used to determine whether the execution has finished.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The ID of the historical event record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>record-001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The complete original event object. The internal fields retain their original protocol names, without recursive naming conversion or the need for further JSON string parsing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;type&quot;:&quot;TEXT_MESSAGE_CONTENT&quot;,&quot;messageId&quot;:&quot;m001&quot;,&quot;delta&quot;:&quot;Checking.&quot;}</para>
                /// </summary>
                [NameInMap("metadata")]
                [Validation(Required=false)]
                public object Metadata { get; set; }

                /// <summary>
                /// <para>Currently, an empty string is returned. This field is not used to identify the event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The role in the original event. An empty string is returned if the event does not contain a role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The ID of the associated execution. This field is empty if there is no associated execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t001</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <para>The token usage per event. This data is not currently returned. To query the cumulative usage of an execution, call GetCopilotSession.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("usage")]
                [Validation(Required=false)]
                public object Usage { get; set; }

            }

            /// <summary>
            /// <para>The token for the next page. Pass this value back as is in the next request. An empty value indicates that there is no next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The session summary of the current user. This object does not contain the active execution summary. To query the execution status, call GetCopilotSession.</para>
            /// </summary>
            [NameInMap("session")]
            [Validation(Required=false)]
            public ListCopilotSessionMessagesResponseBodyDataSession Session { get; set; }
            public class ListCopilotSessionMessagesResponseBodyDataSession : TeaModel {
                /// <summary>
                /// <para>The agent identifier in the session summary, which does not represent the current executor. The current executor is subject to activeTurn.agentId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sysagent</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The time when the session was created, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The session ID, which is the same as sessionId. We recommend using sessionId to initiate subsequent requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The session title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Troubleshoot CPU load</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The snapshot information when the scheduled task is triggered. This field is returned only for scheduled task sessions and is empty for sessions from other sources. Subsequent renaming or deletion of the task does not change the historical snapshot.</para>
                /// </summary>
                [NameInMap("scheduledTask")]
                [Validation(Required=false)]
                public ListCopilotSessionMessagesResponseBodyDataSessionScheduledTask ScheduledTask { get; set; }
                public class ListCopilotSessionMessagesResponseBodyDataSessionScheduledTask : TeaModel {
                    /// <summary>
                    /// <para>The ID of this scheduled execution. Different runIds are used for multiple triggers of the same scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>run-example-001</para>
                    /// </summary>
                    [NameInMap("runId")]
                    [Validation(Required=false)]
                    public string RunId { get; set; }

                    /// <summary>
                    /// <para>The scheduled trigger time, in ISO 8601 format with time zone. This field is empty if there is no record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T01:00:00+00:00</para>
                    /// </summary>
                    [NameInMap("scheduledAt")]
                    [Validation(Required=false)]
                    public string ScheduledAt { get; set; }

                    /// <summary>
                    /// <para>The time when Copilot started processing this schedule, in ISO 8601 format with time zone. This is not the time when the model outputs the first token.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T01:00:03+00:00</para>
                    /// </summary>
                    [NameInMap("startedAt")]
                    [Validation(Required=false)]
                    public string StartedAt { get; set; }

                    /// <summary>
                    /// <para>The ID of the associated scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42</para>
                    /// </summary>
                    [NameInMap("taskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    /// <summary>
                    /// <para>The name of the scheduled task at the time of this trigger.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Daily inspection</para>
                    /// </summary>
                    [NameInMap("taskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                    /// <summary>
                    /// <para>The scheduling time zone of the scheduled task, such as Asia/Shanghai.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// <para>The session ID. Use this value when you send follow-up questions, query history, or delete the session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s001</para>
                /// </summary>
                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The source from which the session was created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>openapi: Active call.</description></item>
                /// <item><description>cron: Scheduled task.</description></item>
                /// <item><description>im_dingtalk: DingTalk.</description></item>
                /// <item><description>im_feishu: Lark.</description></item>
                /// <item><description>alert: Alert.
                /// This value is determined by the server and is not changed by follow-up questions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>openapi</para>
                /// </summary>
                [NameInMap("sessionType")]
                [Validation(Required=false)]
                public string SessionType { get; set; }

                /// <summary>
                /// <para>The time when the session was last updated, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:02:00+08:00</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

                /// <summary>
                /// <para>The ID of the user to whom the session belongs. This value is determined by the server based on the caller identity and is not used as a parameter for the client to specify the identity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// <para>A field retained for historical compatibility, which may be omitted. Use data.maxResults instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The error message. If the code is Success, this field is empty. Otherwise, this field contains the error message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service temporarily unavailable</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BC79EF5-798B-5499-9683-4E14EBBBF712</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
