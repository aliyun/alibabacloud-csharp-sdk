// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyRequest : TeaModel {
        /// <summary>
        /// The backup type. Valid values:
        /// 
        /// *   **DataBackupPolicy**: data backup
        /// *   **LogBackupPolicy**: log backup
        /// </summary>
        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        /// <summary>
        /// The method that is used to compress backup data. Valid values:
        /// 
        /// *   **0**: Backup data is not compressed.
        /// *   **1**: Backup data is compressed by using zlib.
        /// *   **2**: Backup data is compressed by using zlib that invokes more than one thread in parallel for each backup.
        /// *   **4**: Backup data is compressed by using QuickLZ and can be used to restore individual databases or tables.
        /// *   **8**: Backup data is compressed by using QuickLZ but cannot be used to restore individual databases or tables.
        /// </summary>
        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The policy that is used to retain archived backup files if the instance is released. Valid values:
        /// 
        /// *   **None**: No archived backup files are retained.
        /// *   **Lastest**: Only the last archived backup file is retained.
        /// *   **All**: All archived backup files are retained.
        /// </summary>
        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
