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
