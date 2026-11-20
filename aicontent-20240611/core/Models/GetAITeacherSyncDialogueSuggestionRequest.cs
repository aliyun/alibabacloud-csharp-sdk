// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetAITeacherSyncDialogueSuggestionRequest : TeaModel {
        /// <summary>
        /// <para>The collection of conversation task content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<GetAITeacherSyncDialogueSuggestionRequestDialogueTasks> DialogueTasks { get; set; }
        public class GetAITeacherSyncDialogueSuggestionRequestDialogueTasks : TeaModel {
            /// <summary>
            /// <para>The AI conversation content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why might some people think dog walking is a great job?</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The translation of the AI conversation content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why do some people think walking dogs is a good job?</para>
            /// </summary>
            [NameInMap("assistantTranslate")]
            [Validation(Required=false)]
            public string AssistantTranslate { get; set; }

            /// <summary>
            /// <para>The sequence number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The user conversation content.</para>
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
        /// <para>The collection of conversation records.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetAITeacherSyncDialogueSuggestionRequestRecords> Records { get; set; }
        public class GetAITeacherSyncDialogueSuggestionRequestRecords : TeaModel {
            /// <summary>
            /// <para>The conversation content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask Mark if he has thought about what his dream job might be.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Specifies whether the response is off-topic and applies flow control. This parameter indicates whether the student\&quot;s response aligns with the conversation task settings. The value is derived from the return results of previous conversation turns. Additionally, this parameter controls the conversation flow. If the response is off-topic more than twice, the value is forcibly set to true to switch the task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Off-topic.</description></item>
            /// <item><description>false: On-topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Specifies whether the response is on-topic.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: On-topic.</description></item>
            /// <item><description>false: Off-topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOnTopic")]
            [Validation(Required=false)]
            public bool? IsOnTopic { get; set; }

            /// <summary>
            /// <para>The sequence number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The role.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI: assistant; User: user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The user ID.</para>
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
