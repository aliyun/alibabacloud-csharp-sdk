// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDetachedBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDetachedBackupsResponseBodyItems Items { get; set; }
        public class DescribeDetachedBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeDetachedBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeDetachedBackupsResponseBodyItemsBackup : TeaModel {
                public string BackupDownloadURL { get; set; }
                public string BackupEndTime { get; set; }
                public string BackupId { get; set; }
                public string BackupIntranetDownloadURL { get; set; }
                public string BackupMethod { get; set; }
                public string BackupMode { get; set; }
                public long? BackupSize { get; set; }
                public string BackupStartTime { get; set; }
                public string BackupStatus { get; set; }
                public string BackupType { get; set; }
                public long? ConsistentTime { get; set; }
                public string DBInstanceComment { get; set; }
                public string DBInstanceId { get; set; }
                public string HostInstanceID { get; set; }
                public int? IsAvail { get; set; }
                public string MetaStatus { get; set; }
                public string StoreStatus { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
