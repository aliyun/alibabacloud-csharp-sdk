// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class ChatResponseBody : TeaModel {
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ChatResponseBodyMessages> Messages { get; set; }
        public class ChatResponseBodyMessages : TeaModel {
            [NameInMap("AnswerSource")]
            [Validation(Required=false)]
            public string AnswerSource { get; set; }

            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            [NameInMap("Knowledge")]
            [Validation(Required=false)]
            public ChatResponseBodyMessagesKnowledge Knowledge { get; set; }
            public class ChatResponseBodyMessagesKnowledge : TeaModel {
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
                public List<ChatResponseBodyMessagesKnowledgeRelatedKnowledges> RelatedKnowledges { get; set; }
                public class ChatResponseBodyMessagesKnowledgeRelatedKnowledges : TeaModel {
                    public string KnowledgeId { get; set; }
                    public string Title { get; set; }
                }
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }
                [NameInMap("Summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }
            };

            [NameInMap("Recommends")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesRecommends> Recommends { get; set; }
            public class ChatResponseBodyMessagesRecommends : TeaModel {
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

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
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }
                [NameInMap("ArticleTitle")]
                [Validation(Required=false)]
                public string ArticleTitle { get; set; }
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public Dictionary<string, string> Commands { get; set; }
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
                public Dictionary<string, string> Ext { get; set; }
                [NameInMap("ExternalFlags")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExternalFlags { get; set; }
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
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }
                [NameInMap("Slots")]
                [Validation(Required=false)]
                public List<ChatResponseBodyMessagesTextSlots> Slots { get; set; }
                public class ChatResponseBodyMessagesTextSlots : TeaModel {
                    public bool? IsHit { get; set; }
                    public string Name { get; set; }
                    public string Origin { get; set; }
                    public string Value { get; set; }
                }
                [NameInMap("UserDefinedChatTitle")]
                [Validation(Required=false)]
                public string UserDefinedChatTitle { get; set; }
            };

            /// <summary>
            /// 在线场景，反问标题
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 语音场景，澄清内容
            /// </summary>
            [NameInMap("VoiceTitle")]
            [Validation(Required=false)]
            public string VoiceTitle { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
