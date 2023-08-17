// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeAdviceServiceEnabledResponseBody : TeaModel {
        /// <summary>
        /// The message returned for the operation. Valid values:
        /// 
        /// *   **Success** is returned if the operation is successful.
        /// *   An error message is returned if the operation fails.
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
        /// Indicates whether the suggestion feature is enabled. Valid values:
        /// 
        /// *   **True**: The suggestion feature is enabled.
        /// *   **False**: The suggestion feature is disabled.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
