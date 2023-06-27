// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class BatchSendMessageToGlobeResponseBody : TeaModel {
        /// <summary>
        /// The list of mobile phone numbers that failed to receive the message.
        /// </summary>
        [NameInMap("FailedList")]
        [Validation(Required=false)]
        public string FailedList { get; set; }

        /// <summary>
        /// The sender ID returned.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the message.
        /// </summary>
        [NameInMap("MessageIdList")]
        [Validation(Required=false)]
        public string MessageIdList { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status code. If OK is returned, the request is successful. For more information, see [Error codes](https://www.alibabacloud.com/help/zh/short-message-service/latest/error-codes).
        /// </summary>
        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// The description of the status code.
        /// </summary>
        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        /// <summary>
        /// The number of mobile phone numbers that received the message.
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
