// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListMessageResponseBody : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<ListMessageResponseBodyMessages> Messages { get; set; }
        public class ListMessageResponseBodyMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public ListMessageResponseBodyMessagesContent Content { get; set; }
            public class ListMessageResponseBodyMessagesContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public ListMessageResponseBodyMessagesContentCardCallback CardCallback { get; set; }
                public class ListMessageResponseBodyMessagesContentCardCallback : TeaModel {
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
                public ListMessageResponseBodyMessagesContentDingCard DingCard { get; set; }
                public class ListMessageResponseBodyMessagesContentDingCard : TeaModel {
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
                public ListMessageResponseBodyMessagesContentDingNormalCard DingNormalCard { get; set; }
                public class ListMessageResponseBodyMessagesContentDingNormalCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("cardData")]
                    [Validation(Required=false)]
                    public ListMessageResponseBodyMessagesContentDingNormalCardCardData CardData { get; set; }
                    public class ListMessageResponseBodyMessagesContentDingNormalCardCardData : TeaModel {
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
                    public ListMessageResponseBodyMessagesContentDingNormalCardCardUpdateOptions CardUpdateOptions { get; set; }
                    public class ListMessageResponseBodyMessagesContentDingNormalCardCardUpdateOptions : TeaModel {
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
                    public List<ListMessageResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigs> DynamicDataSourceConfigs { get; set; }
                    public class ListMessageResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigs : TeaModel {
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
                        public ListMessageResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig PullConfig { get; set; }
                        public class ListMessageResponseBodyMessagesContentDingNormalCardDynamicDataSourceConfigsPullConfig : TeaModel {
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
                public ListMessageResponseBodyMessagesContentMarkdown Markdown { get; set; }
                public class ListMessageResponseBodyMessagesContentMarkdown : TeaModel {
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
                public ListMessageResponseBodyMessagesContentStructView StructView { get; set; }
                public class ListMessageResponseBodyMessagesContentStructView : TeaModel {
                    [NameInMap("parts")]
                    [Validation(Required=false)]
                    public List<ListMessageResponseBodyMessagesContentStructViewParts> Parts { get; set; }
                    public class ListMessageResponseBodyMessagesContentStructViewParts : TeaModel {
                        [NameInMap("append")]
                        [Validation(Required=false)]
                        public bool? Append { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("dataPart")]
                        [Validation(Required=false)]
                        public ListMessageResponseBodyMessagesContentStructViewPartsDataPart DataPart { get; set; }
                        public class ListMessageResponseBodyMessagesContentStructViewPartsDataPart : TeaModel {
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
                        public ListMessageResponseBodyMessagesContentStructViewPartsReasonPart ReasonPart { get; set; }
                        public class ListMessageResponseBodyMessagesContentStructViewPartsReasonPart : TeaModel {
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
                        public ListMessageResponseBodyMessagesContentStructViewPartsRecommendPart RecommendPart { get; set; }
                        public class ListMessageResponseBodyMessagesContentStructViewPartsRecommendPart : TeaModel {
                            [NameInMap("recommends")]
                            [Validation(Required=false)]
                            public List<ListMessageResponseBodyMessagesContentStructViewPartsRecommendPartRecommends> Recommends { get; set; }
                            public class ListMessageResponseBodyMessagesContentStructViewPartsRecommendPartRecommends : TeaModel {
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
                        public ListMessageResponseBodyMessagesContentStructViewPartsReferencePart ReferencePart { get; set; }
                        public class ListMessageResponseBodyMessagesContentStructViewPartsReferencePart : TeaModel {
                            [NameInMap("references")]
                            [Validation(Required=false)]
                            public List<ListMessageResponseBodyMessagesContentStructViewPartsReferencePartReferences> References { get; set; }
                            public class ListMessageResponseBodyMessagesContentStructViewPartsReferencePartReferences : TeaModel {
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
                        public ListMessageResponseBodyMessagesContentStructViewPartsTextPart TextPart { get; set; }
                        public class ListMessageResponseBodyMessagesContentStructViewPartsTextPart : TeaModel {
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
                public ListMessageResponseBodyMessagesContentText Text { get; set; }
                public class ListMessageResponseBodyMessagesContentText : TeaModel {
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

    }

}
