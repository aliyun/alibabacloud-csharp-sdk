// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class EnableBackupPlanRequest : TeaModel {
        /// <summary>
        /// The ID of the backup schedule.
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: The system backs up data from Elastic Compute Service (ECS) instances.
        /// *   **OSS**: The system backs up data from Object Storage Service (OSS) buckets.
        /// *   **NAS**: The system backs up data from Apsara File Storage NAS file systems.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
