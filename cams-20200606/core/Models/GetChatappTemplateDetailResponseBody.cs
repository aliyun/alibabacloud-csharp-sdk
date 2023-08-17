// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappTemplateDetailResponseBodyData Data { get; set; }
        public class GetChatappTemplateDetailResponseBodyData : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("Components")]
            [Validation(Required=false)]
            public List<GetChatappTemplateDetailResponseBodyDataComponents> Components { get; set; }
            public class GetChatappTemplateDetailResponseBodyDataComponents : TeaModel {
                /// <summary>
                /// Whatsapp类型模板，Category为Authentication，并且Component Type为Body时有效，表示在Body上面显示不要将验证码信息提供给其它人的提示信息
                /// </summary>
                [NameInMap("AddSecretRecommendation")]
                [Validation(Required=false)]
                public bool? AddSecretRecommendation { get; set; }

                [NameInMap("Buttons")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    /// <summary>
                    /// Whatsapp模板，Category为Authentication，并且Button Type为ONE_TAP时必填，Whatsap Autofill操作的按钮文本
                    /// </summary>
                    [NameInMap("AutofillText")]
                    [Validation(Required=false)]
                    public string AutofillText { get; set; }

                    /// <summary>
                    /// 扩展字段
                    /// </summary>
                    [NameInMap("ExtendAttrs")]
                    [Validation(Required=false)]
                    public GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs ExtendAttrs { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs : TeaModel {
                        /// <summary>
                        /// 事件类型
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// 意图编码
                        /// </summary>
                        [NameInMap("IntentCode")]
                        [Validation(Required=false)]
                        public string IntentCode { get; set; }

                        /// <summary>
                        /// 下一个模板语言
                        /// </summary>
                        [NameInMap("NextLanguageCode")]
                        [Validation(Required=false)]
                        public string NextLanguageCode { get; set; }

                        /// <summary>
                        /// 下一个模板编码
                        /// </summary>
                        [NameInMap("NextTemplateCode")]
                        [Validation(Required=false)]
                        public string NextTemplateCode { get; set; }

                        /// <summary>
                        /// 下一个模板名称
                        /// </summary>
                        [NameInMap("NextTemplateName")]
                        [Validation(Required=false)]
                        public string NextTemplateName { get; set; }

                    }

                    /// <summary>
                    /// Whatsapp模板，在Category为Marketing,并且Button type为QUICK_REPLY时有效，表示按钮为营销退订按钮，客户如果点击了此按钮，并且在chatapp平台上配置了发送控制操作，则后续Marketing消息则不会发送到客户
                    /// </summary>
                    [NameInMap("IsOptOut")]
                    [Validation(Required=false)]
                    public bool? IsOptOut { get; set; }

                    /// <summary>
                    /// Whatsapp模板，Category为Authentication，并且Button Type为ONE_TAP时必填，表示Whatsapp调起应用的包名
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// Whatsapp模板，Category为Authentication，并且Button Type为ONE_TAP时必填，表示Whatsapp调起应用的签名Hash值
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("UrlType")]
                    [Validation(Required=false)]
                    public string UrlType { get; set; }

                }

                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// Whatsapp Authentication模板验证码有效期（分钟），只在Whatsapp类型消息，Category为Authentication并且Component Type为Footer时有效（此信息显示在Footer位置）
                /// </summary>
                [NameInMap("CodeExpirationMinutes")]
                [Validation(Required=false)]
                public int? CodeExpirationMinutes { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// 位置纬度属性
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// 位置地址
                /// </summary>
                [NameInMap("LocationAddress")]
                [Validation(Required=false)]
                public string LocationAddress { get; set; }

                /// <summary>
                /// 位置名称
                /// </summary>
                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                /// <summary>
                /// 位置经度属性
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                [NameInMap("ThumbUrl")]
                [Validation(Required=false)]
                public string ThumbUrl { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public Dictionary<string, string> Example { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("MessageSendTtlSeconds")]
            [Validation(Required=false)]
            public int? MessageSendTtlSeconds { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public string QualityScore { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
