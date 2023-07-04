// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesResponseBody : TeaModel {
        /// <summary>
        /// The details about the IPv6 addresses.
        /// </summary>
        [NameInMap("Ipv6Addresses")]
        [Validation(Required=false)]
        public DescribeIpv6AddressesResponseBodyIpv6Addresses Ipv6Addresses { get; set; }
        public class DescribeIpv6AddressesResponseBodyIpv6Addresses : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address> Ipv6Address { get; set; }
            public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address : TeaModel {
                /// <summary>
                /// The time when the IPv6 address was created.
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// The ID of the instance that is assigned the IPv6 address.
                /// </summary>
                [NameInMap("AssociatedInstanceId")]
                [Validation(Required=false)]
                public string AssociatedInstanceId { get; set; }

                /// <summary>
                /// The type of the instance that is assigned the IPv6 address.
                /// </summary>
                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                /// <summary>
                /// The IPv6 address.
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                /// <summary>
                /// The ID of the IPv6 address.
                /// </summary>
                [NameInMap("Ipv6AddressId")]
                [Validation(Required=false)]
                public string Ipv6AddressId { get; set; }

                /// <summary>
                /// The name of the IPv6 address.
                /// </summary>
                [NameInMap("Ipv6AddressName")]
                [Validation(Required=false)]
                public string Ipv6AddressName { get; set; }

                /// <summary>
                /// The ID of the IPv6 gateway to which the IPv6 address belongs.
                /// </summary>
                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                /// <summary>
                /// The information about the Internet bandwidth of the IPv6 address.
                /// </summary>
                [NameInMap("Ipv6InternetBandwidth")]
                [Validation(Required=false)]
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth Ipv6InternetBandwidth { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth : TeaModel {
                    /// <summary>
                    /// The exclusive Internet bandwidth of the IPv6 address. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// The status of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// *   **Normal**: normal
                    /// *   **FinancialLocked**: locked due to overdue payments
                    /// *   **SecurityLocked**: locked due to security reasons
                    /// </summary>
                    [NameInMap("BusinessStatus")]
                    [Validation(Required=false)]
                    public string BusinessStatus { get; set; }

                    [NameInMap("HasReservationData")]
                    [Validation(Required=false)]
                    public bool? HasReservationData { get; set; }

                    /// <summary>
                    /// The billing method of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// **PostPaid**: pay-as-you-go
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// The billing method of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// *   **PayByTraffic**: pay-by-data-transfer
                    /// *   **PayByBandwidth**: pay-by-bandwidth
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// The instance ID of the Internet bandwidth of the IPv6 address.
                    /// </summary>
                    [NameInMap("Ipv6InternetBandwidthId")]
                    [Validation(Required=false)]
                    public string Ipv6InternetBandwidthId { get; set; }

                    [NameInMap("ReservationActiveTime")]
                    [Validation(Required=false)]
                    public string ReservationActiveTime { get; set; }

                    [NameInMap("ReservationBandwidth")]
                    [Validation(Required=false)]
                    public long? ReservationBandwidth { get; set; }

                    [NameInMap("ReservationInternetChargeType")]
                    [Validation(Required=false)]
                    public string ReservationInternetChargeType { get; set; }

                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                }

                /// <summary>
                /// The service provider of the IPv6 address. Valid values:
                /// 
                /// *   **BGP**: Alibaba Cloud Border Gateway Protocol (BGP) IPv6. This is the default value.
                /// *   **ChinaMobile**: China Mobile (single ISP).
                /// *   **ChinaUnicom**: China Unicom (single ISP).
                /// *   **ChinaTelecom**: China Telecom (single ISP).
                /// </summary>
                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

                /// <summary>
                /// The type of communication supported by the IPv6 address. Valid values:
                /// 
                /// *   **Private**: communication within private networks
                /// *   **Public**: communication over the Internet
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The maximum bandwidth value of the IPv6 address.
                /// 
                /// *   If the IPv6 address is associated with an EIP bandwidth plan, the value of **RealBandwidth** is the maximum bandwidth value of the EIP bandwidth plan.
                /// *   If the IPv6 address is not associated with an EIP bandwidth plan, the value of **RealBandwidth** is the maximum bandwidth value of the Internet bandwidth of the IPv6 address.
                /// *   If the IPv6 address is not associated with an EIP bandwidth plan or an Internet bandwidth plan, the values of **RealBandwidth** and **Bandwidth** are both 0.
                /// </summary>
                [NameInMap("RealBandwidth")]
                [Validation(Required=false)]
                public int? RealBandwidth { get; set; }

                /// <summary>
                /// The status of the IPv6 address. Valid values:
                /// 
                /// *   **Pending**: being configured
                /// *   **Available**: available
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the vSwitch to which the IPv6 address belongs.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC to which the IPv6 address belongs.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
