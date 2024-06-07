// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoResponseBody : TeaModel {
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
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information returned after the phone numbers were bound.
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public List<QueryPhoneNoAByTrackNoResponseBodyModule> Module { get; set; }
        public class QueryPhoneNoAByTrackNoResponseBodyModule : TeaModel {
            /// <summary>
            /// The extension of phone number X.
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// Phone number A.
            /// </summary>
            [NameInMap("PhoneNoA")]
            [Validation(Required=false)]
            public string PhoneNoA { get; set; }

            /// <summary>
            /// The private number, that is, phone number X.
            /// </summary>
            [NameInMap("PhoneNoX")]
            [Validation(Required=false)]
            public string PhoneNoX { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
