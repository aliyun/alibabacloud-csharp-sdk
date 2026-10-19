// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetTodoResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>todoId 查询时的单条结果（其余查询为空）；字段集同 getTodoDetail 平铺结构</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例待办键值对</para>
        /// </summary>
        [NameInMap("todo")]
        [Validation(Required=false)]
        public Dictionary<string, object> Todo { get; set; }

        /// <summary>
        /// <para>workItemId/messageId 查询时的多条结果（todoId 查询为空）</para>
        /// </summary>
        [NameInMap("todos")]
        [Validation(Required=false)]
        public List<GetTodoResponseBodyTodos> Todos { get; set; }
        public class GetTodoResponseBodyTodos : TeaModel {
            /// <summary>
            /// <para>全部处理人</para>
            /// </summary>
            [NameInMap("assignees")]
            [Validation(Required=false)]
            public List<GetTodoResponseBodyTodosAssignees> Assignees { get; set; }
            public class GetTodoResponseBodyTodosAssignees : TeaModel {
                /// <summary>
                /// <para>处理时间（北京时间）；未处理为空</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-16T10:30:00+08:00</para>
                /// </summary>
                [NameInMap("actedAt")]
                [Validation(Required=false)]
                public string ActedAt { get; set; }

                /// <summary>
                /// <para>处理人来源：ORIGINAL/TRANSFERRED</para>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGINAL</para>
                /// </summary>
                [NameInMap("assigneeSource")]
                [Validation(Required=false)]
                public string AssigneeSource { get; set; }

                /// <summary>
                /// <para>处理人用户ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("assigneeUserId")]
                [Validation(Required=false)]
                public string AssigneeUserId { get; set; }

                /// <summary>
                /// <para>已读时间（北京时间）；未读为空</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-12 10:01:00</para>
                /// </summary>
                [NameInMap("readAt")]
                [Validation(Required=false)]
                public string ReadAt { get; set; }

                /// <summary>
                /// <para>处理人行状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>转出人用户ID；仅转办产生</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("transferredFromUserId")]
                [Validation(Required=false)]
                public string TransferredFromUserId { get; set; }

            }

            /// <summary>
            /// <para>完成时间（北京时间）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <para>完成人用户ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("completedByUserId")]
            [Validation(Required=false)]
            public string CompletedByUserId { get; set; }

            /// <summary>
            /// <para>创建时间（北京时间）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>最后修改时间（北京时间）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>assistant 消息ID；无会话来源为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-1</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>优先级</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEDIUM</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>问题清单（JSONB 原样）</para>
            /// 
            /// <b>Example:</b>
            /// <para>q1=示例问题</para>
            /// </summary>
            [NameInMap("questions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Questions { get; set; }

            /// <summary>
            /// <para>作答内容（JSONB 原样）</para>
            /// 
            /// <b>Example:</b>
            /// <para>result=同意</para>
            /// </summary>
            [NameInMap("resultPayload")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResultPayload { get; set; }

            /// <summary>
            /// <para>来源上下文（原样透传）</para>
            /// 
            /// <b>Example:</b>
            /// <para>source=openapi</para>
            /// </summary>
            [NameInMap("sourceContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceContext { get; set; }

            /// <summary>
            /// <para>待办主状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>待办摘要</para>
            /// 
            /// <b>Example:</b>
            /// <para>待办事项摘要</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>待办标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>治理审批</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>待办ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_abc123</para>
            /// </summary>
            [NameInMap("todoId")]
            [Validation(Required=false)]
            public string TodoId { get; set; }

        }

    }

}
