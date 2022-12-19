// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OpenSensitiveFileScanRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable or disable sensitive file scan. Valid values:
        /// 
        /// *   **on**: enables sensitive file scan
        /// *   **off**: disables sensitive file scan
        /// </summary>
        [NameInMap("SwitchOn")]
        [Validation(Required=false)]
        public string SwitchOn { get; set; }

    }

}
