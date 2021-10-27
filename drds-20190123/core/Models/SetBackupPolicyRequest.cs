// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetBackupPolicyRequest : TeaModel {
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        [NameInMap("DataBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataBackupRetentionPeriod { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        [NameInMap("PreferredBackupEndTime")]
        [Validation(Required=false)]
        public string PreferredBackupEndTime { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupStartTime")]
        [Validation(Required=false)]
        public string PreferredBackupStartTime { get; set; }

    }

}
