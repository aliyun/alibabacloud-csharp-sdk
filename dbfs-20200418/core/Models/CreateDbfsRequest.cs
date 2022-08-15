// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class CreateDbfsRequest : TeaModel {
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DeleteSnapshot")]
        [Validation(Required=false)]
        public bool? DeleteSnapshot { get; set; }

        [NameInMap("EnableRaid")]
        [Validation(Required=false)]
        public bool? EnableRaid { get; set; }

        [NameInMap("Encryption")]
        [Validation(Required=false)]
        public bool? Encryption { get; set; }

        [NameInMap("FsName")]
        [Validation(Required=false)]
        public string FsName { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        [NameInMap("RaidStripeUnitNumber")]
        [Validation(Required=false)]
        public int? RaidStripeUnitNumber { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SizeG")]
        [Validation(Required=false)]
        public int? SizeG { get; set; }

        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        [NameInMap("UsedScene")]
        [Validation(Required=false)]
        public string UsedScene { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
