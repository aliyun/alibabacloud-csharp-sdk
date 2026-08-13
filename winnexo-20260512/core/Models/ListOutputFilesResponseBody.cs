// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListOutputFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListOutputFilesResponseBodyItems> Items { get; set; }
        public class ListOutputFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>会话 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleConversationId</para>
            /// </summary>
            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <para>创建时间(ISO8601)</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>更新时间(ISO8601)</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>数字员工（运营对象）名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("operatingObjectName")]
            [Validation(Required=false)]
            public string OperatingObjectName { get; set; }

            /// <summary>
            /// <para>产出 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleOutputId</para>
            /// </summary>
            [NameInMap("outputId")]
            [Validation(Required=false)]
            public string OutputId { get; set; }

            [NameInMap("outputItems")]
            [Validation(Required=false)]
            public List<ListOutputFilesResponseBodyItemsOutputItems> OutputItems { get; set; }
            public class ListOutputFilesResponseBodyItemsOutputItems : TeaModel {
                /// <summary>
                /// <para>创建时间(ISO8601)</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("emailInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsEmailInfo EmailInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsEmailInfo : TeaModel {
                    /// <summary>
                    /// <para>邮件内容</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("body")]
                    [Validation(Required=false)]
                    public string Body { get; set; }

                    /// <summary>
                    /// <para>内容类型，如 MARKDOWN/JSONML/HTML</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>recipients</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("recipients")]
                    [Validation(Required=false)]
                    public List<string> Recipients { get; set; }

                    /// <summary>
                    /// <para>邮件主题</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("subject")]
                    [Validation(Required=false)]
                    public string Subject { get; set; }

                }

                [NameInMap("fileInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsFileInfo FileInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsFileInfo : TeaModel {
                    /// <summary>
                    /// <para>文件描述</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例描述</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>文件名</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例名称.pdf</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>文件 OSS URL</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/oss/file.pdf">https://example.com/oss/file.pdf</a></para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>文件类型，如 .pdf, .md</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>数据库创建时间(ISO8601)</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>数据库更新时间(ISO8601)</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-01T12:00:00Z</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>产出名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleItemName</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>产出明细类型: ppt/html/document/picture/slides/video/audio/email/others</para>
                /// 
                /// <b>Example:</b>
                /// <para>ppt</para>
                /// </summary>
                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                /// <summary>
                /// <para>产出明细类型国际化展示名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_value</para>
                /// </summary>
                [NameInMap("itemTypeDisplayName")]
                [Validation(Required=false)]
                public string ItemTypeDisplayName { get; set; }

                /// <summary>
                /// <para>助手消息ID，由 sendAsyncChatMessage 返回；不属于当前租户时返回 404</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleMessageId</para>
                /// </summary>
                [NameInMap("messageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

                /// <summary>
                /// <para>产出明细 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>string_example_value</para>
                /// </summary>
                [NameInMap("outputItemId")]
                [Validation(Required=false)]
                public string OutputItemId { get; set; }

                /// <summary>
                /// <para>是否开启分享</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("shareEnabled")]
                [Validation(Required=false)]
                public bool? ShareEnabled { get; set; }

                /// <summary>
                /// <para>分享令牌</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_share_token</para>
                /// </summary>
                [NameInMap("shareToken")]
                [Validation(Required=false)]
                public string ShareToken { get; set; }

                /// <summary>
                /// <para>技能产出 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleSkillOutputId</para>
                /// </summary>
                [NameInMap("skillOutputId")]
                [Validation(Required=false)]
                public string SkillOutputId { get; set; }

                [NameInMap("slidesInfo")]
                [Validation(Required=false)]
                public ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo SlidesInfo { get; set; }
                public class ListOutputFilesResponseBodyItemsOutputItemsSlidesInfo : TeaModel {
                    /// <summary>
                    /// <para>已完成幻灯片数</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("completedSlides")]
                    [Validation(Required=false)]
                    public long? CompletedSlides { get; set; }

                    /// <summary>
                    /// <para>PPT ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>examplePptId</para>
                    /// </summary>
                    [NameInMap("pptId")]
                    [Validation(Required=false)]
                    public string PptId { get; set; }

                    /// <summary>
                    /// <para>PPT 名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string_value</para>
                    /// </summary>
                    [NameInMap("pptName")]
                    [Validation(Required=false)]
                    public string PptName { get; set; }

                    /// <summary>
                    /// <para>总幻灯片数</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("totalSlides")]
                    [Validation(Required=false)]
                    public long? TotalSlides { get; set; }

                }

                /// <summary>
                /// <para>任务执行 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleTaskExecutionId</para>
                /// </summary>
                [NameInMap("taskExecutionId")]
                [Validation(Required=false)]
                public string TaskExecutionId { get; set; }

            }

            /// <summary>
            /// <para>产出类型: conversation/skill/task</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversation</para>
            /// </summary>
            [NameInMap("outputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// <para>产出类型国际化展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("outputTypeDisplayName")]
            [Validation(Required=false)]
            public string OutputTypeDisplayName { get; set; }

            /// <summary>
            /// <para>技能产出 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSkillOutputId</para>
            /// </summary>
            [NameInMap("skillOutputId")]
            [Validation(Required=false)]
            public string SkillOutputId { get; set; }

            /// <summary>
            /// <para>任务 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_example_value</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>每页数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>符合条件的产出总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
