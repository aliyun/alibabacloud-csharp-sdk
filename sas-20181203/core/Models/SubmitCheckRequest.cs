// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitCheckRequest : TeaModel {
        /// <summary>
        /// The check items that are scanned. Valid values:
        /// 
        /// *   **FULL**: All check items are scanned.
        /// *   **FULL**: Only the check items that are configured are scanned.
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public string ScanRange { get; set; }

    }

}
