// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateRunResponseBody : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<CreateRunResponseBodyMessages> Messages { get; set; }
        public class CreateRunResponseBodyMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public CreateRunResponseBodyMessagesContent Content { get; set; }
            public class CreateRunResponseBodyMessagesContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public CreateRunResponseBodyMessagesContentCardCallback CardCallback { get; set; }
                public class CreateRunResponseBodyMessagesContentCardCallback : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>aliding_messageId123</para>
                    /// </summary>
                    [NameInMap("relatedMessageId")]
                    [Validation(Required=false)]
                    public string RelatedMessageId { get; set; }

                }

                [NameInMap("dingCard")]
                [Validation(Required=false)]
                public CreateRunResponseBodyMessagesContentDingCard DingCard { get; set; }
                public class CreateRunResponseBodyMessagesContentDingCard : TeaModel {
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
                public CreateRunResponseBodyMessagesContentDingNormalCard DingNormalCard { get; set; }
                public class CreateRunResponseBodyMessagesContentDingNormalCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("cardData")]
                    [Validation(Required=false)]
                    public CreateRunResponseBodyMessagesContentDingNormalCardCardData CardData { get; set; }
                    public class CreateRunResponseBodyMessagesContentDingNormalCardCardData : TeaModel {
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
                    public CreateRunResponseBodyMessagesContentDingNormalCardCardUpdateOptions CardUpdateOptions { get; set; }
                    public class CreateRunResponseBodyMessagesContentDingNormalCardCardUpdateOptions : TeaModel {
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
                    public List<CreateRunResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
                    public class CreateRunResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigs : TeaModel {
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
                        public CreateRunResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                        public class CreateRunResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig : TeaModel {
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
                public CreateRunResponseBodyMessagesContentMarkdown Markdown { get; set; }
                public class CreateRunResponseBodyMessagesContentMarkdown : TeaModel {
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
                public CreateRunResponseBodyMessagesContentStructView StructView { get; set; }
                public class CreateRunResponseBodyMessagesContentStructView : TeaModel {
                    [NameInMap("parts")]
                    [Validation(Required=false)]
                    public List<CreateRunResponseBodyMessagesContentStructViewParts> Parts { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructViewParts : TeaModel {
                        [NameInMap("append")]
                        [Validation(Required=false)]
                        public bool? Append { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("dataPart")]
                        [Validation(Required=false)]
                        public CreateRunResponseBodyMessagesContentStructViewPartsDataPart DataPart { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructViewPartsDataPart : TeaModel {
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
                        public CreateRunResponseBodyMessagesContentStructViewPartsReasonPart ReasonPart { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructViewPartsReasonPart : TeaModel {
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
                        public CreateRunResponseBodyMessagesContentStructViewPartsRecommendPart RecommendPart { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructViewPartsRecommendPart : TeaModel {
                            [NameInMap("recommends")]
                            [Validation(Required=false)]
                            public List<CreateRunResponseBodyMessagesContentStructViewPartsRecommendPartRecommends> Recommends { get; set; }
                            public class CreateRunResponseBodyMessagesContentStructViewPartsRecommendPartRecommends : TeaModel {
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
                        public CreateRunResponseBodyMessagesContentStructViewPartsReferencePart ReferencePart { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructViewPartsReferencePart : TeaModel {
                            [NameInMap("references")]
                            [Validation(Required=false)]
                            public List<CreateRunResponseBodyMessagesContentStructViewPartsReferencePartReferences> References { get; set; }
                            public class CreateRunResponseBodyMessagesContentStructViewPartsReferencePartReferences : TeaModel {
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
                        public CreateRunResponseBodyMessagesContentStructViewPartsTextPart TextPart { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructViewPartsTextPart : TeaModel {
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
                public CreateRunResponseBodyMessagesContentText Text { get; set; }
                public class CreateRunResponseBodyMessagesContentText : TeaModel {
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

            [NameInMap("contentStruct")]
            [Validation(Required=false)]
            public CreateRunResponseBodyMessagesContentStruct ContentStruct { get; set; }
            public class CreateRunResponseBodyMessagesContentStruct : TeaModel {
                [NameInMap("parts")]
                [Validation(Required=false)]
                public List<CreateRunResponseBodyMessagesContentStructParts> Parts { get; set; }
                public class CreateRunResponseBodyMessagesContentStructParts : TeaModel {
                    [NameInMap("append")]
                    [Validation(Required=false)]
                    public bool? Append { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("dataPart")]
                    [Validation(Required=false)]
                    public CreateRunResponseBodyMessagesContentStructPartsDataPart DataPart { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructPartsDataPart : TeaModel {
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
                    public CreateRunResponseBodyMessagesContentStructPartsReasonPart ReasonPart { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructPartsReasonPart : TeaModel {
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
                    public CreateRunResponseBodyMessagesContentStructPartsRecommendPart RecommendPart { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructPartsRecommendPart : TeaModel {
                        [NameInMap("recommends")]
                        [Validation(Required=false)]
                        public List<CreateRunResponseBodyMessagesContentStructPartsRecommendPartRecommends> Recommends { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructPartsRecommendPartRecommends : TeaModel {
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
                    public CreateRunResponseBodyMessagesContentStructPartsReferencePart ReferencePart { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructPartsReferencePart : TeaModel {
                        [NameInMap("references")]
                        [Validation(Required=false)]
                        public List<CreateRunResponseBodyMessagesContentStructPartsReferencePartReferences> References { get; set; }
                        public class CreateRunResponseBodyMessagesContentStructPartsReferencePartReferences : TeaModel {
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
                    public CreateRunResponseBodyMessagesContentStructPartsTextPart TextPart { get; set; }
                    public class CreateRunResponseBodyMessagesContentStructPartsTextPart : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1642448000000</para>
            /// </summary>
            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>messageId1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>runId1</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>threadId1</para>
            /// </summary>
            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("run")]
        [Validation(Required=false)]
        public CreateRunResponseBodyRun Run { get; set; }
        public class CreateRunResponseBodyRun : TeaModel {
            [NameInMap("cancelledAt")]
            [Validation(Required=false)]
            public long? CancelledAt { get; set; }

            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public long? CompletedAt { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("expiresAt")]
            [Validation(Required=false)]
            public long? ExpiresAt { get; set; }

            [NameInMap("failedAt")]
            [Validation(Required=false)]
            public long? FailedAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("lastErrorMsg")]
            [Validation(Required=false)]
            public string LastErrorMsg { get; set; }

            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public long? StartedAt { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("threadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

        }

    }

}
