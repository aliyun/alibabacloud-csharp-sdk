// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class NluResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2828708A-2C7A-1BAE-B810-87DB9DA9C661</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<NluResponseBodyMessages> Messages { get; set; }
        public class NluResponseBodyMessages : TeaModel {
            [NameInMap("DialogHubNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDialogHubNluInfo DialogHubNluInfo { get; set; }
            public class NluResponseBodyMessagesDialogHubNluInfo : TeaModel {
                [NameInMap("GlobalDictList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalDictList> GlobalDictList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalDictList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

                [NameInMap("GlobalSensitiveWordList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList> GlobalSensitiveWordList { get; set; }
                public class NluResponseBodyMessagesDialogHubNluInfoGlobalSensitiveWordList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("StandardWord")]
                    [Validation(Required=false)]
                    public string StandardWord { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>天气</para>
                    /// </summary>
                    [NameInMap("Word")]
                    [Validation(Required=false)]
                    public string Word { get; set; }

                }

            }

            [NameInMap("DsNluInfo")]
            [Validation(Required=false)]
            public NluResponseBodyMessagesDsNluInfo DsNluInfo { get; set; }
            public class NluResponseBodyMessagesDsNluInfo : TeaModel {
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoEntityList> EntityList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoEntityList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>@城市</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("Origin")]
                    [Validation(Required=false)]
                    public string Origin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("IntentList")]
                [Validation(Required=false)]
                public List<NluResponseBodyMessagesDsNluInfoIntentList> IntentList { get; set; }
                public class NluResponseBodyMessagesDsNluInfoIntentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>724387</para>
                    /// </summary>
                    [NameInMap("IntentId")]
                    [Validation(Required=false)]
                    public long? IntentId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>classifierType=Fewshot,from=Fewshot,content=[我要查北京的天气, 帮我查北京的天气, 北京天气怎么样, 北京今天下雨吗, 北京今天多少度]</para>
                    /// </summary>
                    [NameInMap("MatchDetail")]
                    [Validation(Required=false)]
                    public string MatchDetail { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>FewShotLearning</para>
                    /// </summary>
                    [NameInMap("MatchType")]
                    [Validation(Required=false)]
                    public string MatchType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>查天气意图</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.995</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    [NameInMap("SlotList")]
                    [Validation(Required=false)]
                    public List<NluResponseBodyMessagesDsNluInfoIntentListSlotList> SlotList { get; set; }
                    public class NluResponseBodyMessagesDsNluInfoIntentListSlotList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>@城市</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>北京</para>
                        /// </summary>
                        [NameInMap("Origin")]
                        [Validation(Required=false)]
                        public string Origin { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
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
        /// <b>Example:</b>
        /// <para>A6357C1B-1D79-1382-B259-BD9E80751B42</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
