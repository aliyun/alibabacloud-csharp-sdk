// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

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
        /// The message templates.
        /// </summary>
        [NameInMap("ListTemplate")]
        [Validation(Required=false)]
        public List<ListChatappTemplateResponseBodyListTemplate> ListTemplate { get; set; }
        public class ListChatappTemplateResponseBodyListTemplate : TeaModel {
            /// <summary>
            /// The review state of the message template. Valid values:
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
            /// The category of the WhatsApp template. Valid values:
            /// 
            /// *   **UTILITY**: utility template
            /// *   **MARKETING**: marketing template
            /// *   **AUTHENTICATION**: authentication template
            /// 
            /// The category of the Viber template. Valid values:
            /// 
            /// *   **text**: template that contains only text
            /// *   **image**: template that contains only an image
            /// *   **text_image_button**: template that contains text, an image, and a button
            /// *   **text_button**: template that contains text and a button
            /// *   **document**: template that contains only a document
            /// *   **video**: template that contains only a video
            /// *   **text_video**: template that contains text and a video
            /// *   **text_video_button**: template that contains text, a video, and a button
            /// *   **text_image**: template that contains text and an image
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The language that is used in the message template. For more information, see [Language codes](~~463420~~).
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The reason for the review failure.
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
            /// The name of the message template.
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// The type of the template. Valid values: WHATSAPP and VIBER.
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

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
