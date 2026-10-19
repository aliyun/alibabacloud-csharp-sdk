// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListTodosResponseBody : TeaModel {
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
        /// <para>是否还有更多数据</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>当前页待办列表</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListTodosResponseBodyItems> Items { get; set; }
        public class ListTodosResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>处理人数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("assigneeCount")]
            [Validation(Required=false)]
            public long? AssigneeCount { get; set; }

            /// <summary>
            /// <para>完成时间（北京时间 YYYY-MM-DD HH:mm:ss）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <para>完成人用户ID；未完成为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("completedByUserId")]
            [Validation(Required=false)]
            public string CompletedByUserId { get; set; }

            /// <summary>
            /// <para>完成人姓名；未完成为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("completedByUserName")]
            [Validation(Required=false)]
            public string CompletedByUserName { get; set; }

            /// <summary>
            /// <para>创建时间（北京时间 YYYY-MM-DD HH:mm:ss）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>最后修改时间（北京时间 YYYY-MM-DD HH:mm:ss）</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>调用者是否已读</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isRead")]
            [Validation(Required=false)]
            public bool? IsRead { get; set; }

            /// <summary>
            /// <para>发出该待办的 assistant 消息ID；无会话来源为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-1</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>调用者的处理人行状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("myAssigneeStatus")]
            [Validation(Required=false)]
            public string MyAssigneeStatus { get; set; }

            /// <summary>
            /// <para>调用者的列表展示状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>TODO</para>
            /// </summary>
            [NameInMap("myDisplayState")]
            [Validation(Required=false)]
            public string MyDisplayState { get; set; }

            /// <summary>
            /// <para>优先级</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>问题数量</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("questionCount")]
            [Validation(Required=false)]
            public long? QuestionCount { get; set; }

            /// <summary>
            /// <para>问题摘要列表</para>
            /// </summary>
            [NameInMap("questionSummaries")]
            [Validation(Required=false)]
            public List<string> QuestionSummaries { get; set; }

            /// <summary>
            /// <para>来源上下文（创建时原样透传）</para>
            /// 
            /// <b>Example:</b>
            /// <para>source=openapi</para>
            /// </summary>
            [NameInMap("sourceContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceContext { get; set; }

            /// <summary>
            /// <para>待办来源类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORKFLOW</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

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

        /// <summary>
        /// <para>本次生效的单页最大返回数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

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
        /// <para>下一页翻页令牌；无更多数据时为空字符串</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>当前页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>生效单页条数</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>筛选条件下可见总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
