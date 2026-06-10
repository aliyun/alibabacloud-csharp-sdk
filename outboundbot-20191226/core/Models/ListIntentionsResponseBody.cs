// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListIntentionsResponseBody : TeaModel {
        /// <summary>
        /// <para>API Status Code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIntentionsResponseBodyData Data { get; set; }
        public class ListIntentionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Bot ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>chatbot-cn-n7QmzrUnNe</para>
            /// </summary>
            [NameInMap("BotId")]
            [Validation(Required=false)]
            public string BotId { get; set; }

            /// <summary>
            /// <para>Intent List</para>
            /// </summary>
            [NameInMap("IntentList")]
            [Validation(Required=false)]
            public List<ListIntentionsResponseBodyDataIntentList> IntentList { get; set; }
            public class ListIntentionsResponseBodyDataIntentList : TeaModel {
                /// <summary>
                /// <para>Intent Alias</para>
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public List<string> Alias { get; set; }

                /// <summary>
                /// <para>Bot ID (Deprecated)</para>
                /// 
                /// <b>Example:</b>
                /// <para>chatbot-cn-n7QmzrUnNe</para>
                /// </summary>
                [NameInMap("BotId")]
                [Validation(Required=false)]
                public long? BotId { get; set; }

                /// <summary>
                /// <para>Bot Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("BotName")]
                [Validation(Required=false)]
                public string BotName { get; set; }

                /// <summary>
                /// <para>Conversation Flow ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>50099</para>
                /// </summary>
                [NameInMap("DialogId")]
                [Validation(Required=false)]
                public string DialogId { get; set; }

                /// <summary>
                /// <para>Intent ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>10717802</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Language</para>
                /// <list type="bullet">
                /// <item><description><para>English (en-us)</para>
                /// </description></item>
                /// <item><description><para>Chinese (zh-cn)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>zh-cn</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>Intent Name</para>
                /// 
                /// <b>Example:</b>
                /// <para>知道了</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>LGF Intent Expression</para>
                /// </summary>
                [NameInMap("RuleCheck")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListRuleCheck> RuleCheck { get; set; }
                public class ListIntentionsResponseBodyDataIntentListRuleCheck : TeaModel {
                    /// <summary>
                    /// <para>Error Message</para>
                    /// </summary>
                    [NameInMap("Error")]
                    [Validation(Required=false)]
                    public List<string> Error { get; set; }

                    /// <summary>
                    /// <para>Is Strict Match</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    /// <summary>
                    /// <para>Expression Value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>知道</para>
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// <para>Warning Message</para>
                    /// </summary>
                    [NameInMap("Warning")]
                    [Validation(Required=false)]
                    public List<string> Warning { get; set; }

                }

                /// <summary>
                /// <para>Intent Slot Information</para>
                /// </summary>
                [NameInMap("Slot")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListSlot> Slot { get; set; }
                public class ListIntentionsResponseBodyDataIntentListSlot : TeaModel {
                    /// <summary>
                    /// <para>The follow-up question function.</para>
                    /// <remarks>
                    /// <para>Notice: This parameter is invalid.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("FeedbackFunctions")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions> FeedbackFunctions { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctions : TeaModel {
                        /// <summary>
                        /// <para>Alibaba Cloud Function Name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunFunction")]
                        [Validation(Required=false)]
                        public string AliyunFunction { get; set; }

                        /// <summary>
                        /// <para>Alibaba Cloud Service</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("AliyunService")]
                        [Validation(Required=false)]
                        public string AliyunService { get; set; }

                        /// <summary>
                        /// <para>API Status Code</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>OK</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>Follow-up Question Description</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>GA setup for HPC cn4-HPC-EndUserServer-GlobalAccelerator</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Endpoint</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou.log.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("EndPoint")]
                        [Validation(Required=false)]
                        public string EndPoint { get; set; }

                        /// <summary>
                        /// <para>Follow-up Question Function</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>count</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// <para>Function Name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>方欣云呼系统每日拨测_2024年11月</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Parameters</para>
                        /// </summary>
                        [NameInMap("Params")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Params { get; set; }

                        /// <summary>
                        /// <para>Feature Switch. Values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>on</b>: Enabled</para>
                        /// </description></item>
                        /// <item><description><para><b>off</b>: Disabled</para>
                        /// </description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("Switch")]
                        [Validation(Required=false)]
                        public List<ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch> Switch { get; set; }
                        public class ListIntentionsResponseBodyDataIntentListSlotFeedbackFunctionsSwitch : TeaModel {
                            /// <summary>
                            /// <para>Condition ID</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>b9932604-08ae-4525-bbe5-c8cce3066070</para>
                            /// </summary>
                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public string Id { get; set; }

                            /// <summary>
                            /// <para>Follow-up Question Label</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SQL_SUB_QUERY</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>Condition Name</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>测试0609_20241021_101018_复制_复制_复制</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            /// <summary>
                            /// <para>Type</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>PASSKEY</para>
                            /// </summary>
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            /// <summary>
                            /// <para>Condition Value</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>BASE_VALIDATE_FILTER_SWITCH</para>
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// <para>Follow-up Question Type</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cluster</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>Feedback Type</para>
                    /// <remarks>
                    /// <para>Notice: Invalid content</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("FeedbackType")]
                    [Validation(Required=false)]
                    public string FeedbackType { get; set; }

                    /// <summary>
                    /// <para>Slot Unique Identifier</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Is Array:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: Yes</para>
                    /// </description></item>
                    /// <item><description><para>false: No</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsArray")]
                    [Validation(Required=false)]
                    public bool? IsArray { get; set; }

                    /// <summary>
                    /// <para>Is Encrypted</para>
                    /// <remarks>
                    /// <para>Notice: Invalid content</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsEncrypt")]
                    [Validation(Required=false)]
                    public bool? IsEncrypt { get; set; }

                    /// <summary>
                    /// <para>Is Interactive</para>
                    /// <remarks>
                    /// <para>Notice: Invalid content</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsInteractive")]
                    [Validation(Required=false)]
                    public bool? IsInteractive { get; set; }

                    /// <summary>
                    /// <para>Is Required Slot:</para>
                    /// <list type="bullet">
                    /// <item><description><para>true: Yes</para>
                    /// </description></item>
                    /// <item><description><para>false: No</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsNecessary")]
                    [Validation(Required=false)]
                    public bool? IsNecessary { get; set; }

                    /// <summary>
                    /// <para>Slot Lifecycle</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("LifeSpan")]
                    [Validation(Required=false)]
                    public int? LifeSpan { get; set; }

                    /// <summary>
                    /// <para>Slot Name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>知道</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Slot Follow-up Question</para>
                    /// </summary>
                    [NameInMap("Question")]
                    [Validation(Required=false)]
                    public List<string> Question { get; set; }

                    /// <summary>
                    /// <para>Slot Tagging Labels</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListSlotTags> Tags { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListSlotTags : TeaModel {
                        /// <summary>
                        /// <para>User Say Unique Identifier for the Label</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>17448458</para>
                        /// </summary>
                        [NameInMap("UserSayId")]
                        [Validation(Required=false)]
                        public string UserSayId { get; set; }

                        /// <summary>
                        /// <para>The value of the tag is the result of tagging an intent expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>你知道xxxx？</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>Slot Tagging Result</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>@知道</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Table ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>43258</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public long? TableId { get; set; }

                /// <summary>
                /// <para>Intent Type:</para>
                /// <list type="bullet">
                /// <item><description><para>0: Normal intent;</para>
                /// </description></item>
                /// <item><description><para>1: UNKNOWN;</para>
                /// </description></item>
                /// <item><description><para>2: TableQA intent;</para>
                /// </description></item>
                /// <item><description><para>3: Generated from standard intent</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>User Say List</para>
                /// </summary>
                [NameInMap("UserSay")]
                [Validation(Required=false)]
                public List<ListIntentionsResponseBodyDataIntentListUserSay> UserSay { get; set; }
                public class ListIntentionsResponseBodyDataIntentListUserSay : TeaModel {
                    /// <summary>
                    /// <para>Source ID</para>
                    /// <remarks>
                    /// <para>Notice: Invalid content</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567</para>
                    /// </summary>
                    [NameInMap("FromId")]
                    [Validation(Required=false)]
                    public string FromId { get; set; }

                    /// <summary>
                    /// <para>The ID of the user utterance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17448458</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Is Strict Match</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Strict")]
                    [Validation(Required=false)]
                    public bool? Strict { get; set; }

                    /// <summary>
                    /// <para>User Say List</para>
                    /// </summary>
                    [NameInMap("UserSayData")]
                    [Validation(Required=false)]
                    public List<ListIntentionsResponseBodyDataIntentListUserSayUserSayData> UserSayData { get; set; }
                    public class ListIntentionsResponseBodyDataIntentListUserSayUserSayData : TeaModel {
                        /// <summary>
                        /// <para>Slot Unique Identifier</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>9ec31b50-32b8-11eb-9478-19d2d885afdb</para>
                        /// </summary>
                        [NameInMap("SlotId")]
                        [Validation(Required=false)]
                        public string SlotId { get; set; }

                        /// <summary>
                        /// <para>Expression</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>知道</para>
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>API Message</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>HTTP Status Code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>API Message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Is Success</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
