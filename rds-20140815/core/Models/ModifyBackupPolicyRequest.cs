// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public int? ArchiveBackupKeepCount { get; set; }

        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupPolicyMode")]
        [Validation(Required=false)]
        public string BackupPolicyMode { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public string LocalLogRetentionHours { get; set; }

        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

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
