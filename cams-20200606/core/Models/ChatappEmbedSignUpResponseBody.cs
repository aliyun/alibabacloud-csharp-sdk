// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ChatappEmbedSignUpResponseBody : TeaModel {
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
        /// The list of WhatsApp Business accounts.
        /// </summary>
        [NameInMap("Wabas")]
        [Validation(Required=false)]
        public List<ChatappEmbedSignUpResponseBodyWabas> Wabas { get; set; }
        public class ChatappEmbedSignUpResponseBodyWabas : TeaModel {
            /// <summary>
            /// The review status of the WhatsApp Business account.
            /// </summary>
            [NameInMap("AccountReviewStatus")]
            [Validation(Required=false)]
            public string AccountReviewStatus { get; set; }

            /// <summary>
            /// The currency.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// WabaId
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The namespace of the message template.
            /// </summary>
            [NameInMap("MessageTemplateNamespace")]
            [Validation(Required=false)]
            public string MessageTemplateNamespace { get; set; }

            /// <summary>
            /// Waba Name
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
