// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the response message in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The list of messages.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ChatResponseBodyMessages> Messages { get; set; }
        public class ChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>The source of the recommended answer when AnswerType is Recommend.
            /// [_single.resp.200.props.Messages.items.AnswerSource.enum. INTENT_FAQ_CLARIFY]mixed clarification from FAQ and dialog flow</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE</para>
            /// </summary>
            [NameInMap("AnswerSource")]
            [Validation(Required=false)]
            public string AnswerSource { get; set; }

            /// <summary>
            /// <para>The type of this message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            /// <summary>
            /// <para>When AnswerType is Knowledge, this field contains the Knowledge object returned by the chatbot.</para>
            /// </summary>
            [NameInMap("Knowledge")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesKnowledge Knowledge { get; set; }
            public class ChatResponseBodyMessagesKnowledge : TeaModel {
                /// <summary>
                /// <para>Distinguishes the answer type.
                /// KnowledgeBase: knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KnowledgeBase</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>The knowledge category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The content of the hit question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取，请在首页搜索公积金提取，提交办事的表单</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The indicator of whether the answer is plain text or rich text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The hit statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金</para>
                /// </summary>
                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                /// <summary>
                /// <para>The ID of the hit question in the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>735898</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The list of related knowledge entries.</para>
                /// </summary>
                [NameInMap("RelatedKnowledges")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                public class ChatResponseBodyMessagesKnowledgeRelatedKnowledges : TeaModel {
                    /// <summary>
                    /// <para>The ID of the related knowledge entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>735899</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public string KnowledgeId { get; set; }

                    /// <summary>
                    /// <para>The title of the related knowledge entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>公积金查询</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>The score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.998</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The summary of the hit question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The title of the hit question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>The list of recommendations returned by the bot when AnswerType is Recommend.</para>
            /// </summary>
            [NameInMap("Recommends")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesRecommends> Recommends { get; set; }
            public class ChatResponseBodyMessagesRecommends : TeaModel {
                /// <summary>
                /// <para>The identifier of the clarification source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KNOWLEDGE</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>The knowledge ID for clarification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4548</para>
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

                /// <summary>
                /// <para>The score of the recommended content. This field has a value when AnswerSource is KNOWLEDGE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.46</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The clarification content, which can be an entity from knowledge graph Q&amp;A, a knowledge title from knowledge-based Q&amp;A, or a column value from table-based Q&amp;A.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test plain text</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>When AnswerType is Text, this field contains the Text object returned by the chatbot.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesText Text { get; set; }
            public class ChatResponseBodyMessagesText : TeaModel {
                /// <summary>
                /// <para>Distinguishes the answer type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BotFramework</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>When AnswerSource is MACHINE_READ, this field returns the title of the hit article.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ICP Filing 11
                /// [responses.200.schema.properties.Messages.items.properties.AnswerSource.enumValueTitles. INTENT_FAQ_CLARIFY]FAQ and dialog flow mixed clarification</para>
                /// </summary>
                [NameInMap("ArticleTitle")]
                [Validation(Required=false)]
                public string ArticleTitle { get; set; }

                /// <summary>
                /// <para>The instruction parameters, such as the skill group for a transfer-to-agent instruction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;sysToAgent&quot;: &quot;{\&quot;skillGroup\&quot;:\&quot;12\&quot;}&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public Dictionary<string, object> Commands { get; set; }

                /// <summary>
                /// <para>The content of the text message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Which location do you want to check the weather for?</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The indicator of whether the answer is plain text or rich text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>When AnswerSource is BotFramework, this field returns the dialog flow unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample_CheckWeather</para>
                /// </summary>
                [NameInMap("DialogName")]
                [Validation(Required=false)]
                public string DialogName { get; set; }

                /// <summary>
                /// <para>The pass-through parameters returned in this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;MATCHED_INTENT_SOURCE&quot;: &quot;&quot;,
                ///     &quot;INTENT_ID&quot;: 724414,
                ///     &quot;IntentName&quot;: &quot;CheckWeatherIntent&quot;,
                ///     &quot;INTENT_DETAIL&quot;: &quot;[I want|I need to] check the weather&quot;,
                ///     &quot;LGF_EXPRESSION&quot;: &quot;[I want|I need to] check the weather&quot;,
                ///     &quot;IS_SESSION_FINISHED&quot;: false,
                ///     &quot;DsScore&quot;: 100.0,
                ///     &quot;DIALOG_ID&quot;: &quot;299034&quot;,
                ///     &quot;FINISH_LABEL&quot;: false,
                ///     &quot;MODULE_START&quot;: false,
                ///     &quot;INTENT_NAME&quot;: &quot;CheckWeatherIntent&quot;,
                ///     &quot;INTENT_SOURCE&quot;: &quot;Lgf&quot;,
                ///     &quot;DIALOG_NAME&quot;: &quot;Sample_CheckWeather&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>The pass-through parameters returned when AnswerSource is BotFramework.</para>
                /// </summary>
                [NameInMap("ExternalFlags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExternalFlags { get; set; }

                /// <summary>
                /// <para>The hit statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CheckWeather</para>
                /// </summary>
                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                /// <summary>
                /// <para>When AnswerSource is BotFramework, this field returns the intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CheckWeatherIntent</para>
                /// </summary>
                [NameInMap("IntentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>The metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[[{&quot;columnName&quot;:&quot;Name&quot;,&quot;stringValue&quot;:&quot;Wang Shanshan&quot;}]]</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                /// <summary>
                /// <para>The node ID returned when AnswerSource is BotFramework.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1410-c7a72a78.__city</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>When AnswerSource is BotFramework, this field returns the node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample_CheckWeather.CheckWeatherSlotFilling.__city</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>When AnswerSource is BotFramework and ResponseType is SSML, this field indicates that a dialog flow interactive slot filling is hit. Otherwise, this field does not exist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SSML</para>
                /// </summary>
                [NameInMap("ResponseType")]
                [Validation(Required=false)]
                public string ResponseType { get; set; }

                /// <summary>
                /// <para>The score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>When AnswerSource is BotFramework, this field returns the list of named entities.</para>
                /// </summary>
                [NameInMap("Slots")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesTextSlots> Slots { get; set; }
                public class ChatResponseBodyMessagesTextSlots : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the slot is hit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Hit")]
                    [Validation(Required=false)]
                    public bool? Hit { get; set; }

                    /// <summary>
                    /// <para>The name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CheckWeatherIntent.city</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The original value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing</para>
                    /// </summary>
                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    /// <summary>
                    /// <para>The specific value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The title of the custom chitchat topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Greeting</para>
                /// </summary>
                [NameInMap("UserDefinedChatTitle")]
                [Validation(Required=false)]
                public string UserDefinedChatTitle { get; set; }

            }

            /// <summary>
            /// <para>The counter-question title in online scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Which insurance age range are you inquiring about?</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The clarification content in voice scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Are you asking about provident fund inquiry or provident fund withdrawal?</para>
            /// </summary>
            [NameInMap("VoiceTitle")]
            [Validation(Required=false)]
            public string VoiceTitle { get; set; }

        }

        /// <summary>
        /// <para>The tokenization results of the query, which may be empty.</para>
        /// </summary>
        [NameInMap("QuerySegList")]
        [Validation(Required=false)]
        public List<string> QuerySegList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a6f216a0685c4c8baa0e8beb6d5ec6db</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
