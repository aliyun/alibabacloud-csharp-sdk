// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmInstanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The instances list.</para>
        /// </summary>
        [NameInMap("InstanceConfigs")]
        [Validation(Required=false)]
        public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigs InstanceConfigs { get; set; }
        public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigs : TeaModel {
            [NameInMap("InstanceConfig")]
            [Validation(Required=false)]
            public List<SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
            public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig : TeaModel {
                /// <summary>
                /// <para>The policy for load balancing between address pools. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>round_robin: All address pools are returned for DNS requests from any source. All address pools are sorted in round-robin mode each time they are returned.</description></item>
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
                /// <para>The address pools.</para>
                /// </summary>
                [NameInMap("AddressPools")]
                [Validation(Required=false)]
                public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools AddressPools { get; set; }
                public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools : TeaModel {
                    [NameInMap("AddressPool")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool> AddressPool { get; set; }
                    public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool : TeaModel {
                        /// <summary>
                        /// <para>Load balancing policy among addresses in the address pool:</para>
                        /// <list type="bullet">
                        /// <item><description>round_robin: Round-robin, where for any source of DNS resolution requests, all addresses are returned, with a rotation of the order for every request.</description></item>
                        /// <item><description>sequence: Sequential, where for any source of DNS resolution requests, the address with the lower sequence number (indicating a higher priority, the smaller the number, the higher the priority) is returned. If the address with the lower sequence number is unavailable, the next address with a lower sequence number is returned.</description></item>
                        /// <item><description>weight: Weighted, supporting the setting of different weight values for each address to realize returning addresses according to the ratio of weights in DNS query resolutions.</description></item>
                        /// <item><description>source_nearest: Source-nearest, referring to the intelligent resolution feature, where GTM can return different addresses based on the source of different DNS resolution requests, achieving the effect of users accessing the nearest server.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>round_robin</para>
                        /// </summary>
                        [NameInMap("AddressLbStrategy")]
                        [Validation(Required=false)]
                        public string AddressLbStrategy { get; set; }

                        /// <summary>
                        /// <para>Address pool ID, uniquely identifying the address pool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pool-89564504435014**60</para>
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
                        /// <item><description>available: Available</description></item>
                        /// <item><description>unavailable: Unavailable</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>available</para>
                        /// </summary>
                        [NameInMap("AvailableStatus")]
                        [Validation(Required=false)]
                        public string AvailableStatus { get; set; }

                        /// <summary>
                        /// <para>Address pool creation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-03-15T01:46Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>Address pool creation time (timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1527690629357</para>
                        /// </summary>
                        [NameInMap("CreateTimestamp")]
                        [Validation(Required=false)]
                        public long? CreateTimestamp { get; set; }

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
                        /// <para>Parse the request source list.</para>
                        /// </summary>
                        [NameInMap("RequestSource")]
                        [Validation(Required=false)]
                        public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource RequestSource { get; set; }
                        public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource : TeaModel {
                            [NameInMap("RequestSource")]
                            [Validation(Required=false)]
                            public List<string> RequestSource { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether it is a sequential (non-preemptive) scheduling object for hybrid cloud management scenarios: </para>
                        /// <list type="bullet">
                        /// <item><description>true: yes </description></item>
                        /// <item><description>false: no</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("SeqNonPreemptiveSchedule")]
                        [Validation(Required=false)]
                        public bool? SeqNonPreemptiveSchedule { get; set; }

                        /// <summary>
                        /// <para>The mode used if the address with the smallest sequence number is recovered. This parameter is required only when the policy for load balancing between addresses is sequence. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>preemptive: The address with the smallest sequence number is preferentially used if this address is recovered.</description></item>
                        /// <item><description>non_preemptive: The current address is still used even if the address with the smallest sequence number is recovered.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>preemptive</para>
                        /// </summary>
                        [NameInMap("SequenceLbStrategyMode")]
                        [Validation(Required=false)]
                        public string SequenceLbStrategyMode { get; set; }

                        /// <summary>
                        /// <para>Sequence number. For any parsing request, the address pool with the smaller sequence number (indicating the priority of the address pool returned, with smaller numbers having higher priority) will be returned.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        /// <summary>
                        /// <para>Last modification time of the address pool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-03-15T01:46Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        /// <summary>
                        /// <para>Update time (timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1527690629357</para>
                        /// </summary>
                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        /// <summary>
                        /// <para>Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address pool, implementing the return of address pools according to weight ratios in resolution queries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("WeightValue")]
                        [Validation(Required=false)]
                        public int? WeightValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The availability state of the access domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>available: If the access domain name is <b>enabled</b> and the health state is <b>normal</b>, the access domain name is deemed <b>available</b>.</description></item>
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
                /// <para>The commodity code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>dns_gtm_public_cn: the commodity code on the China site (aliyun.com)</description></item>
                /// <item><description>dns_gtm_public_intl: the commodity code on the international site (alibabacloud.com)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dns_gtm_public_cn</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Config-000**11</para>
                /// </summary>
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("ConfigLoggingSwitchStatus")]
                [Validation(Required=false)]
                public string ConfigLoggingSwitchStatus { get; set; }

                /// <summary>
                /// <para>Domain instance creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Domain instance creation time (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

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
                /// <para>gtm-cn-x0r38e0**03</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Remarks for the domain instance.</para>
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
                /// <para>The allocation mode of the access domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom: custom allocation. You must specify a custom hostname and associate the hostname with a zone that is hosted by the Public Authoritative DNS module within the account to which the GTM instance belongs to generate an access domain name.</description></item>
                /// <item><description>sys_assign: system allocation. This mode is not supported. Do not set ScheduleZoneMode to sys_assign.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("ScheduleZoneMode")]
                [Validation(Required=false)]
                public string ScheduleZoneMode { get; set; }

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
                /// <para>Global TTL (in seconds), the TTL value for resolving the access domain name to the address pool, which affects the caching time of DNS records in the operator\&quot;s LocalDNS. Supports custom TTL values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// <para>The last modification time of the domain instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The last modification time of the domain instance (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

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
        /// <para>Current page number, starting from 1, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of <b>100</b>, and a default of <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6AEC7A64-3CB1-4C49-8B35-0B901F1E26BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of instance configuration entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
