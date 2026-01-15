// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmInstanceConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the instance.</para>
        /// </summary>
        [NameInMap("InstanceConfigs")]
        [Validation(Required=false)]
        public ListCloudGtmInstanceConfigsResponseBodyInstanceConfigs InstanceConfigs { get; set; }
        public class ListCloudGtmInstanceConfigsResponseBodyInstanceConfigs : TeaModel {
            [NameInMap("InstanceConfig")]
            [Validation(Required=false)]
            public List<ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
            public class ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig : TeaModel {
                /// <summary>
                /// <para>The policy for load balancing between address pools. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>round_robin: All address pools are returned for DNS requests from any source. All address pools are sorted in round-robin mode each time they are returned.</description></item>
                /// <item><description>sequence: The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number indicates the priority for returning the address pool. A smaller sequence number indicates a higher priority. If the address pool with the smallest sequence number is unavailable, the address pool with the second smallest sequence number is returned.</description></item>
                /// <item><description>weight: You can set a different weight value for each address pool. This way, address pools are returned based on the weight values.</description></item>
                /// <item><description>source_nearest: GTM returns different address pools based on the sources of DNS requests. This way, users can access nearby addresses.</description></item>
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
                public ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools AddressPools { get; set; }
                public class ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools : TeaModel {
                    [NameInMap("AddressPool")]
                    [Validation(Required=false)]
                    public List<ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool> AddressPool { get; set; }
                    public class ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool : TeaModel {
                        /// <summary>
                        /// <para>Load balancing policy among addresses in the address pool:</para>
                        /// <list type="bullet">
                        /// <item><description>round_robin: Round-robin, for any source of DNS resolution requests, returns all addresses and rotates the order of all addresses each time.</description></item>
                        /// <item><description>sequence: Sequential, for any source of DNS resolution requests, returns the address with the smaller sequence number (the sequence number indicates the priority of the address return, the smaller the higher the priority). If the address with the smaller sequence number is unavailable, return the next address with a smaller sequence number.</description></item>
                        /// <item><description>weight: Weighted, supports setting different weight values for each address to realize returning addresses according to the weight ratio for resolution queries.</description></item>
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
                        /// <para>The ID of the address pool. This ID uniquely identifies the address pool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>pool-89528023225442**16</para>
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
                        /// <para>The health state of the address pool. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ok: The health state of the address pool is Normal and all addresses that are referenced by the address pool are available.</description></item>
                        /// <item><description>ok_alert: The health state of the address pool is Warning and some of the addresses that are referenced by the address pool are unavailable. However, the address pool is deemed normal. In this case, available address pools are normally used for DNS resolution, but unavailable address pools cannot be used for DNS resolution.</description></item>
                        /// <item><description>exceptional: The health state of the address pool is Abnormal and some or all of the addresses that are referenced by the address pool are unavailable. In this case, the address pool is deemed abnormal.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ok</para>
                        /// </summary>
                        [NameInMap("HealthJudgement")]
                        [Validation(Required=false)]
                        public string HealthJudgement { get; set; }

                        /// <summary>
                        /// <para>The health state of the address pool. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ok: The health state of the address pool is Normal and all addresses that are referenced by the address pool are available.</description></item>
                        /// <item><description>ok_alert: The health state of the address pool is Warning and some of the addresses that are referenced by the address pool are unavailable. However, the address pool is deemed normal. In this case, available address pools are normally used for DNS resolution, but unavailable address pools cannot be used for DNS resolution.</description></item>
                        /// <item><description>exceptional: The health state of the address pool is Abnormal and some or all of the addresses that are referenced by the address pool are unavailable. In this case, the address pool is deemed abnormal.</description></item>
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
                        public ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource RequestSource { get; set; }
                        public class ListCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource : TeaModel {
                            [NameInMap("RequestSource")]
                            [Validation(Required=false)]
                            public List<string> RequestSource { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the mode of the sequence policy for load balancing between address pools is non-preemptive. This parameter is available only for the multicloud integration scenario. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("SeqNonPreemptiveSchedule")]
                        [Validation(Required=false)]
                        public bool? SeqNonPreemptiveSchedule { get; set; }

                        /// <summary>
                        /// <para>The mode used if the address with the smallest sequence number is recovered. This parameter is required only when AddressLbStrategy is set to sequence. Valid values:</para>
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
                        /// <para>Sequence number. For any parsing request, the address pool with the smaller sequence number (indicating the priority of the address pool returned, with smaller numbers having higher priority) is returned.</para>
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
                        /// <para>Last modification time of the address pool (timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1527690629357</para>
                        /// </summary>
                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        /// <summary>
                        /// <para>Weight value (an integer between 1 and 100, including both 1 and 100), which supports setting different weight values for each address pool, enabling the resolution query to return address pools according to the weighted ratio.</para>
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
                /// <item><description>available: If the access domain name is <b>enabled</b> and the health state of the access domain name is <b>Normal</b>, the access domain name is deemed <b>Available</b>.</description></item>
                /// <item><description>unavailable: If the access domain name is <b>disabled</b> or the health state of the access domain name is <b>Abnormal</b>, the access domain name is deemed <b>Unavailable</b>.</description></item>
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
                /// <para>Instance configuration creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Instance creation time (timestamp).</para>
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
                /// <item><description>enable: The access domain name is enabled and the intelligent scheduling policy of the GTM instance takes effect.</description></item>
                /// <item><description>disable: The access domain name is disabled and the intelligent scheduling policy of the GTM instance does not take effect.</description></item>
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
                /// <item><description>ok: The health state of the access domain name is Normal and all address pools that are referenced by the access domain name are available.</description></item>
                /// <item><description>ok_alert: The health state of the access domain name is Warning and some of the address pools that are referenced by the access domain name are unavailable. In this case, available address pools are normally used for DNS resolution, but unavailable address pools cannot be used for DNS resolution.</description></item>
                /// <item><description>exceptional: The health state of the access domain name is Abnormal and all address pools that are referenced by the access domain name are unavailable. In this case, addresses in the non-empty address pool with the smallest sequence number are preferentially used for fallback resolution. This returns DNS results for clients as much as possible.</description></item>
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
                /// <para>gtm-cn-wwo3a3hbz**</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Remarks on the configuration of domain instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The GTM access domain name. The value of this parameter is composed of the value of ScheduleHostname and the value of ScheduleZoneName.</para>
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
                /// <item><description>custom: custom allocation. You must specify a custom hostname and associate the hostname with a zone within the account to which the GTM instance belongs to generate an access domain name.</description></item>
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
                /// <para>The zone (such as example.com) or subzone (such as a.example.com) of the GTM access domain name. In most cases, the zone or subzone is hosted in Authoritative DNS Resolution of the Alibaba Cloud DNS console within the account to which the GTM instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("ScheduleZoneName")]
                [Validation(Required=false)]
                public string ScheduleZoneName { get; set; }

                /// <summary>
                /// <para>The mode used if the address pool with the smallest sequence number is recovered. This parameter is required when AddressPoolLbStrategy is set to sequence. Valid values:</para>
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
                /// <para>Global TTL (in seconds), the TTL value for domain resolution to addresses in the address pool, affecting the caching time of DNS records in the ISP\&quot;s LocalDNS. Supports custom TTL values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                /// <summary>
                /// <para>The last modified time of the instance configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-03-15T01:46Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The last modification time of the instance configuration (timestamp).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The edition of the GTM 3.0 instance. Valid values:</para>
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
        /// <para>Current page number, starting from <b>1</b>, default is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
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
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries for domain instance configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
