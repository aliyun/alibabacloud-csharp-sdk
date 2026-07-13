// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The switchover policy for the address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AUTO: automatic switchover.</para>
        /// </description></item>
        /// <item><description><para>DEFAULT: the primary address pool group.</para>
        /// </description></item>
        /// <item><description><para>FAILOVER: the secondary address pool group.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
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
        /// <para>The time when the access policy was created. This value is a UNIX timestamp.</para>
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
        /// <item><description><para>AVAILABLE</para>
        /// </description></item>
        /// <item><description><para>NOT_AVAILABLE</para>
        /// </description></item>
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
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        [NameInMap("DefaultAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools DefaultAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools : TeaModel {
            [NameInMap("DefaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool> DefaultAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool : TeaModel {
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

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
        /// <para>Indicates whether latency-based scheduling is enabled for the primary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: enabled.</para>
        /// </description></item>
        /// <item><description><para>CLOSE: disabled.</para>
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
        /// <para>The load balancing policy for the primary address pool group. Valid values:</para>
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
        /// <para>The maximum number of addresses that can be returned from the primary address pool group.</para>
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
        /// <para>The type of the address pool group that is currently in effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DEFAULT: the primary address pool group.</para>
        /// </description></item>
        /// <item><description><para>FAILOVER: the secondary address pool group.</para>
        /// </description></item>
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
        /// <item><description><para>AVAILABLE</para>
        /// </description></item>
        /// <item><description><para>NOT_AVAILABLE</para>
        /// </description></item>
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

        [NameInMap("FailoverAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools FailoverAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools : TeaModel {
            [NameInMap("FailoverAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool> FailoverAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool : TeaModel {
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

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
        /// <para>Indicates whether latency-based scheduling is enabled for the secondary address pool group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: enabled.</para>
        /// </description></item>
        /// <item><description><para>CLOSE: disabled.</para>
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
        /// <para>The load balancing policy for the secondary address pool group. Valid values:</para>
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
        /// <para>The maximum number of addresses that can be returned from the secondary address pool group.</para>
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
        /// <para>The ID of the associated Global Traffic Manager (GTM) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
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
        /// <para>hr***</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// <para>The type of the access policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GEO: a geolocation-based access policy.</para>
        /// </description></item>
        /// <item><description><para>LATENCY: a latency-based access policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GEO</para>
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
