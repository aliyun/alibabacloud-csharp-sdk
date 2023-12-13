// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberStatusForVoiceResponseBody : TeaModel {
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
        public PhoneNumberStatusForVoiceResponseBodyData Data { get; set; }
        public class PhoneNumberStatusForVoiceResponseBodyData : TeaModel {
            /// <summary>
            /// The basic carrier who assigns the phone number. If the queried phone number involves mobile number portability, the carrier after mobile number portability is returned. Valid values:
            /// 
            /// *   **CMCC**: China Mobile
            /// *   **CUCC**: China Unicom
            /// *   **CTCC**: China Telecom
            /// 
            /// >  You are not allowed to query the phone numbers assigned by China Broadnet.
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// The returned status for the queried phone number. Valid values:
            /// 
            /// *   **NORMAL**: The queried phone number can be reached.
            /// *   **SHUTDOWN**: The queried phone number is suspended.
            /// *   **POWER_OFF**: The phone is powered off.
            /// *   **NOT_EXIST**: The queried phone number is a nonexistent number.
            /// *   **SUSPECTED_POWER_OFF**: The phone is suspected to be powered off.
            /// *   **DEFECT**: The queried phone number is invalid.
            /// *   **UNKNOWN**: The queried phone number is unknown.
            /// 
            /// >  Due to system adjustment of the carrier, the BUSY, SUSPECTED_POWER_OFF, and POWER_OFF states cannot be returned for the numbers assigned by China Telecom. [For more information, see the official announcements](https://help.aliyun.com/document_detail/2489709.html).
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The unique request ID. It is a common parameter and can be used to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
