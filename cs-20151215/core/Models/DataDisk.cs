// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DataDisk : TeaModel {
        [NameInMap("auto_snapshot_policy_id")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        [NameInMap("bursting_enabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("encrypted")]
        [Validation(Required=false)]
        public string Encrypted { get; set; }

        [NameInMap("performance_level")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("provisioned_iops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
