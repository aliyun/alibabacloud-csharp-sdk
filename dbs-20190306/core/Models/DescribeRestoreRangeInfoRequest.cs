// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreRangeInfoRequest : TeaModel {
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        [NameInMap("BeginTimestampForRestore")]
        [Validation(Required=false)]
        public long? BeginTimestampForRestore { get; set; }

        [NameInMap("EndTimestampForRestore")]
        [Validation(Required=false)]
        public long? EndTimestampForRestore { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("RecentlyRestore")]
        [Validation(Required=false)]
        public bool? RecentlyRestore { get; set; }

    }

}
