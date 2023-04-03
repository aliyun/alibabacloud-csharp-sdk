// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategiesResponseBody : TeaModel {
        /// <summary>
        /// The number of the page returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned list of access policies of the GTM instance.
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
                /// The access policy. Valid values:
                /// 
                /// *   **AUTO**: Automatic switch
                /// *   **DEFAULT**: Default address pool
                /// *   **FAILOVER**: Failover address pool
                /// </summary>
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public string AccessMode { get; set; }

                /// <summary>
                /// The access status. Valid values:
                /// 
                /// *   **DEFAULT**: The default address pool is currently accessed.
                /// *   **FAILOVER**: The failover address pool is currently accessed.
                /// </summary>
                [NameInMap("AccessStatus")]
                [Validation(Required=false)]
                public string AccessStatus { get; set; }

                /// <summary>
                /// The time when the access policy was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The ID of the default address pool.
                /// </summary>
                [NameInMap("DefaultAddrPoolId")]
                [Validation(Required=false)]
                public string DefaultAddrPoolId { get; set; }

                /// <summary>
                /// Indicates whether health check was enabled for the default address pool. Valid values:
                /// 
                /// *   **OPEN**: Enabled
                /// *   **CLOSE**: Disabled
                /// *   **UNCONFIGURED**: Not configured
                /// </summary>
                [NameInMap("DefaultAddrPoolMonitorStatus")]
                [Validation(Required=false)]
                public string DefaultAddrPoolMonitorStatus { get; set; }

                /// <summary>
                /// The name of the default address pool.
                /// </summary>
                [NameInMap("DefaultAddrPoolName")]
                [Validation(Required=false)]
                public string DefaultAddrPoolName { get; set; }

                /// <summary>
                /// The availability status of the default address pool. Valid values:
                /// 
                /// *   **AVAILABLE**: Available
                /// *   **NOT_AVAILABLE**: Unavailable
                /// </summary>
                [NameInMap("DefaultAddrPoolStatus")]
                [Validation(Required=false)]
                public string DefaultAddrPoolStatus { get; set; }

                /// <summary>
                /// The ID of the failover address pool.
                /// </summary>
                [NameInMap("FailoverAddrPoolId")]
                [Validation(Required=false)]
                public string FailoverAddrPoolId { get; set; }

                /// <summary>
                /// Indicates whether health check was enabled for the failover address pool.
                /// </summary>
                [NameInMap("FailoverAddrPoolMonitorStatus")]
                [Validation(Required=false)]
                public string FailoverAddrPoolMonitorStatus { get; set; }

                /// <summary>
                /// The name of the failover address pool.
                /// </summary>
                [NameInMap("FailoverAddrPoolName")]
                [Validation(Required=false)]
                public string FailoverAddrPoolName { get; set; }

                /// <summary>
                /// The availability status of the failover address pool.
                /// </summary>
                [NameInMap("FailoverAddrPoolStatus")]
                [Validation(Required=false)]
                public string FailoverAddrPoolStatus { get; set; }

                /// <summary>
                /// The ID of the GTM instance whose access policies you want to query.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The returned lines of access regions.
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
                        /// The code of the access region group.
                        /// </summary>
                        [NameInMap("GroupCode")]
                        [Validation(Required=false)]
                        public string GroupCode { get; set; }

                        /// <summary>
                        /// The name of the access region group.
                        /// </summary>
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        /// <summary>
                        /// The code for the line of the access region.
                        /// </summary>
                        [NameInMap("LineCode")]
                        [Validation(Required=false)]
                        public string LineCode { get; set; }

                        /// <summary>
                        /// The name for the line of the access region.
                        /// </summary>
                        [NameInMap("LineName")]
                        [Validation(Required=false)]
                        public string LineName { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the access policy.
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// The mode of the access policy. **SELF_DEFINED** indicates that the access policy is user-defined.
                /// </summary>
                [NameInMap("StrategyMode")]
                [Validation(Required=false)]
                public string StrategyMode { get; set; }

                /// <summary>
                /// The name of the access policy.
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
