// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateResponseBody : TeaModel {
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
        /// The message templates.
        /// </summary>
        [NameInMap("ListTemplate")]
        [Validation(Required=false)]
        public List<ListChatappTemplateResponseBodyListTemplate> ListTemplate { get; set; }
        public class ListChatappTemplateResponseBodyListTemplate : TeaModel {
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
            /// The language that is used in the message template.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

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
