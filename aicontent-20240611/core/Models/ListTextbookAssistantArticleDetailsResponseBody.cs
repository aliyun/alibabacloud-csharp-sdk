// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticleDetailsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantArticleDetailsResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantArticleDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0c05700d4d9411efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("articleId")]
            [Validation(Required=false)]
            public string ArticleId { get; set; }

            [NameInMap("questionList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList> QuestionList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>I\&quot;m Mike Black</para>
                /// </summary>
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                [NameInMap("questionTranslate")]
                [Validation(Required=false)]
                public string QuestionTranslate { get; set; }

            }

            [NameInMap("sceneList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataSceneList> SceneList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataSceneList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>In the park, you introduce yourself to John and ask his name.</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>38cddd70509911efbe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("sceneImageList")]
                [Validation(Required=false)]
                public List<string> SceneImageList { get; set; }

                [NameInMap("sceneTransLate")]
                [Validation(Required=false)]
                public string SceneTransLate { get; set; }

            }

            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList> SentenceList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList : TeaModel {
                [NameInMap("sentenceAnalysis")]
                [Validation(Required=false)]
                public string SentenceAnalysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4de677d2509811efbe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public string SentenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>I\&quot;m Mike Black</para>
                /// </summary>
                [NameInMap("sentenceText")]
                [Validation(Required=false)]
                public string SentenceText { get; set; }

            }

            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            [NameInMap("theme")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTheme Theme { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTheme : TeaModel {
                [NameInMap("themeImageList")]
                [Validation(Required=false)]
                public List<string> ThemeImageList { get; set; }

                [NameInMap("themeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Self-awareness, self-management, self-improvement</para>
                /// </summary>
                [NameInMap("themeTranslate")]
                [Validation(Required=false)]
                public string ThemeTranslate { get; set; }

            }

            [NameInMap("topic")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTopic Topic { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTopic : TeaModel {
                [NameInMap("topicImageList")]
                [Validation(Required=false)]
                public List<string> TopicImageList { get; set; }

                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Greetings and self-introduction</para>
                /// </summary>
                [NameInMap("topicTranslate")]
                [Validation(Required=false)]
                public string TopicTranslate { get; set; }

            }

            [NameInMap("wordList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataWordList> WordList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataWordList : TeaModel {
                [NameInMap("wordAnalysis")]
                [Validation(Required=false)]
                public string WordAnalysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a94df134ed8c11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("wordId")]
                [Validation(Required=false)]
                public string WordId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nice</para>
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
