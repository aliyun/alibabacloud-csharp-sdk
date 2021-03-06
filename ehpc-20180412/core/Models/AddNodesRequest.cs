// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddNodesRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public string ComputeSpotPriceLimit { get; set; }

        [NameInMap("EcsChargeType")]
        [Validation(Required=false)]
        public string EcsChargeType { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        [NameInMap("CreateMode")]
        [Validation(Required=false)]
        public string CreateMode { get; set; }

        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        [NameInMap("ComputeEnableHt")]
        [Validation(Required=false)]
        public bool? ComputeEnableHt { get; set; }

        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
