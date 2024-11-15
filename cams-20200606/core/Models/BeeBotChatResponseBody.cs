// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotChatResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied for detailed information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The content of the text message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of the recommended knowledge. When AnswerType is set to Recommend, the list of the recommended knowledge is returned by the bot for this parameter.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotChatResponseBodyData Data { get; set; }
        public class BeeBotChatResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the recommended knowledge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ab6be8af-cee4-40c3-9919-2ac7461d7d98</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The source of the recommended answer. When AnswerType is set to Recommend, a value is returned for this parameter.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<BeeBotChatResponseBodyDataMessages> Messages { get; set; }
            public class BeeBotChatResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// <para>When AnswerType is Recommended, this field indicates the source of the recommended answer.</para>
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
                /// <para>When AnswerType is Knowledge, this field contains the Knowledge object returned by the robot.</para>
                /// </summary>
                [NameInMap("Knowledge")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesKnowledge Knowledge { get; set; }
                public class BeeBotChatResponseBodyDataMessagesKnowledge : TeaModel {
                    /// <summary>
                    /// <para>Distinguish answer types.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KnowledgeBase</para>
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// <para>Knowledge category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>provident fund.</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>Hit the content of the problem.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Provident fund withdrawal, please search for provident fund withdrawal on the homepage and submit the form for handling the matter.</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Indication of plain/rich text answers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PLAIN_TEXT</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>Hit statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>provident fund</para>
                    /// </summary>
                    [NameInMap("HitStatement")]
                    [Validation(Required=false)]
                    public string HitStatement { get; set; }

                    /// <summary>
                    /// <para>The ID of the hit problem in the knowledge base.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>735898</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Related knowledge list.</para>
                    /// </summary>
                    [NameInMap("RelatedKnowledges")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges : TeaModel {
                        /// <summary>
                        /// <para>The ID of knowledge associated with knowledge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>735899</para>
                        /// </summary>
                        [NameInMap("KnowledgeId")]
                        [Validation(Required=false)]
                        public string KnowledgeId { get; set; }

                        /// <summary>
                        /// <para>The title of related knowledge.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Withdrawal of housing provident fund.</para>
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <para>Introduction to hit problems.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Withdrawal of housing provident fund</para>
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// <para>Hit the title of the problem.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Withdrawal of housing provident fund.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>When AnswerType is Recommended, this field contains a list of Recommendations returned by the robot.</para>
                /// </summary>
                [NameInMap("Recommends")]
                [Validation(Required=false)]
                public List<BeeBotChatResponseBodyDataMessagesRecommends> Recommends { get; set; }
                public class BeeBotChatResponseBodyDataMessagesRecommends : TeaModel {
                    /// <summary>
                    /// <para>Clarify the identification of the source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KNOWLEDGE</para>
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// <para>Clarify the knowledge ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4548</para>
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public string KnowledgeId { get; set; }

                    /// <summary>
                    /// <para>Clarify the content, which may be the entities of graph Q&amp;A, the knowledge titles of knowledge Q&amp;A, or the column values of table Q&amp;A.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test plain text.</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <para>When AnswerType is Text, this field contains the Text object returned by the robot.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesText Text { get; set; }
                public class BeeBotChatResponseBodyDataMessagesText : TeaModel {
                    /// <summary>
                    /// <para>Distinguish answer types.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BotFramework</para>
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// <para>The content of the text message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>May I ask where you want to check the weather?</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>Indication of plain/rich text answers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PLAIN_TEXT</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>When AnswerSource is BotFramework, this field returns the name of the dialogue unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Example: Checking Weather</para>
                    /// </summary>
                    [NameInMap("DialogName")]
                    [Validation(Required=false)]
                    public string DialogName { get; set; }

                    /// <summary>
                    /// <para>This field returns transparent parameters.</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    /// <summary>
                    /// <para>When AnswerSource is BotFramework, this field returns a transparent parameter.</para>
                    /// </summary>
                    [NameInMap("ExternalFlags")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExternalFlags { get; set; }

                    /// <summary>
                    /// <para>Hit statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check the weather.</para>
                    /// </summary>
                    [NameInMap("HitStatement")]
                    [Validation(Required=false)]
                    public string HitStatement { get; set; }

                    /// <summary>
                    /// <para>When AnswerSource is BotFramework, this field returns the intent name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Check weather intention.</para>
                    /// </summary>
                    [NameInMap("IntentName")]
                    [Validation(Required=false)]
                    public string IntentName { get; set; }

                    /// <summary>
                    /// <para>Metadata.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[[{\&quot;columnName\&quot;:\&quot;name\&quot;,\&quot;stringValue\&quot;:\&quot;wangshanshan\&quot;}]]</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    /// <summary>
                    /// <para>When AnswerSource is BotFramework, this field returns the node ID.</para>
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
                    /// <para>Example: Checking Weather Check the weather and fill in the slots__ city</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>Slot information list.</para>
                    /// </summary>
                    [NameInMap("Slots")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesTextSlots> Slots { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesTextSlots : TeaModel {
                        /// <summary>
                        /// <para>Whether it hits.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Hit")]
                        [Validation(Required=false)]
                        public bool? Hit { get; set; }

                        /// <summary>
                        /// <para>Name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Check weather intentions. city</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Original value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Beijing</para>
                        /// </summary>
                        [NameInMap("Origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        /// <summary>
                        /// <para>Specific values.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Beijing</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Custom Chat Topic Title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>greet.</para>
                    /// </summary>
                    [NameInMap("UserDefinedChatTitle")]
                    [Validation(Required=false)]
                    public string UserDefinedChatTitle { get; set; }

                }

            }

            /// <summary>
            /// <para>The source of the recommended answer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the answer is in plain text or rich text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The passthrough parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
