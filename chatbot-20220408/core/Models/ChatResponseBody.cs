// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatResponseBody : TeaModel {
        /// <summary>
        /// 本条会话应答消息的ID
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息的列表
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<ChatResponseBodyMessages> Messages { get; set; }
        public class ChatResponseBodyMessages : TeaModel {
            /// <summary>
            /// 当AnswerType为Recommend时，此字段表示推荐的答案来源
            /// </summary>
            [NameInMap("AnswerSource")]
            [Validation(Required=false)]
            public string AnswerSource { get; set; }

            /// <summary>
            /// 本条消息的类型
            /// </summary>
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            /// <summary>
            /// 当AnswerType为CardAnswer时，此字段包含机器人返回的Card的列表
            /// </summary>
            [NameInMap("CardList")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesCardList> CardList { get; set; }
            public class ChatResponseBodyMessagesCardList : TeaModel {
                /// <summary>
                /// 区分答案类型：cardAnswer
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// 消息类型：card
                /// </summary>
                [NameInMap("MsgType")]
                [Validation(Required=false)]
                public string MsgType { get; set; }

                /// <summary>
                /// 平台类型：beebot
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

            /// <summary>
            /// 当AnswerType为Knowledge时，此字段包含机器人返回的Knowledge对象
            /// </summary>
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

            /// <summary>
            /// 当AnswerType为Recommend时，此字段包含机器人返回的Recommend的列表
            /// </summary>
            [NameInMap("Recommends")]
            [Validation(Required=false)]
            public List<ChatResponseBodyMessagesRecommends> Recommends { get; set; }
            public class ChatResponseBodyMessagesRecommends : TeaModel {
                /// <summary>
                /// 澄清来源的标识
                /// </summary>
                [NameInMap("AnswerSource")]
                [Validation(Required=false)]
                public string AnswerSource { get; set; }

                /// <summary>
                /// 澄清的知识id
                /// </summary>
                [NameInMap("KnowledgeId")]
                [Validation(Required=false)]
                public string KnowledgeId { get; set; }

                /// <summary>
                /// 推荐内容的分数，当AnswerSource为KNOWLEDGE时，此字段有值
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// 澄清内容，可能是
                /// 图谱问答的实体、
                /// 知识问答的知识标题、
                /// 表格问答的列值
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 当AnswerType为Text时，此字段包含机器人返回的Text对象
            /// </summary>
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
                    public bool? Hit { get; set; }
                    public string Name { get; set; }
                    public string Origin { get; set; }
                    public string Value { get; set; }
                }
                [NameInMap("UserDefinedChatTitle")]
                [Validation(Required=false)]
                public string UserDefinedChatTitle { get; set; }
            };

            /// <summary>
            /// 当AnswerType为Recommend时，此字段表示推荐或者反问的标题话术
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 当AnswerType为Recommend时，并且问答的机器人为语音机器人，此字段表示列表型答案在语音场景渲染之后的答案内容
            /// </summary>
            [NameInMap("VoiceTitle")]
            [Validation(Required=false)]
            public string VoiceTitle { get; set; }

        }

        /// <summary>
        /// query的分词结果，可能为空
        /// </summary>
        [NameInMap("QuerySegList")]
        [Validation(Required=false)]
        public List<string> QuerySegList { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次会话的ID
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
