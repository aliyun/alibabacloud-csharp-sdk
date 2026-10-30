// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetCopilotSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCopilotSessionResponseBodyData Data { get; set; }
        public class GetCopilotSessionResponseBodyData : TeaModel {
            [NameInMap("activeTurn")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataActiveTurn ActiveTurn { get; set; }
            public class GetCopilotSessionResponseBodyDataActiveTurn : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:01:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:03:00Z</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e499819f351242dba59ab8af31bc8b0f</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:02:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-09T01:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>十进制事件序号字符串，范围 0..9223372036854775807；避免 JavaScript 精度丢失</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("cursor")]
            [Validation(Required=false)]
            public string Cursor { get; set; }

            [NameInMap("lastTurn")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataLastTurn LastTurn { get; set; }
            public class GetCopilotSessionResponseBodyDataLastTurn : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:01:00Z</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:03:00Z</para>
                /// </summary>
                [NameInMap("finishedAt")]
                [Validation(Required=false)]
                public string FinishedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("inputTokens")]
                [Validation(Required=false)]
                public long? InputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("outputTokens")]
                [Validation(Required=false)]
                public long? OutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>iso-boot-validation</para>
                /// </summary>
                [NameInMap("pendingInputId")]
                [Validation(Required=false)]
                public string PendingInputId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e499819f351242dba59ab8af31bc8b0f</para>
                /// </summary>
                [NameInMap("turnId")]
                [Validation(Required=false)]
                public string TurnId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-09-09T01:02:00Z</para>
                /// </summary>
                [NameInMap("updatedAt")]
                [Validation(Required=false)]
                public string UpdatedAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>排查 CPU 负载</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>定时任务触发快照；非定时会话为空</para>
            /// </summary>
            [NameInMap("scheduledTask")]
            [Validation(Required=false)]
            public GetCopilotSessionResponseBodyDataScheduledTask ScheduledTask { get; set; }
            public class GetCopilotSessionResponseBodyDataScheduledTask : TeaModel {
                /// <summary>
                /// <para>本次定时执行的 Run ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>run-example-001</para>
                /// </summary>
                [NameInMap("runId")]
                [Validation(Required=false)]
                public string RunId { get; set; }

                /// <summary>
                /// <para>计划触发时间，ISO 8601 含时区偏移</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:00:00+00:00</para>
                /// </summary>
                [NameInMap("scheduledAt")]
                [Validation(Required=false)]
                public string ScheduledAt { get; set; }

                /// <summary>
                /// <para>Copilot 开始处理时间，ISO 8601 含时区偏移</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-09-09T01:00:03+00:00</para>
                /// </summary>
                [NameInMap("startedAt")]
                [Validation(Required=false)]
                public string StartedAt { get; set; }

                /// <summary>
                /// <para>任务 ID；任务删除后仍保留</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>触发时的任务名称快照</para>
                /// 
                /// <b>Example:</b>
                /// <para>每日巡检</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>任务的 cron 时区</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c356bc310e4345c3a602a2912322ad21</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>会话初始来源：chat、scheduled_task、alert；后续追问不改变来源</para>
            /// 
            /// <b>Example:</b>
            /// <para>openapi</para>
            /// </summary>
            [NameInMap("sessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-09-09T01:02:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5BC79EF5-798B-5499-9683-4E14EBBBF712</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
