// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupSetsResponseBody : TeaModel {
        [NameInMap("BackupSets")]
        [Validation(Required=false)]
        public DescribeBackupSetsResponseBodyBackupSets BackupSets { get; set; }
        public class DescribeBackupSetsResponseBodyBackupSets : TeaModel {
            [NameInMap("backupSet")]
            [Validation(Required=false)]
            public List<DescribeBackupSetsResponseBodyBackupSetsBackupSet> BackupSet { get; set; }
            public class DescribeBackupSetsResponseBodyBackupSetsBackupSet : TeaModel {
                public string BackupConsitentTime { get; set; }
                public DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs BackupDbs { get; set; }
                public class DescribeBackupSetsResponseBodyBackupSetsBackupSetBackupDbs : TeaModel {
                    [NameInMap("backupDb")]
                    [Validation(Required=false)]
                    public List<string> BackupDb { get; set; }

                }
                public long? BackupEndTime { get; set; }
                public string BackupLevel { get; set; }
                public string BackupMode { get; set; }
                public long? BackupStartTime { get; set; }
                public string BackupTotalSize { get; set; }
                public string BackupType { get; set; }
                public bool? EnableRecovery { get; set; }
                public string Id { get; set; }
                public long? Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
