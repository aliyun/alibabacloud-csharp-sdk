// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateCopilotSessionResponseBody : TeaModel {
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
        public UpdateCopilotSessionResponseBodyData Data { get; set; }
        public class UpdateCopilotSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The summary of the execution that currently occupies the session. This field is empty when no active execution is in progress. An execution with an unknown outcome may still occupy the session.</para>
            /// </summary>
            [NameInMap("activeTurn")]
            [Validation(Required=false)]
            public UpdateCopilotSessionResponseBodyDataActiveTurn ActiveTurn { get; set; }
            public class UpdateCopilotSessionResponseBodyDataActiveTurn : TeaModel {
                /// <summary>
                /// <para>The creation time of the current execution turn. The time is in the ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The end time of the execution. The time is in the ISO 8601 format. This field is empty if the execution has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:03:00+08:00</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The cumulative number of input tokens for the current turn. This is not the incremental usage for the current event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The cumulative number of output tokens for the current turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The ID of the form that is currently waiting for user input. It is used when submitting user input. This field is empty when no form is pending.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <para>The execution status. Valid values: running (in progress), waiting_input (waiting for user input), cancelling (cancelling), completed (completed), failed (failed), cancelled (cancelled), and outcome_unknown (outcome unknown, may still occupy the session, and should not be automatically rerun).</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the current execution turn. It is used to submit user input, reconnect, or stop the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t001</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <para>The last update time of the current execution turn. The time is in the ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:02:00+08:00</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the session. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-09T09:00:00+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The latest persisted event cursor for the current session, returned as a decimal string. The value is 0 when no events exist. This value does not represent the position consumed by the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("cursor")]
            [Validation(Required=false)]
            public string Cursor { get; set; }

            /// <summary>
            /// <para>The summary of the most recent execution. This field is empty if no execution has ever occurred. If the most recent execution has not ended, this field may point to the same execution as activeTurn.</para>
            /// </summary>
            [NameInMap("lastTurn")]
            [Validation(Required=false)]
            public UpdateCopilotSessionResponseBodyDataLastTurn LastTurn { get; set; }
            public class UpdateCopilotSessionResponseBodyDataLastTurn : TeaModel {
                /// <summary>
                /// <para>The creation time of the current execution turn. The time is in the ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:00:00+08:00</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <para>The end time of the execution. The time is in the ISO 8601 format. This field is empty if the execution has not ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:03:00+08:00</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <para>The cumulative number of input tokens for the current turn. This is not the incremental usage for the current event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <para>The cumulative number of output tokens for the current turn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <para>The ID of the form that is currently waiting for user input. It is used when submitting user input. This field is empty when no form is pending.</para>
                /// 
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <para>The execution status. Valid values: running (in progress), waiting_input (waiting for user input), cancelling (cancelling), completed (completed), failed (failed), cancelled (cancelled), and outcome_unknown (outcome unknown, may still occupy the session, and should not be automatically rerun).</para>
                /// 
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the current execution turn. It is used to submit user input, reconnect, or stop the execution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t001</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <para>The last update time of the current execution turn. The time is in the ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T09:02:00+08:00</para>
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
            /// <para>The snapshot information when the scheduled task is triggered. This is returned only for scheduled task sessions and is empty for sessions from other sources. Subsequent renaming or deletion of the task does not change the historical snapshot.</para>
            /// </summary>
            [NameInMap("scheduledTask")]
            [Validation(Required=false)]
            public UpdateCopilotSessionResponseBodyDataScheduledTask ScheduledTask { get; set; }
            public class UpdateCopilotSessionResponseBodyDataScheduledTask : TeaModel {
                /// <summary>
                /// <para>The ID of this scheduled execution. Multiple triggers of the same scheduled task use different runIds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>run-example-001</para>
                /// </summary>
                [NameInMap("runId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// <para>The scheduled trigger time. The time is in the ISO 8601 format with a time zone. This field is empty when no record exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:00:00+00:00</para>
                /// </summary>
                [NameInMap("scheduledAt")]
                [Validation(Required=false)]
                public string ScheduledAt { get; set; }

                /// <summary>
                /// <para>The time when Copilot starts processing this schedule. The time is in the ISO 8601 format with a time zone. This is not the time when the model outputs the first token.</para>
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
            /// <para>The session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s001</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The source of the session creation. Valid values: openapi (proactive call), cron (scheduled task), im_dingtalk (DingTalk), im_feishu (Lark), and alert (alert). This is determined by the server, and subsequent follow-up questions do not change the source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openapi</para>
            /// </summary>
            [NameInMap("sessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The session status. Valid values: active (not archived) and archived (archived). This field does not indicate whether the execution has ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time of the session. The time is in the ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-09T09:02:00+08:00</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <para>The error message. If the code is Success, this field is empty. Otherwise, this field contains the request error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service temporarily unavailable</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID. It can be used for end-to-end diagnostics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BC79EF5-798B-5499-9683-4E14EBBBF712</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
