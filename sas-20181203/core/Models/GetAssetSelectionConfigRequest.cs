// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// The business type that you want to select for the asset. Valid values:
        /// 
        /// *   **VIRUS_SCAN_CYCLE_CONFIG**: virus detection configuration
        /// *   **VIRUS_SCAN_ONCE_TASK**: one-time scan for virus detection
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

    }

}
