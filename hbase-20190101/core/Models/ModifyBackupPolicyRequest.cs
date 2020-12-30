// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupStartTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupStartTimeUTC { get; set; }

        [NameInMap("PreferredBackupEndTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupEndTimeUTC { get; set; }

    }

}
