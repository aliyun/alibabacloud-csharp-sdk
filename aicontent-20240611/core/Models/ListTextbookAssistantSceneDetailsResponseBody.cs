// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantSceneDetailsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantSceneDetailsResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantSceneDetailsResponseBodyData : TeaModel {
            [NameInMap("roleList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataRoleList> RoleList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataRoleList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Carl, a curious boy</para>
                /// </summary>
                [NameInMap("introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                [NameInMap("introductionTranslate")]
                [Validation(Required=false)]
                public string IntroductionTranslate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Hi Noah, who is that in the photo?</para>
                /// </summary>
                [NameInMap("promoting")]
                [Validation(Required=false)]
                public string Promoting { get; set; }

                [NameInMap("promotingTranslate")]
                [Validation(Required=false)]
                public string PromotingTranslate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Carl</para>
                /// </summary>
                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Carl</para>
                /// </summary>
                [NameInMap("roleNameTranslate")]
                [Validation(Required=false)]
                public string RoleNameTranslate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("roleType")]
                [Validation(Required=false)]
                public string RoleType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>At school, Carl sees a photo and asks you about your family.</para>
            /// </summary>
            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>38c41b7b509911efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("sceneImageList")]
            [Validation(Required=false)]
            public List<string> SceneImageList { get; set; }

            [NameInMap("sceneTaskList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataSceneTaskList> SceneTaskList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataSceneTaskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Say that this is your dad\&quot;s brother.</para>
                /// </summary>
                [NameInMap("sceneTask")]
                [Validation(Required=false)]
                public string SceneTask { get; set; }

                [NameInMap("sceneTaskTranslate")]
                [Validation(Required=false)]
                public string SceneTaskTranslate { get; set; }

            }

            [NameInMap("sceneTranslate")]
            [Validation(Required=false)]
            public string SceneTranslate { get; set; }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataSentenceList> SentenceList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataSentenceList : TeaModel {
                [NameInMap("sentenceAnalysis")]
                [Validation(Required=false)]
                public string SentenceAnalysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a774c6d09c4511eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public string SentenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Is this your sister?</para>
                /// </summary>
                [NameInMap("sentenceText")]
                [Validation(Required=false)]
                public string SentenceText { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("theme")]
            [Validation(Required=false)]
            public ListTextbookAssistantSceneDetailsResponseBodyDataTheme Theme { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataTheme : TeaModel {
                [NameInMap("themeImageList")]
                [Validation(Required=false)]
                public List<string> ThemeImageList { get; set; }

                [NameInMap("themeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Family and family life</para>
                /// </summary>
                [NameInMap("themeTranslate")]
                [Validation(Required=false)]
                public string ThemeTranslate { get; set; }

            }

            [NameInMap("topic")]
            [Validation(Required=false)]
            public ListTextbookAssistantSceneDetailsResponseBodyDataTopic Topic { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataTopic : TeaModel {
                [NameInMap("topicImageList")]
                [Validation(Required=false)]
                public List<string> TopicImageList { get; set; }

                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Introducing family members</para>
                /// </summary>
                [NameInMap("topicTranslate")]
                [Validation(Required=false)]
                public string TopicTranslate { get; set; }

            }

            [NameInMap("wordList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantSceneDetailsResponseBodyDataWordList> WordList { get; set; }
            public class ListTextbookAssistantSceneDetailsResponseBodyDataWordList : TeaModel {
                [NameInMap("wordAnalysis")]
                [Validation(Required=false)]
                public string WordAnalysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a94c3337ed8c11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("wordId")]
                [Validation(Required=false)]
                public string WordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>family</para>
                /// </summary>
                [NameInMap("wordText")]
                [Validation(Required=false)]
                public string WordText { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
