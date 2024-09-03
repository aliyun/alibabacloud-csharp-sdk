// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappBindWabaResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/196974.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryChatappBindWabaResponseBodyData Data { get; set; }
        public class QueryChatappBindWabaResponseBodyData : TeaModel {
            /// <summary>
            /// The review state of the WhatsApp Business account (WABA).
            /// 
            /// >  Valid values:
            /// 
            /// *   PENDING: The WABA is to be reviewed.
            /// 
            /// *   APPROVED: The WABA was approved.
            /// 
            /// *   REJECTED: The WABA was rejected.
            /// 
            /// *   DISABLED: The WABA was forbidden.
            /// </summary>
            [NameInMap("AccountReviewStatus")]
            [Validation(Required=false)]
            public string AccountReviewStatus { get; set; }

            [NameInMap("AuthInternationalRateEligibility")]
            [Validation(Required=false)]
            public Dictionary<string, object> AuthInternationalRateEligibility { get; set; }

            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// The currency.
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// The ID of the WhatsApp Business account.
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
            /// The name of the WhatsApp Business account.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PrimaryBusinessLocation")]
            [Validation(Required=false)]
            public string PrimaryBusinessLocation { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
