// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>Load balancing policy among addresses in the address pool:</para>
        /// <list type="bullet">
        /// <item><description>round_robin: Round-robin, where for any source of DNS resolution requests, all addresses are returned, with a rotation of the order for every request.</description></item>
        /// <item><description>sequence: Sequential, where for any source of DNS resolution requests, the address with the lower sequence number (indicating a higher priority, the smaller the number, the higher the priority) is returned. If the address with the lower sequence number is unavailable, the next address with a lower sequence number is returned.</description></item>
        /// <item><description>weight: Weighted, supporting the setting of different weight values for each address to realize returning addresses according to the weight ratio of query resolutions.</description></item>
        /// <item><description>source_nearest: Source-nearest, also known as intelligent resolution, where GTM can return different addresses based on the source of different DNS resolution requests, achieving the effect of users accessing nearby servers.</description></item>
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
        /// <para>pool-89564674533755**96</para>
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
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressPoolResponseBodyAddresses Addresses { get; set; }
        public class DescribeCloudGtmAddressPoolResponseBodyAddresses : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressPoolResponseBodyAddressesAddress> Address { get; set; }
            public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddress : TeaModel {
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
                /// <para>addr-89518218114368**92</para>
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
                /// <item><description>available: Address available</description></item>
                /// <item><description>unavailable: Address unavailable</description></item>
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
                /// <para>Health check task list.</para>
                /// </summary>
                [NameInMap("HealthTasks")]
                [Validation(Required=false)]
                public DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasks HealthTasks { get; set; }
                public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasks : TeaModel {
                    [NameInMap("HealthTask")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasksHealthTask> HealthTask { get; set; }
                    public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasksHealthTask : TeaModel {
                        /// <summary>
                        /// <para>The target service port for health check probes. When the health check protocol is set to Ping, configuration of the service port is not supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>ID of the health check template associated with the address.</para>
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
                /// <para>Remarks for the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The request source list.</para>
                /// </summary>
                [NameInMap("RequestSource")]
                [Validation(Required=false)]
                public DescribeCloudGtmAddressPoolResponseBodyAddressesAddressRequestSource RequestSource { get; set; }
                public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressRequestSource : TeaModel {
                    [NameInMap("RequestSource")]
                    [Validation(Required=false)]
                    public List<string> RequestSource { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether it is a sequential (non-preemptive) scheduling object for hybrid cloud management scenarios: - true: yes - false: no</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SeqNonPreemptiveSchedule")]
                [Validation(Required=false)]
                public bool? SeqNonPreemptiveSchedule { get; set; }

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
                /// <para>The address type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPv4: IPv4 address</description></item>
                /// <item><description>IPv6: IPv6 address</description></item>
                /// <item><description>domain: domain name</description></item>
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
                /// <para>Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address, enabling resolution queries to return addresses according to the weighted ratio.</para>
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
        /// <item><description>ok_alert: The health state of the address pool is warning and some of the addresses that are referenced by the address pool are unavailable. However, the address pool is deemed normal. In this case, only the available addresses are returned for Domain Name System (DNS) requests.</description></item>
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
        /// <para>Remarks for the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>The last modification time of the address pool.</para>
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

    }

}
