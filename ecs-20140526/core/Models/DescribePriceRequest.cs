// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribePriceRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public DescribePriceRequestSystemDisk SystemDisk { get; set; }
        public class DescribePriceRequestSystemDisk : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }
        };

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<DescribePriceRequestDataDisk> DataDisk { get; set; }
        public class DescribePriceRequestDataDisk : TeaModel {
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("DedicatedHostType")]
        [Validation(Required=false)]
        public string DedicatedHostType { get; set; }

        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("InstanceTypeList")]
        [Validation(Required=false)]
        public List<string> InstanceTypeList { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
