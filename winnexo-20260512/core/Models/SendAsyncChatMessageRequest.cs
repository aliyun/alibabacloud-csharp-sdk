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
        /// <para>The message or file entries referenced as context for the current turn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("contextItems")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestContextItems> ContextItems { get; set; }
        public class SendAsyncChatMessageRequestContextItems : TeaModel {
            /// <summary>
            /// <para>The user\&quot;s annotation on the referenced content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please verify the data for the East China region</para>
            /// </summary>
            [NameInMap("annotation")]
            [Validation(Required=false)]
            public string Annotation { get; set; }

            /// <summary>
            /// <para>The list of files associated with the annotation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("annotationFiles")]
            [Validation(Required=false)]
            public List<SendAsyncChatMessageRequestContextItemsAnnotationFiles> AnnotationFiles { get; set; }
            public class SendAsyncChatMessageRequestContextItemsAnnotationFiles : TeaModel {
                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SupplementaryNotes.pdf</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The public access URL of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/public/file">https://example.com/public/file</a></para>
                /// </summary>
                [NameInMap("filePublicUrl")]
                [Validation(Required=false)]
                public string FilePublicUrl { get; set; }

                /// <summary>
                /// <para>The file record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exampleFileRecordId</para>
                /// </summary>
                [NameInMap("fileRecordId")]
                [Validation(Required=false)]
                public string FileRecordId { get; set; }

                /// <summary>
                /// <para>The internal access URL of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/file">https://example.com/file</a></para>
                /// </summary>
                [NameInMap("fileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

            }

            /// <summary>
            /// <para>The body of the referenced content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales revenue for this month</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the referenced file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileId</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The name of the referenced file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SalesData.xlsx</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The type of the referenced file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlsx</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>The ID of the referenced message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleMessageId</para>
            /// </summary>
            [NameInMap("messageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The name of the message sender.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sales Assistant</para>
            /// </summary>
            [NameInMap("senderName")]
            [Validation(Required=false)]
            public string SenderName { get; set; }

            /// <summary>
            /// <para>The context entry type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>message_annotation</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of digital employee names. For backward compatibility, a single string can also be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pcitc-magent&quot;]</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct connection mode. If set to true, regular scenario routing is skipped and the direct conversation scenario is entered directly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("directChat")]
        [Validation(Required=false)]
        public bool? DirectChat { get; set; }

        /// <summary>
        /// <para>The number of recent complete direct Q&amp;A rounds carried in the current turn, excluding the current input. This parameter takes effect only when workMode is set to direct or directChat is set to true. Valid values are JSON integers from 0 to 100. If omitted, the backend processes it as 0, carrying no history but still saving the current round. Null, Boolean, string, decimal, and out-of-bounds values are processed through the original direct path, and the gateway retains the original values for backend determination. This field is ignored in work and ask modes. This parameter does not limit the history range when switching to the work mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("directMaxHistoryRounds")]
        [Validation(Required=false)]
        public object DirectMaxHistoryRounds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable web search. Default value: false. In task execution scenarios where taskExecution is passed, the task configuration prevails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableWebSearch")]
        [Validation(Required=false)]
        public bool? EnableWebSearch { get; set; }

        /// <summary>
        /// <para>The list of file references. Each item is an object, and fileId is required, which is returned by uploadChatFile.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestFiles> Files { get; set; }
        public class SendAsyncChatMessageRequestFiles : TeaModel {
            /// <summary>
            /// <para>The file ID, which is returned by uploadChatFile.</para>
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
        /// <para>The language for the current turn. Valid values: zh-CN and en-US. This parameter is used for API error messages and passed through to CodeAgent. If omitted, the current language behavior is retained and user settings are not modified.</para>
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
        /// <para>Specifies whether to reuse the most recent session under the digital employee when sessionId is not provided, which applies to CLI scenarios. Default value: false, which means a new session is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reuseLastSession")]
        [Validation(Required=false)]
        public bool? ReuseLastSession { get; set; }

        /// <summary>
        /// <para>The structured segments in the message, such as session or object mentions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("segments")]
        [Validation(Required=false)]
        public List<SendAsyncChatMessageRequestSegments> Segments { get; set; }
        public class SendAsyncChatMessageRequestSegments : TeaModel {
            /// <summary>
            /// <para>The display content of the segment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Old session</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The category of the mentioned object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversations</para>
            /// </summary>
            [NameInMap("mentionType")]
            [Validation(Required=false)]
            public string MentionType { get; set; }

            /// <summary>
            /// <para>The name of the referenced object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Old session</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the referenced object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The referenced object type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conversation</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The session type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>personal</para>
            /// </summary>
            [NameInMap("sessionType")]
            [Validation(Required=false)]
            public string SessionType { get; set; }

            /// <summary>
            /// <para>The segment type.</para>
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
        /// <para>Specifies whether to use streaming generation. This API always generates background content in streaming mode and writes it to the message stream. The value does not change the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The task execution metadata returned by executeScheduledTask. If passed, the request is processed through the task execution pipeline.</para>
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
            /// <para>The digital employee name.</para>
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
            /// <para>[&quot;code&quot;]</para>
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
        /// <para>The session work mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ask: Quick Q&amp;A mode. Trims tools, skills, and connectors for single-turn direct answers.</description></item>
        /// <item><description>work: Deep work mode. This is the default value.</description></item>
        /// <item><description>direct: Direct connection mode at the request level. Does not start a sandbox and prevents context pollution. Equivalent to setting directChat to true.
        /// The ask and work modes are session-level. Once selected during session creation, the mode is fixed and inherited by default in subsequent chats. If the explicitly passed value conflicts with the session mode, a parameter error is returned. To switch modes, create a new session or fork the current one. In scenarios with multiple digital employees or task execution, passing ask takes effect as work. This parameter is ignored when directChat is set to true.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("workMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
