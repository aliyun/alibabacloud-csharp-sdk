// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressReferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>IP address or domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>223.5.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The address ID. This ID uniquely identifies the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>addr-89564584963974**40</para>
        /// </summary>
        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        /// <summary>
        /// <para>The address pools.</para>
        /// </summary>
        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressReferenceResponseBodyAddressPools AddressPools { get; set; }
        public class DescribeCloudGtmAddressReferenceResponseBodyAddressPools : TeaModel {
            [NameInMap("AddressPool")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPool> AddressPool { get; set; }
            public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPool : TeaModel {
                /// <summary>
                /// <para>Load balancing policy among addresses in the address pool:</para>
                /// <list type="bullet">
                /// <item><description>round_robin: Round-robin, for any source of DNS resolution requests, all addresses are returned, with a rotation sort applied to all addresses each time.</description></item>
                /// <item><description>sequence: Sequential, for any source of DNS resolution requests, returns the address with the smaller sequence number (the sequence number indicates the priority of address return, with smaller numbers having higher priority). If the address with the smaller sequence number is unavailable, the next address with a smaller sequence number is returned.</description></item>
                /// <item><description>weight: Weighted, supports setting different weight values for each address, realizing the return of addresses according to the ratio of weight for DNS query resolutions.</description></item>
                /// <item><description>source_nearest: Source-nearest, i.e., intelligent resolution function, where GTM can return different addresses based on the source of different DNS resolution requests, achieving the effect of users accessing nearby.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>round_robin</para>
                /// </summary>
                [NameInMap("AddressLbStrategy")]
                [Validation(Required=false)]
                public string AddressLbStrategy { get; set; }

                /// <summary>
                /// <para>The ID of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool-895280232254422016</para>
                /// </summary>
                [NameInMap("AddressPoolId")]
                [Validation(Required=false)]
                public string AddressPoolId { get; set; }

                /// <summary>
                /// <para>Address pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AddressPool-1</para>
                /// </summary>
                [NameInMap("AddressPoolName")]
                [Validation(Required=false)]
                public string AddressPoolName { get; set; }

                /// <summary>
                /// <para>Address pool type:</para>
                /// <list type="bullet">
                /// <item><description>IPv4</description></item>
                /// <item><description>IPv6</description></item>
                /// <item><description>domain</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("AddressPoolType")]
                [Validation(Required=false)]
                public string AddressPoolType { get; set; }

                /// <summary>
                /// <para>Address pool availability status:</para>
                /// <list type="bullet">
                /// <item><description>available</description></item>
                /// <item><description>unavailable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>available</para>
                /// </summary>
                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                /// <summary>
                /// <para>Address pool status:</para>
                /// <list type="bullet">
                /// <item><description>enable: Enabled status</description></item>
                /// <item><description>disable: Disabled status</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                /// <summary>
                /// <para>The condition for determining the health status of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>any_ok: At least one address in the address pool is available.</description></item>
                /// <item><description>p30_ok: At least 30% of the addresses in the address pool are available.</description></item>
                /// <item><description>p50_ok: At least 50% of the addresses in the address pool are available.</description></item>
                /// <item><description>p70_ok: At least 70% of the addresses in the address pool are available.</description></item>
                /// <item><description>all_ok: All addresses in the address pool are available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>any_ok</para>
                /// </summary>
                [NameInMap("HealthJudgement")]
                [Validation(Required=false)]
                public string HealthJudgement { get; set; }

                /// <summary>
                /// <para>The health state of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ok: The health state of the address pool is normal and all addresses that are referenced by the address pool are available.</description></item>
                /// <item><description>ok_alert: The health state of the address pool is warning and some of the addresses that are referenced by the address pool are unavailable. However, the address pool is deemed normal. In this case, only the available addresses are returned for DNS requests.</description></item>
                /// <item><description>exceptional: The health state of the address pool is abnormal and some or all of the addresses that are referenced by the address pool are unavailable. In this case, the address pool is deemed abnormal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>The instances that reference the address pool.</para>
                /// </summary>
                [NameInMap("InstanceConfigs")]
                [Validation(Required=false)]
                public DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigs InstanceConfigs { get; set; }
                public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigs : TeaModel {
                    [NameInMap("InstanceConfig")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
                    public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigsInstanceConfig : TeaModel {
                        /// <summary>
                        /// <para>The policy for load balancing between address pools. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>round_robin: All address pools are returned for Domain Name System (DNS) requests from any source. All address pools are sorted in round-robin mode each time they are returned.</description></item>
                        /// <item><description>sequence: The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number indicates the priority for returning the address pool. A smaller sequence number indicates a higher priority. If the address pool with the smallest sequence number is unavailable, the address pool with the second smallest sequence number is returned.</description></item>
                        /// <item><description>weight: You can set a different weight value for each address pool. This way, address pools are returned based on the weight values.</description></item>
                        /// <item><description>source_nearest: Different address pools are returned based on the sources of DNS requests. This way, users can access nearby address pools.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>round_robin</para>
                        /// </summary>
                        [NameInMap("AddressPoolLbStrategy")]
                        [Validation(Required=false)]
                        public string AddressPoolLbStrategy { get; set; }

                        /// <summary>
                        /// <para>The availability state of the access domain name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>available: If the access domain name is <b>enabled</b> and the health state is normal, the access domain name is deemed <b>available</b>.</description></item>
                        /// <item><description>unavailable: If the access domain name is <b>disabled</b> or the health state is <b>abnormal</b>, the access domain name is deemed <b>unavailable</b>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>available</para>
                        /// </summary>
                        [NameInMap("AvailableStatus")]
                        [Validation(Required=false)]
                        public string AvailableStatus { get; set; }

                        /// <summary>
                        /// <para>The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>config-00**01</para>
                        /// </summary>
                        [NameInMap("ConfigId")]
                        [Validation(Required=false)]
                        public string ConfigId { get; set; }

                        /// <summary>
                        /// <para>The enabling state of the access domain name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>enable: The access domain name is enabled and the intelligent scheduling policy of the corresponding GTM instance takes effect.</description></item>
                        /// <item><description>disable: The access domain name is disabled and the intelligent scheduling policy of the corresponding GTM instance does not take effect.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>enable</para>
                        /// </summary>
                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public string EnableStatus { get; set; }

                        /// <summary>
                        /// <para>The health state of the access domain name. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ok: The health state of the access domain name is normal and all address pools that are referenced by the access domain name are available.</description></item>
                        /// <item><description>ok_alert: The health state of the access domain name is warning and some of the address pools that are referenced by the access domain name are unavailable. In this case, only the available address pools are returned for DNS requests.</description></item>
                        /// <item><description>exceptional: The health state of the access domain name is abnormal and all address pools that are referenced by the access domain name are unavailable. In this case, addresses in the non-empty address pool with the smallest sequence number are preferentially used for fallback resolution. This returns DNS results for clients as much as possible.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ok</para>
                        /// </summary>
                        [NameInMap("HealthStatus")]
                        [Validation(Required=false)]
                        public string HealthStatus { get; set; }

                        /// <summary>
                        /// <para>The ID of the GTM 3.0 instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>gtm-cn-zz11t58**0k</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>Instance name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        /// <summary>
                        /// <para>Remarks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// <para>The access domain name. The value of this parameter is composed of the value of ScheduleHostname and the value of ScheduleZoneName.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="http://www.example.com">www.example.com</a></para>
                        /// </summary>
                        [NameInMap("ScheduleDomainName")]
                        [Validation(Required=false)]
                        public string ScheduleDomainName { get; set; }

                        /// <summary>
                        /// <para>Host record of the domain accessed by GTM.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>www</para>
                        /// </summary>
                        [NameInMap("ScheduleHostname")]
                        [Validation(Required=false)]
                        public string ScheduleHostname { get; set; }

                        /// <summary>
                        /// <para>DNS record types for the scheduling domain:</para>
                        /// <list type="bullet">
                        /// <item><description>A: IPv4 address</description></item>
                        /// <item><description>AAAA: IPv6 address</description></item>
                        /// <item><description>CNAME: Domain name</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A</para>
                        /// </summary>
                        [NameInMap("ScheduleRrType")]
                        [Validation(Required=false)]
                        public string ScheduleRrType { get; set; }

                        /// <summary>
                        /// <para>The zone such as example.com or subzone such as a.example.com of the access domain name. In most cases, the zone or subzone is hosted by the Public Authoritative DNS module of Alibaba Cloud DNS. This zone belongs to the account to which the GTM instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com</para>
                        /// </summary>
                        [NameInMap("ScheduleZoneName")]
                        [Validation(Required=false)]
                        public string ScheduleZoneName { get; set; }

                        /// <summary>
                        /// <para>The mode used if the address pool with the smallest sequence number is recovered. This parameter is returned when AddressPoolLbStrategy is set to sequence. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>preemptive: The address pool with the smallest sequence number is preferentially used if this address pool is recovered.</description></item>
                        /// <item><description>non_preemptive: The current address pool is still used even if the address pool with the smallest sequence number is recovered.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>preemptive</para>
                        /// </summary>
                        [NameInMap("SequenceLbStrategyMode")]
                        [Validation(Required=false)]
                        public string SequenceLbStrategyMode { get; set; }

                        /// <summary>
                        /// <para>Global TTL (in seconds), the TTL value for domain name resolution to addresses in the address pool, which affects the caching time of DNS records in the ISP\&quot;s LocalDNS. Custom TTL values are supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Ttl")]
                        [Validation(Required=false)]
                        public int? Ttl { get; set; }

                        /// <summary>
                        /// <para>Global Traffic Management version 3.0 instance types:</para>
                        /// <list type="bullet">
                        /// <item><description>standard: Standard Edition</description></item>
                        /// <item><description>ultimate: Ultimate Edition</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ultimate</para>
                        /// </summary>
                        [NameInMap("VersionCode")]
                        [Validation(Required=false)]
                        public string VersionCode { get; set; }

                    }

                }

                /// <summary>
                /// <para>Remarks for the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pool-1</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>Load balancing policy between addresses in sequential mode during the recovery of preceding resources service mode:</para>
                /// <list type="bullet">
                /// <item><description>preemptive: Preemption mode, where upon recovery of preceding resources, priority is given to using addresses with smaller sequence numbers;</description></item>
                /// <item><description>non_preemptive: Non-preemption mode, where upon recovery of preceding resources, the current address continues to be used;</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>preemptive</para>
                /// </summary>
                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

            }

        }

        /// <summary>
        /// <para>Address name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Address-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
