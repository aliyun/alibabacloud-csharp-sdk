// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyChatappTemplateRequest : TeaModel {
        /// <summary>
        /// The category of the Viber message template. Valid values:
        /// 
        /// *   **text**: the template that contains only text
        /// *   **image**: the template that contains only images
        /// *   **text_image_button**: the template that contains text, images, and buttons
        /// *   **text_button**: the template that contains text and buttons
        /// *   **document**: the template that contains only documents
        /// *   **video**: the template that contains only videos
        /// *   **text_video**: the template that contains text and videos
        /// *   **text_video_button**: the template that contains text, videos, and buttons
        /// *   **text_image**: the template that contains text and images
        /// 
        /// > This parameter applies only to Viber message templates.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The components of the message template.
        /// 
        /// >  If Category is set to AUTHENTICATION, the Type sub-parameter of the Components parameter cannot be set to HEADER. If the Type sub-parameter is set to BODY or FOOTER, the Text sub-parameter of the Components parameter is empty and text in the body or footer is automatically generated.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<ModifyChatappTemplateRequestComponents> Components { get; set; }
        public class ModifyChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// The note indicating that customers cannot share verification codes with others. The note is displayed in the message body. This parameter is valid only if Category is set to AUTHENTICATION and the Type sub-parameter of the Components parameter is set to BODY for a WhatsApp message template.
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// The buttons. Specify this parameter only if you set the Type sub-parameter of the Components parameter to **BUTTONS**.
            /// 
            /// >  The following section describes the limits on the number of buttons in a WhatsApp message.
            /// 
            /// *   A marketing or utility WhatsApp message template supports up to 10 buttons.
            /// 
            /// *   A WhatsApp message template can contain only one phone call button.
            /// 
            /// *   A WhatsApp message template can contain up to two URL buttons.
            /// 
            /// *   In a WhatsApp message template, the quick reply button cannot be used together with the phone call button or the URL button.
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class ModifyChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// The text of the one-tap autofill button. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                [NameInMap("CouponCode")]
                [Validation(Required=false)]
                public string CouponCode { get; set; }

                [NameInMap("FlowAction")]
                [Validation(Required=false)]
                public string FlowAction { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// The unsubscribe button. This parameter is valid if Category is set to MARKETING and the Type sub-parameter of the Buttons parameter is set to QUICK_REPLY for a WhatsApp message template. After you configure message sending in the ChatApp Message Service console, marketing messages are not sent to customers if they click this button.
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                [NameInMap("NavigateScreen")]
                [Validation(Required=false)]
                public string NavigateScreen { get; set; }

                /// <summary>
                /// The app package name that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.
                /// </summary>
                [NameInMap("PackageName")]
                [Validation(Required=false)]
                [Obsolete]
                public string PackageName { get; set; }

                /// <summary>
                /// The phone number.
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// The app signing key hash that WhatsApp uses to load your app. This parameter is required if Category is set to AUTHENTICATION and the Type sub-parameter of the Buttons parameter is set to ONE_TAP for a WhatsApp message template.
                /// </summary>
                [NameInMap("SignatureHash")]
                [Validation(Required=false)]
                [Obsolete]
                public string SignatureHash { get; set; }

                [NameInMap("SupportedApps")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsButtonsSupportedApps> SupportedApps { get; set; }
                public class ModifyChatappTemplateRequestComponentsButtonsSupportedApps : TeaModel {
                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                    [NameInMap("SignatureHash")]
                    [Validation(Required=false)]
                    public string SignatureHash { get; set; }

                }

                /// <summary>
                /// The text of the button.
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
                /// *   **COPY_CODE**: copy code button if Category is set to AUTHENTICATION
                /// *   **ONE_TAP**: one-tap autofill button if Category is set to AUTHENTICATION
                /// 
                /// > 
                /// 
                /// *   In a WhatsApp message template, a quick reply button cannot be used together with a phone call button or a URL button.
                /// 
                /// *   You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a WhatsApp message template.
                /// 
                /// *   If Category is set to AUTHENTICATION for a WhatsApp message template, you can add only one button to the WhatsApp message template and you must set the Type sub-parameter of the Buttons parameter to COPY_CODE or ONE_TAP. If the Type sub-parameter of the Buttons parameter is set to COPY_CODE, the Text sub-parameter of the Buttons parameter is required. If the Type sub-parameter of the Buttons parameter is set to ONE_TAP, the Text, SignatureHash, PackageName, and AutofillText sub-parameters of the Buttons parameter are required. The value of Text is displayed if the desired app is not installed on the device. The value of Text indicates that you must manually copy the verification code.
                /// 
                /// *   You can add only one button to a Viber message template, and you must set the Type sub-parameter of the Buttons parameter to URL.
                /// 
                /// This parameter is required.
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
            /// The description.
            /// 
            /// >  You can specify this parameter if the Type sub-parameter of the Components parameter is set to **HEADER** and the Format sub-parameter of the Components parameter is set to **IMAGE, DOCUMENT, or VIDEO**.
            /// </summary>
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }

            [NameInMap("Cards")]
            [Validation(Required=false)]
            public List<ModifyChatappTemplateRequestComponentsCards> Cards { get; set; }
            public class ModifyChatappTemplateRequestComponentsCards : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("CardComponents")]
                [Validation(Required=false)]
                public List<ModifyChatappTemplateRequestComponentsCardsCardComponents> CardComponents { get; set; }
                public class ModifyChatappTemplateRequestComponentsCardsCardComponents : TeaModel {
                    [NameInMap("Buttons")]
                    [Validation(Required=false)]
                    public List<ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons> Buttons { get; set; }
                    public class ModifyChatappTemplateRequestComponentsCardsCardComponentsButtons : TeaModel {
                        [NameInMap("PhoneNumber")]
                        [Validation(Required=false)]
                        public string PhoneNumber { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                        /// <summary>
                        /// This parameter is required.
                        /// </summary>
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

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

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
            /// The length of the video in the Viber message template. Unit: seconds. Valid values: 0 to 600.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// The name of the document.
            /// 
            /// >  You can specify this parameter if the Type sub-parameter of the Components parameter is set to **HEADER** and the Format sub-parameter of the Components parameter is set to **DOCUMENT**.
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
            /// The type of the media resources that are included in the message. Valid values:
            /// 
            /// *   **TEXT**
            /// *   **IMAGE**
            /// *   **DOCUMENT**
            /// *   **VIDEO**
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            [NameInMap("HasExpiration")]
            [Validation(Required=false)]
            public bool? HasExpiration { get; set; }

            /// <summary>
            /// The text of the message that you want to send.
            /// 
            /// >  If Category is set to AUTHENTICATION, the Text sub-parameter of the Components parameter is empty.
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
            /// *   In a Viber message template, media resources such as images, videos, and documents are placed in the **HEADER** component. If a Viber message contains text and images, the images are placed under the text in the message received on a device.
            /// 
            /// This parameter is required.
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

        }

        /// <summary>
        /// The space ID of the user within the ISV account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The WhatsApp Business account (WABA) ID of the user within the independent software vendor (ISV) account.
        /// 
        /// > CustWabaId is an obsolete parameter. Use CustSpaceId instead.
        /// </summary>
        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustWabaId { get; set; }

        /// <summary>
        /// The examples of variables that are used when you create the message template.
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public Dictionary<string, string> Example { get; set; }

        /// <summary>
        /// The ISV verification code, which is used to verify whether the user is authorized by the ISV account.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The language that is used in the message template. For more information, see [Language codes](https://help.aliyun.com/document_detail/463420.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// Validity period of authentication template message sending in WhatsApp
        /// 
        /// >This attribute requires providing waba in advance to Alibaba operators to open the whitelist, otherwise it will result in template submission failure
        /// </summary>
        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        /// <summary>
        /// The message template code.
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The type of the message template.
        /// 
        /// *   **WHATSAPP**
        /// *   **VIBER**
        /// *   LINE: the Line message template. This type of message template will be released later.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
