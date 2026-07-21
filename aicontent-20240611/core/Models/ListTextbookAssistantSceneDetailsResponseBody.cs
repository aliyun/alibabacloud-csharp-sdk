// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantSceneDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantSceneDetailsResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantSceneDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of roles in the scene.</para>
            /// </summary>
            [NameInMap("roleList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataRoleList> RoleList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataRoleList : TeaModel {
                /// <summary>
                /// <para>The role introduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Carl, a curious boy</para>
                /// </summary>
                [NameInMap("introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                /// <summary>
                /// <para>The translation of the role introduction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Carl，一个好奇的男孩</para>
                /// </summary>
                [NameInMap("introductionTranslate")]
                [Validation(Required=false)]
                public string IntroductionTranslate { get; set; }

                /// <summary>
                /// <para>The role guidance text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hi Noah, who is that in the photo?</para>
                /// </summary>
                [NameInMap("promoting")]
                [Validation(Required=false)]
                public string Promoting { get; set; }

                /// <summary>
                /// <para>The translation of the role guidance text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>嗨 Noah，照片里的人是谁？</para>
                /// </summary>
                [NameInMap("promotingTranslate")]
                [Validation(Required=false)]
                public string PromotingTranslate { get; set; }

                /// <summary>
                /// <para>The role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Carl</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <para>The translation of the role name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Carl</para>
                /// </summary>
                [NameInMap("roleNameTranslate")]
                [Validation(Required=false)]
                public string RoleNameTranslate { get; set; }

                /// <summary>
                /// <para>The role type:</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("roleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

            }

            /// <summary>
            /// <para>The scene description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>At school, Carl sees a photo and asks you about your family.</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38c41b7b509911efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <para>A list of image URLs related to the current scene.</para>
            /// </summary>
            [NameInMap("sceneImageList")]
            [Validation(Required=false)]
            public List<string> SceneImageList { get; set; }

            /// <summary>
            /// <para>The scene task list.</para>
            /// </summary>
            [NameInMap("sceneTaskList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataSceneTaskList> SceneTaskList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataSceneTaskList : TeaModel {
                /// <summary>
                /// <para>The scene task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Say that this is your dad\&quot;s brother.</para>
                /// </summary>
                [NameInMap("sceneTask")]
                [Validation(Required=false)]
                public string SceneTask { get; set; }

                /// <summary>
                /// <para>The translation of the scene task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>说这是你爸爸的兄弟。</para>
                /// </summary>
                [NameInMap("sceneTaskTranslate")]
                [Validation(Required=false)]
                public string SceneTaskTranslate { get; set; }

            }

            /// <summary>
            /// <para>The translation of the scene description.</para>
            /// </summary>
            [NameInMap("sceneTranslate")]
            [Validation(Required=false)]
            public string SceneTranslate { get; set; }

            /// <summary>
            /// <para>The sentence list.</para>
            /// </summary>
            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataSentenceList> SentenceList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataSentenceList : TeaModel {
                /// <summary>
                /// <para>The sentence analysis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Is + this + your + 家庭成员?</para>
                /// </summary>
                [NameInMap("sentenceAnalysis")]
                [Validation(Required=false)]
                public string SentenceAnalysis { get; set; }

                /// <summary>
                /// <para>The sentence ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a774c6d09c4511eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public string SentenceId { get; set; }

                /// <summary>
                /// <para>The sentence text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Is this your sister?</para>
                /// </summary>
                [NameInMap("sentenceText")]
                [Validation(Required=false)]
                public string SentenceText { get; set; }

            }

            /// <summary>
            /// <para>The practice target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The theme details.</para>
            /// </summary>
            [NameInMap("theme")]
            [Validation(Required=false)]
            public ListTextbookAssistantSceneDetailsResponseBodyDataTheme Theme { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataTheme : TeaModel {
                /// <summary>
                /// <para>A list of image URLs related to the theme.</para>
                /// </summary>
                [NameInMap("themeImageList")]
                [Validation(Required=false)]
                public List<string> ThemeImageList { get; set; }

                /// <summary>
                /// <para>The theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>家庭生活</para>
                /// </summary>
                [NameInMap("themeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

                /// <summary>
                /// <para>The translation of the theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Family and family life</para>
                /// </summary>
                [NameInMap("themeTranslate")]
                [Validation(Required=false)]
                public string ThemeTranslate { get; set; }

            }

            /// <summary>
            /// <para>The topic details.</para>
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public ListTextbookAssistantSceneDetailsResponseBodyDataTopic Topic { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataTopic : TeaModel {
                /// <summary>
                /// <para>A list of image URLs related to the topic.</para>
                /// </summary>
                [NameInMap("topicImageList")]
                [Validation(Required=false)]
                public List<string> TopicImageList { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>介绍家人</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>The translation of the topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Introducing family members</para>
                /// </summary>
                [NameInMap("topicTranslate")]
                [Validation(Required=false)]
                public string TopicTranslate { get; set; }

            }

            /// <summary>
            /// <para>The word list.</para>
            /// </summary>
            [NameInMap("wordList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataWordList> WordList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataWordList : TeaModel {
                /// <summary>
                /// <para>The word definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>家；家庭</para>
                /// </summary>
                [NameInMap("wordAnalysis")]
                [Validation(Required=false)]
                public string WordAnalysis { get; set; }

                /// <summary>
                /// <para>The word ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a94c3337ed8c11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("wordId")]
                [Validation(Required=false)]
                public string WordId { get; set; }

                /// <summary>
                /// <para>The word text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>family</para>
                /// </summary>
                [NameInMap("wordText")]
                [Validation(Required=false)]
                public string WordText { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
