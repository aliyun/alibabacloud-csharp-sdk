// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotChatResponseBody : TeaModel {
        /// <summary>
        /// If OK is returned, the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotChatResponseBodyData Data { get; set; }
        public class BeeBotChatResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the response message.
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// The list of the message.
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<BeeBotChatResponseBodyDataMessages> Messages { get; set; }
            public class BeeBotChatResponseBodyDataMessages : TeaModel {
                /// <summary>
                /// If the AnswerType parameter is set to Recommend, this parameter indicates the source of the recommended answer.
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// The type of the message.
                /// </summary>
                [NameInMap("AnswerType")]
                [Validation(Required=false)]
                public string AnswerType { get; set; }

                /// <summary>
                /// When the AnswerType parameter is set to Knowledge, this parameter contains the Knowledge object returned by the bot.
                /// </summary>
                [NameInMap("Knowledge")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesKnowledge Knowledge { get; set; }
                public class BeeBotChatResponseBodyDataMessagesKnowledge : TeaModel {
                    /// <summary>
                    /// The source of the answer.
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// The category of the knowledge.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The content of the hit question.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// Indicates whether the answer is in plain text or rich text.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// The hit text.
                    /// </summary>
                    [NameInMap("HitStatement")]
                    [Validation(Required=false)]
                    public string HitStatement { get; set; }

                    /// <summary>
                    /// The ID of the hit problem in the knowledge base.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// The list of the related knowledge.
                    /// </summary>
                    [NameInMap("RelatedKnowledges")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges : TeaModel {
                        /// <summary>
                        /// The ID of the related knowledge.
                        /// </summary>
                        [NameInMap("KnowledgeId")]
                        [Validation(Required=false)]
                        public string KnowledgeId { get; set; }

                        /// <summary>
                        /// The title of the related knowledge.
                        /// </summary>
                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// The summary to the hit question.
                    /// </summary>
                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    /// <summary>
                    /// The title of the hit question.
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// When the AnswerType parameter is set to Recommend, this parameter contains a list of recommends returned by the bot.
                /// </summary>
                [NameInMap("Recommends")]
                [Validation(Required=false)]
                public List<BeeBotChatResponseBodyDataMessagesRecommends> Recommends { get; set; }
                public class BeeBotChatResponseBodyDataMessagesRecommends : TeaModel {
                    /// <summary>
                    /// The source of the recommended answer.
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// The ID of the recommended knowledge.
                    /// </summary>
                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public string KnowledgeId { get; set; }

                    /// <summary>
                    /// The recommended content, which may be the entity in graph-based question answering, the standard knowledge in knowledge-based question answering, or the column value in table-based question answering.
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// When the AnswerType parameter is set to Text, this parameter contains the Text object returned by the bot.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesText Text { get; set; }
                public class BeeBotChatResponseBodyDataMessagesText : TeaModel {
                    /// <summary>
                    /// The source of the answer.
                    /// </summary>
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    /// <summary>
                    /// The content of the text message.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// Indicates whether the answer is in plain text or rich text.
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// When the AnswerSource parameter is set to BotFramework, the value of this parameter is returned.
                    /// </summary>
                    [NameInMap("DialogName")]
                    [Validation(Required=false)]
                    public string DialogName { get; set; }

                    /// <summary>
                    /// The passthrough parameters are returned.
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Ext { get; set; }

                    /// <summary>
                    /// When the AnswerSource parameter is set to BotFramework, the value of this parameter is returned.
                    /// </summary>
                    [NameInMap("ExternalFlags")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExternalFlags { get; set; }

                    /// <summary>
                    /// The hit text.
                    /// </summary>
                    [NameInMap("HitStatement")]
                    [Validation(Required=false)]
                    public string HitStatement { get; set; }

                    /// <summary>
                    /// When the AnswerSource parameter is set to BotFramework, the value of this parameter is returned.
                    /// </summary>
                    [NameInMap("IntentName")]
                    [Validation(Required=false)]
                    public string IntentName { get; set; }

                    /// <summary>
                    /// The metadata.
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                    /// <summary>
                    /// When the AnswerSource parameter is set to BotFramework, the value of this parameter is returned.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// When the AnswerSource parameter is set to BotFramework, the value of this parameter is returned.
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// The list of slots.
                    /// </summary>
                    [NameInMap("Slots")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesTextSlots> Slots { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesTextSlots : TeaModel {
                        /// <summary>
                        /// Indicates whether the slot is hit.
                        /// </summary>
                        [NameInMap("Hit")]
                        [Validation(Required=false)]
                        public bool? Hit { get; set; }

                        /// <summary>
                        /// The name of the slot.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The original value.
                        /// </summary>
                        [NameInMap("Origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        /// <summary>
                        /// The specific value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The title of the chitchat.
                    /// </summary>
                    [NameInMap("UserDefinedChatTitle")]
                    [Validation(Required=false)]
                    public string UserDefinedChatTitle { get; set; }

                }

            }

            /// <summary>
            /// The ID of the session.
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
