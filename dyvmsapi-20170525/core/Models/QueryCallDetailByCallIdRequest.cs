// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallDetailByCallIdRequest : TeaModel {
        /// <summary>
        /// The unique ID of the call.
        /// 
        /// > 
        /// 
        /// *   The CallId parameter is included in the response parameters of the outbound call operation that you call to initiate a call.
        /// 
        /// *   The date when the call specified by CallId is started must be the same as the date specified by QueryDate.
        /// 
        /// *   The value of CallId must match the value of ProdId.
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The service ID. Valid values:
        /// 
        /// *   **11000000300006**: voice notification. You can call the [SingleCallByVoice](https://help.aliyun.com/document_detail/393517.html) operation to send a voice notification of the voice notification file type to the specified number.
        /// *   **11010000138001**: voice verification code. You can call the [SingleCallByTts](https://help.aliyun.com/document_detail/393519.html) operation to send a voice verification code or a text-to-speech (TTS) voice notification to the specified number.
        /// *   **11000000300005**: IVR. You can call the [IvrCall](https://help.aliyun.com/document_detail/393521.html) operation to initiate an interactive voice call to the specified number.
        /// *   **11000000300009**: Session Initiation Protocol (SIP) call.
        /// *   **11030000180001**: intelligent outbound call.
        /// </summary>
        [NameInMap("ProdId")]
        [Validation(Required=false)]
        public long? ProdId { get; set; }

        /// <summary>
        /// The time at which call details are queried. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// > The system queries the call records that are generated within 24 hours after the specified point in time. For example, if you specify the time 20:00:01 on November 21, 2022, the system queries the call records that are generated for the specified call ID from 20:00:01 on November 21, 2022, to 20:00:01 on November 22, 2022.
        /// </summary>
        [NameInMap("QueryDate")]
        [Validation(Required=false)]
        public long? QueryDate { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
