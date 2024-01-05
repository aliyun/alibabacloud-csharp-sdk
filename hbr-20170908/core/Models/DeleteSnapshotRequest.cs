// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeleteSnapshotRequest : TeaModel {
        /// <summary>
        /// The ID of the backup client. If you delete a backup file for Elastic Compute Service (ECS) instances, you must set one of the **InstanceId** and ClientId parameters.
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies whether to forcibly delete the most recent backup file. Valid values:
        /// 
        /// *   true: The system forcibly deletes the last backup file.
        /// *   false: The system does not forcibly delete the last backup file. Default value: false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the ECS instance. If you delete a backup file for Elastic Compute Service (ECS) instances, you must set one of the **ClientId** and InstanceId parameters.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the backup file.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The type of the backup source. Valid values:
        /// 
        /// *   **ECS_FILE**: indicates backup files for ECS instances.
        /// *   **OSS**: indicates backup files for Object Storage Service (OSS) buckets.
        /// *   **NAS**: indicates the backup files for Apsara File Storage NAS file systems.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The token.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the backup vault.
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
