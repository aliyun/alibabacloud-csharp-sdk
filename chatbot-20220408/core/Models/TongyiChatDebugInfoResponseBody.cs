// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class TongyiChatDebugInfoResponseBody : TeaModel {
        [NameInMap("AnswerInfo")]
        [Validation(Required=false)]
        public TongyiChatDebugInfoResponseBodyAnswerInfo AnswerInfo { get; set; }
        public class TongyiChatDebugInfoResponseBodyAnswerInfo : TeaModel {
            [NameInMap("AnswerReferenceInfo")]
            [Validation(Required=false)]
            public TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfo AnswerReferenceInfo { get; set; }
            public class TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfo : TeaModel {
                [NameInMap("ItemList")]
                [Validation(Required=false)]
                public List<TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfoItemList> ItemList { get; set; }
                public class TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfoItemList : TeaModel {
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public string DataSource { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public int? Number { get; set; }

                    [NameInMap("ReferenceExt")]
                    [Validation(Required=false)]
                    public object ReferenceExt { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("MessageBody")]
            [Validation(Required=false)]
            public TongyiChatDebugInfoResponseBodyAnswerInfoMessageBody MessageBody { get; set; }
            public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBody : TeaModel {
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public object Commands { get; set; }

                [NameInMap("DirectMessageBody")]
                [Validation(Required=false)]
                public TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBody DirectMessageBody { get; set; }
                public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBody : TeaModel {
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("TransitionList")]
                    [Validation(Required=false)]
                    public List<string> TransitionList { get; set; }

                    [NameInMap("relatedQuestionList")]
                    [Validation(Required=false)]
                    public List<string> RelatedQuestionList { get; set; }

                    [NameInMap("sentenceList")]
                    [Validation(Required=false)]
                    public List<TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodySentenceList> SentenceList { get; set; }
                    public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodySentenceList : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("ReferNumber")]
                        [Validation(Required=false)]
                        public int? ReferNumber { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the response message in the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2828708A-2C7A-1BAE-B810-87DB9DA9C661</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The information about the entire Q&amp;A pipeline.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public List<TongyiChatDebugInfoResponseBodyPipeline> Pipeline { get; set; }
        public class TongyiChatDebugInfoResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The debugging input information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>用户问句：转人工\n命中规则：[转]人工[客服|服务|坐席]</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public object Input { get; set; }

            /// <summary>
            /// <para>The Policy Name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>High-frequency Q&amp;A direct response</description></item>
            /// <item><description>Keyword-based transfer to agent</description></item>
            /// <item><description>Global sensitive words</description></item>
            /// </list>
            /// <para>This field is returned only when NodeType is system_strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>关键词转人工</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system_strategy</b>: system strategy.</description></item>
            /// <item><description><b>rewrite_query</b>: retrieval query.</description></item>
            /// <item><description><b>invoke_llm</b>: LLM invocation.</description></item>
            /// <item><description><b>invoke_tools</b>: tool calling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system_strategy</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The output information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>commands:{\&quot;sysToAgent\&quot;:\&quot;{\\\&quot;skillGroup\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;ext\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;toAgentReason\\\&quot;:\\\&quot;HitKeywords\\\&quot;}\&quot;}\nresponse:正在为您转接人工客服</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public object Output { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3E5C779-A630-45AC-B0F2-A4506A4212F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
