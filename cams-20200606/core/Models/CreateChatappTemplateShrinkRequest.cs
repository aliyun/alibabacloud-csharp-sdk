// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CreateChatappTemplateShrinkRequest : TeaModel {
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
        public string ComponentsShrink { get; set; }

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
        public string ExampleShrink { get; set; }

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
