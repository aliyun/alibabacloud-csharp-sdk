// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryWabaBusinessInfoResponseBody : TeaModel {
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
        /// The business information about the WhatsApp Business account.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryWabaBusinessInfoResponseBodyData Data { get; set; }
        public class QueryWabaBusinessInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the business platform.
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// The name of the business platform.
            /// </summary>
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// The verification status.
            /// </summary>
            [NameInMap("VerificationStatus")]
            [Validation(Required=false)]
            public string VerificationStatus { get; set; }

            /// <summary>
            /// The industry.
            /// </summary>
            [NameInMap("Vertical")]
            [Validation(Required=false)]
            public string Vertical { get; set; }

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
