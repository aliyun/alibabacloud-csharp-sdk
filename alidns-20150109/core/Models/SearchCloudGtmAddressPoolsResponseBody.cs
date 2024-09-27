// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmAddressPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The address pools.</para>
        /// </summary>
        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public SearchCloudGtmAddressPoolsResponseBodyAddressPools AddressPools { get; set; }
        public class SearchCloudGtmAddressPoolsResponseBodyAddressPools : TeaModel {
            [NameInMap("AddressPool")]
            [Validation(Required=false)]
            public List<SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPool> AddressPool { get; set; }
            public class SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPool : TeaModel {
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
                /// <para>The IP addresses or domain names.</para>
                /// </summary>
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddresses Addresses { get; set; }
                public class SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddresses : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddress> Address { get; set; }
                    public class SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddress : TeaModel {
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
                        /// <para>addr-895182181143688192</para>
                        /// </summary>
                        [NameInMap("AddressId")]
                        [Validation(Required=false)]
                        public string AddressId { get; set; }

                        /// <summary>
                        /// <para>Address ownership information, not supported in the current version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Not supported in the current version.</para>
                        /// </summary>
                        [NameInMap("AttributeInfo")]
                        [Validation(Required=false)]
                        public string AttributeInfo { get; set; }

                        /// <summary>
                        /// <para>The failover method that is used if the address fails health checks. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>auto: the automatic mode. The system determines whether to return an address based on the health check results. If the address fails health checks, the system does not return the address. If the address passes health checks, the system returns the address.</description></item>
                        /// <item><description>manual: the manual mode. If an address is in the unavailable state, the address is not returned for DNS requests even if the address passes health checks. If an address is in the available state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>auto</para>
                        /// </summary>
                        [NameInMap("AvailableMode")]
                        [Validation(Required=false)]
                        public string AvailableMode { get; set; }

                        /// <summary>
                        /// <para>Address availability status:</para>
                        /// <list type="bullet">
                        /// <item><description>available: Address is available</description></item>
                        /// <item><description>unavailable: Address is unavailable</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>available</para>
                        /// </summary>
                        [NameInMap("AvailableStatus")]
                        [Validation(Required=false)]
                        public string AvailableStatus { get; set; }

                        /// <summary>
                        /// <para>Address creation time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-03-15T01:46Z</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// <para>Address creation time (timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1527690629357</para>
                        /// </summary>
                        [NameInMap("CreateTimestamp")]
                        [Validation(Required=false)]
                        public long? CreateTimestamp { get; set; }

                        /// <summary>
                        /// <para>Address enable status, indicating whether the address is currently available:</para>
                        /// <list type="bullet">
                        /// <item><description>enable: Enabled status </description></item>
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
                        /// <para>The condition for determining the health status of the address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>any_ok: The health check results of at least one health check template are normal.</description></item>
                        /// <item><description>p30_ok: The health check results of at least 30% of health check templates are normal.</description></item>
                        /// <item><description>p50_ok: The health check results of at least 50% of health check templates are normal.</description></item>
                        /// <item><description>p70_ok: The health check results of at least 70% of health check templates are normal.</description></item>
                        /// <item><description>all_ok: The health check results of all health check templates are normal.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>any_ok</para>
                        /// </summary>
                        [NameInMap("HealthJudgement")]
                        [Validation(Required=false)]
                        public string HealthJudgement { get; set; }

                        /// <summary>
                        /// <para>The health check state of the address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>ok: The address passes all health checks of the referenced health check templates.</description></item>
                        /// <item><description>ok_alert: The address fails some health checks of the referenced health check templates but the address is deemed normal.</description></item>
                        /// <item><description>ok_no_monitor: The address does not reference a health check template and is normal.</description></item>
                        /// <item><description>exceptional: The address fails some or all health checks of the referenced health check templates and the address is deemed abnormal.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ok</para>
                        /// </summary>
                        [NameInMap("HealthStatus")]
                        [Validation(Required=false)]
                        public string HealthStatus { get; set; }

                        /// <summary>
                        /// <para>The health check tasks.</para>
                        /// </summary>
                        [NameInMap("HealthTasks")]
                        [Validation(Required=false)]
                        public SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddressHealthTasks HealthTasks { get; set; }
                        public class SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddressHealthTasks : TeaModel {
                            [NameInMap("HealthTask")]
                            [Validation(Required=false)]
                            public List<SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddressHealthTasksHealthTask> HealthTask { get; set; }
                            public class SearchCloudGtmAddressPoolsResponseBodyAddressPoolsAddressPoolAddressesAddressHealthTasksHealthTask : TeaModel {
                                /// <summary>
                                /// <para>The target service port for health checks. When the Ping protocol is selected for health checks, configuration of the service port is not supported.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>80</para>
                                /// </summary>
                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public int? Port { get; set; }

                                /// <summary>
                                /// <para>The ID of the health check template associated with the address.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>mtp-89518052425100**80</para>
                                /// </summary>
                                [NameInMap("TemplateId")]
                                [Validation(Required=false)]
                                public string TemplateId { get; set; }

                                /// <summary>
                                /// <para>Health check template name.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>IPv4-Ping</para>
                                /// </summary>
                                [NameInMap("TemplateName")]
                                [Validation(Required=false)]
                                public string TemplateName { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The availability state of the address when AvailableMode is set to manual. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>available: The address is normal. In this state, the address is returned for DNS requests even if an alert is triggered when the address fails health checks.</description></item>
                        /// <item><description>unavailable: The address is abnormal. In this state, the address is not returned for DNS requests even if the address passes health checks.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>available</para>
                        /// </summary>
                        [NameInMap("ManualAvailableStatus")]
                        [Validation(Required=false)]
                        public string ManualAvailableStatus { get; set; }

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
                        /// <para>Remarks.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// <para>Request source, referring to the source of the request. GTM schedules based on the exit IP of the LocalDNS used by the terminal. If the LocalDNS supports ECS (edns-client-subnet), intelligent scheduling can also be performed based on the IP of the visiting terminal.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("RequestSource")]
                        [Validation(Required=false)]
                        public string RequestSource { get; set; }

                        /// <summary>
                        /// <para>Sequence number, indicating the priority of address return, where smaller numbers have higher priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        /// <summary>
                        /// <para>Address type:</para>
                        /// <list type="bullet">
                        /// <item><description>IPv4: ipv4 address - IPv6: ipv6 address - domain: domain name</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>IPv4</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The last time the address was modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2024-03-15T01:46Z</para>
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        /// <summary>
                        /// <para>The last modification time of the address (timestamp).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1527690629357</para>
                        /// </summary>
                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        /// <summary>
                        /// <para>Weight value (an integer between 1 and 100), allowing different weight values to be set for each address, enabling resolution queries to return addresses according to the weighted ratio.</para>
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
                /// <para>Address remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The mode used if the address with the smallest sequence number is recovered. This parameter is returned only when the policy for load balancing between addresses is sequence. Valid values:</para>
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
                /// <para>Last modification time of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>024-03-15T01:46Z</para>
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
        /// <para>Total number of address pools matching the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
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
