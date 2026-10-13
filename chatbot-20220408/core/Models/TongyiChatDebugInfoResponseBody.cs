// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class TongyiChatDebugInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The answer information corresponding to the conversation.</para>
        /// </summary>
        [NameInMap("AnswerInfo")]
        [Validation(Required=false)]
        public TongyiChatDebugInfoResponseBodyAnswerInfo AnswerInfo { get; set; }
        public class TongyiChatDebugInfoResponseBodyAnswerInfo : TeaModel {
            /// <summary>
            /// <para>The referenced knowledge information of the matched answer.</para>
            /// </summary>
            [NameInMap("AnswerReferenceInfo")]
            [Validation(Required=false)]
            public TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfo AnswerReferenceInfo { get; set; }
            public class TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfo : TeaModel {
                /// <summary>
                /// <para>The list of referenced knowledge entries.</para>
                /// </summary>
                [NameInMap("ItemList")]
                [Validation(Required=false)]
                public List<TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfoItemList> ItemList { get; set; }
                public class TongyiChatDebugInfoResponseBodyAnswerInfoAnswerReferenceInfoItemList : TeaModel {
                    /// <summary>
                    /// <para>The type of the referenced text.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PLAIN_TEXT/RICH_TEXT</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The source of the referenced knowledge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FLOW/DOC/FAQ/FAQ_DIRECT</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public string DataSource { get; set; }

                    /// <summary>
                    /// <para>The ID of the referenced knowledge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>611926</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The number that corresponds one-to-one with the ReferNumber in AnswerInfo.MessageBody.DirectMessageBody.SentenceList.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public int? Number { get; set; }

                    /// <summary>
                    /// <para>The extension information specific to the knowledge type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///             &quot;CollectedParams&quot;: {
                    ///               &quot;ReturnMaster&quot;: &quot;true&quot;
                    ///             },
                    ///             &quot;Edges&quot;: [],
                    ///             &quot;Nodes&quot;: [
                    ///               {
                    ///                 &quot;InvokedApis&quot;: [
                    ///                   {
                    ///                     &quot;ApiName&quot;: &quot;intentionRepeatCallQry&quot;
                    ///                   }
                    ///                 ],
                    ///                 &quot;OptionalParams&quot;: [
                    ///                   &quot;mobile&quot;,
                    ///                   &quot;intention&quot;
                    ///                 ],
                    ///                 &quot;Id&quot;: &quot;22874cb7-c253-4832-a38d-7113b15ef7fc&quot;,
                    ///                 &quot;RequiredParams&quot;: [],
                    ///                 &quot;Name&quot;: &quot;Check for repeated contacts&quot;
                    ///               },
                    ///               {
                    ///                 &quot;InvokedApis&quot;: [
                    ///                   {
                    ///                     &quot;ApiName&quot;: &quot;complaintAllChannelLatest&quot;
                    ///                   }
                    ///                 ],
                    ///                 &quot;OptionalParams&quot;: [
                    ///                   &quot;mobile&quot;,
                    ///                   &quot;billCode&quot;
                    ///                 ],
                    ///                 &quot;Id&quot;: &quot;071b082e-ce76-47f9-8b8d-f29e0dd1015c&quot;,
                    ///                 &quot;RequiredParams&quot;: [],
                    ///                 &quot;Name&quot;: &quot;Query ticket information&quot;
                    ///               },
                    ///               {
                    ///                 &quot;Id&quot;: &quot;db02f361-61ee-4e30-bda0-2fd62cf4ca46&quot;,
                    ///                 &quot;Name&quot;: &quot;Logical judgment_35a6&quot;
                    ///               },
                    ///               {
                    ///                 &quot;OptionalParams&quot;: [],
                    ///                 &quot;Id&quot;: &quot;97f68b60-2973-4d10-8e42-1cbfcbb15cf6&quot;,
                    ///                 &quot;RequiredParams&quot;: [
                    ///                   &quot;returnMaster&quot;
                    ///                 ],
                    ///                 &quot;Name&quot;: &quot;Whether to return to the main flow&quot;
                    ///               },
                    ///               {
                    ///                 &quot;Id&quot;: &quot;8167e4ec-a589-42de-97c2-271672b26ffe&quot;,
                    ///                 &quot;Name&quot;: &quot;Return to the main flow&quot;
                    ///               }
                    ///             ]
                    ///           }</para>
                    /// </summary>
                    [NameInMap("ReferenceExt")]
                    [Validation(Required=false)]
                    public object ReferenceExt { get; set; }

                    /// <summary>
                    /// <para>The title of the referenced knowledge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Is it possible to make the payment when the contract entity and the paying entity are different?</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <para>The message body.</para>
            /// </summary>
            [NameInMap("MessageBody")]
            [Validation(Required=false)]
            public TongyiChatDebugInfoResponseBodyAnswerInfoMessageBody MessageBody { get; set; }
            public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBody : TeaModel {
                /// <summary>
                /// <para>The command parameters, such as the skill group for the transfer-to-agent command.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///         &quot;SysToAgent&quot;: &quot;{\&quot;skillGroup\&quot;:\&quot;\&quot;,\&quot;ext\&quot;:\&quot;\&quot;,\&quot;toAgentReason\&quot;:\&quot;HitKeywords\&quot;}&quot;
                ///       }</para>
                /// </summary>
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public object Commands { get; set; }

                /// <summary>
                /// <para>The message body that contains the Q&amp;A results, including the answer, text type, recommended questions, and matched system type.</para>
                /// </summary>
                [NameInMap("DirectMessageBody")]
                [Validation(Required=false)]
                public TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBody DirectMessageBody { get; set; }
                public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBody : TeaModel {
                    /// <summary>
                    /// <para>The answer type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RICH_TEXT/PLAIN_TEXT</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The matched system Q&amp;A policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SENSITIVE_WORD/NO_ANSWER/COMMANDS</para>
                    /// </summary>
                    [NameInMap("HitSystemAskConfig")]
                    [Validation(Required=false)]
                    public string HitSystemAskConfig { get; set; }

                    /// <summary>
                    /// <para>The response time (RT) debugging information for the current Q&amp;A.</para>
                    /// </summary>
                    [NameInMap("RtDetail")]
                    [Validation(Required=false)]
                    public TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodyRtDetail RtDetail { get; set; }
                    public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodyRtDetail : TeaModel {
                        /// <summary>
                        /// <para>The list of RTs for each segment from the time the user question is received on the text side to the sequential generation of the formal answer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[200, 256, 300, 430]</para>
                        /// </summary>
                        [NameInMap("SentenceRtList")]
                        [Validation(Required=false)]
                        public object SentenceRtList { get; set; }

                        /// <summary>
                        /// <para>The list of RTs for each segment from the time the user question is received on the text side to the sequential generation of the transition phrases.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[130]</para>
                        /// </summary>
                        [NameInMap("TransitionRtList")]
                        [Validation(Required=false)]
                        public object TransitionRtList { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of transition phrases.</para>
                    /// </summary>
                    [NameInMap("TransitionList")]
                    [Validation(Required=false)]
                    public List<string> TransitionList { get; set; }

                    /// <summary>
                    /// <para>The list of similar questions.</para>
                    /// </summary>
                    [NameInMap("relatedQuestionList")]
                    [Validation(Required=false)]
                    public List<string> RelatedQuestionList { get; set; }

                    /// <summary>
                    /// <para>The list of formal answers.</para>
                    /// </summary>
                    [NameInMap("sentenceList")]
                    [Validation(Required=false)]
                    public List<TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodySentenceList> SentenceList { get; set; }
                    public class TongyiChatDebugInfoResponseBodyAnswerInfoMessageBodyDirectMessageBodySentenceList : TeaModel {
                        /// <summary>
                        /// <para>The formal answer entry.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The weather is sunny today</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The number that corresponds one-to-one with the Number in AnswerReferenceInfo.ItemList for generating this answer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("ReferNumber")]
                        [Validation(Required=false)]
                        public int? ReferNumber { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the response message for the current session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2828708A-2C7A-1BAE-B810-87DB9DA9C661</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The information about the entire Q&amp;A process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>For examples, see the child elements</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public List<TongyiChatDebugInfoResponseBodyPipeline> Pipeline { get; set; }
        public class TongyiChatDebugInfoResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The debugging input information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User question: Transfer to agent
            /// Rule hits: [transfer] agent [customer service|service|representative]</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public object Input { get; set; }

            /// <summary>
            /// <para>The policy name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>High-frequency Q&amp;A direct output</description></item>
            /// <item><description>Keyword-based transfer to agent</description></item>
            /// <item><description>Global sensitive words</description></item>
            /// </list>
            /// <para>This field is available only when NodeType is system_strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Keyword-based transfer to agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The node type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system_strategy</b>: system policy.</description></item>
            /// <item><description><b>rewrite_query</b>: retrieved question.</description></item>
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
            /// <para>commands:{&quot;sysToAgent&quot;:&quot;{\&quot;skillGroup\&quot;:\&quot;\&quot;,\&quot;ext\&quot;:\&quot;\&quot;,\&quot;toAgentReason\&quot;:\&quot;HitKeywords\&quot;}&quot;}
            /// response:Transferring you to a human agent</para>
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

        /// <summary>
        /// <para>The ID of the session to which the current response message belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19856284-0ba1-4da3-9a5a-05db2bdf296e</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
