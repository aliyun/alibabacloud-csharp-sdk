// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public string BackupSize { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
