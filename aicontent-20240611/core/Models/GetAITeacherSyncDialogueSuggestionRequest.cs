// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetAITeacherSyncDialogueSuggestionRequest : TeaModel {
        /// <summary>
        /// <para>A list of dialogue tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<GetAITeacherSyncDialogueSuggestionRequestDialogueTasks> DialogueTasks { get; set; }
        public class GetAITeacherSyncDialogueSuggestionRequestDialogueTasks : TeaModel {
            /// <summary>
            /// <para>The assistant\&quot;s message content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why might some people think dog walking is a great job?</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The translation of the assistant\&quot;s message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>为什么有些人认为遛狗是份好差事?</para>
            /// </summary>
            [NameInMap("assistantTranslate")]
            [Validation(Required=false)]
            public string AssistantTranslate { get; set; }

            /// <summary>
            /// <para>The sequence number of the dialogue task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The user\&quot;s message content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>They think it\&quot;s great because they won\&quot;t be stuck in an office.</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-gb</para>
        /// </summary>
        [NameInMap("languageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>A list of dialogue records.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetAITeacherSyncDialogueSuggestionRequestRecords> Records { get; set; }
        public class GetAITeacherSyncDialogueSuggestionRequestRecords : TeaModel {
            /// <summary>
            /// <para>The message content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask Mark if he has thought about what his dream job might be.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>A control flag that indicates if a student\&quot;s response is off-topic. The value is based on the previous turn. If the conversation goes off-topic more than twice, the system sets this value to <c>true</c> to force a task switch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>跑题：true, 不跑题：false</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Specifies if the message is on topic. <c>true</c> indicates the message is on topic; <c>false</c> indicates it is off topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扣题：true, 不扣题：false</para>
            /// </summary>
            [NameInMap("isOnTopic")]
            [Validation(Required=false)]
            public bool? IsOnTopic { get; set; }

            /// <summary>
            /// <para>The sequence number of the message in the conversation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The role of the message author. Valid values: <c>assistant</c> (for AI-generated messages) and <c>user</c> (for user-provided messages).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI：assistant；用户：user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier for the end-user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>886eba3702xxxxxxxxx4ba52a87a525</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
