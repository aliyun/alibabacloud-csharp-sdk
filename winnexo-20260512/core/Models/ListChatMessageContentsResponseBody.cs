// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListChatMessageContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Specifies whether there is a next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The list of MCP cards.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListChatMessageContentsResponseBodyItems> Items { get; set; }
        public class ListChatMessageContentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The content type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Text.</description></item>
            /// <item><description>1: Image material.</description></item>
            /// <item><description>2: Handwritten text.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ListChatMessageContentsResponseBodyItemsAttachments> Attachments { get; set; }
            public class ListChatMessageContentsResponseBodyItemsAttachments : TeaModel {
                /// <summary>
                /// <para>The ID of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file-1</para>
                /// </summary>
                [NameInMap("attachmentId")]
                [Validation(Required=false)]
                public string AttachmentId { get; set; }

                /// <summary>
                /// <para>The total number of characters in the content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("charCount")]
                [Validation(Required=false)]
                public long? CharCount { get; set; }

                /// <summary>
                /// <para>The number of chunks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("chunkCount")]
                [Validation(Required=false)]
                public int? ChunkCount { get; set; }

                /// <summary>
                /// <para>The content of the user message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Attachment content</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The reason why the content is empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("emptyReason")]
                [Validation(Required=false)]
                public string EmptyReason { get; set; }

                /// <summary>
                /// <para>The failure code of the batch. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ARREARAGE: The account has an overdue payment.</description></item>
                /// <item><description>NO_TARGET: No valid inspection instance is available.</description></item>
                /// <item><description>TIMEOUT: The batch execution timed out.</description></item>
                /// <item><description>SYSTEM_ERROR: A system error occurred.</description></item>
                /// <item><description>ALL_INSTANCE_FAILED: All instance inspections failed.</description></item>
                /// </list>
                /// <para>This parameter is empty if the batch does not fail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ARREARAGE</para>
                /// </summary>
                [NameInMap("failureCode")]
                [Validation(Required=false)]
                public string FailureCode { get; set; }

                /// <summary>
                /// <para>The failure summary of the asynchronous task. This parameter is not returned if no failure information is available. You can use the taskId and requestId to troubleshoot the issue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Scheduling failed</para>
                /// </summary>
                [NameInMap("failureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>The new file name. This parameter is optional. If you do not specify this parameter or specify an empty string, the original file name is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weekly_Report.pdf</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>Specifies whether the standard package instance is found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("found")]
                [Validation(Required=false)]
                public bool? Found { get; set; }

                /// <summary>
                /// <para>The ID of the message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msg-1</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The type of the attachment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc</para>
                /// </summary>
                [NameInMap("modality")]
                [Validation(Required=false)]
                public string Modality { get; set; }

                /// <summary>
                /// <para>The status of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Online.</description></item>
                /// <item><description><b>0</b>: Offline.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PARSED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Specifies whether the scan result is truncated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("truncated")]
                [Validation(Required=false)]
                public bool? Truncated { get; set; }

            }

            /// <summary>
            /// <para>The ID of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-1</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MARKDOWN</b>: Markdown message.</description></item>
            /// <item><description><b>ACTIONCARD</b>: Card message.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Message buttons cannot be used in Markdown messages.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The ID of the service record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("recordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>The DingTalk ID of the customer service representative.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sender-1</para>
            /// </summary>
            [NameInMap("senderId")]
            [Validation(Required=false)]
            public string SenderId { get; set; }

            /// <summary>
            /// <para>The name of the message sender.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("senderName")]
            [Validation(Required=false)]
            public string SenderName { get; set; }

            /// <summary>
            /// <para>The time when the message was sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-09T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("sentAt")]
            [Validation(Required=false)]
            public string SentAt { get; set; }

            /// <summary>
            /// <para>The batch text to be translated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please check the attachment</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The current zone list is illegal.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The maximum number of data records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trace-chat-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the original project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-chat-1</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
