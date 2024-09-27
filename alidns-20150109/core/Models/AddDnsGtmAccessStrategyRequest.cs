// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The address pools in the primary address pool set.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DefaultAddrPool")]
        [Validation(Required=false)]
        public List<AddDnsGtmAccessStrategyRequestDefaultAddrPool> DefaultAddrPool { get; set; }
        public class AddDnsGtmAccessStrategyRequestDefaultAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool in the primary address pool set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool in the primary address pool set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the primary address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// <item><description>DOMAIN</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable DNS resolution with optimal latency for the primary address pool set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN</description></item>
        /// <item><description>CLOSE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the primary address pool set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_RR: returns all addresses.</description></item>
        /// <item><description>RATIO: returns addresses by weight.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all_rr</para>
        /// </summary>
        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=false)]
        public string DefaultLbaStrategy { get; set; }

        /// <summary>
        /// <para>The maximum number of addresses returned from the primary address pool set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the primary address pool set.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The address pools in the secondary address pool set. If no address pool exists in the secondary address pool set, set this parameter to EMPTY.</para>
        /// </summary>
        [NameInMap("FailoverAddrPool")]
        [Validation(Required=false)]
        public List<AddDnsGtmAccessStrategyRequestFailoverAddrPool> FailoverAddrPool { get; set; }
        public class AddDnsGtmAccessStrategyRequestFailoverAddrPool : TeaModel {
            /// <summary>
            /// <para>The ID of the address pool in the secondary address pool set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pool1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The weight of the address pool in the secondary address pool set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LbaWeight")]
            [Validation(Required=false)]
            public int? LbaWeight { get; set; }

        }

        /// <summary>
        /// <para>The type of the secondary address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// <item><description>DOMAIN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=false)]
        public string FailoverAddrPoolType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable DNS resolution with optimal latency for the secondary address pool set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN</description></item>
        /// <item><description>CLOSE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the secondary address pool set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_RR: returns all addresses.</description></item>
        /// <item><description>RATIO: returns addresses by weight.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all_rr</para>
        /// </summary>
        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=false)]
        public string FailoverLbaStrategy { get; set; }

        /// <summary>
        /// <para>The maximum number of addresses returned from the secondary address pool set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the secondary address pool set.</para>
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
        /// <para>The language of the values for specific response parameters. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The Domain Name System (DNS) request source. For example: <c>[&quot;default&quot;, &quot;drpeng&quot;]</c> indicates Global and Dr. Peng Group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;default&quot;, &quot;drpeng&quot;]</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        /// <summary>
        /// <para>The type of the access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GEO: geographical location-based access policy</description></item>
        /// <item><description>LATENCY: latency-based access policy</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>geo</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// <para>The name of the access policy.</para>
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
