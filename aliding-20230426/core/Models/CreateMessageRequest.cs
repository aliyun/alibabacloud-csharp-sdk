// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMessageRequest : TeaModel {
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
        public List<CreateMessageRequestMessages> Messages { get; set; }
        public class CreateMessageRequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public CreateMessageRequestMessagesContent Content { get; set; }
            public class CreateMessageRequestMessagesContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public CreateMessageRequestMessagesContentCardCallback CardCallback { get; set; }
                public class CreateMessageRequestMessagesContentCardCallback : TeaModel {
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
                public CreateMessageRequestMessagesContentDingCard DingCard { get; set; }
                public class CreateMessageRequestMessagesContentDingCard : TeaModel {
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
                public CreateMessageRequestMessagesContentDingNormalCard DingNormalCard { get; set; }
                public class CreateMessageRequestMessagesContentDingNormalCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("cardData")]
                    [Validation(Required=false)]
                    public CreateMessageRequestMessagesContentDingNormalCardCardData CardData { get; set; }
                    public class CreateMessageRequestMessagesContentDingNormalCardCardData : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("cardParamMap")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> CardParamMap { get; set; }

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
                    public CreateMessageRequestMessagesContentDingNormalCardCardUpdateOptions CardUpdateOptions { get; set; }
                    public class CreateMessageRequestMessagesContentDingNormalCardCardUpdateOptions : TeaModel {
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
                    public List<CreateMessageRequestMessagesContentDingNormalCardDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
                    public class CreateMessageRequestMessagesContentDingNormalCardDynamicDataSourceConfigs : TeaModel {
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
                        public CreateMessageRequestMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                        public class CreateMessageRequestMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig : TeaModel {
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
                    public Dictionary<string, Dictionary<string, object>> PrivateData { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public CreateMessageRequestMessagesContentMarkdown Markdown { get; set; }
                public class CreateMessageRequestMessagesContentMarkdown : TeaModel {
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
                public CreateMessageRequestMessagesContentStructView StructView { get; set; }
                public class CreateMessageRequestMessagesContentStructView : TeaModel {
                    [NameInMap("parts")]
                    [Validation(Required=false)]
                    public List<CreateMessageRequestMessagesContentStructViewParts> Parts { get; set; }
                    public class CreateMessageRequestMessagesContentStructViewParts : TeaModel {
                        [NameInMap("append")]
                        [Validation(Required=false)]
                        public bool? Append { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("dataPart")]
                        [Validation(Required=false)]
                        public CreateMessageRequestMessagesContentStructViewPartsDataPart DataPart { get; set; }
                        public class CreateMessageRequestMessagesContentStructViewPartsDataPart : TeaModel {
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
                        public CreateMessageRequestMessagesContentStructViewPartsReasonPart ReasonPart { get; set; }
                        public class CreateMessageRequestMessagesContentStructViewPartsReasonPart : TeaModel {
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
                        public CreateMessageRequestMessagesContentStructViewPartsRecommendPart RecommendPart { get; set; }
                        public class CreateMessageRequestMessagesContentStructViewPartsRecommendPart : TeaModel {
                            [NameInMap("recommends")]
                            [Validation(Required=false)]
                            public List<CreateMessageRequestMessagesContentStructViewPartsRecommendPartRecommends> Recommends { get; set; }
                            public class CreateMessageRequestMessagesContentStructViewPartsRecommendPartRecommends : TeaModel {
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
                        public CreateMessageRequestMessagesContentStructViewPartsReferencePart ReferencePart { get; set; }
                        public class CreateMessageRequestMessagesContentStructViewPartsReferencePart : TeaModel {
                            [NameInMap("references")]
                            [Validation(Required=false)]
                            public List<CreateMessageRequestMessagesContentStructViewPartsReferencePartReferences> References { get; set; }
                            public class CreateMessageRequestMessagesContentStructViewPartsReferencePartReferences : TeaModel {
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
                        public CreateMessageRequestMessagesContentStructViewPartsTextPart TextPart { get; set; }
                        public class CreateMessageRequestMessagesContentStructViewPartsTextPart : TeaModel {
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
                public CreateMessageRequestMessagesContentText Text { get; set; }
                public class CreateMessageRequestMessagesContentText : TeaModel {
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
        /// <para>assistantId</para>
        /// </summary>
        [NameInMap("originalAssistantId")]
        [Validation(Required=false)]
        public string OriginalAssistantId { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
