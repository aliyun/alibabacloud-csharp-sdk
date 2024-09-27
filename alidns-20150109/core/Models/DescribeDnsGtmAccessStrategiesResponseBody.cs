// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CCC9971-CEC9-4132-824B-4AE611C07623</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The access policies.</para>
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeDnsGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy : TeaModel {
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
                /// <para>The type of the active address pool group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DEFAULT: the primary address pool group</description></item>
                /// <item><description>FAILOVER: the secondary address pool group</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("EffectiveAddrPoolGroupType")]
                [Validation(Required=false)]
                public string EffectiveAddrPoolGroupType { get; set; }

                /// <summary>
                /// <para>The type of the active address pools. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IPV4</description></item>
                /// <item><description>IPV6</description></item>
                /// <item><description>DOMAIN</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ipv4</para>
                /// </summary>
                [NameInMap("EffectiveAddrPoolType")]
                [Validation(Required=false)]
                public string EffectiveAddrPoolType { get; set; }

                /// <summary>
                /// <para>The active address pool groups.</para>
                /// </summary>
                [NameInMap("EffectiveAddrPools")]
                [Validation(Required=false)]
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools EffectiveAddrPools { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools : TeaModel {
                    [NameInMap("EffectiveAddrPool")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool> EffectiveAddrPool { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool : TeaModel {
                        /// <summary>
                        /// <para>The number of addresses in the address pool.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
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
                /// <para>The load balancing policy of the active address pool group. Data is returned when StrategyMode is set to GEO. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>ALL_RR: returns all addresses.</description></item>
                /// <item><description>RATIO: returns addresses by weight.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all_rr</para>
                /// </summary>
                [NameInMap("EffectiveLbaStrategy")]
                [Validation(Required=false)]
                public string EffectiveLbaStrategy { get; set; }

                /// <summary>
                /// <para>The source regions. Data is returned when StrategyMode is set to GEO. Valid values:</para>
                /// </summary>
                [NameInMap("Lines")]
                [Validation(Required=false)]
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines Lines { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine : TeaModel {
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
                /// <para>The ID of the access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>strategyid1</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The name of the access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>strategname1</para>
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries returned on all pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
