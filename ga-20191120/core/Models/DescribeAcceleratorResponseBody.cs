// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeAcceleratorResponseBody : TeaModel {
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        public string DdosId { get; set; }

        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("CrossDomainBandwidthPackage")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

        [NameInMap("SecondDnsName")]
        [Validation(Required=false)]
        public string SecondDnsName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("BasicBandwidthPackage")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyBasicBandwidthPackage BasicBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyBasicBandwidthPackage : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

    }

}
