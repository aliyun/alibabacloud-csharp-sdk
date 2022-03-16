// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyBackupPlanConfigRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("FullBackupCycle")]
        [Validation(Required=false)]
        public string FullBackupCycle { get; set; }

        [NameInMap("MinHFileBackupCount")]
        [Validation(Required=false)]
        public string MinHFileBackupCount { get; set; }

        [NameInMap("NextFullBackupDate")]
        [Validation(Required=false)]
        public string NextFullBackupDate { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

    }

}
