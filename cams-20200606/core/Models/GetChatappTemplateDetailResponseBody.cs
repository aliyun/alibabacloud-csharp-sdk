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

        /// <summary>
        /// The HTTP status code.
        /// 
        /// *   Example: OK. This value indicates that the request is successful.
        /// *   Other codes indicate that the request fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappTemplateDetailResponseBodyData Data { get; set; }
        public class GetChatappTemplateDetailResponseBodyData : TeaModel {
            /// <summary>
            /// The review status of the message template. Valid values:
            /// 
            /// *   **pass**: The message template is approved.
            /// *   **fail**: The message template is rejected.
            /// *   **auditing**: The message template is being reviewed.
            /// *   **unaudit**: The review is suspended.
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// The category of the template when the returned value of TemplateType is WHATSAPP. Valid values:
            /// 
            /// *   **UTILITY**: a transactional template
            /// *   **MARKETING**: a marketing template
            /// *   **AUTHENTICATION**: an identity authentication template
            /// 
            /// The category of the template when the returned value of the TemplateType parameter is VIBER. Valid values:
            /// 
            /// *   **text**: a template that contains only text
            /// *   **image**: a template that contains only images
            /// *   **text_image_button**: a template that contains text, images, and buttons
            /// *   **text_button**: a template that contains text and buttons
            /// *   **document**: a template that contains only files
            /// *   **video**: a template that contains only videos
            /// *   **text_video**: a template that contains text and videos
            /// *   **text_video_button**: a template that contains text, videos, and buttons
            /// *   **text_image**: a template that contains text and images
            /// 
            /// > If Category is set to text_video_button, users cannot open a web page by clicking the button. Users can open only the video in the message. In this case, you do not need to specify the Url parameter for the URL button in the template.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The components of the message template.
            /// </summary>
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

                /// <summary>
                /// This parameter applies only to components of the **BUTTONS** type. This parameter is passed in by converting its original JSON structure into a string.
                /// </summary>
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

                    [NameInMap("CouponCode")]
                    [Validation(Required=false)]
                    public string CouponCode { get; set; }

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

                    [NameInMap("FlowAction")]
                    [Validation(Required=false)]
                    public string FlowAction { get; set; }

                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }

                    /// <summary>
                    /// Whatsapp模板，在Category为Marketing,并且Button type为QUICK_REPLY时有效，表示按钮为营销退订按钮，客户如果点击了此按钮，并且在chatapp平台上配置了发送控制操作，则后续Marketing消息则不会发送到客户
                    /// </summary>
                    [NameInMap("IsOptOut")]
                    [Validation(Required=false)]
                    public bool? IsOptOut { get; set; }

                    [NameInMap("NavigateScreen")]
                    [Validation(Required=false)]
                    public string NavigateScreen { get; set; }

                    /// <summary>
                    /// Whatsapp模板，Category为Authentication，并且Button Type为ONE_TAP时必填，表示Whatsapp调起应用的包名
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// The phone number. This parameter is valid only if the returned value of the Type parameter is **PHONE_NUMBER**.
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// Whatsapp模板，Category为Authentication，并且Button Type为ONE_TAP时必填，表示Whatsapp调起应用的签名Hash值
                    /// </summary>
                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                    /// <summary>
                    /// The display name of the button.
                    /// </summary>
                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    /// <summary>
                    /// The type of the button. Valid values:
                    /// 
                    /// *   **PHONE_NUMBER**: a phone call button
                    /// *   **URL**: a URL button
                    /// *   **QUICK_REPLY**: a quick reply button
                    /// 
                    /// > 
                    /// 
                    /// *   A quick reply button cannot coexist with a phone call button or a URL button in a message template.
                    /// 
                    /// *   You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a message template.
                    /// 
                    /// *   You can add only one button to a Viber message template, and the button must be a URL button.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The URL to be accessed when you click the URL button.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// The type of the URL. Valid values:
                    /// 
                    /// *   **static**: a static URL
                    /// *   **dynamic**: a dynamic URL
                    /// </summary>
                    [NameInMap("UrlType")]
                    [Validation(Required=false)]
                    public string UrlType { get; set; }

                }

                /// <summary>
                /// The description of the file.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                [NameInMap("Cards")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsCards> Cards { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsCards : TeaModel {
                    [NameInMap("CardComponents")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents> CardComponents { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents : TeaModel {
                        [NameInMap("Buttons")]
                        [Validation(Required=false)]
                        public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons> Buttons { get; set; }
                        public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons : TeaModel {
                            [NameInMap("PhoneNumber")]
                            [Validation(Required=false)]
                            public string PhoneNumber { get; set; }

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

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// Whatsapp Authentication模板验证码有效期（分钟），只在Whatsapp类型消息，Category为Authentication并且Component Type为Footer时有效（此信息显示在Footer位置）
                /// </summary>
                [NameInMap("CodeExpirationMinutes")]
                [Validation(Required=false)]
                public int? CodeExpirationMinutes { get; set; }

                /// <summary>
                /// The length of the video in the Viber message template. Valid values: 0 to 600. Unit: seconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The name of the file.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The type of the file attached in the Viber message template.
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// The type of the media resources that are included in the message.
                /// </summary>
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

                [NameInMap("OfferExpirationTimeMs")]
                [Validation(Required=false)]
                public string OfferExpirationTimeMs { get; set; }

                /// <summary>
                /// The text of the message that you want to send.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The thumbnail URL of the video in the Viber message template.
                /// </summary>
                [NameInMap("ThumbUrl")]
                [Validation(Required=false)]
                public string ThumbUrl { get; set; }

                /// <summary>
                /// The type of the component. Valid values:
                /// 
                /// *   **BODY**
                /// *   **HEADER**
                /// *   **FOOTER**
                /// *   **BUTTONS**
                /// 
                /// > 
                /// 
                /// *   The following limits apply to components in WhatsApp message templates: A component of the **BODY** type cannot exceed 1,024 characters. A component of the **HEADER** or **FOOTER** type cannot exceed 60 characters in length.
                /// 
                /// > 
                /// 
                /// *   **FOOTER** components are not supported in Viber message templates.
                /// 
                /// > 
                /// 
                /// *   In a Viber message template, a media resource, such as an image, a video, or a file, is placed in the **HEADER** component. If a Viber message contains text and an image, the image is placed under the text in the message received on a device.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The URL of the material.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("hasExpiration")]
                [Validation(Required=false)]
                public bool? HasExpiration { get; set; }

            }

            /// <summary>
            /// The examples of variables.
            /// </summary>
            [NameInMap("Example")]
            [Validation(Required=false)]
            public Dictionary<string, string> Example { get; set; }

            /// <summary>
            /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// Whatsapp中Authentication类型模板发送消息时的消息有效期
            /// </summary>
            [NameInMap("MessageSendTtlSeconds")]
            [Validation(Required=false)]
            public int? MessageSendTtlSeconds { get; set; }

            /// <summary>
            /// The name of the message template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模板质量
            /// </summary>
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public string QualityScore { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// The code of the message template.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// The type of the message template. Valid values:
            /// 
            /// *   **WHATSAPP**
            /// *   **VIBER**
            /// *   LINE (developing)
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
