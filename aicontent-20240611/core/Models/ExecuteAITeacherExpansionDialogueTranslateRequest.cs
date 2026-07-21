// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherExpansionDialogueTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The background context for the dialogue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>In this dialogue, you will be playing the role of Lily, a young girl. I will be Jane, Lily\&quot;s mother. We are in the kitchen, where I am preparing dinner. I am asking you about your food preferences, specifically if you like meat, fish, and milk. You like meat and milk, but you don\&quot;t like fish because of its smell. I explain to you the nutritional benefits of these foods and suggest alternatives for the ones you don\&quot;t like. Finally, I invite you to start eating.</para>
        /// </summary>
        [NameInMap("background")]
        [Validation(Required=false)]
        public string Background { get; set; }

        /// <summary>
        /// <para>An array of dialogue tasks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dialogueTasks")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueTranslateRequestDialogueTasks> DialogueTasks { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestDialogueTasks : TeaModel {
            /// <summary>
            /// <para>The dialogue content from the assistant.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Why might some people think dog walking is a great job?</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The translation of the assistant content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>为什么有些人认为遛狗是份好差事?</para>
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
            /// <para>The dialogue content from the user.</para>
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
        /// <para>An array of dialogue records.</para>
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ExecuteAITeacherExpansionDialogueTranslateRequestRecords> Records { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestRecords : TeaModel {
            /// <summary>
            /// <para>The dialogue content.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ask Mark if he has thought about what his dream job might be.</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Controls the conversation flow based on whether the user\&quot;s response is off-topic. This value is determined by previous turns. If a user provides more than two consecutive off-topic responses, the system sets this parameter to <c>true</c> to switch tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>跑题：true, 不跑题：false</para>
            /// </summary>
            [NameInMap("isOffTopicControl")]
            [Validation(Required=false)]
            public bool? IsOffTopicControl { get; set; }

            /// <summary>
            /// <para>Indicates whether the message is on-topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>扣题：true, 不扣题：false</para>
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
            /// <para>The role of the message author. Valid values are <c>assistant</c> for the AI and <c>user</c> for the user.</para>
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
        /// <para>Role information for the participants.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("roleInfo")]
        [Validation(Required=false)]
        public ExecuteAITeacherExpansionDialogueTranslateRequestRoleInfo RoleInfo { get; set; }
        public class ExecuteAITeacherExpansionDialogueTranslateRequestRoleInfo : TeaModel {
            /// <summary>
            /// <para>The assistant name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jane, a caring mother</para>
            /// </summary>
            [NameInMap("assistant")]
            [Validation(Required=false)]
            public string Assistant { get; set; }

            /// <summary>
            /// <para>The user name.</para>
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
        /// <para>The opening sentence of the dialogue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello Lily, could you please come to the kitchen for a moment?</para>
        /// </summary>
        [NameInMap("startSentence")]
        [Validation(Required=false)]
        public string StartSentence { get; set; }

        /// <summary>
        /// <para>The topic of the conversation.</para>
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
