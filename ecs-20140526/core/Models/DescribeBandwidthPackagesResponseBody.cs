// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("BandwidthPackages")]
        [Validation(Required=false)]
        public DescribeBandwidthPackagesResponseBodyBandwidthPackages BandwidthPackages { get; set; }
        public class DescribeBandwidthPackagesResponseBodyBandwidthPackages : TeaModel {
            [NameInMap("BandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage> BandwidthPackage { get; set; }
            public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackage : TeaModel {
                [NameInMap("PublicIpAddresse")]
                [Validation(Required=false)]
                public List<DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresse> PublicIpAddresse { get; set; }
                public class DescribeBandwidthPackagesResponseBodyBandwidthPackagesBandwidthPackagePublicIpAddresse : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                }

            }
        };

    }

}
