// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendChatMessageRequest : TeaModel {
        /// <summary>
        /// <para>The message body from the user.</para>
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
        /// <para>The list of digital employee names. A single string can be passed for backward compatibility with the legacy format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("digitalEmployeeName")]
        [Validation(Required=false)]
        public List<string> DigitalEmployeeName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable direct connection mode. If set to true, the regular scenario routing is skipped and the direct conversation scenario is entered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("directChat")]
        [Validation(Required=false)]
        public bool? DirectChat { get; set; }

        /// <summary>
        /// <para>The list of file references. Each item is an object in which fileId is required and is returned by uploadChatFile.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<SendChatMessageRequestFiles> Files { get; set; }
        public class SendChatMessageRequestFiles : TeaModel {
            /// <summary>
            /// <para>The file ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleFileId</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The element type. Valid values: text, web_search, mention, and skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The abstract model tier. Valid values: quick, standard, and flagship. If not specified, new sessions use standard, and existing sessions retain the current session tier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quick</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>Specifies whether to reuse the most recent session of the digital employee when sessionId is not provided (CLI scenario). Default value: false, which creates a new session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("reuseLastSession")]
        [Validation(Required=false)]
        public bool? ReuseLastSession { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSessionId</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use streaming output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>The task execution metadata returned by executeScheduledTask. When provided, the request is processed through the task execution pipeline.</para>
        /// </summary>
        [NameInMap("taskExecution")]
        [Validation(Required=false)]
        public SendChatMessageRequestTaskExecution TaskExecution { get; set; }
        public class SendChatMessageRequestTaskExecution : TeaModel {
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
            /// <para>The tenant ID to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The user ID to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleUserId</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
