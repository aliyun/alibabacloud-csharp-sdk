// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowClusterResponseBody : TeaModel {
        /// <summary>
        /// 集群列表。
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListFlowClusterResponseBodyClusters Clusters { get; set; }
        public class ListFlowClusterResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public List<ListFlowClusterResponseBodyClustersClusterInfo> ClusterInfo { get; set; }
            public class ListFlowClusterResponseBodyClustersClusterInfo : TeaModel {
                public string ChargeType { get; set; }
                public string CreateResource { get; set; }
                public long? CreateTime { get; set; }
                public long? ExpiredTime { get; set; }
                public ListFlowClusterResponseBodyClustersClusterInfoFailReason FailReason { get; set; }
                public class ListFlowClusterResponseBodyClustersClusterInfoFailReason : TeaModel {
                    /// <summary>
                    /// 错误码。
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// 错误原因。
                    /// </summary>
                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    /// <summary>
                    /// 请求ID。
                    /// </summary>
                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                }
                public bool? HasUncompletedOrder { get; set; }
                public string Id { get; set; }
                public string K8sClusterId { get; set; }
                public string Name { get; set; }
                public string OrderList { get; set; }
                public ListFlowClusterResponseBodyClustersClusterInfoOrderTaskInfo OrderTaskInfo { get; set; }
                public class ListFlowClusterResponseBodyClustersClusterInfoOrderTaskInfo : TeaModel {
                    /// <summary>
                    /// 当前数量。
                    /// </summary>
                    [NameInMap("CurrentCount")]
                    [Validation(Required=false)]
                    public int? CurrentCount { get; set; }

                    /// <summary>
                    /// 订单列表。
                    /// </summary>
                    [NameInMap("OrderIdList")]
                    [Validation(Required=false)]
                    public string OrderIdList { get; set; }

                    /// <summary>
                    /// 目标数量。
                    /// </summary>
                    [NameInMap("TargetCount")]
                    [Validation(Required=false)]
                    public int? TargetCount { get; set; }

                }
                public int? Period { get; set; }
                public int? RunningTime { get; set; }
                public string Status { get; set; }
                public string Type { get; set; }
            }
        };

        /// <summary>
        /// 当前页码，从1开始。
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页查询时每页行数。
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
