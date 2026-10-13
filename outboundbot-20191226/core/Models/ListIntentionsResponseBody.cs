// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIntentionsResponseBodyData Data { get; set; }
        public class ListIntentionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The robot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-n7QmzrUnNe</para>
            /// </summary>
            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            /// <summary>
            /// <para>The list of intents.</para>
            /// </summary>
            [NameInMap("IntentList")]
            [Validation(Required=false)]
            public List<ListIntentionsResponseBodyDataIntentList> IntentList { get; set; }
            public class ListIntentionsResponseBodyDataIntentList : TeaModel {
                /// <summary>
                /// <para>The intent alias.</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                /// <summary>
                /// <para>The robot ID. [Deprecated]</para>
                /// 
                /// <b>Example:</b>
                /// <para>chatbot-cn-n7QmzrUnNe</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public long? BotId { get; set; }

                /// <summary>
                /// <para>The robot name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("BotName")]
                [Validation(Required=false)]
                public string BotName { get; set; }

                /// <summary>
                /// <para>The dialog flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50099</para>
                /// </summary>
                [NameInMap("DialogId")]
                [Validation(Required=false)]
                public string DialogId { get; set; }

                /// <summary>
                /// <para>The intent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10717802</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The language.</para>
                /// <list type="bullet">
                /// <item><description>English: en-us</description></item>
                /// <item><description>Chinese: zh-cn</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>zh-cn</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The intent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Got it</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The LGF intent utterance expressions.</para>
                /// </summary>
                [NameInMap("RuleCheck")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListRuleCheck> RuleCheck { get; set; }
                public class ListIntentionsResponseBodyDataIntentListRuleCheck : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public List<string> Error { get; set; }

                    /// <summary>
                    /// <para>Indicates whether strict matching is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    /// <summary>
                    /// <para>The expression value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>know</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>The warning message.</para>
                    /// </summary>
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public List<string> Warning { get; set; }

                }

                /// <summary>
                /// <para>The intent slot information.</para>
                /// </summary>
                [NameInMap("Slot")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListSlot> Slot { get; set; }
                public class ListIntentionsResponseBodyDataIntentListSlot : TeaModel {
                    /// <summary>
                    /// <para>The clarification functions.</para>
                    /// <remarks>
                    /// <para>Notice: 无效内容</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("FeedbackFunctions")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions> FeedbackFunctions { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions : TeaModel {
                        /// <summary>
                        /// <para>The Alibaba Cloud function name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunFunction")]
                        [Validation(Required=false)]
                        public string AliyunFunction { get; set; }

                        /// <summary>
                        /// <para>The Alibaba Cloud service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunService")]
                        [Validation(Required=false)]
                        public string AliyunService { get; set; }

                        /// <summary>
                        /// <para>The status code of the operation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OK</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The clarification description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GA setup for HPC cn4-HPC-EndUserServer-GlobalAccelerator</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The endpoint.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou.log.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("EndPoint")]
                        [Validation(Required=false)]
                        public string EndPoint { get; set; }

                        /// <summary>
                        /// <para>The clarification function.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>count</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// <para>The function name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>方欣云呼系统每日拨测_2024年11月</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The parameters.</para>
                        /// </summary>
                        [NameInMap("Params")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Params { get; set; }

                        /// <summary>
                        /// <para>The feature switch. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>on</b>: Enabled.</description></item>
                        /// <item><description><b>off</b>: Disabled.</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Switch")]
                        [Validation(Required=false)]
                        public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch> Switch { get; set; }
                        public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch : TeaModel {
                            /// <summary>
                            /// <para>The condition ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>b9932604-08ae-4525-bbe5-c8cce3066070</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <para>The clarification prompt label.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SQL_SUB_QUERY</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The condition name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>测试0609_20241021_101018_复制_复制_复制</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>The type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PASSKEY</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>The condition value.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BASE_VALIDATE_FILTER_SWITCH</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>The clarification type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cluster</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The feedback type.</para>
                    /// <remarks>
                    /// <para>Notice: 无效内容</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("FeedbackType")]
                    [Validation(Required=false)]
                    public string FeedbackType { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the slot.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the slot is an array. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Yes.</description></item>
                    /// <item><description>false: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsArray")]
                    [Validation(Required=false)]
                    public bool? IsArray { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the slot is encrypted.</para>
                    /// <remarks>
                    /// <para>Notice: 无效内容</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsEncrypt")]
                    [Validation(Required=false)]
                    public bool? IsEncrypt { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the slot is interactive.</para>
                    /// <remarks>
                    /// <para>Notice: 无效内容</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsInteractive")]
                    [Validation(Required=false)]
                    public bool? IsInteractive { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the slot is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Yes.</description></item>
                    /// <item><description>false: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsNecessary")]
                    [Validation(Required=false)]
                    public bool? IsNecessary { get; set; }

                    /// <summary>
                    /// <para>The slot life span.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LifeSpan")]
                    [Validation(Required=false)]
                    public int? LifeSpan { get; set; }

                    /// <summary>
                    /// <para>The slot name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>know</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The slot clarification prompts.</para>
                    /// </summary>
                    [NameInMap("Question")]
                    [Validation(Required=false)]
                    public List<string> Question { get; set; }

                    /// <summary>
                    /// <para>The slot tagging labels.</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotTags> Tags { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotTags : TeaModel {
                        /// <summary>
                        /// <para>The unique identifier of the intent utterance corresponding to the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>17448458</para>
                        /// </summary>
                        [NameInMap("UserSayId")]
                        [Validation(Required=false)]
                        public string UserSayId { get; set; }

                        /// <summary>
                        /// <para>The tagging result of the intent utterance corresponding to the label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Do you know xxxx?</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The slot tagging result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>@知道</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43258</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

                /// <summary>
                /// <para>The intent type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: normal intent. </description></item>
                /// <item><description>1: UNKNOWN. </description></item>
                /// <item><description>2: TableQA intent. </description></item>
                /// <item><description>3: generated from a standard intent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The list of user utterances.</para>
                /// </summary>
                [NameInMap("UserSay")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListUserSay> UserSay { get; set; }
                public class ListIntentionsResponseBodyDataIntentListUserSay : TeaModel {
                    /// <summary>
                    /// <para>The source ID.</para>
                    /// <remarks>
                    /// <para>Notice: 无效内容</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567</para>
                    /// </summary>
                    [NameInMap("FromId")]
                    [Validation(Required=false)]
                    public string FromId { get; set; }

                    /// <summary>
                    /// <para>The utterance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17448458</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Indicates whether strict matching is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    /// <summary>
                    /// <para>The list of user utterances.</para>
                    /// </summary>
                    [NameInMap("UserSayData")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListUserSayUserSayData> UserSayData { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListUserSayUserSayData : TeaModel {
                        /// <summary>
                        /// <para>The unique identifier of the slot.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                        /// </summary>
                        [NameInMap("SlotId")]
                        [Validation(Required=false)]
                        public string SlotId { get; set; }

                        /// <summary>
                        /// <para>The utterance text.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>know</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The message returned by the operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
