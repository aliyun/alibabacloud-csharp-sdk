// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeEipAddressesResponseBody : TeaModel {
        [NameInMap("EipAddresses")]
        [Validation(Required=false)]
        public DescribeEipAddressesResponseBodyEipAddresses EipAddresses { get; set; }
        public class DescribeEipAddressesResponseBodyEipAddresses : TeaModel {
            [NameInMap("EipAddress")]
            [Validation(Required=false)]
            public List<DescribeEipAddressesResponseBodyEipAddressesEipAddress> EipAddress { get; set; }
            public class DescribeEipAddressesResponseBodyEipAddressesEipAddress : TeaModel {
                public string AllocationId { get; set; }
                public string AllocationTime { get; set; }
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressAvailableRegions AvailableRegions { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressAvailableRegions : TeaModel {
                    [NameInMap("AvailableRegion")]
                    [Validation(Required=false)]
                    public List<string> AvailableRegion { get; set; }

                }
                public string Bandwidth { get; set; }
                public string BandwidthPackageBandwidth { get; set; }
                public string BandwidthPackageId { get; set; }
                public string BandwidthPackageType { get; set; }
                public string BusinessStatus { get; set; }
                public string ChargeType { get; set; }
                public bool? DeletionProtection { get; set; }
                public string Descritpion { get; set; }
                public string EipBandwidth { get; set; }
                public string ExpiredTime { get; set; }
                public string HDMonitorStatus { get; set; }
                public string HasReservationData { get; set; }
                public string ISP { get; set; }
                public string InstanceId { get; set; }
                public string InstanceRegionId { get; set; }
                public string InstanceType { get; set; }
                public string InternetChargeType { get; set; }
                public string IpAddress { get; set; }
                public string Name { get; set; }
                public string Netmode { get; set; }
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks OperationLocks { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocks : TeaModel {
                    [NameInMap("LockReason")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason> LockReason { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressOperationLocksLockReason : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }
                public string RegionId { get; set; }
                public string ReservationActiveTime { get; set; }
                public string ReservationBandwidth { get; set; }
                public string ReservationInternetChargeType { get; set; }
                public string ReservationOrderType { get; set; }
                public string ResourceGroupId { get; set; }
                public bool? SecondLimited { get; set; }
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }
                public string SegmentInstanceId { get; set; }
                public int? ServiceManaged { get; set; }
                public string Status { get; set; }
            }
        };

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
