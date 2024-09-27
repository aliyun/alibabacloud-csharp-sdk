// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigFullInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The policy for load balancing between address pools. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>round_robin: All address pools are returned for DNS requests from any source. All address pools are sorted in round-robin mode each time they are returned.</description></item>
        /// <item><description>sequence: The address pool with the smallest sequence number is preferentially returned for DNS requests from any source. The sequence number indicates the priority for returning the address pool. A smaller sequence number indicates a higher priority. If the address pool with the smallest sequence number is unavailable, the address pool with the second smallest sequence number is returned.</description></item>
        /// <item><description>weight: You can set a different weight value for each address pool. This way, address pools are returned based on the weight values.</description></item>
        /// <item><description>source_nearest: GTM returns different addresses based on the sources of DNS requests. This way, users can access nearby addresses.</description></item>
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
        public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPools AddressPools { get; set; }
        public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPools : TeaModel {
            [NameInMap("AddressPool")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPool> AddressPool { get; set; }
            public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPool : TeaModel {
                /// <summary>
                /// <para>Load balancing policy among addresses in the address pool:</para>
                /// <list type="bullet">
                /// <item><description>round_robin: Round-robin, for any source of DNS resolution requests, returns all addresses and rotates their order for each request.</description></item>
                /// <item><description>sequence: Sequential, for any source of DNS resolution requests, returns the address with the smaller sequence number (the sequence number indicates the priority of the address return, with smaller numbers having higher priority). If the address with the smaller sequence number is unavailable, the next address with a smaller sequence number is returned.</description></item>
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
                /// <para>The addresses.</para>
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
                        /// <para>addr-89564712295703**96</para>
                        /// </summary>
                        [NameInMap("AddressId")]
                        [Validation(Required=false)]
                        public string AddressId { get; set; }

                        /// <summary>
                        /// <para>Address ownership information, not supported in the current version.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The current version does not support returning this parameter.</para>
                        /// </summary>
                        [NameInMap("AttributeInfo")]
                        [Validation(Required=false)]
                        public string AttributeInfo { get; set; }

                        /// <summary>
                        /// <para>The failover mode that is used when address exceptions are identified. Valid values:</para>
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
                        /// <para>The availability state of the address. Valid values:</para>
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
                        /// <para>The enabling state of the address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>enable</description></item>
                        /// <item><description>disable</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>enable</para>
                        /// </summary>
                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public string EnableStatus { get; set; }

                        /// <summary>
                        /// <para>The condition for determining the health state of the address. Valid values:</para>
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
                        /// <item><description>ok_no_monitor: The address does not reference any health check template and is normal.</description></item>
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
                        /// <para>The remark of the address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// <para>Request source list.</para>
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
                        /// <para>Indicates whether it is a sequential (non-preemptive) mode scheduling object, applicable to hybrid cloud management scenarios: </para>
                        /// <list type="bullet">
                        /// <item><description>true: yes</description></item>
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
                        /// <para>Sequence number, indicating the priority of address return, where smaller numbers have higher priority.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        /// <summary>
                        /// <para>The type of the address. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>IPV4: the IPv4 address</description></item>
                        /// <item><description>IPv6: the IPv6 address</description></item>
                        /// <item><description>domain: the domain name</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>IPv4</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>Last modified time of the address.</para>
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
                        /// <para>Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address, enabling resolution queries to return addresses in proportion to their weights.</para>
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
                /// <para>The availability state of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available</description></item>
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
                /// <para>The enabling state of the address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>enable</description></item>
                /// <item><description>disable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enable</para>
                /// </summary>
                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                /// <summary>
                /// <para>The condition for determining the health state of the address pool. Valid values:</para>
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
                /// <para>Address pool health status:</para>
                /// <list type="bullet">
                /// <item><description>ok: Normal, all addresses referenced by the address pool are available.</description></item>
                /// <item><description>ok_alert: Warning, some addresses referenced by the address pool are unavailable, but the address pool status is deemed normal. In the warning state, available address pools are resolved normally, while unavailable ones stop resolving.</description></item>
                /// <item><description>exceptional: Abnormal, some or all of the addresses referenced by the address pool are unavailable, and the address pool status is determined to be abnormal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                /// <summary>
                /// <para>Parse the list of request sources.</para>
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
                /// <para>Sequence number. For any parsing request from any source, the address pool with the smaller sequence number is returned (the sequence number indicates the priority of the address pool returned, with smaller numbers having higher priority).</para>
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
                /// <para>Weight value (an integer between 1 and 100, inclusive), allowing different weight values to be set for each address pool, enabling resolution queries to return address pools according to the weighted ratio.</para>
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
        /// <para>Alert notification configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;NoticeType\&quot;:\&quot;addr_alert\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_resume\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_pool_unavailable\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_pool_available\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true}]&quot;</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfig { get; set; }

        /// <summary>
        /// <para>Alert notification group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;Default Contact Group\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The availability state of the access domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>available: If the access domain name is <b>enabled</b> and the health state of the access domain name is <b>Normal</b>, the access domain name is deemed <b>available</b>.</description></item>
        /// <item><description>unavailable: If the access domain name is <b>disabled</b> or the health state of the access domain name is <b>Abnormal</b>, the access domain name is deemed <b>unavailable</b>.</description></item>
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
        /// <para>Instance creation time.</para>
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
        /// <item><description>ok: The health state of the access domain name is Normal and all address pools that are referenced by the access domain name are available.</description></item>
        /// <item><description>ok_alert: The health state of the access domain name is Warning and some of the address pools that are referenced by the access domain name are unavailable. In this case, the available address pools are normally used for DNS resolution, but the unavailable address pools cannot be used for DNS resolution.</description></item>
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
        /// <para>Schedule instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Remarks of the configuration of domain instance.</para>
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
        /// <para>29D0F8F8-5499-4F6C-9FDC-1EE13BF55925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <para>Host name of the domain accessed by GTM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("ScheduleHostname")]
        [Validation(Required=false)]
        public string ScheduleHostname { get; set; }

        /// <summary>
        /// <para>DNS record types for the ScheduleDomainName:</para>
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
        /// <item><description>custom: custom allocation. You must specify a custom hostname and associate the hostname with a zone or subzone within the account to which the GTM instance belongs to generate an access domain name.</description></item>
        /// <item><description>sys_assign: The system assigns an access domain name by default. This mode is no longer supported. Do not choose this mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ScheduleZoneMode")]
        [Validation(Required=false)]
        public string ScheduleZoneMode { get; set; }

        /// <summary>
        /// <para>The zone (such as example.com) or subzone (such as a.example.com) associated with the GTM access domain name. In most cases, the zone or subzone is hosted in Authoritative DNS Resolution of the Alibaba Cloud DNS console within the account to which the GTM instance belongs.</para>
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
        /// <para>Global TTL (in seconds), the TTL value for resolving the access domain to addresses in the address pool, which affects the caching time of DNS records in the ISP\&quot;s LocalDNS. Custom TTL values are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>Last modified time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-15T01:46Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>Last modified time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>Global Traffic Management version 3.0 instances:</para>
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
