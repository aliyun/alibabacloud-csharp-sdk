// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateTodoResponseBody : TeaModel {
        /// <summary>
        /// <para>处理人列表</para>
        /// </summary>
        [NameInMap("assignees")]
        [Validation(Required=false)]
        public List<CreateTodoResponseBodyAssignees> Assignees { get; set; }
        public class CreateTodoResponseBodyAssignees : TeaModel {
            /// <summary>
            /// <para>处理人用户ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("assigneeUserId")]
            [Validation(Required=false)]
            public string AssigneeUserId { get; set; }

            /// <summary>
            /// <para>处理人行状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <para>创建时间（ISO8601 带时区；与列表/详情的北京时间格式串不同）</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12T15:00:00+08:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

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
        /// <para>待办状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>新建待办ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoId")]
        [Validation(Required=false)]
        public string TodoId { get; set; }

    }

}
