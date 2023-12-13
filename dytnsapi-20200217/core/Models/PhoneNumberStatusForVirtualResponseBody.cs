// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForVirtualResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **OperatorLimit**: The carrier prohibits the query of the phone number.
        /// *   **RequestFrequencyLimit**: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PhoneNumberStatusForVirtualResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForVirtualResponseBodyData : TeaModel {
            /// <summary>
            /// Indicate whether the phone number is a virtual number assigned by the carrier. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsPrivacyNumber")]
            [Validation(Required=false)]
            public bool? IsPrivacyNumber { get; set; }

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
