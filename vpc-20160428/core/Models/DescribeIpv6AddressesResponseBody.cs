// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIpv6AddressesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the IPv6 address.</para>
        /// </summary>
        [NameInMap("Ipv6Addresses")]
        [Validation(Required=false)]
        public DescribeIpv6AddressesResponseBodyIpv6Addresses Ipv6Addresses { get; set; }
        public class DescribeIpv6AddressesResponseBodyIpv6Addresses : TeaModel {
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public List<DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address> Ipv6Address { get; set; }
            public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6Address : TeaModel {
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>The time when the IPv6 address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-20T14:56:09Z</para>
                /// </summary>
                [NameInMap("AllocationTime")]
                [Validation(Required=false)]
                public string AllocationTime { get; set; }

                /// <summary>
                /// <para>The ID of the instance associated with the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2ze72wuqj4y3jl4f****</para>
                /// </summary>
                [NameInMap("AssociatedInstanceId")]
                [Validation(Required=false)]
                public string AssociatedInstanceId { get; set; }

                /// <summary>
                /// <para>The type of instance associated with the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EcsInstance</para>
                /// </summary>
                [NameInMap("AssociatedInstanceType")]
                [Validation(Required=false)]
                public string AssociatedInstanceType { get; set; }

                /// <summary>
                /// <para>The IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:XXXX:153:3921:851c:c435:7b12:1c5f</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                /// <summary>
                /// <para>The description of the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Ipv6AddressDescription")]
                [Validation(Required=false)]
                public string Ipv6AddressDescription { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6-2zen5j4axcp5l5qyy****</para>
                /// </summary>
                [NameInMap("Ipv6AddressId")]
                [Validation(Required=false)]
                public string Ipv6AddressId { get; set; }

                /// <summary>
                /// <para>The name of the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Ipv6AddressName")]
                [Validation(Required=false)]
                public string Ipv6AddressName { get; set; }

                /// <summary>
                /// <para>The ID of the IPv6 gateway to which the IPv6 address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6gw-2zewg0l66s73b4k2q****</para>
                /// </summary>
                [NameInMap("Ipv6GatewayId")]
                [Validation(Required=false)]
                public string Ipv6GatewayId { get; set; }

                /// <summary>
                /// <para>The Internet bandwidth of the IPv6 address.</para>
                /// </summary>
                [NameInMap("Ipv6InternetBandwidth")]
                [Validation(Required=false)]
                public DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth Ipv6InternetBandwidth { get; set; }
                public class DescribeIpv6AddressesResponseBodyIpv6AddressesIpv6AddressIpv6InternetBandwidth : TeaModel {
                    /// <summary>
                    /// <para>The dedicated Internet bandwidth of the IPv6 address. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Bandwidth")]
                    [Validation(Required=false)]
                    public int? Bandwidth { get; set; }

                    /// <summary>
                    /// <para>The status of the Internet bandwidth of the IPv6 address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Normal</b></description></item>
                    /// <item><description><b>FinancialLocked</b></description></item>
                    /// <item><description><b>SecurityLocked</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("BusinessStatus")]
                    [Validation(Required=false)]
                    public string BusinessStatus { get; set; }

                    /// <summary>
                    /// <para>Indicates whether renewal data is included. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>false</b></description></item>
                    /// <item><description><b>true</b> <b>true</b> is returned only when <b>IncludeReservationData</b> is set to <b>true</b> and some orders have not taken effect.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasReservationData")]
                    [Validation(Required=false)]
                    public bool? HasReservationData { get; set; }

                    /// <summary>
                    /// <para>The billing method of the Internet bandwidth of the IPv6 address. Valid values:</para>
                    /// <para>Only <b>PostPaid</b> may be returned, which indicates the pay-as-you-go billing method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PostPaid</para>
                    /// </summary>
                    [NameInMap("InstanceChargeType")]
                    [Validation(Required=false)]
                    public string InstanceChargeType { get; set; }

                    /// <summary>
                    /// <para>The billing method of the Internet bandwidth of the IPv6 address. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>PayByTraffic</b></description></item>
                    /// <item><description><b>PayByBandwidth</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayByTraffic</para>
                    /// </summary>
                    [NameInMap("InternetChargeType")]
                    [Validation(Required=false)]
                    public string InternetChargeType { get; set; }

                    /// <summary>
                    /// <para>The Internet bandwidth ID of the IPv6 address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ipv6bw-hp3b35oq1fj50kbv****</para>
                    /// </summary>
                    [NameInMap("Ipv6InternetBandwidthId")]
                    [Validation(Required=false)]
                    public string Ipv6InternetBandwidthId { get; set; }

                    /// <summary>
                    /// <para>The time when the renewal takes effect. The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-05-23T16:00:00Z</para>
                    /// </summary>
                    [NameInMap("ReservationActiveTime")]
                    [Validation(Required=false)]
                    public string ReservationActiveTime { get; set; }

                    /// <summary>
                    /// <para>The maximum bandwidth after the renewal takes effect. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("ReservationBandwidth")]
                    [Validation(Required=false)]
                    public long? ReservationBandwidth { get; set; }

                    /// <summary>
                    /// <para>The metering method that is used after the renewal takes effect.</para>
                    /// <list type="bullet">
                    /// <item><description><b>PayByTraffic</b></description></item>
                    /// <item><description><b>PayByBandwidth</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PayByTraffic</para>
                    /// </summary>
                    [NameInMap("ReservationInternetChargeType")]
                    [Validation(Required=false)]
                    public string ReservationInternetChargeType { get; set; }

                    /// <summary>
                    /// <para>The type of the renewal order. Only <b>RENEW</b> may be returned, which indicates that the order is placed for service renewal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RENEW</para>
                    /// </summary>
                    [NameInMap("ReservationOrderType")]
                    [Validation(Required=false)]
                    public string ReservationOrderType { get; set; }

                }

                /// <summary>
                /// <para>The ISP of the IPv6 address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BGP</b> (default)</description></item>
                /// <item><description><b>ChinaMobile</b></description></item>
                /// <item><description><b>ChinaUnicom</b></description></item>
                /// <item><description><b>ChinaTelecom</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("Ipv6Isp")]
                [Validation(Required=false)]
                public string Ipv6Isp { get; set; }

                /// <summary>
                /// <para>The type of connection supported by the IPv6 address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Private</b></description></item>
                /// <item><description><b>Public</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The peak bandwidth of the IPv6 address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RealBandwidth")]
                [Validation(Required=false)]
                public int? RealBandwidth { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the IPv6 gateway belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: yes</description></item>
                /// <item><description><b>0</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServiceManaged")]
                [Validation(Required=false)]
                public int? ServiceManaged { get; set; }

                /// <summary>
                /// <para>The status of the IPv6 address.</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tag list.</para>
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
                        /// <para>The tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
                        /// <para>The tag key can be up to 128 characters in length. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FinanceDept</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// <para>The tag value can be up to 128 characters in length. It can be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
                        /// <para>Each tag key corresponds to one tag value. You can specify at most 20 tag values at a time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>yunke</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the vSwitch to which the IPv6 address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-25navfgbue4g****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC to which the IPv6 address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp15zckdt37pq72zv****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA4486A8-B6AE-469E-AB09-820EF8ECFA2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
