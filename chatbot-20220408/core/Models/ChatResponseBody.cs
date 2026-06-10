// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>A list of message objects.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ChatResponseBodyMessages> Messages { get; set; }
        public class ChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>Indicates the source of the recommended answer if <c>AnswerType</c> is <c>Recommend</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KNOWLEDGE</para>
            /// </summary>
            [NameInMap("AnswerSource")]
            [Validation(Required=false)]
            public string AnswerSource { get; set; }

            /// <summary>
            /// <para>Type of the message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            /// <summary>
            /// <para>Contains the <c>Knowledge</c> object if <c>AnswerType</c> is <c>Knowledge</c>.</para>
            /// </summary>
            [NameInMap("Knowledge")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesKnowledge Knowledge { get; set; }
            public class ChatResponseBodyMessagesKnowledge : TeaModel {
                /// <summary>
                /// <para>The source of the answer.
                /// <c>KnowledgeBase</c>: The answer is from the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KnowledgeBase</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>The category of the knowledge entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The content of the matched knowledge entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取，请在首页搜索公积金提取，提交办事的表单</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>Content format of the answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The hit statement matching the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金</para>
                /// </summary>
                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                /// <summary>
                /// <para>ID of the matched knowledge entry in the knowledge base.</para>
                /// 
                /// <b>Example:</b>
                /// <para>735898</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>A list of related knowledge objects.</para>
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
                /// <para>The confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.998</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>Summary of the matched knowledge entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取</para>
                /// </summary>
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                /// <summary>
                /// <para>The title of the matched knowledge entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>公积金提取</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Contains a list of <c>Recommend</c> objects if <c>AnswerType</c> is <c>Recommend</c>.</para>
            /// </summary>
            [NameInMap("Recommends")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesRecommends> Recommends { get; set; }
            public class ChatResponseBodyMessagesRecommends : TeaModel {
                /// <summary>
                /// <para>Source of the clarification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KNOWLEDGE</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>The knowledge ID for the clarification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4548</para>
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

                /// <summary>
                /// <para>The score of the recommended content. Returned only if <c>AnswerSource</c> is <c>KNOWLEDGE</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.46</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>Clarification content. This can be an entity from knowledge graph QA, a knowledge title from FAQ-based QA, or a column value from table QA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试纯文本</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>Contains the <c>Text</c> object if <c>AnswerType</c> is <c>Text</c>.</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesText Text { get; set; }
            public class ChatResponseBodyMessagesText : TeaModel {
                /// <summary>
                /// <para>The source of the answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BotFramework</para>
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// <para>Title of the matched article. Returned only if <c>AnswerSource</c> is <c>MACHINE_READ</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>备案十一</para>
                /// </summary>
                [NameInMap("ArticleTitle")]
                [Validation(Required=false)]
                public string ArticleTitle { get; set; }

                /// <summary>
                /// <para>Command parameters, such as the skill group for transferring to a human agent.</para>
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
                /// <para>请问您要查哪里的天气？</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The content format of the answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PLAIN_TEXT</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>Name of the dialog. Returned only if <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例_查天气</para>
                /// </summary>
                [NameInMap("DialogName")]
                [Validation(Required=false)]
                public string DialogName { get; set; }

                /// <summary>
                /// <para>Contains passthrough parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;MATCHED_INTENT_SOURCE&quot;: &quot;&quot;,
                ///     &quot;INTENT_ID&quot;: 724414,
                ///     &quot;IntentName&quot;: &quot;查天气意图&quot;,
                ///     &quot;INTENT_DETAIL&quot;: &quot;[我想|我要]查天气&quot;,
                ///     &quot;LGF_EXPRESSION&quot;: &quot;[我想|我要]查天气&quot;,
                ///     &quot;IS_SESSION_FINISHED&quot;: false,
                ///     &quot;DsScore&quot;: 100.0,
                ///     &quot;DIALOG_ID&quot;: &quot;299034&quot;,
                ///     &quot;FINISH_LABEL&quot;: false,
                ///     &quot;MODULE_START&quot;: false,
                ///     &quot;INTENT_NAME&quot;: &quot;查天气意图&quot;,
                ///     &quot;INTENT_SOURCE&quot;: &quot;Lgf&quot;,
                ///     &quot;DIALOG_NAME&quot;: &quot;示例_查天气&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// <para>Passthrough parameters. Returned only if <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// </summary>
                [NameInMap("ExternalFlags")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExternalFlags { get; set; }

                /// <summary>
                /// <para>The hit statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>查天气</para>
                /// </summary>
                [NameInMap("HitStatement")]
                [Validation(Required=false)]
                public string HitStatement { get; set; }

                /// <summary>
                /// <para>The name of the intent. This field is returned when <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>查天气意图</para>
                /// </summary>
                [NameInMap("IntentName")]
                [Validation(Required=false)]
                public string IntentName { get; set; }

                /// <summary>
                /// <para>Metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[[{\&quot;columnName\&quot;:\&quot;姓名\&quot;,\&quot;stringValue\&quot;:\&quot;王珊珊\&quot;}]]</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public string MetaData { get; set; }

                /// <summary>
                /// <para>The node ID. Returned only if <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1410-c7a72a78.__city</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node. This field is returned when <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例_查天气.查天气填槽.__city</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>A value of <c>SSML</c> indicates that an interactive slot-filling process has started in the dialog factory. This field is returned only if <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SSML</para>
                /// </summary>
                [NameInMap("ResponseType")]
                [Validation(Required=false)]
                public string ResponseType { get; set; }

                /// <summary>
                /// <para>The confidence score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.0</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>A list of slot objects. Returned only if <c>AnswerSource</c> is <c>BotFramework</c>.</para>
                /// </summary>
                [NameInMap("Slots")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesTextSlots> Slots { get; set; }
                public class ChatResponseBodyMessagesTextSlots : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the slot was filled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Hit")]
                    [Validation(Required=false)]
                    public bool? Hit { get; set; }

                    /// <summary>
                    /// <para>The name of the slot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>查天气意图.city</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The original value from the user\&quot;s input.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    /// <summary>
                    /// <para>Extracted value of the slot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The title of a custom chit-chat topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>问候</para>
                /// </summary>
                [NameInMap("UserDefinedChatTitle")]
                [Validation(Required=false)]
                public string UserDefinedChatTitle { get; set; }

            }

            /// <summary>
            /// <para>The title of the clarification question for text-based chat scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请问您想咨询的是哪个投保年龄区间呢？</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The clarification content for voice-based scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请问你说的是公积金查询，还是公积金提取</para>
            /// </summary>
            [NameInMap("VoiceTitle")]
            [Validation(Required=false)]
            public string VoiceTitle { get; set; }

        }

        /// <summary>
        /// <para>The words segmented from the query. This field may be empty.</para>
        /// </summary>
        [NameInMap("QuerySegList")]
        [Validation(Required=false)]
        public List<string> QuerySegList { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2315C4B-A872-5DEE-9DAD-D73B194A4AEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a6f216a0685c4c8baa0e8beb6d5ec6db</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
