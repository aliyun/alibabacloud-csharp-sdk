// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The status of the anti-ransomware policy. Valid values:
        /// 
        /// *   **enabled**: The anti-ransomware policy is manually enabled.
        /// *   **disabled**: The anti-ransomware policy is manually disabled. After an anti-ransomware policy is disabled, the data backup task that is running based on the policy stops.
        /// *   **closed**: The anti-ransomware policy automatically stops because the anti-ransomware capacity is insufficient.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
