// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        [NameInMap("AllowCategoryChange")]
        [Validation(Required=false)]
        public bool? AllowCategoryChange { get; set; }

        /// <summary>
        /// The category of the template when the TemplateType parameter is set to WHATSAPP. Valid values:
        /// 
        /// *   **TRANSACTIONAL**: a transactional template
        /// *   **MARKETING**: a marketing template
        /// *   **OTP**: a one-time password template
        /// 
        /// The category of the template when the TemplateType parameter is set to VIBER. Valid values:
        /// 
        /// *   **text**: a text message template
        /// *   **image**: an image message template
        /// *   **text_image_button**: a template that contains multiple media objects, including text, image, and button
        /// *   **text_button**: a template that contains the text and button media objects
        /// *   **document**: a document message template
        /// *   **video**: a video message template
        /// *   **text_video**: a template that contains the text and video media objects
        /// *   **text_video_button**: a template that contains multiple media objects, including text, video, and button
        /// *   **text_image**: a template that contains the text and image media objects
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The list of components of the message template.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// The list of buttons, which applies only to the **BUTTONS** component.
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// The phone number. This parameter is valid only if the Type parameter is set to **PHONE_NUMBER**.
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// The display name of the button.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The type of the button. Valid values:
                /// 
                /// *   **PHONE_NUMBER**: a phone number button
                /// *   **URL**: a URL button
                /// *   **QUICK_REPLY**: a quick reply button
                /// 
                /// > 
                /// 
                /// *   When the TemplateType parameter is set to WHATSAPP, if you have created a website link or a phone number link, you cannot create an quick reply button.
                /// 
                /// *   When the TemplateType parameter is set to WHATSAPP, you can add a combination of two URL buttons or a combination of a URL button and a phone number button to a message template.
                /// 
                /// *   When the TemplateType parameter is set to VIBER, you can add only one button and the button must be of the URL type.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The URL to be accessed when users click the URL button.
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

            /// <summary>
            /// The duration of the video message when the TemplateType parameter is set to VIBER. Valid values: 0 to 600. Unit: seconds.
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
            /// The type of the file when the TemplateType parameter is set to VIBER.
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// The type of the media resources that are included in the message.
            /// 
            /// *   **TEXT**: text
            /// *   **IMAGE**: image
            /// *   **DOCUMENT**: document
            /// *   **VIDEO**: video
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The text of the message that is sent.
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// The thumbnail URL of the video message when the TemplateType parameter is set to VIBER.
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
            /// > When the TemplateType parameter is set to WHATSAPP, the component of the **BODY** type cannot exceed 1,024 characters in length. The component of the **HEADER** or **FOOTER** type cannot exceed 60 characters in length.
            /// 
            /// > When the TemplateType parameter is set to VIBER, the **FOOTER** parameter is invalid.
            /// 
            /// > When the TemplateType parameter is set to VIBER, media objects including image, video, and text are placed in the **HEADER** component. A device displays that the image is placed below the text.
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

        }

        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// The ID of the WhatsApp account that you register.
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
        /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// The name of the message template.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of the message template.
        /// 
        /// *   **WHATSAPP**
        /// *   **VIBER**
        /// *   LINE: the LINE message template. The LINE message template is under development.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
