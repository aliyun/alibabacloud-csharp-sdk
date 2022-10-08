// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotChatResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotChatResponseBodyData Data { get; set; }
        public class BeeBotChatResponseBodyData : TeaModel {
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<BeeBotChatResponseBodyDataMessages> Messages { get; set; }
            public class BeeBotChatResponseBodyDataMessages : TeaModel {
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                [NameInMap("AnswerType")]
                [Validation(Required=false)]
                public string AnswerType { get; set; }

                [NameInMap("Knowledge")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesKnowledge Knowledge { get; set; }
                public class BeeBotChatResponseBodyDataMessagesKnowledge : TeaModel {
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("HitStatement")]
                    [Validation(Required=false)]
                    public string HitStatement { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("RelatedKnowledges")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesKnowledgeRelatedKnowledges : TeaModel {
                        [NameInMap("KnowledgeId")]
                        [Validation(Required=false)]
                        public string KnowledgeId { get; set; }

                        [NameInMap("Title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    [NameInMap("Summary")]
                    [Validation(Required=false)]
                    public string Summary { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("Recommends")]
                [Validation(Required=false)]
                public List<BeeBotChatResponseBodyDataMessagesRecommends> Recommends { get; set; }
                public class BeeBotChatResponseBodyDataMessagesRecommends : TeaModel {
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    [NameInMap("KnowledgeId")]
                    [Validation(Required=false)]
                    public string KnowledgeId { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public BeeBotChatResponseBodyDataMessagesText Text { get; set; }
                public class BeeBotChatResponseBodyDataMessagesText : TeaModel {
                    [NameInMap("AnswerSource")]
                    [Validation(Required=false)]
                    public string AnswerSource { get; set; }

                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

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

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("Slots")]
                    [Validation(Required=false)]
                    public List<BeeBotChatResponseBodyDataMessagesTextSlots> Slots { get; set; }
                    public class BeeBotChatResponseBodyDataMessagesTextSlots : TeaModel {
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

            }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
