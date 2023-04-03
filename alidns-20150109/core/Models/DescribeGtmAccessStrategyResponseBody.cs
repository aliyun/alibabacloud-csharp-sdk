// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// The access policy.
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// The access status. Valid values:
        /// 
        /// *   **DEFAULT**: Indicates normal when the default address pool is accessed.
        /// *   **FAILOVER**: Indicates an exception when a failover address pool is accessed.
        /// </summary>
        [NameInMap("AccessStatus")]
        [Validation(Required=false)]
        public string AccessStatus { get; set; }

        /// <summary>
        /// Indicates whether health check is enabled for the default address pool.
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
        /// The availability status of the default address pool.
        /// </summary>
        [NameInMap("DefaultAddrPoolStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolStatus { get; set; }

        /// <summary>
        /// The ID of the default address pool.
        /// </summary>
        [NameInMap("DefultAddrPoolId")]
        [Validation(Required=false)]
        public string DefultAddrPoolId { get; set; }

        /// <summary>
        /// The ID of the failover address pool.
        /// </summary>
        [NameInMap("FailoverAddrPoolId")]
        [Validation(Required=false)]
        public string FailoverAddrPoolId { get; set; }

        /// <summary>
        /// Indicates whether health check is enabled for the failover address pool.
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
        /// The ID of the GTM instance whose access policy details you want to query.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The returned lines of access regions.
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeGtmAccessStrategyResponseBodyLinesLine : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the access policy queried.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// The mode of traffic scheduling.
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// The name of the access policy queried.
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
