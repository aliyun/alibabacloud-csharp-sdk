// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupDirsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupDirsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupDirsResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
        };

        [NameInMap("BackupDirs")]
        [Validation(Required=false)]
        public List<DescribeBackupDirsResponseBodyBackupDirs> BackupDirs { get; set; }
        public class DescribeBackupDirsResponseBodyBackupDirs : TeaModel {
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("BackupJobId")]
            [Validation(Required=false)]
            public long? BackupJobId { get; set; }

        }

    }

}
