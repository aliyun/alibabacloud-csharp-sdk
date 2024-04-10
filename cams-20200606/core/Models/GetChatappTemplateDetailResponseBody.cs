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
                /// The note indicating that customers cannot share verification codes with others. The note is displayed in the message body. This parameter is valid if Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to BODY in a WhatsApp message template.
                /// </summary>
                [NameInMap("AddSecretRecommendation")]
                [Validation(Required=false)]
                public bool? AddSecretRecommendation { get; set; }

                /// <summary>
                /// The buttons. Specify this parameter only if you set the Type sub-parameter of the Components parameter to **BUTTONS**. Before you specify this parameter, the format of the value must be changed from JSON to String.
                /// </summary>
                [NameInMap("Buttons")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    /// <summary>
                    /// The text of the one-tap autofill button. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.
                    /// </summary>
                    [NameInMap("AutofillText")]
                    [Validation(Required=false)]
                    public string AutofillText { get; set; }

                    /// <summary>
                    /// The coupon code.
                    /// </summary>
                    [NameInMap("CouponCode")]
                    [Validation(Required=false)]
                    public string CouponCode { get; set; }

                    /// <summary>
                    /// The extended fields.
                    /// </summary>
                    [NameInMap("ExtendAttrs")]
                    [Validation(Required=false)]
                    public GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs ExtendAttrs { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsButtonsExtendAttrs : TeaModel {
                        /// <summary>
                        /// The event type.
                        /// </summary>
                        [NameInMap("Action")]
                        [Validation(Required=false)]
                        public string Action { get; set; }

                        /// <summary>
                        /// The intent code.
                        /// </summary>
                        [NameInMap("IntentCode")]
                        [Validation(Required=false)]
                        public string IntentCode { get; set; }

                        /// <summary>
                        /// The language of the next template.
                        /// </summary>
                        [NameInMap("NextLanguageCode")]
                        [Validation(Required=false)]
                        public string NextLanguageCode { get; set; }

                        /// <summary>
                        /// The code of the next template.
                        /// </summary>
                        [NameInMap("NextTemplateCode")]
                        [Validation(Required=false)]
                        public string NextTemplateCode { get; set; }

                        /// <summary>
                        /// The name of the next template.
                        /// </summary>
                        [NameInMap("NextTemplateName")]
                        [Validation(Required=false)]
                        public string NextTemplateName { get; set; }

                    }

                    /// <summary>
                    /// flow 数据事件类型
                    /// 取值范围：NAVIGATE/DATA_EXCHANGE
                    /// </summary>
                    [NameInMap("FlowAction")]
                    [Validation(Required=false)]
                    public string FlowAction { get; set; }

                    /// <summary>
                    /// Flow ID
                    /// </summary>
                    [NameInMap("FlowId")]
                    [Validation(Required=false)]
                    public string FlowId { get; set; }

                    /// <summary>
                    /// The unsubscribe button. This parameter is valid if Category is set to MARKETING and the Type sub-parameter of the Buttons parameter is set to QUICK_REPLY in a WhatsApp message template. After you configure message sending in the ChatApp Message Service console, marketing messages will not be sent to customers if they click this button.
                    /// </summary>
                    [NameInMap("IsOptOut")]
                    [Validation(Required=false)]
                    public bool? IsOptOut { get; set; }

                    /// <summary>
                    /// 跳转屏 
                    /// 在FlowAction=NAVIGATE时必填
                    /// </summary>
                    [NameInMap("NavigateScreen")]
                    [Validation(Required=false)]
                    public string NavigateScreen { get; set; }

                    /// <summary>
                    /// The app package name that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.
                    /// </summary>
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    /// <summary>
                    /// The phone number. This parameter is valid only if the Type sub-parameter of the Buttons parameter is set to **PHONE_NUMBER**.
                    /// </summary>
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public string PhoneNumber { get; set; }

                    /// <summary>
                    /// The app signing key hash that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP in a WhatsApp message template.
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
                    /// *   **PHONE_NUMBER**: phone call button
                    /// *   **URL**: URL button
                    /// *   **QUICK_REPLY**: quick reply button
                    /// 
                    /// > 
                    /// 
                    /// *   In a message template, a quick reply button cannot be used together with a phone call button or a URL button.
                    /// 
                    /// *   You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a message template.
                    /// 
                    /// *   You can add only one button to a Viber message template, and you must set the Type sub-parameter of the Buttons parameter to URL.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// The URL to which you are redirected when you click the URL button.
                    /// </summary>
                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    /// <summary>
                    /// The type of the URL. Valid values:
                    /// 
                    /// *   **static**
                    /// *   **dynamic**
                    /// </summary>
                    [NameInMap("UrlType")]
                    [Validation(Required=false)]
                    public string UrlType { get; set; }

                }

                /// <summary>
                /// The description of the document.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// The carousel cards.
                /// </summary>
                [NameInMap("Cards")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsCards> Cards { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsCards : TeaModel {
                    /// <summary>
                    /// The card components.
                    /// </summary>
                    [NameInMap("CardComponents")]
                    [Validation(Required=false)]
                    public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents> CardComponents { get; set; }
                    public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponents : TeaModel {
                        /// <summary>
                        /// The card buttons.
                        /// </summary>
                        [NameInMap("Buttons")]
                        [Validation(Required=false)]
                        public List<GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons> Buttons { get; set; }
                        public class GetChatappTemplateDetailResponseBodyDataComponentsCardsCardComponentsButtons : TeaModel {
                            /// <summary>
                            /// The phone number.
                            /// </summary>
                            [NameInMap("PhoneNumber")]
                            [Validation(Required=false)]
                            public string PhoneNumber { get; set; }

                            /// <summary>
                            /// The button content.
                            /// </summary>
                            [NameInMap("Text")]
                            [Validation(Required=false)]
                            public string Text { get; set; }

                            /// <summary>
                            /// The type of the button in the carousel template. Valid values: URL, PHONE_NUMBER, and QUICK_REQLY.
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
                            /// The type of the URL. Valid values: static and dynamic.
                            /// </summary>
                            [NameInMap("UrlType")]
                            [Validation(Required=false)]
                            public string UrlType { get; set; }

                        }

                        /// <summary>
                        /// The type of the header in the carousel template. The header can only be an image or a video. The headers of all cards must be the same.
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// The card text.
                        /// </summary>
                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// The type of the component.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The URL address.
                        /// </summary>
                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }

                /// <summary>
                /// The validity period of the verification code in the WhatsApp authentication template. Unit: minutes. This parameter is valid only when Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to FOOTER in a WhatsApp message template. The validity period of the verification code is displayed in the footer.
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
                /// The name of the document.
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// The type of the document attached in the Viber message template.
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// The format.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The latitude of the location.
                /// </summary>
                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// The address of the location.
                /// </summary>
                [NameInMap("LocationAddress")]
                [Validation(Required=false)]
                public string LocationAddress { get; set; }

                /// <summary>
                /// The name of the location.
                /// </summary>
                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                /// <summary>
                /// The longitude of the location.
                /// </summary>
                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// The variable when the coupon code expires in the limited-time offer template.
                /// </summary>
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
                /// *   The following limits apply to components in WhatsApp message templates: A **BODY** component cannot exceed 1,024 characters in length. A **HEADER** or **FOOTER** component cannot exceed 60 characters in length.
                /// 
                /// *   **FOOTER** components are not supported in Viber message templates.
                /// 
                /// *   In a Viber message template, media resources such as images, videos, and documents are placed in the **HEADER** component. If a Viber message contains both text and an image, the image is placed below the text in the message received on a device.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The URL of the media resource.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// Indicates whether the coupon code will expire in the limited-time offer template.
                /// </summary>
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
            /// The validity period of the WhatsApp authentication message.
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
            /// The quality of the template.
            /// </summary>
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public string QualityScore { get; set; }

            /// <summary>
            /// The reason why the template was rejected.
            /// </summary>
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
