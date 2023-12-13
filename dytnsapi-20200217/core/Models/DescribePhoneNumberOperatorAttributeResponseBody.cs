// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOperatorAttributeResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **InvalidParameter**: The specified phone number is invalid or the parameter format is invalid.
        /// *   **PhoneNumberNotfound**: No attribute information can be found for the specified phone number.
        /// *   **isp.UNKNOWN**: An unknown exception occurred.
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
        public DescribePhoneNumberOperatorAttributeResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOperatorAttributeResponseBodyData : TeaModel {
            /// <summary>
            /// The basic carrier. Valid values:
            /// 
            /// *   **China Mobile**
            /// *   **China Unicom**
            /// *   **China Telecom**
            /// *   **China Broadnet**
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// The actual carrier, including the virtual network operator (VNO). If the phone number involves mobile number portability, the value of this parameter is the carrier after mobile number portability.
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// The city where the phone number is registered.
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// Indicates whether the phone number involves mobile number portability. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsNumberPortability")]
            [Validation(Required=false)]
            public bool? IsNumberPortability { get; set; }

            /// <summary>
            /// The number segment to which the phone number belongs.
            /// </summary>
            [NameInMap("NumberSegment")]
            [Validation(Required=false)]
            public long? NumberSegment { get; set; }

            /// <summary>
            /// The province where the phone number is registered.
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

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
