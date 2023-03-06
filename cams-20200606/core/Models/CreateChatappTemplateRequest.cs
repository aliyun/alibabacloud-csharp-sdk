// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateRequest : TeaModel {
        /// <summary>
        /// The category of the message template. Valid values:
        /// 
        /// *   **ACCOUNT_UPDATE**: account update
        /// *   **PAYMENT_UPDATE**: payment update
        /// *   **PERSONAL_FINANCE\_UPDATE**: personal finance update
        /// *   **SHIPPING_UPDATE**: traffic update
        /// *   **RESERVATION_UPDATE**: reservation update
        /// *   **ISSUE_RESOLUTION**: issue resolution
        /// *   **APPOINTMENT_UPDATE**: appointment update
        /// *   **TRANSPORTATION_UPDATE**: logistics information update
        /// *   **TICKET_UPDATE**: ticket update
        /// *   **ALERT_UPDATE**: alert update
        /// *   **AUTO_REPLY**: auto reply
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The components of the message template.
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<CreateChatappTemplateRequestComponents> Components { get; set; }
        public class CreateChatappTemplateRequestComponents : TeaModel {
            /// <summary>
            /// This parameter applies only to components of the **BUTTONS** type.
            /// </summary>
            [NameInMap("Buttons")]
            [Validation(Required=false)]
            public List<CreateChatappTemplateRequestComponentsButtons> Buttons { get; set; }
            public class CreateChatappTemplateRequestComponentsButtons : TeaModel {
                /// <summary>
                /// The mobile phone number. This parameter is valid only if the Type parameter is set to **PHONE_NUMBER**.
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
                /// *   **PHONE_NUMBER**: a phone call button
                /// *   **URL**: a URL button
                /// *   **QUICK_REPLY**: a quick reply button
                /// 
                /// > *   A quick reply button cannot coexist with a phone call button or a URL button in a message template.
                /// > *   You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a message template.
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

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }

            /// <summary>
            /// The name of the file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// The format of the message.
            /// 
            /// *   **TEXT**: text
            /// *   **IMGAGE**: image
            /// *   **DOCUMENT**: document
            /// *   **VIDEO**: video
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The text of the message to be sent.
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

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
            /// > A component of the **BODY** type cannot exceed 1,024 characters in length. A component of the **HEADER** or **FOOTER** type cannot exceed 60 characters in length.
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
        /// The unique identifier of the WhatsApp account that you register.
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
        /// Assigned by ISV for RAM user authentication and authorization.
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// The language that is used in the message template.
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
        /// The type of the message template. Valid values:
        /// 
        /// *   **WHATSAPP**
        /// *   VIBER (under development)
        /// *   LINE (under development)
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
