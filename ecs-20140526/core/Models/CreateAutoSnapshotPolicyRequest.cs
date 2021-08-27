// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        [NameInMap("timePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        [NameInMap("retentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        [NameInMap("EnableCrossRegionCopy")]
        [Validation(Required=false)]
        public bool? EnableCrossRegionCopy { get; set; }

        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        [NameInMap("CopiedSnapshotsRetentionDays")]
        [Validation(Required=false)]
        public int? CopiedSnapshotsRetentionDays { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateAutoSnapshotPolicyRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
