// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetAssistantCapabilityRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>assistantId1</para>
        /// </summary>
        [NameInMap("assistantId")]
        [Validation(Required=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<GetAssistantCapabilityRequestMessages> Messages { get; set; }
        public class GetAssistantCapabilityRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public GetAssistantCapabilityRequestMessagesContent Content { get; set; }
            public class GetAssistantCapabilityRequestMessagesContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentCardCallback CardCallback { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentCardCallback : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliding_messageId123</para>
                    /// </summary>
                    [NameInMap("relatedMessageId")]
                    [Validation(Required=false)]
                    public string RelatedMessageId { get; set; }

                }

                [NameInMap("dingCard")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentDingCard DingCard { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentDingCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>basic_card_schema</para>
                    /// </summary>
                    [NameInMap("contentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("finished")]
                    [Validation(Required=false)]
                    public bool? Finished { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>templateId123</para>
                    /// </summary>
                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("dingNormalCard")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentDingNormalCard DingNormalCard { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentDingNormalCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("cardData")]
                    [Validation(Required=false)]
                    public GetAssistantCapabilityRequestMessagesContentDingNormalCardCardData CardData { get; set; }
                    public class GetAssistantCapabilityRequestMessagesContentDingNormalCardCardData : TeaModel {
                        [NameInMap("cardParamMap")]
                        [Validation(Required=false)]
                        public object CardParamMap { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>templateId1</para>
                    /// </summary>
                    [NameInMap("cardTemplateId")]
                    [Validation(Required=false)]
                    public string CardTemplateId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("cardUpdateOptions")]
                    [Validation(Required=false)]
                    public GetAssistantCapabilityRequestMessagesContentDingNormalCardCardUpdateOptions CardUpdateOptions { get; set; }
                    public class GetAssistantCapabilityRequestMessagesContentDingNormalCardCardUpdateOptions : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("updateCardDataByKey")]
                        [Validation(Required=false)]
                        public bool? UpdateCardDataByKey { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("updatePrivateDataByKey")]
                        [Validation(Required=false)]
                        public bool? UpdatePrivateDataByKey { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("dynamicDataSourceConfigs")]
                    [Validation(Required=false)]
                    public List<GetAssistantCapabilityRequestMessagesContentDingNormalCardDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
                    public class GetAssistantCapabilityRequestMessagesContentDingNormalCardDynamicDataSourceConfigs : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("constParams")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> ConstParams { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>dynamicDataSourceId1</para>
                        /// </summary>
                        [NameInMap("dynamicDataSourceId")]
                        [Validation(Required=false)]
                        public string DynamicDataSourceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("pullConfig")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("interval")]
                            [Validation(Required=false)]
                            public int? Interval { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>NONE</para>
                            /// </summary>
                            [NameInMap("pullStrategy")]
                            [Validation(Required=false)]
                            public string PullStrategy { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>SECONDS</para>
                            /// </summary>
                            [NameInMap("timeUnit")]
                            [Validation(Required=false)]
                            public string TimeUnit { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("privateData")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> PrivateData { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentMarkdown Markdown { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentMarkdown : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <ol>
                    /// <item><description>markdown内容</description></item>
                    /// <item><description>markdown内容</description></item>
                    /// </ol>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("structView")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentStructView StructView { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentStructView : TeaModel {
                    [NameInMap("parts")]
                    [Validation(Required=false)]
                    public List<GetAssistantCapabilityRequestMessagesContentStructViewParts> Parts { get; set; }
                    public class GetAssistantCapabilityRequestMessagesContentStructViewParts : TeaModel {
                        [NameInMap("append")]
                        [Validation(Required=false)]
                        public bool? Append { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("dataPart")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentStructViewPartsDataPart DataPart { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentStructViewPartsDataPart : TeaModel {
                            [NameInMap("data")]
                            [Validation(Required=false)]
                            public object Data { get; set; }

                        }

                        [NameInMap("finish")]
                        [Validation(Required=false)]
                        public bool? Finish { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>这是正文内容部分</para>
                        /// </summary>
                        [NameInMap("partDesc")]
                        [Validation(Required=false)]
                        public string PartDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>artifactId123</para>
                        /// </summary>
                        [NameInMap("partId")]
                        [Validation(Required=false)]
                        public string PartId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("reasonPart")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentStructViewPartsReasonPart ReasonPart { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentStructViewPartsReasonPart : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123123</para>
                            /// </summary>
                            [NameInMap("reason")]
                            [Validation(Required=false)]
                            public string Reason { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("recommendPart")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentStructViewPartsRecommendPart RecommendPart { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentStructViewPartsRecommendPart : TeaModel {
                            [NameInMap("recommends")]
                            [Validation(Required=false)]
                            public List<GetAssistantCapabilityRequestMessagesContentStructViewPartsRecommendPartRecommends> Recommends { get; set; }
                            public class GetAssistantCapabilityRequestMessagesContentStructViewPartsRecommendPartRecommends : TeaModel {
                                [NameInMap("mobileUrl")]
                                [Validation(Required=false)]
                                public string MobileUrl { get; set; }

                                [NameInMap("text")]
                                [Validation(Required=false)]
                                public string Text { get; set; }

                                [NameInMap("url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("referencePart")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentStructViewPartsReferencePart ReferencePart { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentStructViewPartsReferencePart : TeaModel {
                            [NameInMap("references")]
                            [Validation(Required=false)]
                            public List<GetAssistantCapabilityRequestMessagesContentStructViewPartsReferencePartReferences> References { get; set; }
                            public class GetAssistantCapabilityRequestMessagesContentStructViewPartsReferencePartReferences : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("index")]
                                [Validation(Required=false)]
                                public string Index { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>mcp是....</para>
                                /// </summary>
                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>ata</para>
                                /// </summary>
                                [NameInMap("sourceCode")]
                                [Validation(Required=false)]
                                public string SourceCode { get; set; }

                                [NameInMap("sourceIcon")]
                                [Validation(Required=false)]
                                public string SourceIcon { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>摘要</para>
                                /// </summary>
                                [NameInMap("summary")]
                                [Validation(Required=false)]
                                public string Summary { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>《mcp原理介绍》</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para><a href="https://taobao.com">https://taobao.com</a></para>
                                /// </summary>
                                [NameInMap("url")]
                                [Validation(Required=false)]
                                public string Url { get; set; }

                            }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("textPart")]
                        [Validation(Required=false)]
                        public GetAssistantCapabilityRequestMessagesContentStructViewPartsTextPart TextPart { get; set; }
                        public class GetAssistantCapabilityRequestMessagesContentStructViewPartsTextPart : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>123123</para>
                            /// </summary>
                            [NameInMap("text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                        }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>textPart</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("text")]
                [Validation(Required=false)]
                public GetAssistantCapabilityRequestMessagesContentText Text { get; set; }
                public class GetAssistantCapabilityRequestMessagesContentText : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好！</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>枚举字段，可为：text,markdown,cardCallback,dingCard,agentArtifact,dingNormalCard</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是一张小猫钓鱼图</para>
            /// </summary>
            [NameInMap("contentDesc")]
            [Validation(Required=false)]
            public string ContentDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1642448000000</para>
            /// </summary>
            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>originalAssistantId1</para>
        /// </summary>
        [NameInMap("originalAssistantId")]
        [Validation(Required=false)]
        public string OriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cfp</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agentKey1</para>
        /// </summary>
        [NameInMap("sourceIdOfOriginalAssistantId")]
        [Validation(Required=false)]
        public string SourceIdOfOriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sourceTypeOfOriginalAssistantId")]
        [Validation(Required=false)]
        public string SourceTypeOfOriginalAssistantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>threadId</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
