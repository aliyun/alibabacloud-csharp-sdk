// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetAuthTokenResponseBody : TeaModel {
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
        /// The response parameters.
        /// </summary>
        [NameInMap("TokenInfo")]
        [Validation(Required=false)]
        public GetAuthTokenResponseBodyTokenInfo TokenInfo { get; set; }
        public class GetAuthTokenResponseBodyTokenInfo : TeaModel {
            /// <summary>
            /// The business authentication token.
            /// 
            /// >  AccessToken is valid for 10 minutes and can be used repeatedly within its validity period.
            /// </summary>
            [NameInMap("AccessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// The API authentication token.
            /// 
            /// >  JwtToken is valid for 1 hour and can be used repeatedly within its validity period.
            /// </summary>
            [NameInMap("JwtToken")]
            [Validation(Required=false)]
            public string JwtToken { get; set; }

        }

    }

}
