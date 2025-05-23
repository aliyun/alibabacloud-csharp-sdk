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
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<GetAssistantCapabilityRequestContent> Content { get; set; }
        public class GetAssistantCapabilityRequestContent : TeaModel {
            [NameInMap("cardCallback")]
            [Validation(Required=false)]
            public GetAssistantCapabilityRequestContentCardCallback CardCallback { get; set; }
            public class GetAssistantCapabilityRequestContentCardCallback : TeaModel {
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
            public GetAssistantCapabilityRequestContentDingCard DingCard { get; set; }
            public class GetAssistantCapabilityRequestContentDingCard : TeaModel {
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
            public GetAssistantCapabilityRequestContentImageUrl ImageUrl { get; set; }
            public class GetAssistantCapabilityRequestContentImageUrl : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>auto</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>这是一张小猫钓鱼图</para>
                /// </summary>
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
            public GetAssistantCapabilityRequestContentMarkdown Markdown { get; set; }
            public class GetAssistantCapabilityRequestContentMarkdown : TeaModel {
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
            public GetAssistantCapabilityRequestContentText Text { get; set; }
            public class GetAssistantCapabilityRequestContentText : TeaModel {
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
        /// <para>id1</para>
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
