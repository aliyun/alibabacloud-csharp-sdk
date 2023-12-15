// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class ModifyBackupPlanRequest : TeaModel {
        [NameInMap("Active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        [NameInMap("BackupTime")]
        [Validation(Required=false)]
        public string BackupTime { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DataCenterId")]
        [Validation(Required=false)]
        public string DataCenterId { get; set; }

        [NameInMap("RetentionPeriod")]
        [Validation(Required=false)]
        public int? RetentionPeriod { get; set; }

    }

}
