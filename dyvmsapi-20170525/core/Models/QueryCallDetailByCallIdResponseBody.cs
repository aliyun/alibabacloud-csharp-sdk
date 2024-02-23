// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallDetailByCallIdResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value OK indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the call, in the JSON format.
        /// 
        /// *   **caller**: the calling number.
        /// *   **startDate**: the time when the call was started.
        /// *   **stateDesc**: the description of the call state.
        /// *   **duration**: the call duration. Unit: seconds. The value **0** indicates that the user was not connected.
        /// *   **callerShowNumber**: the calling number displayed to the called party.
        /// *   **gmtCreate**: the time when the call request was received.
        /// *   **state**: the call state. The call state is returned by the Internet service provider (ISP) in real time. For more information about call states, see [ISP-returned error codes](~~55085~~).
        /// *   **endDate**: the time when the call was ended.
        /// *   **calleeShowNumber**: the number displayed to the called party.
        /// *   **callee**: the called number.
        /// *   **aRingTime**: the time when Line A started to ring, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **aEndTime**: the time when ringing on Line A ended, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **bRingTime**: the time when Line B started to ring, in the yyyy-MM-dd HH:mm:ss format.
        /// *   **bEndTime**: the time when ringing on Line B ended, in the yyyy-MM-dd HH:mm:ss format.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

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
