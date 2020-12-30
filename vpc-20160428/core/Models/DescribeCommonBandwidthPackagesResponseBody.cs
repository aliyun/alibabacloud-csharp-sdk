// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCommonBandwidthPackagesResponseBody : TeaModel {
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

        [NameInMap("CommonBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages CommonBandwidthPackages { get; set; }
        public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages : TeaModel {
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage> CommonBandwidthPackage { get; set; }
            public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage : TeaModel {
                [NameInMap("PublicIpAddresse")]
                [Validation(Required=false)]
                public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresse> PublicIpAddresse { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresse : TeaModel {
                    [NameInMap("IpAddress")]
                    [Validation(Required=false)]
                    public string IpAddress { get; set; }

                    [NameInMap("AllocationId")]
                    [Validation(Required=false)]
                    public string AllocationId { get; set; }

                    [NameInMap("BandwidthPackageIpRelationStatus")]
                    [Validation(Required=false)]
                    public string BandwidthPackageIpRelationStatus { get; set; }

                }

            }
        };

    }

}
