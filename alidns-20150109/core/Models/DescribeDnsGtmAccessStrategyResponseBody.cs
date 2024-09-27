// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The primary/secondary switchover policy for address pool groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTO: performs automatic switchover between the primary and secondary address pool groups upon failures.</description></item>
        /// <item><description>DEFAULT: uses the primary address pool group.</description></item>
        /// <item><description>FAILOVER: uses the secondary address pool group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// <para>The time when the access policy was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-08-09T00:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the access policy was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1533773400000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The status of the primary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE: available</description></item>
        /// <item><description>NOT_AVAILABLE: unavailable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolGroupStatus { get; set; }

        /// <summary>
        /// <para>The type of the primary address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// <item><description>DOMAIN</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        /// <summary>
        /// <para>The address pools in the primary address pool group.</para>
        /// </summary>
        [NameInMap("DefaultAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools DefaultAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools : TeaModel {
            [NameInMap("DefaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool> DefaultAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

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

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of available addresses in the primary address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>Indicates whether scheduling optimization for latency resolution was enabled for the primary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: enabled</description></item>
        /// <item><description>CLOSE: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the primary address pool group. Valid values:</para>
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
        /// <para>The maximum number of addresses returned from the primary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the primary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The type of the active address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DEFAULT: the primary address pool group</description></item>
        /// <item><description>FAILOVER: the secondary address pool group</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("EffectiveAddrPoolGroupType")]
        [Validation(Required=false)]
        public string EffectiveAddrPoolGroupType { get; set; }

        /// <summary>
        /// <para>The status of the secondary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE: available</description></item>
        /// <item><description>NOT_AVAILABLE: unavailable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("FailoverAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolGroupStatus { get; set; }

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
        /// <para>The address pools in the secondary address pool group.</para>
        /// </summary>
        [NameInMap("FailoverAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools FailoverAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools : TeaModel {
            [NameInMap("FailoverAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool> FailoverAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool : TeaModel {
                /// <summary>
                /// <para>The number of addresses in the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

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

                /// <summary>
                /// <para>The name of the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of available addresses in the secondary address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>Indicates whether scheduling optimization for latency resolution was enabled for the secondary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: enabled</description></item>
        /// <item><description>CLOSE: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        /// <summary>
        /// <para>The load balancing policy of the secondary address pool group. Valid values:</para>
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
        /// <para>The maximum number of addresses returned from the secondary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the secondary address pool group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The ID of the associated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The source regions.</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// <para>The code of the source region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// <para>The name of the source region group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The line code of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The line name of the source region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA1608CA-834C-4E63-8682-8AF0B11ED72D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the access policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategyId1</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The type of the access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GEO: geographical location-based</description></item>
        /// <item><description>LATENCY: latency-based</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>geo</para>
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// <para>The name of the access policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategyName1</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
