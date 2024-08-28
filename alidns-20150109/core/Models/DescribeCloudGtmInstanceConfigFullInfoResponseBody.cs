// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigFullInfoResponseBody : TeaModel {
        /// <summary>
        /// The policy for load balancing between address pools. Valid values:
        /// 
        /// *   round_robin: All address pools are returned for DNS requests from any source. All address pools are sorted in round-robin mode each time they are returned.
        /// *   sequence: The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number indicates the priority for returning the address pool. A smaller sequence number indicates a higher priority. If the address pool with the smallest sequence number is unavailable, the address pool with the second smallest sequence number is returned.
        /// *   weight: You can set a different weight value for each address pool. This way, address pools are returned based on the weight values.
        /// *   source_nearest: GTM returns different addresses based on the sources of DNS requests. This way, users can access nearby addresses.
        /// </summary>
        [NameInMap("AddressPoolLbStrategy")]
        [Validation(Required=false)]
        public string AddressPoolLbStrategy { get; set; }

        /// <summary>
        /// The address pools.
        /// </summary>
        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPools AddressPools { get; set; }
        public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPools : TeaModel {
            [NameInMap("AddressPool")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPool> AddressPool { get; set; }
            public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPool : TeaModel {
                /// <summary>
                /// Load balancing policy among addresses in the address pool:
                /// - round_robin: Round-robin, for any source of DNS resolution requests, returns all addresses and rotates their order for each request.
                /// - sequence: Sequential, for any source of DNS resolution requests, returns the address with the smaller sequence number (the sequence number indicates the priority of the address return, with smaller numbers having higher priority). If the address with the smaller sequence number is unavailable, the next address with a smaller sequence number is returned.
                /// - weight: Weighted, supports setting different weight values for each address to realize returning addresses according to the weight ratio for resolution queries.
                /// - source_nearest: Source-nearest, i.e., intelligent resolution function, where GTM can return different addresses based on the source of different DNS resolution requests, achieving the effect of users accessing nearby.
                /// </summary>
                [NameInMap("AddressLbStrategy")]
                [Validation(Required=false)]
                public string AddressLbStrategy { get; set; }

                /// <summary>
                /// The ID of the address pool. This ID uniquely identifies the address pool.
                /// </summary>
                [NameInMap("AddressPoolId")]
                [Validation(Required=false)]
                public string AddressPoolId { get; set; }

                /// <summary>
                /// Address pool name.
                /// </summary>
                [NameInMap("AddressPoolName")]
                [Validation(Required=false)]
                public string AddressPoolName { get; set; }

                /// <summary>
                /// Address pool type:
                /// - IPv4
                /// - IPv6
                /// - domain
                /// </summary>
                [NameInMap("AddressPoolType")]
                [Validation(Required=false)]
                public string AddressPoolType { get; set; }

                /// <summary>
                /// The addresses.
                /// </summary>
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddresses Addresses { get; set; }
                public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddresses : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddress> Address { get; set; }
                    public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddress : TeaModel {
                        /// <summary>
                        /// IP address or domain name.
                        /// </summary>
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// The address ID. This ID uniquely identifies the address.
                        /// </summary>
                        [NameInMap("AddressId")]
                        [Validation(Required=false)]
                        public string AddressId { get; set; }

                        /// <summary>
                        /// Address ownership information, not supported in the current version.
                        /// </summary>
                        [NameInMap("AttributeInfo")]
                        [Validation(Required=false)]
                        public string AttributeInfo { get; set; }

                        /// <summary>
                        /// The failover mode that is used when address exceptions are identified. Valid values:
                        /// 
                        /// *   auto: the automatic mode. The system determines whether to return an address based on the health check results. If the address fails health checks, the system does not return the address. If the address passes health checks, the system returns the address.
                        /// *   manual: the manual mode. If an address is in the unavailable state, the address is not returned for DNS requests even if the address passes health checks. If an address is in the available state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.
                        /// </summary>
                        [NameInMap("AvailableMode")]
                        [Validation(Required=false)]
                        public string AvailableMode { get; set; }

                        /// <summary>
                        /// The availability state of the address. Valid values:
                        /// 
                        /// *   available
                        /// *   unavailable
                        /// </summary>
                        [NameInMap("AvailableStatus")]
                        [Validation(Required=false)]
                        public string AvailableStatus { get; set; }

                        /// <summary>
                        /// Address creation time.
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// Address creation time (timestamp).
                        /// </summary>
                        [NameInMap("CreateTimestamp")]
                        [Validation(Required=false)]
                        public long? CreateTimestamp { get; set; }

                        /// <summary>
                        /// The enabling state of the address. Valid values:
                        /// 
                        /// *   enable
                        /// *   disable
                        /// </summary>
                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public string EnableStatus { get; set; }

                        /// <summary>
                        /// The condition for determining the health state of the address. Valid values:
                        /// 
                        /// *   any_ok: The health check results of at least one health check template are normal.
                        /// *   p30_ok: The health check results of at least 30% of health check templates are normal.
                        /// *   p50_ok: The health check results of at least 50% of health check templates are normal.
                        /// *   p70_ok: The health check results of at least 70% of health check templates are normal.
                        /// *   all_ok: The health check results of all health check templates are normal.
                        /// </summary>
                        [NameInMap("HealthJudgement")]
                        [Validation(Required=false)]
                        public string HealthJudgement { get; set; }

                        /// <summary>
                        /// The health check state of the address. Valid values:
                        /// 
                        /// *   ok: The address passes all health checks of the referenced health check templates.
                        /// *   ok_alert: The address fails some health checks of the referenced health check templates but the address is deemed normal.
                        /// *   ok_no_monitor: The address does not reference any health check template and is normal.
                        /// *   exceptional: The address fails some or all health checks of the referenced health check templates and the address is deemed abnormal.
                        /// </summary>
                        [NameInMap("HealthStatus")]
                        [Validation(Required=false)]
                        public string HealthStatus { get; set; }

                        /// <summary>
                        /// The availability state of the address when AvailableMode is set to manual. Valid values:
                        /// 
                        /// *   available: The address is normal. In this state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.
                        /// *   unavailable: The address is abnormal. In this state, the address is not returned for DNS requests even if the address passes health checks.
                        /// </summary>
                        [NameInMap("ManualAvailableStatus")]
                        [Validation(Required=false)]
                        public string ManualAvailableStatus { get; set; }

                        /// <summary>
                        /// Address name.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// The remark of the address.
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// Request source list.
                        /// </summary>
                        [NameInMap("RequestSource")]
                        [Validation(Required=false)]
                        public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddressRequestSource RequestSource { get; set; }
                        public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddressRequestSource : TeaModel {
                            [NameInMap("RequestSource")]
                            [Validation(Required=false)]
                            public List<string> RequestSource { get; set; }

                        }

                        /// <summary>
                        /// Indicates whether it is a sequential (non-preemptive) mode scheduling object, applicable to hybrid cloud management scenarios: 
                        /// 
                        /// - true: yes
                        /// - false: no
                        /// </summary>
                        [NameInMap("SeqNonPreemptiveSchedule")]
                        [Validation(Required=false)]
                        public bool? SeqNonPreemptiveSchedule { get; set; }

                        /// <summary>
                        /// Sequence number, indicating the priority of address return, where smaller numbers have higher priority.
                        /// </summary>
                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        /// <summary>
                        /// The type of the address. Valid values:
                        /// 
                        /// *   IPV4: the IPv4 address
                        /// *   IPv6: the IPv6 address
                        /// *   domain: the domain name
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// Last modified time of the address.
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        /// <summary>
                        /// The last modification time of the address (timestamp).
                        /// </summary>
                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        /// <summary>
                        /// Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address, enabling resolution queries to return addresses in proportion to their weights.
                        /// </summary>
                        [NameInMap("WeightValue")]
                        [Validation(Required=false)]
                        public int? WeightValue { get; set; }

                    }

                }

                /// <summary>
                /// The availability state of the address pool. Valid values:
                /// 
                /// *   Available
                /// *   unavailable
                /// </summary>
                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                /// <summary>
                /// Address pool creation time.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// Address pool creation time (timestamp).
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The enabling state of the address pool. Valid values:
                /// 
                /// *   enable
                /// *   disable
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                /// <summary>
                /// The condition for determining the health state of the address pool. Valid values:
                /// 
                /// *   any_ok: At least one address in the address pool is available.
                /// *   p30_ok: At least 30% of the addresses in the address pool are available.
                /// *   p50_ok: At least 50% of the addresses in the address pool are available.
                /// *   p70_ok: At least 70% of the addresses in the address pool are available.
                /// *   all_ok: All addresses in the address pool are available.
                /// </summary>
                [NameInMap("HealthJudgement")]
                [Validation(Required=false)]
                public string HealthJudgement { get; set; }

                /// <summary>
                /// Address pool health status:
                /// - ok: Normal, all addresses referenced by the address pool are available.
                /// - ok_alert: Warning, some addresses referenced by the address pool are unavailable, but the address pool status is deemed normal. In the warning state, available address pools are resolved normally, while unavailable ones stop resolving.
                /// - exceptional: Abnormal, some or all of the addresses referenced by the address pool are unavailable, and the address pool status is determined to be abnormal.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// Parse the list of request sources.
                /// </summary>
                [NameInMap("RequestSource")]
                [Validation(Required=false)]
                public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolRequestSource RequestSource { get; set; }
                public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolRequestSource : TeaModel {
                    [NameInMap("RequestSource")]
                    [Validation(Required=false)]
                    public List<string> RequestSource { get; set; }

                }

                /// <summary>
                /// Indicates whether it is a sequential (non-preemptive) scheduling object for hybrid cloud management scenarios: 
                /// - true: yes 
                /// - false: no
                /// </summary>
                [NameInMap("SeqNonPreemptiveSchedule")]
                [Validation(Required=false)]
                public bool? SeqNonPreemptiveSchedule { get; set; }

                /// <summary>
                /// The mode used if the address with the smallest sequence number is recovered. This parameter is required only when AddressLbStrategy is set to sequence. Valid values:
                /// 
                /// *   preemptive: The address with the smallest sequence number is preferentially used if this address is recovered.
                /// *   non_preemptive: The current address is still used even if the address with the smallest sequence number is recovered.
                /// </summary>
                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

                /// <summary>
                /// Sequence number. For any parsing request from any source, the address pool with the smaller sequence number is returned (the sequence number indicates the priority of the address pool returned, with smaller numbers having higher priority).
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public int? SerialNumber { get; set; }

                /// <summary>
                /// Last modification time of the address pool.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// Last modification time of the address pool (timestamp).
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address pool, enabling resolution queries to return address pools according to the weighted ratio.
                /// </summary>
                [NameInMap("WeightValue")]
                [Validation(Required=false)]
                public int? WeightValue { get; set; }

            }

        }

        /// <summary>
        /// Alert notification configuration.
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfig { get; set; }

        /// <summary>
        /// Alert notification group.
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// The availability state of the access domain name. Valid values:
        /// 
        /// *   available: If the access domain name is **enabled** and the health state of the access domain name is **Normal**, the access domain name is deemed **available**.
        /// *   unavailable: If the access domain name is **disabled** or the health state of the access domain name is **Abnormal**, the access domain name is deemed **unavailable**.
        /// </summary>
        [NameInMap("AvailableStatus")]
        [Validation(Required=false)]
        public string AvailableStatus { get; set; }

        /// <summary>
        /// The commodity code. Valid values:
        /// 
        /// *   dns_gtm_public_cn: the commodity code on the China site (aliyun.com)
        /// *   dns_gtm_public_intl: the commodity code on the international site (alibabacloud.com)
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// Instance creation time.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Instance creation time (timestamp).
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The enabling state of the access domain name. Valid values:
        /// 
        /// *   enable: The access domain name is enabled and the intelligent scheduling policy of the corresponding GTM instance takes effect.
        /// *   disable: The access domain name is disabled and the intelligent scheduling policy of the corresponding GTM instance does not take effect.
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// The health state of the access domain name. Valid values:
        /// 
        /// *   ok: The health state of the access domain name is Normal and all address pools that are referenced by the access domain name are available.
        /// *   ok_alert: The health state of the access domain name is Warning and some of the address pools that are referenced by the access domain name are unavailable. In this case, the available address pools are normally used for DNS resolution, but the unavailable address pools cannot be used for DNS resolution.
        /// *   exceptional: The health state of the access domain name is Abnormal and all address pools that are referenced by the access domain name are unavailable. In this case, addresses in the non-empty address pool with the smallest sequence number are preferentially used for fallback resolution. This returns DNS results for clients as much as possible.
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// The ID of the GTM 3.0 instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Schedule instance name.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Remarks of the configuration of domain instance.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// Unique request identification code.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The GTM access domain name. The value of this parameter is composed of the value of ScheduleHostname and the value of ScheduleZoneName.
        /// </summary>
        [NameInMap("ScheduleDomainName")]
        [Validation(Required=false)]
        public string ScheduleDomainName { get; set; }

        /// <summary>
        /// Host name of the domain accessed by GTM.
        /// </summary>
        [NameInMap("ScheduleHostname")]
        [Validation(Required=false)]
        public string ScheduleHostname { get; set; }

        /// <summary>
        /// DNS record types for the ScheduleDomainName:
        /// - A: IPv4 address
        /// - AAAA: IPv6 address
        /// - CNAME: Domain name
        /// </summary>
        [NameInMap("ScheduleRrType")]
        [Validation(Required=false)]
        public string ScheduleRrType { get; set; }

        /// <summary>
        /// The allocation mode of the access domain name. Valid values:
        /// 
        /// *   custom: custom allocation. You must specify a custom hostname and associate the hostname with a zone or subzone within the account to which the GTM instance belongs to generate an access domain name.
        /// *   sys_assign: The system assigns an access domain name by default. This mode is no longer supported. Do not choose this mode.
        /// </summary>
        [NameInMap("ScheduleZoneMode")]
        [Validation(Required=false)]
        public string ScheduleZoneMode { get; set; }

        /// <summary>
        /// The zone (such as example.com) or subzone (such as a.example.com) associated with the GTM access domain name. In most cases, the zone or subzone is hosted in Authoritative DNS Resolution of the Alibaba Cloud DNS console within the account to which the GTM instance belongs.
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

        /// <summary>
        /// The mode used if the address pool with the smallest sequence number is recovered. This parameter is required when AddressPoolLbStrategy is set to sequence. Valid values:
        /// 
        /// *   preemptive: The address pool with the smallest sequence number is preferentially used if this address pool is recovered.
        /// *   non_preemptive: The current address pool is still used even if the address pool with the smallest sequence number is recovered.
        /// </summary>
        [NameInMap("SequenceLbStrategyMode")]
        [Validation(Required=false)]
        public string SequenceLbStrategyMode { get; set; }

        /// <summary>
        /// Global TTL (in seconds), the TTL value for resolving the access domain to addresses in the address pool, which affects the caching time of DNS records in the ISP\\"s LocalDNS. Custom TTL values are supported.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// Last modified time.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Last modified time (timestamp).
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// Global Traffic Management version 3.0 instances:
        /// - standard: Standard Edition
        /// - ultimate: Ultimate Edition
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
