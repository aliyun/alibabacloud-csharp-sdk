// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendAsyncChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>The body of the user message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample content</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The message type. Valid values: Text and Markdown.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Text</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>作为本轮上下文引用的消息或文件条目</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("contextItems")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestContextItems> ContextItems { get; set; }
        public class SendAsyncChatMessageRequestContextItems : TeaModel {
            /// <summary>
            /// <para>用户对引用内容的批注</para>
            /// 
            /// <b>Example:</b>
            /// <para>请核对华东区数据</para>
            /// </summary>
            [NameInMap("annotation")]
            [Validation(Required=false)]
            public string Annotation { get; set; }

            /// <summary>
            /// <para>批注关联的文件列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("annotationFiles")]
            [Validation(Required=false)]
            public List<SendAsyncChatMessageRequestContextItemsAnnotationFiles> AnnotationFiles { get; set; }
            public class SendAsyncChatMessageRequestContextItemsAnnotationFiles : TeaModel {
                /// <summary>
                /// <para>文件名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>补充说明.pdf</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>文件公开访问地址</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/public/file">https://example.com/public/file</a></para>
                /// </summary>
                [NameInMap("filePublicUrl")]
                [Validation(Required=false)]
                public string FilePublicUrl { get; set; }

                /// <summary>
                /// <para>文件记录 ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleFileRecordId</para>
                /// </summary>
                [NameInMap("fileRecordId")]
                [Validation(Required=false)]
                public string FileRecordId { get; set; }

                /// <summary>
                /// <para>文件内部访问地址</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/file">https://example.com/file</a></para>
                /// </summary>
                [NameInMap("fileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            /// <summary>
            /// <para>被引用内容正文</para>
            /// 
            /// <b>Example:</b>
            /// <para>本月销售收入</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>被引用文件 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileId</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>被引用文件名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售数据.xlsx</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>被引用文件类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlsx</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>被引用消息 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleMessageId</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>消息发送者名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售助手</para>
            /// </summary>
            [NameInMap("senderName")]
            [Validation(Required=false)]
            public string SenderName { get; set; }

            /// <summary>
            /// <para>上下文条目类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>message_annotation</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of digital employee names. For compatibility with the legacy format, a single string can also be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct connection mode. If set to true, regular scenario routing is skipped and the direct conversation scenario is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("directChat")]
        [Validation(Required=false)]
        public bool? DirectChat { get; set; }

        /// <summary>
        /// <para>本轮携带的最近完整 direct 问答轮数，不含本轮输入。仅 workMode=direct 或 directChat=true 时生效。有效值为 0–100 的 JSON 整数，省略时由后端按 0 处理，不携带历史但仍保存当前轮。null、布尔值、字符串、小数及越界值按原 direct 路径处理，网关保留原始值供后端判定。work/ask 忽略此字段。该参数不限制转换为 work 时的历史范围</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("directMaxHistoryRounds")]
        [Validation(Required=false)]
        public object DirectMaxHistoryRounds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable web search. Default value: false. In the task execution scenario where taskExecution is passed, the task configuration prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableWebSearch")]
        [Validation(Required=false)]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// <para>The list of file references. Each item is an object, and the fileId parameter is required. The fileId is returned by the uploadChatFile operation.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestFiles> Files { get; set; }
        public class SendAsyncChatMessageRequestFiles : TeaModel {
            /// <summary>
            /// <para>The file ID, which is returned by the uploadChatFile operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileId</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>本轮语言，可选 zh-CN、en-US，用于接口错误文案并透传给 CodeAgent；省略时沿用当前语言行为，不修改用户设置</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        /// <summary>
        /// <para>The abstract model tier. Valid values: quick, standard, and flagship. If not specified, standard is used for new sessions, and the current tier is retained for existing sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse the most recent session under the digital employee when sessionId is not specified. This is typically used in CLI scenarios. Default value: false, which means a new session is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reuseLastSession")]
        [Validation(Required=false)]
        public bool? ReuseLastSession { get; set; }

        /// <summary>
        /// <para>消息中的结构化片段，例如会话或对象提及</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestSegments> Segments { get; set; }
        public class SendAsyncChatMessageRequestSegments : TeaModel {
            /// <summary>
            /// <para>片段展示内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>旧会话</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>提及对象类别</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversations</para>
            /// </summary>
            [NameInMap("mentionType")]
            [Validation(Required=false)]
            public string MentionType { get; set; }

            /// <summary>
            /// <para>被引用对象名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>旧会话</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>被引用对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>被引用对象类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversation</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>会话类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>personal</para>
            /// </summary>
            [NameInMap("sessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>片段类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>mention</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The session ID. If not specified, a new session is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use streaming generation. This operation always generates backend content in streaming mode and writes it to the message stream. The value of this parameter does not change the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The task execution metadata returned by the executeScheduledTask operation. If passed, the request is processed through the task execution pipeline.</para>
        /// </summary>
        [NameInMap("taskExecution")]
        [Validation(Required=false)]
        public SendAsyncChatMessageRequestTaskExecution TaskExecution { get; set; }
        public class SendAsyncChatMessageRequestTaskExecution : TeaModel {
            /// <summary>
            /// <para>The billing ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleBillingId</para>
            /// </summary>
            [NameInMap("billingId")]
            [Validation(Required=false)]
            public string BillingId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable web search.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableWebSearch")]
            [Validation(Required=false)]
            public bool? EnableWebSearch { get; set; }

            /// <summary>
            /// <para>The execution record ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleExecutionId</para>
            /// </summary>
            [NameInMap("executionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }

            /// <summary>
            /// <para>The name of the digital employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("operatingObjectName")]
            [Validation(Required=false)]
            public string OperatingObjectName { get; set; }

            /// <summary>
            /// <para>The list of associated skill codes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCodes")]
            [Validation(Required=false)]
            public List<string> SkillCodes { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleTaskId</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task understanding content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("taskUnderstand")]
            [Validation(Required=false)]
            public string TaskUnderstand { get; set; }

            /// <summary>
            /// <para>The ID of the tenant to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleUserId</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The session work mode. Valid values: ask (quick Q&amp;A, which trims tools, skills, and connectors for single-turn direct answers), work (deep work, default), and direct (direct connection mode at the request level, which does not start a sandbox and prevents context pollution, equivalent to directChat=true). The ask and work modes are session-level. The mode is fixed when a new session is created and inherited by default in subsequent chats. If the explicitly passed value is inconsistent with the session mode, a parameter error is returned. To switch modes, create a new session or fork the current one. If ask is passed in multi-digital-employee or task execution scenarios, it takes effect as work. This parameter is ignored when directChat is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("workMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
