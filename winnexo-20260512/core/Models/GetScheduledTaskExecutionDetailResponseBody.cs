// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskExecutionDetailResponseBody : TeaModel {
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
        /// <para>完成时间 ISO8601</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>执行完整内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例内容</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>创建人</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>digitalEmployeeName</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>错误信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>执行 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleExecutionId</para>
        /// </summary>
        [NameInMap("executionId")]
        [Validation(Required=false)]
        public string ExecutionId { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GetScheduledTaskExecutionDetailResponseBodyFiles> Files { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyFiles : TeaModel {
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
            /// <para>文件 OSS URL</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/oss/file.pdf">https://example.com/oss/file.pdf</a></para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>创建时间 ISO8601</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public GetScheduledTaskExecutionDetailResponseBodyMetadata Metadata { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyMetadata : TeaModel {
            /// <summary>
            /// <para>会话 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSessionId</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>执行结果推送状态（多频道时为列表）</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("usage")]
            [Validation(Required=false)]
            public Dictionary<string, object> Usage { get; set; }

        }

        /// <summary>
        /// <para>结构化输出内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("outputContent")]
        [Validation(Required=false)]
        public string OutputContent { get; set; }

        [NameInMap("pushResult")]
        [Validation(Required=false)]
        public string PushResult { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>skillCodes</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("skillCodes")]
        [Validation(Required=false)]
        public List<string> SkillCodes { get; set; }

        /// <summary>
        /// <para>开始时间 ISO8601</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>执行状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>任务 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTaskId</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>执行结果标题</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例标题</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public GetScheduledTaskExecutionDetailResponseBodyTriggerInfo TriggerInfo { get; set; }
        public class GetScheduledTaskExecutionDetailResponseBodyTriggerInfo : TeaModel {
            /// <summary>
            /// <para>触发执行的用户标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_10001</para>
            /// </summary>
            [NameInMap("triggeredBy")]
            [Validation(Required=false)]
            public string TriggeredBy { get; set; }

        }

        /// <summary>
        /// <para>触发类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
