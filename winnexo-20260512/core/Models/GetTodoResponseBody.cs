// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetTodoResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The single result returned when you query by todoId. This field is empty for other query types. The field set is the same as the flattened structure of getTodoDetail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample to-do key-value pair</para>
        /// </summary>
        [NameInMap("todo")]
        [Validation(Required=false)]
        public Dictionary<string, object> Todo { get; set; }

        /// <summary>
        /// <para>The multiple results returned when you query by workItemId or messageId. This field is empty for todoId queries.</para>
        /// </summary>
        [NameInMap("todos")]
        [Validation(Required=false)]
        public List<GetTodoResponseBodyTodos> Todos { get; set; }
        public class GetTodoResponseBodyTodos : TeaModel {
            /// <summary>
            /// <para>The assignees.</para>
            /// </summary>
            [NameInMap("assignees")]
            [Validation(Required=false)]
            public List<GetTodoResponseBodyTodosAssignees> Assignees { get; set; }
            public class GetTodoResponseBodyTodosAssignees : TeaModel {
                /// <summary>
                /// <para>The processing time in UTC+8. This field is empty if the item is unprocessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-16T10:30:00+08:00</para>
                /// </summary>
                [NameInMap("actedAt")]
                [Validation(Required=false)]
                public string ActedAt { get; set; }

                /// <summary>
                /// <para>The source of the assignee. Valid values: ORIGINAL and TRANSFERRED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ORIGINAL</para>
                /// </summary>
                [NameInMap("assigneeSource")]
                [Validation(Required=false)]
                public string AssigneeSource { get; set; }

                /// <summary>
                /// <para>The user ID of the assignee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42</para>
                /// </summary>
                [NameInMap("assigneeUserId")]
                [Validation(Required=false)]
                public string AssigneeUserId { get; set; }

                /// <summary>
                /// <para>The read time in UTC+8. This field is empty if the item is unread.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-12 10:01:00</para>
                /// </summary>
                [NameInMap("readAt")]
                [Validation(Required=false)]
                public string ReadAt { get; set; }

                /// <summary>
                /// <para>The action status of the assignee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The user ID of the person who transferred the task. This field is populated only when the task is transferred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43</para>
                /// </summary>
                [NameInMap("transferredFromUserId")]
                [Validation(Required=false)]
                public string TransferredFromUserId { get; set; }

            }

            /// <summary>
            /// <para>The completion time in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <para>The user ID of the person who completed the to-do item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("completedByUserId")]
            [Validation(Required=false)]
            public string CompletedByUserId { get; set; }

            /// <summary>
            /// <para>The creation time in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time in UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the assistant message. This field is empty if there is no conversation source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-1</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEDIUM</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The list of questions in the original JSONB format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>q1=Sample question</para>
            /// </summary>
            [NameInMap("questions")]
            [Validation(Required=false)]
            public Dictionary<string, object> Questions { get; set; }

            /// <summary>
            /// <para>The response content in the original JSONB format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>result=Approved</para>
            /// </summary>
            [NameInMap("resultPayload")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResultPayload { get; set; }

            /// <summary>
            /// <para>The source context passed through in its original format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>source=openapi</para>
            /// </summary>
            [NameInMap("sourceContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceContext { get; set; }

            /// <summary>
            /// <para>The primary status of the to-do item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The summary of the to-do item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>To-do item summary</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The title of the to-do item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Governance approval</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The ID of the to-do item.</para>
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
