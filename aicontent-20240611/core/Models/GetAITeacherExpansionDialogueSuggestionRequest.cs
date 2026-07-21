// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class GetAITeacherExpansionDialogueSuggestionRequest : TeaModel {
        /// <summary>
        /// <para>The background of the conversation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In a career counseling session, we are going to discuss our dream jobs and the responsibilities associated with them. Alex, who dreams of becoming a professional travel blogger, will share the tasks and skills required for this role, while Jamie, aspiring to be a wildlife photographer, will outline the responsibilities and challenges of capturing nature\&quot;s moments. Both will explore how their interests align with the practical aspects of their chosen careers, discussing the potential for travel, creativity, and the impact of their work on society and the environment.</para>
        /// </summary>
        [NameInMap("background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// <para>An array of objects that define the dialogue tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<GetAITeacherExpansionDialogueSuggestionRequestDialogueTasks> DialogueTasks { get; set; }
        public class GetAITeacherExpansionDialogueSuggestionRequestDialogueTasks : TeaModel {
            /// <summary>
            /// <para>The content of the assistant\&quot;s dialogue.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why might some people think dog walking is a great job?</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The translated content of the assistant\&quot;s dialogue.</para>
            /// 
            /// <b>Example:</b>
            /// <para>为什么有些人认为遛狗是份好差事?</para>
            /// </summary>
            [NameInMap("assistantTranslate")]
            [Validation(Required=false)]
            public string AssistantTranslate { get; set; }

            /// <summary>
            /// <para>The sequence number of the task.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The content of the user\&quot;s dialogue.</para>
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
        /// <para>The language code, specified as a BCP 47 language tag. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>en-gb</para>
        /// </summary>
        [NameInMap("languageCode")]
        [Validation(Required=false)]
        public string LanguageCode { get; set; }

        /// <summary>
        /// <para>An array of dialogue records.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<GetAITeacherExpansionDialogueSuggestionRequestRecords> Records { get; set; }
        public class GetAITeacherExpansionDialogueSuggestionRequestRecords : TeaModel {
            /// <summary>
            /// <para>The content of the dialogue message.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask Mark if he has thought about what his dream job might be.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Indicates if the user\&quot;s response has gone off-topic. This parameter controls the conversation flow based on dialogue history. The system sets this parameter to <c>true</c> to switch tasks if the user goes off-topic more than twice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>跑题：true, 不跑题：false</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Indicates if the response is on topic.</para>
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
            /// <para>The role of the message author. Valid values:</para>
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
        /// <para>Contains information about the roles in the conversation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleInfo")]
        [Validation(Required=false)]
        public GetAITeacherExpansionDialogueSuggestionRequestRoleInfo RoleInfo { get; set; }
        public class GetAITeacherExpansionDialogueSuggestionRequestRoleInfo : TeaModel {
            /// <summary>
            /// <para>The name of the AI assistant.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alex</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jamie</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The opening sentence of the conversation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello Lily, could you please come to the kitchen for a moment?</para>
        /// </summary>
        [NameInMap("startSentence")]
        [Validation(Required=false)]
        public string StartSentence { get; set; }

        /// <summary>
        /// <para>The main topic of the conversation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Let\&quot;s talk about traffic rules.</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>A unique identifier for the end user, used for monitoring and abuse detection.</para>
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
