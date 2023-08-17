// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow Facebook to automatically change the directory of the template. If you set this parameter to true, the review success rate of the template is improved. This parameter is valid only if TemplateType is set to WHATSAPP.
        /// </summary>
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// The category of the template if TemplateType is set to WHATSAPP. Valid values:
        /// 
        /// *   **UTILITY**: the transaction template
        /// *   **MARKETING**: the marketing template
        /// *   **AUTHENTICATION**: the authentication template
        /// 
        /// The category of the template if TemplateType is set to VIBER. Valid values:
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
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The components of the message template.
        /// 
        /// > If Category is set to AUTHENTICATION, the Type sub-parameter of the Components parameter cannot be set to HEADER. If the value of Type is BODY or FOOTER, the Text sub-parameter of the Components parameter is empty.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// The prompt message indicating that the verification code must be kept secret. This parameter is valid if Category is set to AUTHENTICATION in a WhatsApp message template and the Type sub-parameter of the Components parameter is set to BODY. The prompt message is displayed in the BODY component.
            /// </summary>
            [NameInMap("AddSecretRecommendation")]
            [Validation(Required=false)]
            public bool? AddSecretRecommendation { get; set; }

            /// <summary>
            /// The buttons. This parameter applies only to **BUTTONS** components.
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// The text of the one-tap autofill button. AutofillText is required if Category is set to AUTHENTICATION in a WhatsApp message template and the Type sub-parameter of the Buttons parameter is set to ONE_TAP.
                /// </summary>
                [NameInMap("AutofillText")]
                [Validation(Required=false)]
                public string AutofillText { get; set; }

                /// <summary>
                /// The unsubscribe button in a WhatsApp marketing template. This parameter is valid if Category is set to MARKETING in a WhatsApp message template and the Type sub-parameter of the Buttons parameter is set to QUICK_REPLY. After you tap this button and customers configure the feature for unsubscribing from a WhatsApp marketing template in the ChatAPP console, subsequent marketing messages are not sent to you.
                /// </summary>
                [NameInMap("IsOptOut")]
                [Validation(Required=false)]
                public bool? IsOptOut { get; set; }

                /// <summary>
                /// The package name of the app. PackageName is required if Category is set to AUTHENTICATION in a WhatsApp message template and the Type sub-parameter of the Buttons parameter is set to ONE_TAP.
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
                /// The hash value of the app signing key. SignatureHash is required if Category is set to AUTHENTICATION in a WhatsApp message template and the Type sub-parameter of the Buttons parameter is set to ONE_TAP.
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
                /// *   **PHONE_NUMBER**: the phone call button
                /// *   **URL**: the URL button
                /// *   **QUICK_REPLY**: the quick reply button
                /// *   **COPY_CODE**: the copy code button if Category is set to AUTHENTICATION
                /// *   **ONE_TAP**: the one-tap autofill button if Category is set to AUTHENTICATION
                /// 
                /// > - In a WhatsApp message template, the quick reply button cannot be used together with the phone call button or the URL button.
                /// > - You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a WhatsApp message template.
                /// > -  If Category is set to AUTHENTICATION in a WhatsApp message template, you can add only one button to the WhatsApp message template and you must set the Type sub-parameter of the Buttons parameter to COPY_CODE or ONE_TAP. If the Type sub-parameter of the Buttons parameter is set to COPY_CODE, the Text sub-parameter of the Buttons parameter is required. If the Type sub-parameter of the Buttons parameter is set to ONE_TAP, the Text, SignatureHash, PackageName, and AutofillText sub-parameters of the Buttons parameter are required. The value of Text is displayed if the desired app is not installed on the terminal. It indicates that you must manually copy the verification code.
                /// > - You can add only one button to a Viber message template, and you must set the Type sub-parameter of the Buttons parameter to URL.
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
            /// The validity period of the verification code in a WhatsApp message template. Unit: minutes. This parameter is valid if Category is set to AUTHENTICATION in a WhatsApp message template and the Type sub-parameter of the Components parameter is set to FOOTER. The value of CodeExpirationMinutes is displayed in the FOOTER component.
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

            /// <summary>
            /// The text of the message that you want to send.
            /// 
            /// > If Category is set to AUTHENTICATION, the Text sub-parameter of the Components parameter is empty.
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
            /// > - The following limits apply to components in WhatsApp message templates: A **BODY** component cannot exceed 1,024 characters in length. A **HEADER** or **FOOTER** component cannot exceed 60 characters in length.
            /// > - **FOOTER** components are not supported in Viber message templates.
            /// > - In a Viber message template, a media resource, such as an image, a video, or a document, is placed in the **HEADER** component. If a Viber message contains text and an image, the image is placed under the text in the message received on a terminal.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The URL of the media resource.
            /// 
            /// > We recommend that the resolution of the image in the Viber message template is 800 × 800.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The space ID of the user within the independent software vendor (ISV) account.
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

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

        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("MessageSendTtlSeconds")]
        [Validation(Required=false)]
        public int? MessageSendTtlSeconds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
