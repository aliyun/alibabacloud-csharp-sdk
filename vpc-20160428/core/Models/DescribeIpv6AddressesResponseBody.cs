// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesResponseBody : TeaModel {
        /// <summary>
        /// The details of the IPv6 address.
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
                /// The ID of the instance associated with the IPv6 address.
                /// </summary>
                [NameInMap("AssociatedInstanceId")]
                [Validation(Required=false)]
                public string AssociatedInstanceId { get; set; }

                /// <summary>
                /// The type of instance associated with the IPv6 address.
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
                /// The description of the IPv6 address.
                /// </summary>
                [NameInMap("Ipv6AddressDescription")]
                [Validation(Required=false)]
                public string Ipv6AddressDescription { get; set; }

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
                /// The Internet bandwidth of the IPv6 address.
                /// </summary>
                [NameInMap("Ipv6InternetBandwidth")]
                [Validation(Required=false)]
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth Ipv6InternetBandwidth { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth : TeaModel {
                    /// <summary>
                    /// The dedicated Internet bandwidth of the IPv6 address. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// The status of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// *   **Normal**
                    /// *   **FinancialLocked**
                    /// *   **SecurityLocked**
                    /// </summary>
                    [NameInMap("BusinessStatus")]
                    [Validation(Required=false)]
                    public string BusinessStatus { get; set; }

                    /// <summary>
                    /// Indicates whether renewal data is included. Valid values:
                    /// 
                    /// *   **false**
                    /// *   **true** **true** is returned only when **IncludeReservationData** is set to **true** and some orders have not taken effect.
                    /// </summary>
                    [NameInMap("HasReservationData")]
                    [Validation(Required=false)]
                    public bool? HasReservationData { get; set; }

                    /// <summary>
                    /// The billing method of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// Only **PostPaid** may be returned, which indicates the pay-as-you-go billing method.
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// The billing method of the Internet bandwidth of the IPv6 address. Valid values:
                    /// 
                    /// *   **PayByTraffic**
                    /// *   **PayByBandwidth**: pay-by-bandwidth
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// The Internet bandwidth ID of the IPv6 address.
                    /// </summary>
                    [NameInMap("Ipv6InternetBandwidthId")]
                    [Validation(Required=false)]
                    public string Ipv6InternetBandwidthId { get; set; }

                    /// <summary>
                    /// The time when the renewal took effect. The time follows the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format.
                    /// </summary>
                    [NameInMap("ReservationActiveTime")]
                    [Validation(Required=false)]
                    public string ReservationActiveTime { get; set; }

                    /// <summary>
                    /// The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.
                    /// </summary>
                    [NameInMap("ReservationBandwidth")]
                    [Validation(Required=false)]
                    public long? ReservationBandwidth { get; set; }

                    /// <summary>
                    /// The metering method that is used after the renewal takes effect.
                    /// 
                    /// *   **PayByTraffic**
                    /// *   **PayByBandwidth**: pay-by-bandwidth
                    /// </summary>
                    [NameInMap("ReservationInternetChargeType")]
                    [Validation(Required=false)]
                    public string ReservationInternetChargeType { get; set; }

                    /// <summary>
                    /// The type of the renewal order. Only **RENEW** may be returned, which indicates that the order is placed for service renewal.
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                }

                /// <summary>
                /// The ISP of the IPv6 address.
                /// 
                /// *   **BGP** (default)
                /// *   **ChinaMobile**
                /// *   **ChinaUnicom**
                /// *   **ChinaTelecom**
                /// </summary>
                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

                /// <summary>
                /// The type of connection supported by the IPv6 address. Valid values:
                /// 
                /// *   **Private**
                /// *   **Public**
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The peak bandwidth of the IPv6 address.
                /// </summary>
                [NameInMap("RealBandwidth")]
                [Validation(Required=false)]
                public int? RealBandwidth { get; set; }

                /// <summary>
                /// The ID of the resource group to which the IPv6 gateway belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the IPv6 address.
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag list.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressTags Tags { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressTagsTag> Tag { get; set; }
                    public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressTagsTag : TeaModel {
                        /// <summary>
                        /// The key of tag N. You can specify at most 20 tag keys. The tag key cannot be an empty string.
                        /// 
                        /// The tag key can be up to 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of tag N.
                        /// 
                        /// The tag value can be up to 128 characters in length. It can be an empty string. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
                        /// 
                        /// Each tag key corresponds to one tag value. You can specify at most 20 tag values at a time.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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
        /// The page number of the returned page. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
