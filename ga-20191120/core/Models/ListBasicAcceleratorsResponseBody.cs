// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListBasicAcceleratorsResponseBody : TeaModel {
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<ListBasicAcceleratorsResponseBodyAccelerators> Accelerators { get; set; }
        public class ListBasicAcceleratorsResponseBodyAccelerators : TeaModel {
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            [NameInMap("BandwidthBillingType")]
            [Validation(Required=false)]
            public string BandwidthBillingType { get; set; }

            [NameInMap("BasicBandwidthPackage")]
            [Validation(Required=false)]
            public ListBasicAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage BasicBandwidthPackage { get; set; }
            public class ListBasicAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            [NameInMap("BasicEndpointGroupId")]
            [Validation(Required=false)]
            public string BasicEndpointGroupId { get; set; }

            [NameInMap("BasicIpSetId")]
            [Validation(Required=false)]
            public string BasicIpSetId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CrossDomainBandwidthPackage")]
            [Validation(Required=false)]
            public ListBasicAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
            public class ListBasicAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBasicAcceleratorsResponseBodyAcceleratorsTags> Tags { get; set; }
            public class ListBasicAcceleratorsResponseBodyAcceleratorsTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
