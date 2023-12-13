// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribePhoneNumberOnlineTimeResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   **PortabilityNumberNotSupported**: The phone number that is involved in mobile number portability is not supported.
        /// *   **RequestFrequencyLimit**: Repeated queries for the same phone number at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.
        /// 
        /// >  You are charged if the value of Code is OK and the value of VerifyResult is not -1. For more information, see [Pricing](~~154751~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePhoneNumberOnlineTimeResponseBodyData Data { get; set; }
        public class DescribePhoneNumberOnlineTimeResponseBodyData : TeaModel {
            /// <summary>
            /// The carrier code. Valid values:
            /// 
            /// *   **CMCC**: China Mobile
            /// *   **CUCC**: China Unicom
            /// *   **CTCC**: China Telecom
            /// *   **CBN**: China Broadnet
            /// </summary>
            [NameInMap("CarrierCode")]
            [Validation(Required=false)]
            public string CarrierCode { get; set; }

            /// <summary>
            /// The enumerated value of the usage period of a phone number. Valid values:
            /// 
            /// *   **-1**: No usage period information is available for the phone number.
            /// *   **0**: The phone number status is abnormal. For example, the phone number is a nonexistent number.
            /// *   **1** :\[0-3) months.
            /// *   **2** :\[3-6] months.
            /// *   **3** :(6-12] months.
            /// *   **4** :(12-24] months.
            /// *   **5** :(24,+) months.
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

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
