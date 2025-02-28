// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateMessageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CreateMessageResponseBodyContent> Content { get; set; }
        public class CreateMessageResponseBodyContent : TeaModel {
            [NameInMap("cardCallback")]
            [Validation(Required=false)]
            public CreateMessageResponseBodyContentCardCallback CardCallback { get; set; }
            public class CreateMessageResponseBodyContentCardCallback : TeaModel {
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
            public CreateMessageResponseBodyContentDingCard DingCard { get; set; }
            public class CreateMessageResponseBodyContentDingCard : TeaModel {
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
            public CreateMessageResponseBodyContentImageUrl ImageUrl { get; set; }
            public class CreateMessageResponseBodyContentImageUrl : TeaModel {
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
            public CreateMessageResponseBodyContentMarkdown Markdown { get; set; }
            public class CreateMessageResponseBodyContentMarkdown : TeaModel {
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
            public CreateMessageResponseBodyContentText Text { get; set; }
            public class CreateMessageResponseBodyContentText : TeaModel {
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
        /// <para>messageId123</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>thread.message</para>
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
        /// <para>user</para>
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>threadId123</para>
        /// </summary>
        [NameInMap("threadId")]
        [Validation(Required=false)]
        public string ThreadId { get; set; }

    }

}
