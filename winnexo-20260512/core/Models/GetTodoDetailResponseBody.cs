// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetTodoDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of assignees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("assigneeCount")]
        [Validation(Required=false)]
        public long? AssigneeCount { get; set; }

        /// <summary>
        /// <para>All assignees.</para>
        /// </summary>
        [NameInMap("assignees")]
        [Validation(Required=false)]
        public List<GetTodoDetailResponseBodyAssignees> Assignees { get; set; }
        public class GetTodoDetailResponseBodyAssignees : TeaModel {
            /// <summary>
            /// <para>The action time in UTC+8. This field is empty if the item is not processed.</para>
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
            /// <para>The user ID of the user who transferred the task. This field is populated only when the task is transferred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("transferredFromUserId")]
            [Validation(Required=false)]
            public string TransferredFromUserId { get; set; }

        }

        /// <summary>
        /// <para>The attachment policy. Attachments are not stored in the database in the current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>allowUpload=true</para>
        /// </summary>
        [NameInMap("attachmentPolicy")]
        [Validation(Required=false)]
        public Dictionary<string, object> AttachmentPolicy { get; set; }

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
        /// <para>The completion time in UTC+8 (YYYY-MM-DD HH:mm:ss).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12 10:00:00</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// <para>The user ID of the user who completed the item. This field is empty if the item is not completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("completedByUserId")]
        [Validation(Required=false)]
        public string CompletedByUserId { get; set; }

        /// <summary>
        /// <para>The name of the user who completed the item. This field is empty if the item is not completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("completedByUserName")]
        [Validation(Required=false)]
        public string CompletedByUserName { get; set; }

        /// <summary>
        /// <para>The creation time in UTC+8 (YYYY-MM-DD HH:mm:ss).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12 10:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The last modification time in UTC+8 (YYYY-MM-DD HH:mm:ss).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-12 10:00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether the caller has read the item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isRead")]
        [Validation(Required=false)]
        public bool? IsRead { get; set; }

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
        /// <para>The ID of the assistant message that generated the to-do item. This field is empty if there is no conversation source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>msg-1</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The action status of the caller as the assignee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("myAssigneeStatus")]
        [Validation(Required=false)]
        public string MyAssigneeStatus { get; set; }

        /// <summary>
        /// <para>The list display status for the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TODO</para>
        /// </summary>
        [NameInMap("myDisplayState")]
        [Validation(Required=false)]
        public string MyDisplayState { get; set; }

        /// <summary>
        /// <para>The permissions of the caller, such as canSubmit and canTransfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP/VIEW=true</para>
        /// </summary>
        [NameInMap("myPermissions")]
        [Validation(Required=false)]
        public Dictionary<string, object> MyPermissions { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The list of questions (structured projection).</para>
        /// </summary>
        [NameInMap("questions")]
        [Validation(Required=false)]
        public List<GetTodoDetailResponseBodyQuestions> Questions { get; set; }
        public class GetTodoDetailResponseBodyQuestions : TeaModel {
            /// <summary>
            /// <para>Indicates whether custom input is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowCustom")]
            [Validation(Required=false)]
            public bool? AllowCustom { get; set; }

            /// <summary>
            /// <para>The text for the custom input field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Other</para>
            /// </summary>
            [NameInMap("customLabel")]
            [Validation(Required=false)]
            public string CustomLabel { get; set; }

            /// <summary>
            /// <para>The maximum length for custom input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("customMaxLength")]
            [Validation(Required=false)]
            public long? CustomMaxLength { get; set; }

            /// <summary>
            /// <para>The placeholder for custom input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please specify</para>
            /// </summary>
            [NameInMap("customPlaceholder")]
            [Validation(Required=false)]
            public string CustomPlaceholder { get; set; }

            /// <summary>
            /// <para>The maximum length for text questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("maxLength")]
            [Validation(Required=false)]
            public long? MaxLength { get; set; }

            /// <summary>
            /// <para>The response mode. Valid values: SINGLE_CHOICE, MULTI_CHOICE, and TEXT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_CHOICE</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The options. This field is required for choice questions.</para>
            /// </summary>
            [NameInMap("options")]
            [Validation(Required=false)]
            public List<GetTodoDetailResponseBodyQuestionsOptions> Options { get; set; }
            public class GetTodoDetailResponseBodyQuestionsOptions : TeaModel {
                /// <summary>
                /// <para>The supplementary description of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Supplementary description of the option</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The option text (reference key).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Approve</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Indicates whether the option is recommended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

            }

            /// <summary>
            /// <para>The placeholder for text questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please enter</para>
            /// </summary>
            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            /// <summary>
            /// <para>The question text (reference key).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether to approve</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <para>Indicates whether the question is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response content in JSONB format as-is. Defaults to an empty object if not submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>result=Approved</para>
        /// </summary>
        [NameInMap("resultPayload")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResultPayload { get; set; }

        /// <summary>
        /// <para>The source context. This context is passed through as-is during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source=openapi</para>
        /// </summary>
        [NameInMap("sourceContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceContext { get; set; }

        /// <summary>
        /// <para>The source type of the to-do item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKFLOW</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The workflow ID. This field is required when sourceType is set to WORKFLOW.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf-1</para>
        /// </summary>
        [NameInMap("sourceWorkflowId")]
        [Validation(Required=false)]
        public string SourceWorkflowId { get; set; }

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
        /// <para>Please approve the following items</para>
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
