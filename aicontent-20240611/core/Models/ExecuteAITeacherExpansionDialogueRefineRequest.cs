// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherExpansionDialogueRefineRequest : TeaModel {
        /// <summary>
        /// <para>The conversation background description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In a career counseling session, we are going to discuss our dream jobs and the responsibilities associated with them. Alex, who dreams of becoming a professional travel blogger, will share the tasks and skills required for this role, while Jamie, aspiring to be a wildlife photographer, will outline the responsibilities and challenges of capturing nature\&quot;s moments. Both will explore how their interests align with the practical aspects of their chosen careers, discussing the potential for travel, creativity, and the impact of their work on society and the environment.</para>
        /// </summary>
        [NameInMap("background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// <para>The conversation task content collection.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueRefineRequestDialogueTasks> DialogueTasks { get; set; }
        public class ExecuteAITeacherExpansionDialogueRefineRequestDialogueTasks : TeaModel {
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
        /// <para>The conversation records.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueRefineRequestRecords> Records { get; set; }
        public class ExecuteAITeacherExpansionDialogueRefineRequestRecords : TeaModel {
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
            /// <para>Specifies whether the response is off topic and controls the conversation flow. This parameter indicates whether the student\&quot;s response meets the requirements of the conversation task. The value of this parameter is derived from the return results of previous conversation turns. Additionally, this parameter controls the conversation flow. If the response is off topic more than twice, the value is forcibly set to true to switch the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Off topic.</description></item>
            /// <item><description>false: On topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Specifies whether the response is on topic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: On topic.</description></item>
            /// <item><description>false: Off topic.</description></item>
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
        /// <para>The role settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleInfo")]
        [Validation(Required=false)]
        public ExecuteAITeacherExpansionDialogueRefineRequestRoleInfo RoleInfo { get; set; }
        public class ExecuteAITeacherExpansionDialogueRefineRequestRoleInfo : TeaModel {
            /// <summary>
            /// <para>The name of the AI.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jane, a caring mother</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The name of the user.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lily, a friendly student</para>
            /// </summary>
            [NameInMap("user")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The opening sentence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello Lily, could you please come to the kitchen for a moment?</para>
        /// </summary>
        [NameInMap("startSentence")]
        [Validation(Required=false)]
        public string StartSentence { get; set; }

        /// <summary>
        /// <para>The topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>talk about your dream job.</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

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
