// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthorizationUrlResponseBody : TeaModel {
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
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAuthorizationUrlResponseBodyData Data { get; set; }
        public class GetAuthorizationUrlResponseBodyData : TeaModel {
            /// <summary>
            /// The authorization URL.
            /// </summary>
            [NameInMap("AuthorizationUrl")]
            [Validation(Required=false)]
            public string AuthorizationUrl { get; set; }

        }

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
