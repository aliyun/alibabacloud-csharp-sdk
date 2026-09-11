// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListAliDingGroupMessagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The file information.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListAliDingGroupMessagesResponseBodyItems> Items { get; set; }
        public class ListAliDingGroupMessagesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The comment attachments.</para>
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ListAliDingGroupMessagesResponseBodyItemsAttachments> Attachments { get; set; }
            public class ListAliDingGroupMessagesResponseBodyItemsAttachments : TeaModel {
                /// <summary>
                /// <para>The attachment ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>attachment-example</para>
                /// </summary>
                [NameInMap("attachmentId")]
                [Validation(Required=false)]
                public string AttachmentId { get; set; }

                /// <summary>
                /// <para>The attachment type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FILE</para>
                /// </summary>
                [NameInMap("attachmentType")]
                [Validation(Required=false)]
                public string AttachmentType { get; set; }

                /// <summary>
                /// <para>The execution duration of the asynchronous task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("durationMs")]
                [Validation(Required=false)]
                public long? DurationMs { get; set; }

                /// <summary>
                /// <para>The new file name. This parameter is optional. If you do not specify this parameter or set it to an empty string, the original file name is retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Plan.pdf</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The file size, in <b>bytes</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102400</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The thumbnail height, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// <para>The media type. The file name extension is in uppercase, such as XLS, DOC, DOCX, PDF, or XLSX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/pdf</para>
                /// </summary>
                [NameInMap("mimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The image width, in pixels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1920</para>
                /// </summary>
                [NameInMap("width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

            /// <summary>
            /// <para>The returned content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>See the attachment</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-08 09:01:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msg-example</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The message type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MARKDOWN</b>: Markdown message.</description></item>
            /// <item><description><b>ACTIONCARD</b>: card message.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Markdown messages do not support message buttons.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FILE</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>The DingTalk ID of the business-side customer service representative.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-example</para>
            /// </summary>
            [NameInMap("senderId")]
            [Validation(Required=false)]
            public string SenderId { get; set; }

            /// <summary>
            /// <para>The name of the message sender.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John</para>
            /// </summary>
            [NameInMap("senderName")]
            [Validation(Required=false)]
            public string SenderName { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The time when the next plan is scheduled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-08T09:01:00+08:00</para>
        /// </summary>
        [NameInMap("nextTime")]
        [Validation(Required=false)]
        public string NextTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-id</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
