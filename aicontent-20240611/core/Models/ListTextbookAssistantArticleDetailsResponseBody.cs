// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantArticleDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of article detail objects.</para>
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
            /// <para>A list of Q\&amp;A objects.</para>
            /// </summary>
            [NameInMap("questionList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList> QuestionList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataQuestionList : TeaModel {
                /// <summary>
                /// <para>The answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>I\&quot;m Mike Black</para>
                /// </summary>
                [NameInMap("answer")]
                [Validation(Required=false)]
                public string Answer { get; set; }

                /// <summary>
                /// <para>The question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <para>The translated question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>根据文章，迈克·布莱克是如何介绍自己的？</para>
                /// </summary>
                [NameInMap("questionTranslate")]
                [Validation(Required=false)]
                public string QuestionTranslate { get; set; }

            }

            /// <summary>
            /// <para>A list of scene objects.</para>
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
                /// <para>A list of image URLs for the scene.</para>
                /// </summary>
                [NameInMap("sceneImageList")]
                [Validation(Required=false)]
                public List<string> SceneImageList { get; set; }

                /// <summary>
                /// <para>The translated scene description.</para>
                /// </summary>
                [NameInMap("sceneTranslate")]
                [Validation(Required=false)]
                public string SceneTranslate { get; set; }

            }

            /// <summary>
            /// <para>A list of sentence objects.</para>
            /// </summary>
            [NameInMap("sentenceList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList> SentenceList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataSentenceList : TeaModel {
                /// <summary>
                /// <para>The sentence analysis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>主语 + be动词（am/is/are） + 姓名.</para>
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
            /// <para>The learning objectives.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.能够在自我介绍时运用句型“What\&quot;s your name? My name is/I‘m...”进行询问及回答。\n2.能够和新朋友运用句型“Nice to meet you(too).”进行问候。</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The theme object.</para>
            /// </summary>
            [NameInMap("theme")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTheme Theme { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTheme : TeaModel {
                /// <summary>
                /// <para>A list of image URLs for the theme.</para>
                /// </summary>
                [NameInMap("themeImageList")]
                [Validation(Required=false)]
                public List<string> ThemeImageList { get; set; }

                /// <summary>
                /// <para>The theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>自我认知与提升</para>
                /// </summary>
                [NameInMap("themeName")]
                [Validation(Required=false)]
                public string ThemeName { get; set; }

                /// <summary>
                /// <para>The translated theme name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Self-awareness, self-management, self-improvement</para>
                /// </summary>
                [NameInMap("themeTranslate")]
                [Validation(Required=false)]
                public string ThemeTranslate { get; set; }

            }

            /// <summary>
            /// <para>The topic object.</para>
            /// </summary>
            [NameInMap("topic")]
            [Validation(Required=false)]
            public ListTextbookAssistantArticleDetailsResponseBodyDataTopic Topic { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataTopic : TeaModel {
                /// <summary>
                /// <para>A list of image URLs for the topic.</para>
                /// </summary>
                [NameInMap("topicImageList")]
                [Validation(Required=false)]
                public List<string> TopicImageList { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>打招呼与自我介绍</para>
                /// </summary>
                [NameInMap("topicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                /// <summary>
                /// <para>The translated topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Greetings and self-introduction</para>
                /// </summary>
                [NameInMap("topicTranslate")]
                [Validation(Required=false)]
                public string TopicTranslate { get; set; }

            }

            /// <summary>
            /// <para>A list of word objects.</para>
            /// </summary>
            [NameInMap("wordList")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantArticleDetailsResponseBodyDataWordList> WordList { get; set; }
            public class ListTextbookAssistantArticleDetailsResponseBodyDataWordList : TeaModel {
                /// <summary>
                /// <para>The word analysis.</para>
                /// 
                /// <b>Example:</b>
                /// <para>令人愉快的；友好的</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Success</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failure</para>
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
