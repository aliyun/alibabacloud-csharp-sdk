// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("BackupPolicyDO")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDO BackupPolicyDO { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDO : TeaModel {
            [NameInMap("BackupAppName")]
            [Validation(Required=false)]
            public string BackupAppName { get; set; }
            [NameInMap("BackupDbName")]
            [Validation(Required=false)]
            public string BackupDbName { get; set; }
            [NameInMap("BackupLevel")]
            [Validation(Required=false)]
            public string BackupLevel { get; set; }
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public string BackupLog { get; set; }
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }
            [NameInMap("BackupPolicyMode")]
            [Validation(Required=false)]
            public string BackupPolicyMode { get; set; }
            [NameInMap("BackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? BackupRetentionPeriod { get; set; }
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }
            [NameInMap("DataBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? DataBackupRetentionPeriod { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public long? HighSpaceUsageProtection { get; set; }
            [NameInMap("LocalLogRetentionHours")]
            [Validation(Required=false)]
            public long? LocalLogRetentionHours { get; set; }
            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public long? LocalLogRetentionSpace { get; set; }
            [NameInMap("LogBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? LogBackupRetentionPeriod { get; set; }
            [NameInMap("NextBackupActuallyTime")]
            [Validation(Required=false)]
            public string NextBackupActuallyTime { get; set; }
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }
            [NameInMap("PreferredBackupTime")]
            [Validation(Required=false)]
            public string PreferredBackupTime { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
