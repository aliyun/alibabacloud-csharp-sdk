// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListTodosResponseBody : TeaModel {
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
        /// <para>Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of to-do items on the current page.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListTodosResponseBodyItems> Items { get; set; }
        public class ListTodosResponseBodyItems : TeaModel {
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
            /// <para>The completion time in the YYYY-MM-DD HH:mm:ss format (UTC+8).</para>
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
            /// <para>John Doe</para>
            /// </summary>
            [NameInMap("completedByUserName")]
            [Validation(Required=false)]
            public string CompletedByUserName { get; set; }

            /// <summary>
            /// <para>The creation time in the YYYY-MM-DD HH:mm:ss format (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12 10:00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time in the YYYY-MM-DD HH:mm:ss format (UTC+8).</para>
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
            /// <para>The message ID of the assistant that sent the to-do item. This field is empty if there is no conversation source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-1</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The action status of the caller as an assignee.</para>
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
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HIGH</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The number of questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("questionCount")]
            [Validation(Required=false)]
            public long? QuestionCount { get; set; }

            /// <summary>
            /// <para>The list of question summaries.</para>
            /// </summary>
            [NameInMap("questionSummaries")]
            [Validation(Required=false)]
            public List<string> QuestionSummaries { get; set; }

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
            /// <para>The primary status of the to-do item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The to-do title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Governance approval</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The to-do ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_abc123</para>
            /// </summary>
            [NameInMap("todoId")]
            [Validation(Required=false)]
            public string TodoId { get; set; }

        }

        /// <summary>
        /// <para>The effective maximum number of entries to return per page for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

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
        /// <para>The pagination token for the next page. This field is an empty string if no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The effective number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The total number of visible items under the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
