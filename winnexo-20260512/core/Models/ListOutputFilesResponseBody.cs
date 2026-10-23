// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListOutputFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The output list.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListOutputFilesResponseBodyItems> Items { get; set; }
        public class ListOutputFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The conversation ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>session_123e4567-e89b-42d3-a456-426614174008</para>
            /// </summary>
            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The creation time of the output or detail, serialized from a backend datetime value into an ISO 8601 string, with time zone information returned along with the original value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12T03:10:00+00:00</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time of the output or detail, serialized from a backend datetime value into an ISO 8601 string, with time zone information returned along with the original value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-12T03:12:00+00:00</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The output name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Quarterly business analysis report.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the digital worker (operating object).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Business Analysis Assistant</para>
            /// </summary>
            [NameInMap("operatingObjectName")]
            [Validation(Required=false)]
            public string OperatingObjectName { get; set; }

            /// <summary>
            /// <para>The output ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>output_123e4567-e89b-42d3-a456-426614174009</para>
            /// </summary>
            [NameInMap("outputId")]
            [Validation(Required=false)]
            public string OutputId { get; set; }

            /// <summary>
            /// <para>The output detail list.</para>
            /// </summary>
            [NameInMap("outputItems")]
            [Validation(Required=false)]
            public List<ListOutputFilesResponseBodyItemsOutputItems> OutputItems { get; set; }
            public class ListOutputFilesResponseBodyItemsOutputItems : TeaModel {
                /// <summary>
                /// <para>The creation time of the output detail, serialized from a backend datetime value into an ISO 8601 string, with time zone information returned along with the original value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-12T03:10:00+00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The email information, present when the type is email.</para>
                /// </summary>
                [NameInMap("emailInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsEmailInfo EmailInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsEmailInfo : TeaModel {
                    /// <summary>
                    /// <para>The email content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The quarterly business report has been generated. Please review</para>
                    /// </summary>
                    [NameInMap("body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// <para>The content type, such as MARKDOWN, JSONML, or HTML.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MARKDOWN</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The recipient list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;<a href="mailto:reader@example.com">reader@example.com</a>&quot;]</para>
                    /// </summary>
                    [NameInMap("recipients")]
                    [Validation(Required=false)]
                    public List<string> Recipients { get; set; }

                    /// <summary>
                    /// <para>The email subject.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Quarterly business analysis report</para>
                    /// </summary>
                    [NameInMap("subject")]
                    [Validation(Required=false)]
                    public string Subject { get; set; }

                }

                /// <summary>
                /// <para>The file information, present when the type is file.</para>
                /// </summary>
                [NameInMap("fileInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsFileInfo FileInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsFileInfo : TeaModel {
                    /// <summary>
                    /// <para>The file description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Quarterly revenue, cost, and trend analysis report</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Quarterly business analysis report.pdf</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The file location. It is compatible with file URLs and legacy OSS object keys. The specific value is derived from the output registration information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>reports/2026/quarterly-report.pdf</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The file type, such as .pdf or .md.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.pdf</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The creation time of the output or detail, serialized from a backend datetime value into an ISO 8601 string, with time zone information returned along with the original value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-12T03:10:00+00:00</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time of the output or detail, serialized from a backend datetime value into an ISO 8601 string, with time zone information returned along with the original value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-12T03:12:00+00:00</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The output name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Quarterly business analysis report.pdf</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The output item type. Valid values: ppt, html, document, picture, slides, video, audio, email, and others.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The internationalized display name of the output detail type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Document</para>
                /// </summary>
                [NameInMap("itemTypeDisplayName")]
                [Validation(Required=false)]
                public string ItemTypeDisplayName { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msg_123e4567-e89b-42d3-a456-426614174012</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The output detail ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item_123e4567-e89b-42d3-a456-426614174010</para>
                /// </summary>
                [NameInMap("outputItemId")]
                [Validation(Required=false)]
                public string OutputItemId { get; set; }

                /// <summary>
                /// <para>Indicates whether sharing is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("shareEnabled")]
                [Validation(Required=false)]
                public bool? ShareEnabled { get; set; }

                /// <summary>
                /// <para>The share token, present when sharing is enabled. You can use this token to access the public share preview API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo_public_preview_token</para>
                /// </summary>
                [NameInMap("shareToken")]
                [Validation(Required=false)]
                public string ShareToken { get; set; }

                /// <summary>
                /// <para>The skill output ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillout_123e4567-e89b-42d3-a456-426614174011</para>
                /// </summary>
                [NameInMap("skillOutputId")]
                [Validation(Required=false)]
                public string SkillOutputId { get; set; }

                /// <summary>
                /// <para>The slide deck information, present when the type is slide deck.</para>
                /// </summary>
                [NameInMap("slidesInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo SlidesInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo : TeaModel {
                    /// <summary>
                    /// <para>The number of completed slides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("completedSlides")]
                    [Validation(Required=false)]
                    public long? CompletedSlides { get; set; }

                    /// <summary>
                    /// <para>The PPT file ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ppt_123e4567-e89b-42d3-a456-426614174015</para>
                    /// </summary>
                    [NameInMap("pptId")]
                    [Validation(Required=false)]
                    public string PptId { get; set; }

                    /// <summary>
                    /// <para>The PPT name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Quarterly Business Analysis Report</para>
                    /// </summary>
                    [NameInMap("pptName")]
                    [Validation(Required=false)]
                    public string PptName { get; set; }

                    /// <summary>
                    /// <para>The total number of slides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("totalSlides")]
                    [Validation(Required=false)]
                    public long? TotalSlides { get; set; }

                }

                /// <summary>
                /// <para>The task execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>execution_123e4567-e89b-42d3-a456-426614174013</para>
                /// </summary>
                [NameInMap("taskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

            }

            /// <summary>
            /// <para>The output type: <c>conversation/skill/task</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversation</para>
            /// </summary>
            [NameInMap("outputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// <para>The localized display name of the output type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Conversation output</para>
            /// </summary>
            [NameInMap("outputTypeDisplayName")]
            [Validation(Required=false)]
            public string OutputTypeDisplayName { get; set; }

            /// <summary>
            /// <para>The skill output ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skillout_123e4567-e89b-42d3-a456-426614174011</para>
            /// </summary>
            [NameInMap("skillOutputId")]
            [Validation(Required=false)]
            public string SkillOutputId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_123e4567-e89b-42d3-a456-426614174014</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
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
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-42d3-a456-426614174007</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching outputs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
