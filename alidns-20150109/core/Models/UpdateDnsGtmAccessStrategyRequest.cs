// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The switchover policy for the address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>AUTO: Automatic switchover</para>
        /// </description></item>
        /// <item><description><para>DEFAULT: Primary address pool collection</para>
        /// </description></item>
        /// <item><description><para>FAILOVER: Failover address pool collection</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>The primary address pool collection.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DefaultAddrPool")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAccessStrategyRequestDefaultAddrPool> DefaultAddrPool { get; set; }
        public class UpdateDnsGtmAccessStrategyRequestDefaultAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool in the primary address pool collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool in the primary address pool collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the primary address pool:</para>
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
        /// <para>Specifies whether to enable latency-based scheduling for the primary address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: Enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: Disabled</para>
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
        /// <para>The load balancing policy for the primary address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: Returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: Returns addresses by weight.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the primary address pool collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The failover address pool collection. If no failover address pool collection is configured, enter &quot;EMPTY&quot;.</para>
        /// </summary>
        [NameInMap("FailoverAddrPool")]
        [Validation(Required=false)]
        public List<UpdateDnsGtmAccessStrategyRequestFailoverAddrPool> FailoverAddrPool { get; set; }
        public class UpdateDnsGtmAccessStrategyRequestFailoverAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool in the failover address pool collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>po**</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool in the failover address pool collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the failover address pool:</para>
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
        /// <para>Specifies whether to enable latency-based scheduling for the failover address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: Enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: Disabled</para>
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
        /// <para>The load balancing policy for the failover address pool collection:</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: Returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: Returns addresses by weight.</para>
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
        /// <para>The minimum number of available addresses in the failover address pool collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The language of the response. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The line codes of the access regions. For example, <c>[&quot;default&quot;, &quot;drpeng&quot;]</c> specifies the global line and the Dr. Peng line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;default&quot;, &quot;drpeng&quot;]</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        /// <summary>
        /// <para>The ID of the policy. To obtain the policy ID, call <a href="https://help.aliyun.com/document_detail/2357191.html">DescribeDnsGtmAccessStrategies</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hrb**</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
