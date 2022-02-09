// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupLogsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupLogsResponseBodyItems Items { get; set; }
        public class DescribeBackupLogsResponseBodyItems : TeaModel {
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public List<DescribeBackupLogsResponseBodyItemsBackupLog> BackupLog { get; set; }
            public class DescribeBackupLogsResponseBodyItemsBackupLog : TeaModel {
                public string BackupLogEndTime { get; set; }
                public string BackupLogId { get; set; }
                public string BackupLogName { get; set; }
                public string BackupLogSize { get; set; }
                public string BackupLogStartTime { get; set; }
                public string DownloadLink { get; set; }
                public string IntranetDownloadLink { get; set; }
                public string LinkExpiredTime { get; set; }
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
