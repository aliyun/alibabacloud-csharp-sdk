// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyAuditLogConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the status of SQL audit is updated. Valid values:
        /// 
        /// *   **true**: The status of SQL audit is updated.
        /// *   **false**: The status of SQL audit is not updated.
        /// </summary>
        [NameInMap("UpdateSucceed")]
        [Validation(Required=false)]
        public bool? UpdateSucceed { get; set; }

    }

}
