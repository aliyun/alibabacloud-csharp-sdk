// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815.Models
{
    public class GetTokenResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTokenResponseBodyData Data { get; set; }
        public class GetTokenResponseBodyData : TeaModel {
            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("generateTime")]
            [Validation(Required=false)]
            public string GenerateTime { get; set; }

            /// <summary>
            /// token
            /// </summary>
            [NameInMap("token")]
            [Validation(Required=false)]
            public string Token { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorData")]
        [Validation(Required=false)]
        public GetTokenResponseBodyErrorData ErrorData { get; set; }
        public class GetTokenResponseBodyErrorData : TeaModel {
            [NameInMap("rawErrorCode")]
            [Validation(Required=false)]
            public string RawErrorCode { get; set; }

            [NameInMap("rawErrorMsg")]
            [Validation(Required=false)]
            public string RawErrorMsg { get; set; }

        }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
