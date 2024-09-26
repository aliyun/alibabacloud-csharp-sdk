// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ChatResponseBodyMessages> Messages { get; set; }
        public class ChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>KNOWLEDGE</para>
            /// </summary>
            [NameInMap("AnswerSource")]
            [Validation(Required=false)]
            public string AnswerSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            [NameInMap("Knowledge")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesKnowledge Knowledge { get; set; }
            public class ChatResponseBodyMessagesKnowledge : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>KnowledgeBase</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>735898</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("RelatedKnowledges")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                public class ChatResponseBodyMessagesKnowledgeRelatedKnowledges : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>735899</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public string KnowledgeId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.998</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("Recommends")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesRecommends> Recommends { get; set; }
            public class ChatResponseBodyMessagesRecommends : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>KNOWLEDGE</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4548</para>
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.46</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesText Text { get; set; }
            public class ChatResponseBodyMessagesText : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>BotFramework</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                [NameInMap("ArticleTitle")]
                [Validation(Required=false)]
                public string ArticleTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;sysToAgent&quot;: &quot;{\&quot;skillGroup\&quot;:\&quot;12\&quot;}&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public Dictionary<string, object> Commands { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                [NameInMap("DialogName")]
                [Validation(Required=false)]
                public string DialogName { get; set; }

                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                [NameInMap("ExternalFlags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExternalFlags { get; set; }

                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                [NameInMap("IntentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1410-c7a72a78.__city</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SSML</para>
                /// </summary>
                [NameInMap("ResponseType")]
                [Validation(Required=false)]
                public string ResponseType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Slots")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesTextSlots> Slots { get; set; }
                public class ChatResponseBodyMessagesTextSlots : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Hit")]
                    [Validation(Required=false)]
                    public bool? Hit { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("UserDefinedChatTitle")]
                [Validation(Required=false)]
                public string UserDefinedChatTitle { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("VoiceTitle")]
            [Validation(Required=false)]
            public string VoiceTitle { get; set; }

        }

        [NameInMap("QuerySegList")]
        [Validation(Required=false)]
        public List<string> QuerySegList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a6f216a0685c4c8baa0e8beb6d5ec6db</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
