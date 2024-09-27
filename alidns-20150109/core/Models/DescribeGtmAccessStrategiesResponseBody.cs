// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page returned.</para>
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
        /// <para>20</para>
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
        /// <para>The returned list of access policies of the GTM instance.</para>
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategy : TeaModel {
                /// <summary>
                /// <para>The access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AUTO</b>: Automatic switch</description></item>
                /// <item><description><b>DEFAULT</b>: Default address pool</description></item>
                /// <item><description><b>FAILOVER</b>: Failover address pool</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public string AccessMode { get; set; }

                /// <summary>
                /// <para>The access status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DEFAULT</b>: The default address pool is currently accessed.</description></item>
                /// <item><description><b>FAILOVER</b>: The failover address pool is currently accessed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DEFAULT</para>
                /// </summary>
                [NameInMap("AccessStatus")]
                [Validation(Required=false)]
                public string AccessStatus { get; set; }

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
                /// <b>Example:</b>
                /// <para>1533773400000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The ID of the default address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hra0i1</para>
                /// </summary>
                [NameInMap("DefaultAddrPoolId")]
                [Validation(Required=false)]
                public string DefaultAddrPoolId { get; set; }

                /// <summary>
                /// <para>Indicates whether health check was enabled for the default address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OPEN</b>: Enabled</description></item>
                /// <item><description><b>CLOSE</b>: Disabled</description></item>
                /// <item><description><b>UNCONFIGURED</b>: Not configured</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("DefaultAddrPoolMonitorStatus")]
                [Validation(Required=false)]
                public string DefaultAddrPoolMonitorStatus { get; set; }

                /// <summary>
                /// <para>The name of the default address pool.</para>
                /// </summary>
                [NameInMap("DefaultAddrPoolName")]
                [Validation(Required=false)]
                public string DefaultAddrPoolName { get; set; }

                /// <summary>
                /// <para>The availability status of the default address pool. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AVAILABLE</b>: Available</description></item>
                /// <item><description><b>NOT_AVAILABLE</b>: Unavailable</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("DefaultAddrPoolStatus")]
                [Validation(Required=false)]
                public string DefaultAddrPoolStatus { get; set; }

                /// <summary>
                /// <para>The ID of the failover address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hra0i2</para>
                /// </summary>
                [NameInMap("FailoverAddrPoolId")]
                [Validation(Required=false)]
                public string FailoverAddrPoolId { get; set; }

                /// <summary>
                /// <para>Indicates whether health check was enabled for the failover address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("FailoverAddrPoolMonitorStatus")]
                [Validation(Required=false)]
                public string FailoverAddrPoolMonitorStatus { get; set; }

                /// <summary>
                /// <para>The name of the failover address pool.</para>
                /// </summary>
                [NameInMap("FailoverAddrPoolName")]
                [Validation(Required=false)]
                public string FailoverAddrPoolName { get; set; }

                /// <summary>
                /// <para>The availability status of the failover address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AVAILABLE</para>
                /// </summary>
                [NameInMap("FailoverAddrPoolStatus")]
                [Validation(Required=false)]
                public string FailoverAddrPoolStatus { get; set; }

                /// <summary>
                /// <para>The ID of the GTM instance whose access policies you want to query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instance1</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The returned lines of access regions.</para>
                /// </summary>
                [NameInMap("Lines")]
                [Validation(Required=false)]
                public DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLines Lines { get; set; }
                public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public List<DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine : TeaModel {
                        /// <summary>
                        /// <para>The code of the access region group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEFAULT</para>
                        /// </summary>
                        [NameInMap("GroupCode")]
                        [Validation(Required=false)]
                        public string GroupCode { get; set; }

                        /// <summary>
                        /// <para>The name of the access region group.</para>
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// <para>The code for the line of the access region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("LineCode")]
                        [Validation(Required=false)]
                        public string LineCode { get; set; }

                        /// <summary>
                        /// <para>The name for the line of the access region.</para>
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
                /// <para>hra0hs</para>
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// <para>The mode of the access policy. <b>SELF_DEFINED</b> indicates that the access policy is user-defined.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELF_DEFINED</para>
                /// </summary>
                [NameInMap("StrategyMode")]
                [Validation(Required=false)]
                public string StrategyMode { get; set; }

                /// <summary>
                /// <para>The name of the access policy.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
