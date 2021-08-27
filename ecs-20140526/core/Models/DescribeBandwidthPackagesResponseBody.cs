// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public DescribeBandwidthPackagesResponseBodyBandwidthPackages BandwidthPackages { get; set; }
        public class DescribeBandwidthPackagesResponseBodyBandwidthPackages : TeaModel {
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage> BandwidthPackage { get; set; }
            public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string IpCount { get; set; }
                public string RegionId { get; set; }
                public string InstanceChargeType { get; set; }
                public string BandwidthPackageId { get; set; }
                public string Description { get; set; }
                public string Bandwidth { get; set; }
                public string NatGatewayId { get; set; }
                public string ZoneId { get; set; }
                public string InternetChargeType { get; set; }
                public string BusinessStatus { get; set; }
                public string Name { get; set; }
                public string ISP { get; set; }
                public DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                    }

                }
            }
        };

    }

}
