// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetSmsAuthTokensResponseBody : TeaModel {
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
        public GetSmsAuthTokensResponseBodyData Data { get; set; }
        public class GetSmsAuthTokensResponseBodyData : TeaModel {
            /// <summary>
            /// The business token.
            /// </summary>
            [NameInMap("BizToken")]
            [Validation(Required=false)]
            public string BizToken { get; set; }

            /// <summary>
            /// The time when the token expired. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("StsAccessKeyId")]
            [Validation(Required=false)]
            public string StsAccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret.
            /// </summary>
            [NameInMap("StsAccessKeySecret")]
            [Validation(Required=false)]
            public string StsAccessKeySecret { get; set; }

            /// <summary>
            /// The security token.
            /// </summary>
            [NameInMap("StsToken")]
            [Validation(Required=false)]
            public string StsToken { get; set; }

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
