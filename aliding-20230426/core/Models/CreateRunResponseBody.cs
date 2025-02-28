// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("cancelledAt")]
        [Validation(Required=false)]
        public long? CancelledAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public CreateRunResponseBodyContent Content { get; set; }
        public class CreateRunResponseBodyContent : TeaModel {
            [NameInMap("cardCallback")]
            [Validation(Required=false)]
            public CreateRunResponseBodyContentCardCallback CardCallback { get; set; }
            public class CreateRunResponseBodyContentCardCallback : TeaModel {
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
            public CreateRunResponseBodyContentDingCard DingCard { get; set; }
            public class CreateRunResponseBodyContentDingCard : TeaModel {
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
            public CreateRunResponseBodyContentImageUrl ImageUrl { get; set; }
            public class CreateRunResponseBodyContentImageUrl : TeaModel {
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
            public CreateRunResponseBodyContentMarkdown Markdown { get; set; }
            public class CreateRunResponseBodyContentMarkdown : TeaModel {
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
            public CreateRunResponseBodyContentText Text { get; set; }
            public class CreateRunResponseBodyContentText : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>你好！</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>{}</para>
        /// </summary>
        [NameInMap("delta")]
        [Validation(Required=false)]
        public CreateRunResponseBodyDelta Delta { get; set; }
        public class CreateRunResponseBodyDelta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public CreateRunResponseBodyDeltaContent Content { get; set; }
            public class CreateRunResponseBodyDeltaContent : TeaModel {
                [NameInMap("cardCallback")]
                [Validation(Required=false)]
                public CreateRunResponseBodyDeltaContentCardCallback CardCallback { get; set; }
                public class CreateRunResponseBodyDeltaContentCardCallback : TeaModel {
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
                public CreateRunResponseBodyDeltaContentDingCard DingCard { get; set; }
                public class CreateRunResponseBodyDeltaContentDingCard : TeaModel {
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
                public CreateRunResponseBodyDeltaContentImageUrl ImageUrl { get; set; }
                public class CreateRunResponseBodyDeltaContentImageUrl : TeaModel {
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
                public CreateRunResponseBodyDeltaContentMarkdown Markdown { get; set; }
                public class CreateRunResponseBodyDeltaContentMarkdown : TeaModel {
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
                public CreateRunResponseBodyDeltaContentText Text { get; set; }
                public class CreateRunResponseBodyDeltaContentText : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好！</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
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
        [NameInMap("expiresAt")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("failedAt")]
        [Validation(Required=false)]
        public long? FailedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>runId123</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>errorMsg</para>
        /// </summary>
        [NameInMap("lastErrorMsg")]
        [Validation(Required=false)]
        public string LastErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thread.run</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public string Object { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1642448000000</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public long? StartedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
