// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateRunRequest : TeaModel {
        [NameInMap("allowStructViewContent")]
        [Validation(Required=false)]
        public bool? AllowStructViewContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistantId1</para>
        /// </summary>
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        [NameInMap("extLoginUser")]
        [Validation(Required=false)]
        public CreateRunRequestExtLoginUser ExtLoginUser { get; set; }
        public class CreateRunRequestExtLoginUser : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mozi</para>
            /// </summary>
            [NameInMap("extLoginUserDomain")]
            [Validation(Required=false)]
            public string ExtLoginUserDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>outeruserId123</para>
            /// </summary>
            [NameInMap("extLoginUserId")]
            [Validation(Required=false)]
            public string ExtLoginUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>外部游客1</para>
            /// </summary>
            [NameInMap("extLoginUserName")]
            [Validation(Required=false)]
            public string ExtLoginUserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>assistantId</para>
        /// </summary>
        [NameInMap("originalAssistantId")]
        [Validation(Required=false)]
        public string OriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agentKey1</para>
        /// </summary>
        [NameInMap("sourceIdOfOriginalAssistantId")]
        [Validation(Required=false)]
        public string SourceIdOfOriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sourceTypeOfOriginalAssistantId")]
        [Validation(Required=false)]
        public string SourceTypeOfOriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
