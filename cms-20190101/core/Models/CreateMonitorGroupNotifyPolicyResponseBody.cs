// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupNotifyPolicyResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The HTTP status code 200 indicates that the call succeeds.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries that are returned.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public int? Result { get; set; }

        /// <summary>
        /// Indicates whether the call succeeds. Valid values:
        /// 
        /// *   true: The call succeeds.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
