// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskExecutionRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetScheduledTaskExecutionRecordsResponseBodyTasks> Tasks { get; set; }
        public class GetScheduledTaskExecutionRecordsResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>Cron 表达式</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("cronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>任务简述</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>是否公开</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>任务 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleTaskId</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("timeline")]
            [Validation(Required=false)]
            public List<GetScheduledTaskExecutionRecordsResponseBodyTasksTimeline> Timeline { get; set; }
            public class GetScheduledTaskExecutionRecordsResponseBodyTasksTimeline : TeaModel {
                /// <summary>
                /// <para>实际执行时间（仅历史记录）</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("actualTime")]
                [Validation(Required=false)]
                public string ActualTime { get; set; }

                /// <summary>
                /// <para>执行记录展示名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>错误信息（仅失败记录）</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>执行记录 ID（历史记录才有）</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleExecutionId</para>
                /// </summary>
                [NameInMap("executionId")]
                [Validation(Required=false)]
                public string ExecutionId { get; set; }

                /// <summary>
                /// <para>执行输出内容（仅历史记录）</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("outputContent")]
                [Validation(Required=false)]
                public string OutputContent { get; set; }

                /// <summary>
                /// <para>计划执行时间 ISO8601</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("scheduledTime")]
                [Validation(Required=false)]
                public string ScheduledTime { get; set; }

                /// <summary>
                /// <para>状态：PENDING/RUNNING/SUCCESS/FAILED/SCHEDULED</para>
                /// 
                /// <b>Example:</b>
                /// <para>READY</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>时区</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("timezone")]
            [Validation(Required=false)]
            public string Timezone { get; set; }

            /// <summary>
            /// <para>触发类型 cron/manual/event</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("triggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

    }

}
