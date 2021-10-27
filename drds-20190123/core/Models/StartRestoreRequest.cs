// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class StartRestoreRequest : TeaModel {
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

    }

}
