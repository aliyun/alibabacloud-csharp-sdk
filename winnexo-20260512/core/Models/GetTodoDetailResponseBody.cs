// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetTodoDetailResponseBody : TeaModel {
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
        /// <para>全部处理人</para>
        /// </summary>
        [NameInMap("assignees")]
        [Validation(Required=false)]
        public List<GetTodoDetailResponseBodyAssignees> Assignees { get; set; }
        public class GetTodoDetailResponseBodyAssignees : TeaModel {
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
        /// <para>附件策略（当前版本附件不落库）</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowUpload=true</para>
        /// </summary>
        [NameInMap("attachmentPolicy")]
        [Validation(Required=false)]
        public Dictionary<string, object> AttachmentPolicy { get; set; }

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
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>调用者权限（canSubmit/canTransfer）</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP/VIEW=true</para>
        /// </summary>
        [NameInMap("myPermissions")]
        [Validation(Required=false)]
        public Dictionary<string, object> MyPermissions { get; set; }

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
        /// <para>问题清单（结构化投影）</para>
        /// </summary>
        [NameInMap("questions")]
        [Validation(Required=false)]
        public List<GetTodoDetailResponseBodyQuestions> Questions { get; set; }
        public class GetTodoDetailResponseBodyQuestions : TeaModel {
            /// <summary>
            /// <para>是否允许自定义输入</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowCustom")]
            [Validation(Required=false)]
            public bool? AllowCustom { get; set; }

            /// <summary>
            /// <para>自定义输入项文案</para>
            /// 
            /// <b>Example:</b>
            /// <para>其他</para>
            /// </summary>
            [NameInMap("customLabel")]
            [Validation(Required=false)]
            public string CustomLabel { get; set; }

            /// <summary>
            /// <para>自定义输入长度上限</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("customMaxLength")]
            [Validation(Required=false)]
            public long? CustomMaxLength { get; set; }

            /// <summary>
            /// <para>自定义输入占位符</para>
            /// 
            /// <b>Example:</b>
            /// <para>请说明</para>
            /// </summary>
            [NameInMap("customPlaceholder")]
            [Validation(Required=false)]
            public string CustomPlaceholder { get; set; }

            /// <summary>
            /// <para>TEXT 题长度上限</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("maxLength")]
            [Validation(Required=false)]
            public long? MaxLength { get; set; }

            /// <summary>
            /// <para>作答形态：SINGLE_CHOICE/MULTI_CHOICE/TEXT</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_CHOICE</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>选项（选择类必有）</para>
            /// </summary>
            [NameInMap("options")]
            [Validation(Required=false)]
            public List<GetTodoDetailResponseBodyQuestionsOptions> Options { get; set; }
            public class GetTodoDetailResponseBodyQuestionsOptions : TeaModel {
                /// <summary>
                /// <para>选项补充说明</para>
                /// 
                /// <b>Example:</b>
                /// <para>选项补充说明</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>选项文案（引用键）</para>
                /// 
                /// <b>Example:</b>
                /// <para>通过</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>是否推荐</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

            }

            /// <summary>
            /// <para>TEXT 题占位符</para>
            /// 
            /// <b>Example:</b>
            /// <para>请输入</para>
            /// </summary>
            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            /// <summary>
            /// <para>问题正文（引用键）</para>
            /// 
            /// <b>Example:</b>
            /// <para>是否通过审批</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <para>是否必答</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

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
        /// <para>作答内容（JSONB 原样；未提交为空对象缺省）</para>
        /// 
        /// <b>Example:</b>
        /// <para>result=同意</para>
        /// </summary>
        [NameInMap("resultPayload")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResultPayload { get; set; }

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
        /// <para>工作流ID（sourceType=WORKFLOW 时必有）</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf-1</para>
        /// </summary>
        [NameInMap("sourceWorkflowId")]
        [Validation(Required=false)]
        public string SourceWorkflowId { get; set; }

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
        /// <para>请审批以下事项</para>
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
