// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeCommonBandwidthPackagesResponseBody : TeaModel {
        [NameInMap("CommonBandwidthPackages")]
        [Validation(Required=false)]
        public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages CommonBandwidthPackages { get; set; }
        public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackages : TeaModel {
            [NameInMap("CommonBandwidthPackage")]
            [Validation(Required=false)]
            public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage> CommonBandwidthPackage { get; set; }
            public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackage : TeaModel {
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

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PublicIpAddresses")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses PublicIpAddresses { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddresses : TeaModel {
                    [NameInMap("PublicIpAddresse")]
                    [Validation(Required=false)]
                    public List<DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse> PublicIpAddresse { get; set; }
                    public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackagePublicIpAddressesPublicIpAddresse : TeaModel {
                        [NameInMap("AllocationId")]
                        [Validation(Required=false)]
                        public string AllocationId { get; set; }

                        [NameInMap("BandwidthPackageIpRelationStatus")]
                        [Validation(Required=false)]
                        public string BandwidthPackageIpRelationStatus { get; set; }

                        [NameInMap("IpAddress")]
                        [Validation(Required=false)]
                        public string IpAddress { get; set; }

                    }

                }

                [NameInMap("Ratio")]
                [Validation(Required=false)]
                public int? Ratio { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservationActiveTime")]
                [Validation(Required=false)]
                public string ReservationActiveTime { get; set; }

                [NameInMap("ReservationBandwidth")]
                [Validation(Required=false)]
                public string ReservationBandwidth { get; set; }

                [NameInMap("ReservationInternetChargeType")]
                [Validation(Required=false)]
                public string ReservationInternetChargeType { get; set; }

                [NameInMap("ReservationOrderType")]
                [Validation(Required=false)]
                public string ReservationOrderType { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeCommonBandwidthPackagesResponseBodyCommonBandwidthPackagesCommonBandwidthPackageSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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
