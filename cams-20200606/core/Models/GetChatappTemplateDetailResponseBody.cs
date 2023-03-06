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
        /// *   A code of OK indicates that the call is successful.
        /// *   Other codes indicate that the call fails. For more information, see [Error codes](~~196974~~).
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
            public List<GetChatappTemplateDetailResponseBodyDataComponents> Components { get; set; }
            public class GetChatappTemplateDetailResponseBodyDataComponents : TeaModel {
                /// <summary>
                /// This parameter applies only to components of the **BUTTONS** type. This parameter is passed in by converting its original JSON structure into a string.
                /// </summary>
                [NameInMap("Buttons")]
                [Validation(Required=false)]
                public List<GetChatappTemplateDetailResponseBodyDataComponentsButtons> Buttons { get; set; }
                public class GetChatappTemplateDetailResponseBodyDataComponentsButtons : TeaModel {
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
                    /// **
                    /// 
                    /// **Note**
                    /// 
                    /// *   A quick reply button cannot coexist with a phone call button or a URL button in a message template.
                    /// 
                    /// *   You can add a combination of two URL buttons or a combination of a URL button and a phone call button to a message template.
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
                /// The format.
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
                /// **
                /// 
                /// **Note** A component of the **BODY** type cannot exceed 1,024 characters in length. A component of the **HEADER** or **FOOTER** type cannot exceed 60 characters in length.
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
            /// The code of the message template.
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

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
