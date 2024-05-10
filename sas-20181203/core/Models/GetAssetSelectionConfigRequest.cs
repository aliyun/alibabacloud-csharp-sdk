// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetSelectionConfigRequest : TeaModel {
        /// <summary>
        /// The feature that is selected for the asset. Valid values:
        /// 
        /// *   **VIRUS_SCAN_CYCLE_CONFIG**: virus detection and removal
        /// *   **VIRUS_SCAN_ONCE_TASK**: one-time scan for viruses
        /// *   **AGENTLESS_MALICIOUS_WHITE_LIST_[ID]**: a whitelist rule for alerts that are detected by using the agentless detection feature
        /// *   **AGENTLESS_VUL_WHITE_LIST_[ID]**: a whitelist rule for vulnerabilities that are detected by using the agentless detection feature
        /// *   **FILE_PROTECT_RULE_SWITCH_TYPE_[ID]**: core file protectioion
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

    }

}
