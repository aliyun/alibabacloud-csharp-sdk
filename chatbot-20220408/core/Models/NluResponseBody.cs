// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class NluResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the natural language understanding response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2828708A-2C7A-1BAE-B810-87DB9DA9C661</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The list of messages.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<NluResponseBodyMessages> Messages { get; set; }
        public class NluResponseBodyMessages : TeaModel {
            /// <summary>
            /// <para>The natural language understanding information from DialogHub.</para>
            /// </summary>
            [NameInMap("DialogHubNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDialogHubNluInfo DialogHubNluInfo { get; set; }
            public class NluResponseBodyMessagesDialogHubNluInfo : TeaModel {
                /// <summary>
                /// <para>The list of global dictionary entries.</para>
                /// </summary>
                [NameInMap("GlobalDictList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalDictList> GlobalDictList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalDictList : TeaModel {
                    /// <summary>
                    /// <para>The standard word.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    /// <summary>
                    /// <para>The synonym.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

                /// <summary>
                /// <para>The list of global sensitive words.</para>
                /// </summary>
                [NameInMap("GlobalSensitiveWordList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList> GlobalSensitiveWordList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList : TeaModel {
                    /// <summary>
                    /// <para>The standard word.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    /// <summary>
                    /// <para>The synonym.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

            /// <summary>
            /// <para>The natural language understanding information from Dialog Studio.</para>
            /// </summary>
            [NameInMap("DsNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDsNluInfo DsNluInfo { get; set; }
            public class NluResponseBodyMessagesDsNluInfo : TeaModel {
                /// <summary>
                /// <para>The list of entities.</para>
                /// </summary>
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoEntityList> EntityList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoEntityList : TeaModel {
                    /// <summary>
                    /// <para>The name of the entity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>@城市</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The original word for the entity, also known as an entity member.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    /// <summary>
                    /// <para>The type of the entity. Currently, only the <c>text</c> type is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The entity\&quot;s synonym.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The list of intents.</para>
                /// </summary>
                [NameInMap("IntentList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoIntentList> IntentList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoIntentList : TeaModel {
                    /// <summary>
                    /// <para>The intent ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>724387</para>
                    /// </summary>
                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public long? IntentId { get; set; }

                    /// <summary>
                    /// <para>The details of the matching process.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>classifierType=Fewshot,from=Fewshot,content=[我要查北京的天气, 帮我查北京的天气, 北京天气怎么样, 北京今天下雨吗, 北京今天多少度]</para>
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// <para>The match type. Valid values are <c>Similarity</c> (match by utterance similarity), <c>Lgf</c> (match by LGF), <c>Classify</c> (match by model training), <c>FewShotLearning</c> (match by the built-in few-shot learning model), and <c>BuildIn</c> (match with a built-in intent).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FewShotLearning</para>
                    /// </summary>
                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <para>The name of the intent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>查天气意图</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The confidence score of the match.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.995</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    /// <summary>
                    /// <para>The list of slots for the matched intent.</para>
                    /// </summary>
                    [NameInMap("SlotList")]
                    [Validation(Required=false)]
                    public List<NluResponseBodyMessagesDsNluInfoIntentListSlotList> SlotList { get; set; }
                    public class NluResponseBodyMessagesDsNluInfoIntentListSlotList : TeaModel {
                        /// <summary>
                        /// <para>The name of the entity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>@城市</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The original word for the entity, also known as an entity member.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京</para>
                        /// </summary>
                        [NameInMap("Origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        /// <summary>
                        /// <para>The type of the entity. Currently, only the <c>text</c> type is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The entity\&quot;s synonym.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>首都</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6357C1B-1D79-1382-B259-BD9E80751B42</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
