// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticleDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTextbookAssistantArticleDetailsResponseBodyData> Data { get; set; }
        public class ListTextbookAssistantArticleDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The article ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c05700d4d9411efbe6e0c42a106bb02</para>
            /// </summary>
            [NameInMap("articleId")]
            [Validation(Required=false)]
            public string ArticleId { get; set; }

            /// <summary>
            /// <para>The question and answer data.</para>
            /// </summary>
            [NameInMap("questionList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList> QuestionList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList : TeaModel {
                /// <summary>
                /// <para>The answer to the question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I\&quot;m Mike Black</para>
                /// </summary>
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>The question content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <para>The translation of the question content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>According to the article, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("questionTranslate")]
                [Validation(Required=false)]
                public string QuestionTranslate { get; set; }

            }

            /// <summary>
            /// <para>The scene list.</para>
            /// </summary>
            [NameInMap("sceneList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataSceneList> SceneList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataSceneList : TeaModel {
                /// <summary>
                /// <para>The scene description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>In the park, you introduce yourself to John and ask his name.</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The scene ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38cddd70509911efbe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                /// <summary>
                /// <para>The images related to the current scene.</para>
                /// </summary>
                [NameInMap("sceneImageList")]
                [Validation(Required=false)]
                public List<string> SceneImageList { get; set; }

                /// <summary>
                /// <para>The translation of the scene description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>At a cafe, share the story of how you met your friends</para>
                /// </summary>
                [NameInMap("sceneTranslate")]
                [Validation(Required=false)]
                public string SceneTranslate { get; set; }

            }

            /// <summary>
            /// <para>The sentence list.</para>
            /// </summary>
            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList> SentenceList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList : TeaModel {
                /// <summary>
                /// <para>The sentence analysis and explanation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Subject + be verb (am/is/are) + name</para>
                /// </summary>
                [NameInMap("sentenceAnalysis")]
                [Validation(Required=false)]
                public string SentenceAnalysis { get; set; }

                /// <summary>
                /// <para>The sentence ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4de677d2509811efbe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("sentenceId")]
                [Validation(Required=false)]
                public string SentenceId { get; set; }

                /// <summary>
                /// <para>The sentence text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I\&quot;m Mike Black</para>
                /// </summary>
                [NameInMap("sentenceText")]
                [Validation(Required=false)]
                public string SentenceText { get; set; }

            }

            /// <summary>
            /// <para>The practice objective.</para>
            /// 
            /// <b>Example:</b>
            /// <ol>
            /// <item><description>Be able to use the sentence pattern &quot;What\&quot;s your name? My name is/I\&quot;m...&quot; to ask and answer during self-introductions.\n2. Be able to use the sentence pattern &quot;Nice to meet you (too).&quot; to greet new friends</description></item>
            /// </ol>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The theme information.</para>
            /// </summary>
            [NameInMap("theme")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTheme Theme { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTheme : TeaModel {
                /// <summary>
                /// <para>The images related to the current theme.</para>
                /// </summary>
                [NameInMap("themeImageList")]
                [Validation(Required=false)]
                public List<string> ThemeImageList { get; set; }

                /// <summary>
                /// <para>The theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Self-awareness and improvement</para>
                /// </summary>
                [NameInMap("themeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

                /// <summary>
                /// <para>The translation of the theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Self-awareness, self-management, self-improvement</para>
                /// </summary>
                [NameInMap("themeTranslate")]
                [Validation(Required=false)]
                public string ThemeTranslate { get; set; }

            }

            /// <summary>
            /// <para>The topic information.</para>
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTopic Topic { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTopic : TeaModel {
                /// <summary>
                /// <para>The images related to the current topic.</para>
                /// </summary>
                [NameInMap("topicImageList")]
                [Validation(Required=false)]
                public List<string> TopicImageList { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Greetings and self-introductions</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>The translation of the topic content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Greetings and self-introduction</para>
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
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataWordList> WordList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataWordList : TeaModel {
                /// <summary>
                /// <para>The word definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pleasant; friendly</para>
                /// </summary>
                [NameInMap("wordAnalysis")]
                [Validation(Required=false)]
                public string WordAnalysis { get; set; }

                /// <summary>
                /// <para>The word ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a94df134ed8c11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("wordId")]
                [Validation(Required=false)]
                public string WordId { get; set; }

                /// <summary>
                /// <para>The word text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nice</para>
                /// </summary>
                [NameInMap("wordText")]
                [Validation(Required=false)]
                public string WordText { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unknown error</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failed.</para>
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
