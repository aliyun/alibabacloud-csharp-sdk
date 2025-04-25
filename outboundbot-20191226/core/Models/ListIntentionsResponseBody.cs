// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIntentionsResponseBodyData Data { get; set; }
        public class ListIntentionsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>chatbot-cn-n7QmzrUnNe</para>
            /// </summary>
            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            [NameInMap("IntentList")]
            [Validation(Required=false)]
            public List<ListIntentionsResponseBodyDataIntentList> IntentList { get; set; }
            public class ListIntentionsResponseBodyDataIntentList : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>chatbot-cn-n7QmzrUnNe</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public long? BotId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("BotName")]
                [Validation(Required=false)]
                public string BotName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50099</para>
                /// </summary>
                [NameInMap("DialogId")]
                [Validation(Required=false)]
                public string DialogId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10717802</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zh-cn</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RuleCheck")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListRuleCheck> RuleCheck { get; set; }
                public class ListIntentionsResponseBodyDataIntentListRuleCheck : TeaModel {
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public List<string> Error { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public List<string> Warning { get; set; }

                }

                [NameInMap("Slot")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListSlot> Slot { get; set; }
                public class ListIntentionsResponseBodyDataIntentListSlot : TeaModel {
                    [NameInMap("FeedbackFunctions")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions> FeedbackFunctions { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunFunction")]
                        [Validation(Required=false)]
                        public string AliyunFunction { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunService")]
                        [Validation(Required=false)]
                        public string AliyunService { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>OK</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>GA setup for HPC cn4-HPC-EndUserServer-GlobalAccelerator</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou.log.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("EndPoint")]
                        [Validation(Required=false)]
                        public string EndPoint { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>count</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Params")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Params { get; set; }

                        [NameInMap("Switch")]
                        [Validation(Required=false)]
                        public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch> Switch { get; set; }
                        public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>b9932604-08ae-4525-bbe5-c8cce3066070</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>SQL_SUB_QUERY</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>PASSKEY</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>BASE_VALIDATE_FILTER_SWITCH</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cluster</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("FeedbackType")]
                    [Validation(Required=false)]
                    public string FeedbackType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsArray")]
                    [Validation(Required=false)]
                    public bool? IsArray { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsEncrypt")]
                    [Validation(Required=false)]
                    public bool? IsEncrypt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsInteractive")]
                    [Validation(Required=false)]
                    public bool? IsInteractive { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsNecessary")]
                    [Validation(Required=false)]
                    public bool? IsNecessary { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LifeSpan")]
                    [Validation(Required=false)]
                    public int? LifeSpan { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Question")]
                    [Validation(Required=false)]
                    public List<string> Question { get; set; }

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotTags> Tags { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotTags : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>17448458</para>
                        /// </summary>
                        [NameInMap("UserSayId")]
                        [Validation(Required=false)]
                        public string UserSayId { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43258</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UserSay")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListUserSay> UserSay { get; set; }
                public class ListIntentionsResponseBodyDataIntentListUserSay : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234567</para>
                    /// </summary>
                    [NameInMap("FromId")]
                    [Validation(Required=false)]
                    public string FromId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>17448458</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    [NameInMap("UserSayData")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListUserSayUserSayData> UserSayData { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListUserSayUserSayData : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                        /// </summary>
                        [NameInMap("SlotId")]
                        [Validation(Required=false)]
                        public string SlotId { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
