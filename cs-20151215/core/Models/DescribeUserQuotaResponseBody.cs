// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// The quota of Container Service for Kubernetes (ACK) managed clusters. Default value: 20. If the default quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("amk_cluster_quota")]
        [Validation(Required=false)]
        public long? AmkClusterQuota { get; set; }

        /// <summary>
        /// The quota of ACK Serverless clusters. Default value: 20. If the default quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("ask_cluster_quota")]
        [Validation(Required=false)]
        public long? AskClusterQuota { get; set; }

        /// <summary>
        /// The quota of node pools in an ACK cluster. Default value: 20. If the default quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("cluster_nodepool_quota")]
        [Validation(Required=false)]
        public long? ClusterNodepoolQuota { get; set; }

        /// <summary>
        /// The quota of clusters that belong to an Alibaba Cloud account. Default value: 50. If the default quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("cluster_quota")]
        [Validation(Required=false)]
        public long? ClusterQuota { get; set; }

        /// <summary>
        /// The quota of enhanced edge node pools.
        /// </summary>
        [NameInMap("edge_improved_nodepool_quota")]
        [Validation(Required=false)]
        public DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota EdgeImprovedNodepoolQuota { get; set; }
        public class DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota : TeaModel {
            /// <summary>
            /// The maximum bandwidth of each enhanced node pool. Unit: Mbit/s.
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The quota of enhanced edge node pools that belong to an Alibaba Cloud account.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The maximum subscription duration of an enhanced edge node pool. Unit: months.
            /// 
            /// > You can ignore this parameter because enhanced edge node pools are pay-as-you-go resources.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

        }

        /// <summary>
        /// The quota of nodes in an ACK cluster. Default value: 100. If the default quota limit is reached, submit an application in the [Quota Center console](https://quotas.console.aliyun.com/products/csk/quotas) to increase the quota.
        /// </summary>
        [NameInMap("node_quota")]
        [Validation(Required=false)]
        public long? NodeQuota { get; set; }

        /// <summary>
        /// Information about the new quota.
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, QuotasValue> Quotas { get; set; }

    }

}
