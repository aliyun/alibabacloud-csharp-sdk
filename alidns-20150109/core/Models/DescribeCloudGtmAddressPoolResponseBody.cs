// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The load balancing policy for the addresses in the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>round_robin: For a DNS request from any source, all addresses are returned. The addresses are rotated in each response.</para>
        /// </description></item>
        /// <item><description><para>sequence: For a DNS request from any source, the address with the highest priority is returned. Priority is determined by the \<c>SerialNumber\\</c>, where a smaller value indicates a higher priority. If the highest-priority address is unavailable, the address with the next highest priority is returned.</para>
        /// </description></item>
        /// <item><description><para>weight: A weight can be set for each address. DNS requests are resolved based on the specified weight ratio.</para>
        /// </description></item>
        /// <item><description><para>source_nearest: Global Traffic Manager (GTM) returns an address based on the source of the DNS request. This implements proximity-based access for users.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>round_robin</para>
        /// </summary>
        [NameInMap("AddressLbStrategy")]
        [Validation(Required=false)]
        public string AddressLbStrategy { get; set; }

        /// <summary>
        /// <para>The unique ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89564674533755****</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddressPool-1</para>
        /// </summary>
        [NameInMap("AddressPoolName")]
        [Validation(Required=false)]
        public string AddressPoolName { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IPv4</para>
        /// </description></item>
        /// <item><description><para>IPv6</para>
        /// </description></item>
        /// <item><description><para>domain</para>
        /// </description></item>
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
        /// <para>The availability status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>available: Available.</para>
        /// </description></item>
        /// <item><description><para>unavailable: Unavailable.</para>
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
        /// <para>The time when the address pool was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-15T01:46Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the address pool was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: Enabled</para>
        /// </description></item>
        /// <item><description><para>disable: Disabled</para>
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
        /// <para>The condition used to determine the health status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>any_ok: At least one address is available.</para>
        /// </description></item>
        /// <item><description><para>p30_ok: At least 30% of the addresses are available.</para>
        /// </description></item>
        /// <item><description><para>p50_ok: At least 50% of the addresses are available.</para>
        /// </description></item>
        /// <item><description><para>p70_ok: At least 70% of the addresses are available.</para>
        /// </description></item>
        /// <item><description><para>all_ok: All addresses are available.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>any_ok</para>
        /// </summary>
        [NameInMap("HealthJudgement")]
        [Validation(Required=false)]
        public string HealthJudgement { get; set; }

        /// <summary>
        /// <para>The health status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ok: The address pool is healthy. All addresses in the address pool are available.</para>
        /// </description></item>
        /// <item><description><para>ok_alert: The address pool is in an alert state. Some addresses are unavailable, but the address pool is still considered healthy. In this state, DNS resolution is performed for available addresses, but not for unavailable addresses.</para>
        /// </description></item>
        /// <item><description><para>exceptional: The address pool is unhealthy. Some or all addresses are unavailable, and the address pool is considered unhealthy.</para>
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
        /// <para>The notes on the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service recovery mode for a primary address that becomes available again when the load balancing policy is set to \<c>sequence\\</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>preemptive: The system preferentially uses the address with a smaller \<c>SerialNumber\\</c>.</para>
        /// </description></item>
        /// <item><description><para>non_preemptive: The system continues to use the current address.</para>
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
        /// <para>The time when the address pool was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-15T01:46Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the address pool was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
