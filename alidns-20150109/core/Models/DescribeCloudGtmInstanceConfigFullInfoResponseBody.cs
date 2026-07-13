// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigFullInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The load balancing policy for the address pools.</para>
        /// <list type="bullet">
        /// <item><description><para>round_robin: Returns all address pools for any DNS request. The address pools are rotated in order for each request.</para>
        /// </description></item>
        /// <item><description><para>sequence: Returns the address pool with the smallest ordinal number for any DNS request. The ordinal number indicates the priority of the address pool. A smaller value indicates a higher priority. If the address pool with the smallest ordinal number is unavailable, the address pool with the next smallest ordinal number is returned.</para>
        /// </description></item>
        /// <item><description><para>weight: Returns address pools based on the specified weight for each address pool.</para>
        /// </description></item>
        /// <item><description><para>source_nearest: Returns different address pools based on the source of the DNS requests. This implements proximity-based access for users.</para>
        /// </description></item>
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
                [NameInMap("AddressLbStrategy")]
                [Validation(Required=false)]
                public string AddressLbStrategy { get; set; }

                [NameInMap("AddressPoolId")]
                [Validation(Required=false)]
                public string AddressPoolId { get; set; }

                [NameInMap("AddressPoolName")]
                [Validation(Required=false)]
                public string AddressPoolName { get; set; }

                [NameInMap("AddressPoolType")]
                [Validation(Required=false)]
                public string AddressPoolType { get; set; }

                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddresses Addresses { get; set; }
                public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddresses : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddress> Address { get; set; }
                    public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddress : TeaModel {
                        [NameInMap("Address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        [NameInMap("AddressId")]
                        [Validation(Required=false)]
                        public string AddressId { get; set; }

                        [NameInMap("AttributeInfo")]
                        [Validation(Required=false)]
                        public string AttributeInfo { get; set; }

                        [NameInMap("AvailableMode")]
                        [Validation(Required=false)]
                        public string AvailableMode { get; set; }

                        [NameInMap("AvailableStatus")]
                        [Validation(Required=false)]
                        public string AvailableStatus { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("CreateTimestamp")]
                        [Validation(Required=false)]
                        public long? CreateTimestamp { get; set; }

                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public string EnableStatus { get; set; }

                        [NameInMap("HealthJudgement")]
                        [Validation(Required=false)]
                        public string HealthJudgement { get; set; }

                        [NameInMap("HealthStatus")]
                        [Validation(Required=false)]
                        public string HealthStatus { get; set; }

                        [NameInMap("ManualAvailableStatus")]
                        [Validation(Required=false)]
                        public string ManualAvailableStatus { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        [NameInMap("RequestSource")]
                        [Validation(Required=false)]
                        public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddressRequestSource RequestSource { get; set; }
                        public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolAddressesAddressRequestSource : TeaModel {
                            [NameInMap("RequestSource")]
                            [Validation(Required=false)]
                            public List<string> RequestSource { get; set; }

                        }

                        [NameInMap("SeqNonPreemptiveSchedule")]
                        [Validation(Required=false)]
                        public bool? SeqNonPreemptiveSchedule { get; set; }

                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        [NameInMap("WeightValue")]
                        [Validation(Required=false)]
                        public int? WeightValue { get; set; }

                    }

                }

                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                [NameInMap("HealthJudgement")]
                [Validation(Required=false)]
                public string HealthJudgement { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("RequestSource")]
                [Validation(Required=false)]
                public DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolRequestSource RequestSource { get; set; }
                public class DescribeCloudGtmInstanceConfigFullInfoResponseBodyAddressPoolsAddressPoolRequestSource : TeaModel {
                    [NameInMap("RequestSource")]
                    [Validation(Required=false)]
                    public List<string> RequestSource { get; set; }

                }

                [NameInMap("SeqNonPreemptiveSchedule")]
                [Validation(Required=false)]
                public bool? SeqNonPreemptiveSchedule { get; set; }

                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public int? SerialNumber { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("WeightValue")]
                [Validation(Required=false)]
                public int? WeightValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The alert notification configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;NoticeType\&quot;:\&quot;addr_alert\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_resume\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_pool_unavailable\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true},{\&quot;NoticeType\&quot;:\&quot;addr_pool_available\&quot;,\&quot;SmsNotice\&quot;:true,\&quot;EmailNotice\&quot;:true,\&quot;DingtalkNotice\&quot;:true}]&quot;</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public string AlertConfig { get; set; }

        /// <summary>
        /// <para>The alert group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;云账号报警联系人\&quot;]</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public string AlertGroup { get; set; }

        /// <summary>
        /// <para>The service availability status of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para><c>available</c>: The instance is enabled and its health status is Normal. The service is available for the access domain name.</para>
        /// </description></item>
        /// <item><description><para><c>unavailable</c>: The instance is disabled or its health status is abnormal. The service is unavailable for the access domain name.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("AvailableStatus")]
        [Validation(Required=false)]
        public string AvailableStatus { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// <list type="bullet">
        /// <item><description><para>dns_gtm_public_cn: The commodity code for the China site (aliyun.com).</para>
        /// </description></item>
        /// <item><description><para>dns_gtm_public_intl: The commodity code for the international site (alibabacloud.com).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dns_gtm_public_cn</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the instance configuration. You can configure both A and AAAA records for the same access domain name and Global Traffic Manager (GTM) instance. In this case, the GTM instance has two configurations. The ConfigId uniquely identifies an instance configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-15T01:46Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp that indicates when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The enabled status of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>enable: The GTM instance is enabled and its intelligent scheduling policy is active.</para>
        /// </description></item>
        /// <item><description><para>disable: The GTM instance is disabled and its intelligent scheduling policy is inactive.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("EnableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// <para>The health status of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>ok: Normal. All address pools referenced by the access domain name are available.</para>
        /// </description></item>
        /// <item><description><para>ok_alert: Warning. Some of the address pools referenced by the access domain name are unavailable. In this state, DNS requests are resolved to the available address pools, but not to the unavailable ones.</para>
        /// </description></item>
        /// <item><description><para>exceptional: Abnormal. All address pools referenced by the access domain name are unavailable. In this case, DNS requests are resolved to the addresses in the non-empty address pool with the smallest ordinal number as a failover measure. This helps ensure that clients can receive DNS responses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// <para>The ID of the Global Traffic Manager 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3h****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the GTM instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The remarks on the instance configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29D0F8F8-5499-4F6C-9FDC-1EE13BF55925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The GTM access domain name. The format is ScheduleHostname + ScheduleZoneName.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("ScheduleDomainName")]
        [Validation(Required=false)]
        public string ScheduleDomainName { get; set; }

        /// <summary>
        /// <para>The host record of the GTM access domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("ScheduleHostname")]
        [Validation(Required=false)]
        public string ScheduleHostname { get; set; }

        /// <summary>
        /// <para>The DNS record type of the GTM access domain name.</para>
        /// <list type="bullet">
        /// <item><description><para>A: IPv4 address</para>
        /// </description></item>
        /// <item><description><para>AAAA: IPv6 address</para>
        /// </description></item>
        /// <item><description><para>CNAME: canonical name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("ScheduleRrType")]
        [Validation(Required=false)]
        public string ScheduleRrType { get; set; }

        /// <summary>
        /// <para>The assignment mode of the access domain name.</para>
        /// <list type="bullet">
        /// <item><description><para>custom: You can customize the host record and associate it with a primary domain name or a subdomain name under the account to which the GTM instance belongs. This generates the access domain name.</para>
        /// </description></item>
        /// <item><description><para>sys_assign: The system assigns a default access domain name. This feature is no longer supported. Do not select this mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ScheduleZoneMode")]
        [Validation(Required=false)]
        public string ScheduleZoneMode { get; set; }

        /// <summary>
        /// <para>The primary domain name (example.com) or subdomain name (a.example.com) of the GTM access domain name. This is typically a domain name hosted in the authoritative zone of the Alibaba Cloud DNS console under the account to which the GTM instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ScheduleZoneName")]
        [Validation(Required=false)]
        public string ScheduleZoneName { get; set; }

        /// <summary>
        /// <para>When the load balancing policy for address pools is sequence, this parameter specifies the service recovery mode for a resource that becomes available again.</para>
        /// <list type="bullet">
        /// <item><description><para>preemptive: The address pool with the smaller ordinal number is preferentially used.</para>
        /// </description></item>
        /// <item><description><para>non_preemptive: The current address pool is still used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preemptive</para>
        /// </summary>
        [NameInMap("SequenceLbStrategyMode")]
        [Validation(Required=false)]
        public string SequenceLbStrategyMode { get; set; }

        /// <summary>
        /// <para>The global time to live (TTL) in seconds. This is the TTL value for the DNS records that map the access domain name to the addresses in the address pool. It affects the cache duration of the DNS records on carrier Local DNS servers. You can customize the TTL value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The time when the instance was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-15T01:46Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp that indicates when the instance was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The edition of the Global Traffic Manager 3.0 instance.</para>
        /// <list type="bullet">
        /// <item><description><para>standard: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>ultimate: Ultimate Edition</para>
        /// </description></item>
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
