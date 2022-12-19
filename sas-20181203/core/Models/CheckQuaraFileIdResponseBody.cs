// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckQuaraFileIdResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the ID of the quarantined file is valid. Valid values:
        /// 
        /// *   **true**: The ID of the quarantined file is valid.
        /// *   **false**: The ID of the quarantined file is invalid.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
