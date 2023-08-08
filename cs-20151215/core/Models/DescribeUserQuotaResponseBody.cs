// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// The quota of Container Service for Kubernetes (ACK) managed clusters. Default value: 20. To increase the quota, [go to the Quota Center page to submit a ticket](https://quotas.console.aliyun.com/products/csk/quotas).
        /// </summary>
        [NameInMap("amk_cluster_quota")]
        [Validation(Required=false)]
        public long? AmkClusterQuota { get; set; }

        /// <summary>
        /// The quota of serverless Kubernetes (ASK) clusters. Default value: 20. To increase the quota, [go to the Quota Center page to submit a ticket](https://quotas.console.aliyun.com/products/csk/quotas).
        /// </summary>
        [NameInMap("ask_cluster_quota")]
        [Validation(Required=false)]
        public long? AskClusterQuota { get; set; }

        /// <summary>
        /// The quota of node pools in an ACK cluster. Default value: 20. To increase the quota, [go to the Quota Center page to submit a ticket](https://quotas.console.aliyun.com/products/csk/quotas).
        /// </summary>
        [NameInMap("cluster_nodepool_quota")]
        [Validation(Required=false)]
        public long? ClusterNodepoolQuota { get; set; }

        /// <summary>
        /// The quota of clusters within an Alibaba Cloud account. Default value: 50. To increase the quota, [go to the Quota Center page to submit a ticket](https://quotas.console.aliyun.com/products/csk/quotas).
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
            /// The quota of enhanced edge node pools within an Alibaba Cloud account.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The maximum subscription duration of an enhanced edge node pool. Unit: months.
            /// 
            /// >  Enhanced node pools use the pay-as-you-go billing method. Therefore, this parameter is not required.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

        }

        /// <summary>
        /// The quota of nodes in an ACK cluster. Default value: 100. To increase the quota, [go to the Quota Center page to submit a ticket](https://quotas.console.aliyun.com/products/csk/quotas).
        /// </summary>
        [NameInMap("node_quota")]
        [Validation(Required=false)]
        public long? NodeQuota { get; set; }

        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, QuotasValue> Quotas { get; set; }

    }

}
