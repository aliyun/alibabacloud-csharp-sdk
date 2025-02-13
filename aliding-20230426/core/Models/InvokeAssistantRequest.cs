// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class InvokeAssistantRequest : TeaModel {
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
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;type&quot;: &quot;text&quot;,
        ///         &quot;text&quot;: &quot;你好&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<InvokeAssistantRequestContent> Content { get; set; }
        public class InvokeAssistantRequestContent : TeaModel {
            [NameInMap("cardCallback")]
            [Validation(Required=false)]
            public InvokeAssistantRequestContentCardCallback CardCallback { get; set; }
            public class InvokeAssistantRequestContentCardCallback : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>templateId123</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>012345</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("dingCard")]
            [Validation(Required=false)]
            public InvokeAssistantRequestContentDingCard DingCard { get; set; }
            public class InvokeAssistantRequestContentDingCard : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>卡片描述</para>
                /// </summary>
                [NameInMap("cardDesc")]
                [Validation(Required=false)]
                public string CardDesc { get; set; }

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

            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public InvokeAssistantRequestContentImageUrl ImageUrl { get; set; }
            public class InvokeAssistantRequestContentImageUrl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("imageDesc")]
                [Validation(Required=false)]
                public string ImageDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/1234.png">https://img.alicdn.com/1234.png</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("markdown")]
            [Validation(Required=false)]
            public InvokeAssistantRequestContentMarkdown Markdown { get; set; }
            public class InvokeAssistantRequestContentMarkdown : TeaModel {
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

            [NameInMap("text")]
            [Validation(Required=false)]
            public InvokeAssistantRequestContentText Text { get; set; }
            public class InvokeAssistantRequestContentText : TeaModel {
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
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("history")]
        [Validation(Required=false)]
        public List<InvokeAssistantRequestHistory> History { get; set; }
        public class InvokeAssistantRequestHistory : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<InvokeAssistantRequestHistoryContent> Content { get; set; }
            public class InvokeAssistantRequestHistoryContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public InvokeAssistantRequestHistoryContentCardCallback CardCallback { get; set; }
                public class InvokeAssistantRequestHistoryContentCardCallback : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>templateId123</para>
                    /// </summary>
                    [NameInMap("templateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>012345</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("dingCard")]
                [Validation(Required=false)]
                public InvokeAssistantRequestHistoryContentDingCard DingCard { get; set; }
                public class InvokeAssistantRequestHistoryContentDingCard : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>卡片描述</para>
                    /// </summary>
                    [NameInMap("cardDesc")]
                    [Validation(Required=false)]
                    public string CardDesc { get; set; }

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

                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public InvokeAssistantRequestHistoryContentImageUrl ImageUrl { get; set; }
                public class InvokeAssistantRequestHistoryContentImageUrl : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>auto</para>
                    /// </summary>
                    [NameInMap("detail")]
                    [Validation(Required=false)]
                    public string Detail { get; set; }

                    [NameInMap("imageDesc")]
                    [Validation(Required=false)]
                    public string ImageDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://img.alicdn.com/1234.png">https://img.alicdn.com/1234.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("markdown")]
                [Validation(Required=false)]
                public InvokeAssistantRequestHistoryContentMarkdown Markdown { get; set; }
                public class InvokeAssistantRequestHistoryContentMarkdown : TeaModel {
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

                [NameInMap("text")]
                [Validation(Required=false)]
                public InvokeAssistantRequestHistoryContentText Text { get; set; }
                public class InvokeAssistantRequestHistoryContentText : TeaModel {
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
                /// <para>text</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
        /// <para>sessionId1</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
