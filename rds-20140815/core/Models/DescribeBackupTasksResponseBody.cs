// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyItems Items { get; set; }
        public class DescribeBackupTasksResponseBodyItems : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<DescribeBackupTasksResponseBodyItemsBackupJob> BackupJob { get; set; }
            public class DescribeBackupTasksResponseBodyItemsBackupJob : TeaModel {
                public string BackupProgressStatus { get; set; }
                public string BackupStatus { get; set; }
                public string JobMode { get; set; }
                public string Process { get; set; }
                public string TaskAction { get; set; }
                public string BackupJobId { get; set; }
                public string BackupId { get; set; }
            }
        };

    }

}
