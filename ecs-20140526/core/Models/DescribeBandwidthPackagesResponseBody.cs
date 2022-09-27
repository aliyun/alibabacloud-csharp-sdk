// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public DescribeBandwidthPackagesResponseBodyBandwidthPackages BandwidthPackages { get; set; }
        public class DescribeBandwidthPackagesResponseBodyBandwidthPackages : TeaModel {
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage> BandwidthPackage { get; set; }
            public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("IpCount")]
                [Validation(Required=false)]
                public string IpCount { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

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
