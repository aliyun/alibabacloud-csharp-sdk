// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public int? EnableBackupLog { get; set; }

        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

    }

}
