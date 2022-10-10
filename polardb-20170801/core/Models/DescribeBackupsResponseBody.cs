// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                [NameInMap("BackupSetSize")]
                [Validation(Required=false)]
                public string BackupSetSize { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("BackupsLevel")]
                [Validation(Required=false)]
                public string BackupsLevel { get; set; }

                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

            }

        }

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
