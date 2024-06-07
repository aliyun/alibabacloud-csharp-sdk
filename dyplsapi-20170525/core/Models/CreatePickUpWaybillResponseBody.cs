// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreatePickUpWaybillResponseBodyData Data { get; set; }
        public class CreatePickUpWaybillResponseBodyData : TeaModel {
            /// <summary>
            /// The code of the courier company.
            /// </summary>
            [NameInMap("CpCode")]
            [Validation(Required=false)]
            public string CpCode { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// The pickup code.
            /// </summary>
            [NameInMap("GotCode")]
            [Validation(Required=false)]
            public string GotCode { get; set; }

            /// <summary>
            /// The order ID.
            /// </summary>
            [NameInMap("MailNo")]
            [Validation(Required=false)]
            public string MailNo { get; set; }

            /// <summary>
            /// Indicates whether the request was successful.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
