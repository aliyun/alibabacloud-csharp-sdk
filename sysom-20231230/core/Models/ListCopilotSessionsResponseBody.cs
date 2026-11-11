// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListCopilotSessionsResponseBody : TeaModel {
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
        public ListCopilotSessionsResponseBodyData Data { get; set; }
        public class ListCopilotSessionsResponseBodyData : TeaModel {
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
            /// <para>The pagination token for the next page. Pass this value back as is in the next request. An empty value indicates that no more pages are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The session list.</para>
            /// </summary>
            [NameInMap("sessions")]
            [Validation(Required=false)]
            public List<ListCopilotSessionsResponseBodyDataSessions> Sessions { get; set; }
            public class ListCopilotSessionsResponseBodyDataSessions : TeaModel {
                /// <summary>
                /// <para>The information about the execution that currently occupies the session.</para>
                /// </summary>
                [NameInMap("activeTurn")]
                [Validation(Required=false)]
                public ListCopilotSessionsResponseBodyDataSessionsActiveTurn ActiveTurn { get; set; }
                public class ListCopilotSessionsResponseBodyDataSessionsActiveTurn : TeaModel {
                    /// <summary>
                    /// <para>The Agent ID bound to the current execution round.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sysagent</para>
                    /// </summary>
                    [NameInMap("agentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    /// <summary>
                    /// <para>The time when the current execution round was created, in ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T09:00:00+08:00</para>
                    /// </summary>
                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    /// <summary>
                    /// <para>The time when the execution ended, in ISO 8601 format. This field is empty if the execution has not ended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T09:03:00+08:00</para>
                    /// </summary>
                    [NameInMap("finishedAt")]
                    [Validation(Required=false)]
                    public string FinishedAt { get; set; }

                    /// <summary>
                    /// <para>The cumulative number of input tokens in the current round, which is not the incremental usage of the current event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1200</para>
                    /// </summary>
                    [NameInMap("inputTokens")]
                    [Validation(Required=false)]
                    public long? InputTokens { get; set; }

                    /// <summary>
                    /// <para>The cumulative number of output tokens in the current round.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("outputTokens")]
                    [Validation(Required=false)]
                    public long? OutputTokens { get; set; }

                    /// <summary>
                    /// <para>The ID of the form that is currently waiting for the user to fill out. This field is used when user input is submitted. This field is empty when no form needs to be filled out.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>iso-boot-validation</para>
                    /// </summary>
                    [NameInMap("pendingInputId")]
                    [Validation(Required=false)]
                    public string PendingInputId { get; set; }

                    /// <summary>
                    /// <para>The execution status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>running: The execution is in progress.</description></item>
                    /// <item><description>waiting_input: Waiting for user input.</description></item>
                    /// <item><description>cancelling: The execution is being canceled.</description></item>
                    /// <item><description>completed: The execution is completed.</description></item>
                    /// <item><description>failed: The execution failed.</description></item>
                    /// <item><description>cancelled: The execution is canceled.</description></item>
                    /// <item><description>outcome_unknown: The result is unknown, and the session may still be occupied. The execution should not be automatically rerun.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>running</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the current execution round, which is used to submit user input, reconnect, or stop the execution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t001</para>
                    /// </summary>
                    [NameInMap("turnId")]
                    [Validation(Required=false)]
                    public string TurnId { get; set; }

                    /// <summary>
                    /// <para>The time when the current execution round was last updated, in ISO 8601 format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T09:02:00+08:00</para>
                    /// </summary>
                    [NameInMap("updatedAt")]
                    [Validation(Required=false)]
                    public string UpdatedAt { get; set; }

                }

                /// <summary>
                /// <para>The ID of the execution that currently occupies the session. This field is empty when no active execution exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t001</para>
                /// </summary>
                [NameInMap("activeTurnId")]
                [Validation(Required=false)]
                public string ActiveTurnId { get; set; }

                /// <summary>
                /// <para>The Agent tag of the session. The current executor is subject to activeTurn.agentId.</para>
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
                /// <para>The session ID.</para>
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
                /// <para>The snapshot information when the scheduled task is triggered. This field is returned only for scheduled task sessions and is empty for sessions from other sources.</para>
                /// </summary>
                [NameInMap("scheduledTask")]
                [Validation(Required=false)]
                public ListCopilotSessionsResponseBodyDataSessionsScheduledTask ScheduledTask { get; set; }
                public class ListCopilotSessionsResponseBodyDataSessionsScheduledTask : TeaModel {
                    /// <summary>
                    /// <para>The ID of the current scheduled execution. Different runIds are used for multiple triggers of the same scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>run-example-001</para>
                    /// </summary>
                    [NameInMap("runId")]
                    [Validation(Required=false)]
                    public string RunId { get; set; }

                    /// <summary>
                    /// <para>The scheduled trigger time, in ISO 8601 format with time zone. This field is empty when no record exists.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-09-09T01:00:00+00:00</para>
                    /// </summary>
                    [NameInMap("scheduledAt")]
                    [Validation(Required=false)]
                    public string ScheduledAt { get; set; }

                    /// <summary>
                    /// <para>The time when Copilot started processing the current schedule, in ISO 8601 format with time zone. This is not the time when the model outputs the first token.</para>
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
                    /// <para>The scheduling time zone of the scheduled task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia/Shanghai</para>
                    /// </summary>
                    [NameInMap("timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

                /// <summary>
                /// <para>The session ID. Use this value when you send questions, query history, and delete sessions later.</para>
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
                /// <item><description>openapi: API call.</description></item>
                /// <item><description>cron: Scheduled task.</description></item>
                /// <item><description>im_dingtalk: DingTalk.</description></item>
                /// <item><description>im_feishu: Lark.</description></item>
                /// <item><description>alert: Alert.
                /// This value is determined by the server and is not changed by subsequent follow-up questions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>openapi</para>
                /// </summary>
                [NameInMap("sessionType")]
                [Validation(Required=false)]
                public string SessionType { get; set; }

                /// <summary>
                /// <para>The session status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>active: Not archived.</description></item>
                /// <item><description>archived: Archived.
                /// This field does not indicate whether the execution has ended.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
        /// <para>The page size used for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The error message. If code is Success, this field is empty. Otherwise, this field contains the request error message.</para>
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
