// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class RestoreCapacityResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the release command has been sent. Valid values:
        /// 
        /// *   true: The command has been sent and the storage space is being released.
        /// *   false: The command failed to be sent.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
