// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetBackupStorageCountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackupStorageCount")]
        [Validation(Required=false)]
        public GetBackupStorageCountResponseBodyBackupStorageCount BackupStorageCount { get; set; }
        public class GetBackupStorageCountResponseBodyBackupStorageCount : TeaModel {
            [NameInMap("Overflow")]
            [Validation(Required=false)]
            public int? Overflow { get; set; }
            [NameInMap("UniUsageStorageByte")]
            [Validation(Required=false)]
            public long? UniUsageStorageByte { get; set; }
            [NameInMap("BuyStorageByte")]
            [Validation(Required=false)]
            public long? BuyStorageByte { get; set; }
            [NameInMap("UsageStorageByte")]
            [Validation(Required=false)]
            public long? UsageStorageByte { get; set; }
            [NameInMap("EcsUsageStorageByte")]
            [Validation(Required=false)]
            public long? EcsUsageStorageByte { get; set; }
        };

    }

}
