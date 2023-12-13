// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class TwoElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// The response code. Valid values:
        /// 
        /// *   **OK**: The request is successful.
        /// *   For more information, see Error codes in this documentation.
        /// *   **RequestFrequencyLimit**: Repeated queries for the same phone number or name at a high frequency within a short period of time are prohibited due to restrictions that are set by carriers. If this error code is returned, please try again later.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TwoElementsVerificationResponseBodyData Data { get; set; }
        public class TwoElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// The basic carriers. Valid values:
            /// 
            /// *   **China Mobile**
            /// *   **China Unicom**
            /// *   **China Telecom**
            /// 
            /// >  You are not allowed to verify numbers assigned by China Broadnet.
            /// </summary>
            [NameInMap("BasicCarrier")]
            [Validation(Required=false)]
            public string BasicCarrier { get; set; }

            /// <summary>
            /// Indicates whether the specified name and phone number belong to the same user. Valid values:
            /// 
            /// * **1**: The specified name and phone number belong to the same user.
            /// 
            /// * **0**: The specified name and phone number do not belong to the same user.
            /// 
            /// * **2**: The specified name and phone number cannot be found.
            /// 
            /// The phone number registration data of a user is usually updated one or three days after registration. The registration data can be queried only after the update. The following table shows the verification results under different phone number states.
            /// 
            /// |Carrier/Phone number state|Out-of-service|Nonexistent|Canceled|
            /// |---|---|---|---|
            /// |China Mobile|Verifications can be carried out normally.|The specified name and phone number cannot be found.|The specified name and phone number cannot be found.|
            /// |China Unicom|Verifications can be carried out normally.|The specified name and phone number do not belong to the same user.|The specified name and phone number do not belong to the same user.|
            /// |China Telecom|Verifications can be carried out normally.|The specified name and phone number cannot be found.|The specified name and phone number cannot be found.|
            /// </summary>
            [NameInMap("IsConsistent")]
            [Validation(Required=false)]
            public int? IsConsistent { get; set; }

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
