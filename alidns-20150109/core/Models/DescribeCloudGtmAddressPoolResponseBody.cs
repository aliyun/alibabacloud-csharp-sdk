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

        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressPoolResponseBodyAddresses Addresses { get; set; }
        public class DescribeCloudGtmAddressPoolResponseBodyAddresses : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressPoolResponseBodyAddressesAddress> Address { get; set; }
            public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddress : TeaModel {
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

                [NameInMap("HealthTasks")]
                [Validation(Required=false)]
                public DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasks HealthTasks { get; set; }
                public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasks : TeaModel {
                    [NameInMap("HealthTask")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasksHealthTask> HealthTask { get; set; }
                    public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressHealthTasksHealthTask : TeaModel {
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("TemplateName")]
                        [Validation(Required=false)]
                        public string TemplateName { get; set; }

                    }

                }

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
                public DescribeCloudGtmAddressPoolResponseBodyAddressesAddressRequestSource RequestSource { get; set; }
                public class DescribeCloudGtmAddressPoolResponseBodyAddressesAddressRequestSource : TeaModel {
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
