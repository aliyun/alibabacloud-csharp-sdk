// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddNodesRequest : TeaModel {
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<AddNodesRequestDataDisks> DataDisks { get; set; }
        public class AddNodesRequestDataDisks : TeaModel {
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            [NameInMap("DataDiskDeleteWithInstance")]
            [Validation(Required=false)]
            public bool? DataDiskDeleteWithInstance { get; set; }

            [NameInMap("DataDiskEncrypted")]
            [Validation(Required=false)]
            public bool? DataDiskEncrypted { get; set; }

            [NameInMap("DataDiskKMSKeyId")]
            [Validation(Required=false)]
            public string DataDiskKMSKeyId { get; set; }

            [NameInMap("DataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

        }

        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        [NameInMap("MinCount")]
        [Validation(Required=false)]
        public int? MinCount { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
