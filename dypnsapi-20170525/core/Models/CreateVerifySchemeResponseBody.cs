// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateVerifySchemeResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   For more information about other error codes, see [API response codes](~~85198~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("GateVerifySchemeDTO")]
        [Validation(Required=false)]
        public CreateVerifySchemeResponseBodyGateVerifySchemeDTO GateVerifySchemeDTO { get; set; }
        public class CreateVerifySchemeResponseBodyGateVerifySchemeDTO : TeaModel {
            /// <summary>
            /// The service code.
            /// </summary>
            [NameInMap("SchemeCode")]
            [Validation(Required=false)]
            public string SchemeCode { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
