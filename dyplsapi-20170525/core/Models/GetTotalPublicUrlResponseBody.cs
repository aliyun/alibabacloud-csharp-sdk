// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetTotalPublicUrlResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   Other status codes indicate that the request failed. For more information, see [Error codes](https://help.aliyun.com/document_detail/109196.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The download URLs of the recording files.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTotalPublicUrlResponseBodyData Data { get; set; }
        public class GetTotalPublicUrlResponseBodyData : TeaModel {
            /// <summary>
            /// The download URL of the recorded call.
            /// 
            /// >  The download URL of the recorded call is valid for 30 days.
            /// </summary>
            [NameInMap("PhonePublicUrl")]
            [Validation(Required=false)]
            public string PhonePublicUrl { get; set; }

            /// <summary>
            /// The download URL of the recorded ringing tone.
            /// 
            /// >  The download URL of the recorded ringing tone is valid for 30 days.
            /// </summary>
            [NameInMap("RingPublicUrl")]
            [Validation(Required=false)]
            public string RingPublicUrl { get; set; }

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
