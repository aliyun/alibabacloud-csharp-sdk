// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateRequest : TeaModel {
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
        /// The paging settings.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListChatappTemplateRequestPage Page { get; set; }
        public class ListChatappTemplateRequestPage : TeaModel {
            /// <summary>
            /// The number of the page to return. Default value: 1.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// The number of message templates to return on each page. Default value: 10.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

        }

    }

}
