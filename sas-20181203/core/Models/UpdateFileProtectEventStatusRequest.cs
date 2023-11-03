// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectEventStatusRequest : TeaModel {
        /// <summary>
        /// The IDs of the events.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public List<long?> Id { get; set; }

        /// <summary>
        /// The handling status of the event. Valid values:
        /// 
        /// *   **0**: unhandled
        /// *   **1**: handled
        /// *   **2**: added to the whitelist
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
