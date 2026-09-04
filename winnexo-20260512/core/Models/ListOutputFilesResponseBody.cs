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
            /// <para>exampleConversationId</para>
            /// </summary>
            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The output name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the digital employee (operating object).</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("operatingObjectName")]
            [Validation(Required=false)]
            public string OperatingObjectName { get; set; }

            /// <summary>
            /// <para>The output ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleOutputId</para>
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
                /// <para>The creation time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The email information. This field is present when the output type is email.</para>
                /// </summary>
                [NameInMap("emailInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsEmailInfo EmailInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsEmailInfo : TeaModel {
                    /// <summary>
                    /// <para>The email body.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// <para>The content type, such as MARKDOWN/JSONML/HTML.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The recipient list.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("recipients")]
                    [Validation(Required=false)]
                    public List<string> Recipients { get; set; }

                    /// <summary>
                    /// <para>The email subject.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("subject")]
                    [Validation(Required=false)]
                    public string Subject { get; set; }

                }

                /// <summary>
                /// <para>The file information. This field is present when the output type is file.</para>
                /// </summary>
                [NameInMap("fileInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsFileInfo FileInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsFileInfo : TeaModel {
                    /// <summary>
                    /// <para>The file description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Sample description</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SampleName.pdf</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The file path (OSS object key).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oss/file.pdf">https://example.com/oss/file.pdf</a></para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The file type, such as .pdf or .md.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The database creation time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The database update time in ISO 8601 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The output name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleItemName</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The type of the output item. Valid values: ppt, html, document, picture, slides, video, audio, email, and others.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ppt</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>The internationalized display name of the output detail type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("itemTypeDisplayName")]
                [Validation(Required=false)]
                public string ItemTypeDisplayName { get; set; }

                /// <summary>
                /// <para>The message ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleMessageId</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>The output detail ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_example_value</para>
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
                /// <para>The share token that is present when sharing is enabled. You can use this token to access the public share preview API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_share_token</para>
                /// </summary>
                [NameInMap("shareToken")]
                [Validation(Required=false)]
                public string ShareToken { get; set; }

                /// <summary>
                /// <para>The skill output ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleSkillOutputId</para>
                /// </summary>
                [NameInMap("skillOutputId")]
                [Validation(Required=false)]
                public string SkillOutputId { get; set; }

                /// <summary>
                /// <para>The slides information. This field is present when the output type is slides.</para>
                /// </summary>
                [NameInMap("slidesInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo SlidesInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo : TeaModel {
                    /// <summary>
                    /// <para>The number of completed slides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("completedSlides")]
                    [Validation(Required=false)]
                    public long? CompletedSlides { get; set; }

                    /// <summary>
                    /// <para>The PPT file ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>examplePptId</para>
                    /// </summary>
                    [NameInMap("pptId")]
                    [Validation(Required=false)]
                    public string PptId { get; set; }

                    /// <summary>
                    /// <para>The PPT name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("pptName")]
                    [Validation(Required=false)]
                    public string PptName { get; set; }

                    /// <summary>
                    /// <para>The total number of slides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("totalSlides")]
                    [Validation(Required=false)]
                    public long? TotalSlides { get; set; }

                }

                /// <summary>
                /// <para>The task execution ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleTaskExecutionId</para>
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
            /// <para>The internationalized display name of the output type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("outputTypeDisplayName")]
            [Validation(Required=false)]
            public string OutputTypeDisplayName { get; set; }

            /// <summary>
            /// <para>The skill output ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSkillOutputId</para>
            /// </summary>
            [NameInMap("skillOutputId")]
            [Validation(Required=false)]
            public string SkillOutputId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_example_value</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The prompt message.</para>
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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The total number of outputs that match the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
