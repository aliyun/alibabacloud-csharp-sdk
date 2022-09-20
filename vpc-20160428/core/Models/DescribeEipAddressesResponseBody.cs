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
                [NameInMap("AllocationId")]
                [Validation(Required=false)]
                public string AllocationId { get; set; }

                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                [NameInMap("AvailableRegions")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressAvailableRegions AvailableRegions { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressAvailableRegions : TeaModel {
                    [NameInMap("AvailableRegion")]
                    [Validation(Required=false)]
                    public List<string> AvailableRegion { get; set; }

                }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public string Bandwidth { get; set; }

                [NameInMap("BandwidthPackageBandwidth")]
                [Validation(Required=false)]
                public string BandwidthPackageBandwidth { get; set; }

                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                [NameInMap("BandwidthPackageType")]
                [Validation(Required=false)]
                public string BandwidthPackageType { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("DeletionProtection")]
                [Validation(Required=false)]
                public bool? DeletionProtection { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public string EipBandwidth { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("HDMonitorStatus")]
                [Validation(Required=false)]
                public string HDMonitorStatus { get; set; }

                [NameInMap("HasReservationData")]
                [Validation(Required=false)]
                public string HasReservationData { get; set; }

                [NameInMap("ISP")]
                [Validation(Required=false)]
                public string ISP { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceRegionId")]
                [Validation(Required=false)]
                public string InstanceRegionId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                [NameInMap("IpAddress")]
                [Validation(Required=false)]
                public string IpAddress { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Netmode")]
                [Validation(Required=false)]
                public string Netmode { get; set; }

                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
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

                [NameInMap("PublicIpAddressPoolId")]
                [Validation(Required=false)]
                public string PublicIpAddressPoolId { get; set; }

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

                [NameInMap("SecondLimited")]
                [Validation(Required=false)]
                public bool? SecondLimited { get; set; }

                [NameInMap("SecurityProtectionTypes")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes SecurityProtectionTypes { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressSecurityProtectionTypes : TeaModel {
                    [NameInMap("SecurityProtectionType")]
                    [Validation(Required=false)]
                    public List<string> SecurityProtectionType { get; set; }

                }

                [NameInMap("SegmentInstanceId")]
                [Validation(Required=false)]
                public string SegmentInstanceId { get; set; }

                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeEipAddressesResponseBodyEipAddressesEipAddressTags Tags { get; set; }
                public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag> Tag { get; set; }
                    public class DescribeEipAddressesResponseBodyEipAddressesEipAddressTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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
