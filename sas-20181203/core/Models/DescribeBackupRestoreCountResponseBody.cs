// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupRestoreCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackupRestoreCount")]
        [Validation(Required=false)]
        public DescribeBackupRestoreCountResponseBodyBackupRestoreCount BackupRestoreCount { get; set; }
        public class DescribeBackupRestoreCountResponseBodyBackupRestoreCount : TeaModel {
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
            [NameInMap("Recovering")]
            [Validation(Required=false)]
            public int? Recovering { get; set; }
        };

    }

}
