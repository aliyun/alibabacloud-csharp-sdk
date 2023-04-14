// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappTemplateDetailResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
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
            /// The category of the template when the return value of the TemplateType parameter is WHATSAPP. Valid values:
            /// 
            /// *   **TRANSACTIONAL**: a transactional template
            /// *   **MARKETING**: a marketing template
            /// *   **OTP**: a one-time password template
            /// 
            /// The category of the template when the return value of the TemplateType parameter is VIBER. Valid values:
            /// 
            /// *   **text**: a text message template
            /// *   **image**: an image message template
            /// *   **text_image_button**: a template that contains multiple media objects, including text, image, and button
            /// *   **text_button**: a template that contains the text and button media objects
            /// *   **document**: a template that contains a document attachment
            /// *   **video**: a video message template
            /// *   **text_video**: a template that contains the text and video media objects
            /// *   **text_video_button**: a template that contains multiple media objects, including text, video, and button
            /// *   **text_image**: a template that contains the text and image media objects
            /// 
            /// > When the category of a Viber message template is text_video_button, users cannot open a web page by clicking the button. Users can open only the video in the message. In this case, you do not need to specify the Url parameter for the URL button in the template.
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
                /// This parameter is applicable only to components of the **BUTTONS** type.
                /// </summary>
                [NameInMap("Buttons")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
                    /// <summary>
                    /// The phone number. This parameter is valid only if the return value of the Type parameter is **PHONE_NUMBER**.
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
                    /// *   If you have created a URL button or a phone number button, you cannot create a quick reply button.
                    /// 
                    /// *   You can add a combination of two URL buttons or a combination of a URL button and a phone number button to a message template.
                    /// 
                    /// *   You can add only one button to a Viber message template, and the button must be a URL button.
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
                /// The duration of the video used in the Viber message template. Valid values: 0 to 600. Unit: seconds.
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
                /// The format.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                [NameInMap("LocationAddress")]
                [Validation(Required=false)]
                public string LocationAddress { get; set; }

                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                [NameInMap("Longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// The text of the message to be sent.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// The thumbnail URL of the video used in the Viber message template.
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
                /// *   In a Viber message template, a media object, such as an image, a video, or a document, is placed in the **HEADER** component. If a Viber message contains text and an image, the image is placed under the text in the message received on a device.
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
            /// The name of the message template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The code of the message template.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            /// <summary>
            /// The type of the message template.
            /// 
            /// *   **WHATSAPP**
            /// *   **VIBER**
            /// *   LINE: the LINE message template. This type of message template will be released later.
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
