// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetCopilotSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        public GetCopilotSessionResponseBodyData Data { get; set; }
        public class GetCopilotSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The execution information of the turn that currently occupies the session.</para>
            /// </summary>
            [NameInMap("activeTurn")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataActiveTurn ActiveTurn { get; set; }
            public class GetCopilotSessionResponseBodyDataActiveTurn : TeaModel {
                /// <summary>
                /// <para>The time when the execution turn was created, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:01:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The time when the execution turn ended, in ISO 8601 format. This field is empty if the execution has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:03:00Z</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The cumulative number of input tokens in this execution turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The cumulative number of output tokens in this execution turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The ID of the form that is waiting for user input. It is used when you submit user input. This field is empty if no form needs to be filled out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <para>The execution status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the execution turn. It is used when you submit user input, reconnect, or stop the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e499819f351242dba59ab8af31bc8b0f</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <para>The time when the execution turn was last updated, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:02:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The time when the session was created, in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-09T01:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The cursor of the latest persisted event in the current session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("cursor")]
            [Validation(Required=false)]
            public string Cursor { get; set; }

            /// <summary>
            /// <para>The information about the most recent execution turn.</para>
            /// </summary>
            [NameInMap("lastTurn")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataLastTurn LastTurn { get; set; }
            public class GetCopilotSessionResponseBodyDataLastTurn : TeaModel {
                /// <summary>
                /// <para>The time when the execution turn was created, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:01:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The time when the execution turn ended, in ISO 8601 format. This field is empty if the execution has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:03:00Z</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The cumulative number of input tokens in this execution turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The cumulative number of output tokens in this execution turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The ID of the form that is waiting for user input. It is used when you submit user input. This field is empty if no form needs to be filled out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <para>The execution status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the execution turn. It is used when you submit user input, reconnect, or stop the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e499819f351242dba59ab8af31bc8b0f</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <para>The time when the execution turn was last updated, in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:02:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

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
            /// <para>The snapshot information captured when the scheduled task was triggered.</para>
            /// </summary>
            [NameInMap("scheduledTask")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataScheduledTask ScheduledTask { get; set; }
            public class GetCopilotSessionResponseBodyDataScheduledTask : TeaModel {
                /// <summary>
                /// <para>The ID of this scheduled execution. It is used to associate with the scheduled execution record. Multiple triggers of the same scheduled task use different runIds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>run-example-001</para>
                /// </summary>
                [NameInMap("runId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// <para>The scheduled trigger time, in ISO 8601 format with a time zone. This field is empty if no record exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:00:00+00:00</para>
                /// </summary>
                [NameInMap("scheduledAt")]
                [Validation(Required=false)]
                public string ScheduledAt { get; set; }

                /// <summary>
                /// <para>The time when the processing of this schedule started, in ISO 8601 format with a time zone.</para>
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
                /// <para>The name of the scheduled task when this trigger occurred. Subsequent changes to the task name do not change this snapshot.</para>
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
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c356bc310e4345c3a602a2912322ad21</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The session source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>openapi: API call.</description></item>
            /// <item><description>cron: Scheduled task.</description></item>
            /// <item><description>im_dingtalk: DingTalk.</description></item>
            /// <item><description>im_feishu: Lark.</description></item>
            /// <item><description>alert: Alert.</description></item>
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
            /// <item><description>active: The session is not archived.</description></item>
            /// <item><description>archived: The session is archived.</description></item>
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
            /// <para>2026-09-09T01:02:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// <list type="bullet">
        /// <item><description>If <c>code == Success</c>, this field is empty.</description></item>
        /// <item><description>Otherwise, this field contains the request error message.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. You can use it for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BC79EF5-798B-5499-9683-4E14EBBBF712</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
