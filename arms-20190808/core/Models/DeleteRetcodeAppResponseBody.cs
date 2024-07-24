// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteRetcodeAppResponseBody : TeaModel {
        /// <summary>
        /// Status code. 200 means success, other status codes are exceptions.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Indicates whether the Browser Monitoring task was deleted. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// Additional information. The value description is as follows:
        /// - If the request is normal, return success.
        /// - If the request is abnormal, return specific abnormal information.
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

        /// <summary>
        /// Whether the operation was successful:
        /// - `true`: The operation was successful
        /// - `false`: The operation failed
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
