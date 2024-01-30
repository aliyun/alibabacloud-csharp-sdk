// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteBackupPlanRequest : TeaModel {
        /// <summary>
        /// The ID of the backup plan.
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        [NameInMap("RequireNoRunningJobs")]
        [Validation(Required=false)]
        public bool? RequireNoRunningJobs { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: Elastic Compute Service (ECS) files
        /// *   **OSS**: Object Storage Service (OSS) buckets
        /// *   **NAS**: Apsara File Storage NAS file systems
        /// *   **UDM_ECS**: ECS instances
        /// *   **OTS**: Tablestore instances
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
