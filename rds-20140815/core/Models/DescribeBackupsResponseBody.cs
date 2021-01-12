// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        [NameInMap("TotalEcsSnapshotSize")]
        [Validation(Required=false)]
        public long? TotalEcsSnapshotSize { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                public string BackupId { get; set; }
                public string DBInstanceId { get; set; }
                public string BackupStatus { get; set; }
                public string BackupStartTime { get; set; }
                public string BackupEndTime { get; set; }
                public string BackupType { get; set; }
                public string BackupMode { get; set; }
                public string BackupMethod { get; set; }
                public string BackupDownloadURL { get; set; }
                public string BackupIntranetDownloadURL { get; set; }
                public long? BackupSize { get; set; }
                public string HostInstanceID { get; set; }
                public string StoreStatus { get; set; }
                public string MetaStatus { get; set; }
                public long? ConsistentTime { get; set; }
                public string BackupInitiator { get; set; }
                public string CopyOnlyBackup { get; set; }
                public string StorageClass { get; set; }
                public int? IsAvail { get; set; }
                public string Encryption { get; set; }
            }
        };

    }

}
