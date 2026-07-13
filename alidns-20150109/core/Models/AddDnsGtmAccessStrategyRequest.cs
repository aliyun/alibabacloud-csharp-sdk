// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The collection of primary address pools.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DefaultAddrPool")]
        [Validation(Required=false)]
        public List<AddDnsGtmAccessStrategyRequestDefaultAddrPool> DefaultAddrPool { get; set; }
        public class AddDnsGtmAccessStrategyRequestDefaultAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the primary address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// <item><description><para>DOMAIN</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        /// <summary>
        /// <para>The latency-based scheduling optimization for the primary address pool collection.</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the primary address pool collection.</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: returns addresses by weight.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_RR</para>
        /// </summary>
        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=false)]
        public string DefaultLbaStrategy { get; set; }

        /// <summary>
        /// <para>The maximum number of addresses returned from the primary address pool collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of active addresses in the primary address pool collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The collection of failover address pools. If a failover address pool collection is not configured, enter &quot;EMPTY&quot;.</para>
        /// </summary>
        [NameInMap("FailoverAddrPool")]
        [Validation(Required=false)]
        public List<AddDnsGtmAccessStrategyRequestFailoverAddrPool> FailoverAddrPool { get; set; }
        public class AddDnsGtmAccessStrategyRequestFailoverAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the failover address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// <item><description><para>DOMAIN</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=false)]
        public string FailoverAddrPoolType { get; set; }

        /// <summary>
        /// <para>The latency-based scheduling optimization for the failover address pool collection.</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the failover address pool collection.</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: returns addresses by weight.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_RR</para>
        /// </summary>
        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=false)]
        public string FailoverLbaStrategy { get; set; }

        /// <summary>
        /// <para>The maximum number of addresses returned from the failover address pool collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of active addresses in the failover address pool collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of some returned parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source of the DNS request. For example, <c>[&quot;default&quot;, &quot;drpeng&quot;]</c> indicates a global policy and Dr. Peng Group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;default&quot;, &quot;drpeng&quot;]</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        /// <summary>
        /// <para>The type of the access policy.</para>
        /// <list type="bullet">
        /// <item><description><para>GEO: a location-based access policy.</para>
        /// </description></item>
        /// <item><description><para>LATENCY: a latency-based access policy.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GEO</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testStrategyName</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
