// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherExpansionDialogueTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The conversation background description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In this dialogue, you will be playing the role of Lily, a young girl. I will be Jane, Lily\&quot;s mother. We are in the kitchen, where I am preparing dinner. I am asking you about your food preferences, specifically if you like meat, fish, and milk. You like meat and milk, but you don\&quot;t like fish because of its smell. I explain to you the nutritional benefits of these foods and suggest alternatives for the ones you don\&quot;t like. Finally, I invite you to start eating.</para>
        /// </summary>
        [NameInMap("background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// <para>The collection of conversation task content.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueTranslateRequestDialogueTasks> DialogueTasks { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestDialogueTasks : TeaModel {
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
        /// <para>The collection of conversation records.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueTranslateRequestRecords> Records { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestRecords : TeaModel {
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
            /// <para>Specifies whether the content is off-topic and includes flow control. This parameter reflects whether the student\&quot;s response meets the settings of the conversation task. The value of this parameter is derived from the return results of previous conversation turns. In addition, this parameter serves the purpose of flow control. If the content is off-topic more than twice, the value is forcibly set to true to force a task switch. Valid values:</para>
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
            /// <para>Specifies whether the content is on-topic. Valid values:</para>
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
        /// <para>The role settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleInfo")]
        [Validation(Required=false)]
        public ExecuteAITeacherExpansionDialogueTranslateRequestRoleInfo RoleInfo { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestRoleInfo : TeaModel {
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
        /// <para>The opening remark.</para>
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
        /// <para>talk about food.</para>
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
