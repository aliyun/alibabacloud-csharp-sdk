// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota of Container Service for Kubernetes (ACK) managed clusters. Default value: 20. If the default quota limit is reached, submit an application in the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center console</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("amk_cluster_quota")]
        [Validation(Required=false)]
        public long? AmkClusterQuota { get; set; }

        /// <summary>
        /// <para>The quota of ACK Serverless clusters. Default value: 20. If the default quota limit is reached, submit an application in the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center console</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ask_cluster_quota")]
        [Validation(Required=false)]
        public long? AskClusterQuota { get; set; }

        /// <summary>
        /// <para>The quota of node pools in an ACK cluster. Default value: 20. If the default quota limit is reached, submit an application in the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center console</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cluster_nodepool_quota")]
        [Validation(Required=false)]
        public long? ClusterNodepoolQuota { get; set; }

        /// <summary>
        /// <para>The quota of clusters that belong to an Alibaba Cloud account. Default value: 50. If the default quota limit is reached, submit an application in the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center console</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("cluster_quota")]
        [Validation(Required=false)]
        public long? ClusterQuota { get; set; }

        /// <summary>
        /// <para>This parameter is discontinued.</para>
        /// <para>The quotas of enhanced edge node pools.</para>
        /// </summary>
        [NameInMap("edge_improved_nodepool_quota")]
        [Validation(Required=false)]
        public DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota EdgeImprovedNodepoolQuota { get; set; }
        public class DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota : TeaModel {
            /// <summary>
            /// <para>This parameter is discontinued.</para>
            /// <para>The maximum bandwidth of each enhanced edge node pool. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>This parameter is discontinued.</para>
            /// <para>The maximum number of enhanced edge node pools that you can create within an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>This parameter is discontinued.</para>
            /// <para>The maximum subscription duration of an enhanced edge node pool. Unit: months.</para>
            /// <remarks>
            /// <para> You are charged for enhanced edge node pools based on the pay-as-you-go billing method. Therefore, you can ignore this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

        }

        /// <summary>
        /// <para>The quota of nodes in an ACK cluster. Default value: 100. If the default quota limit is reached, submit an application in the <a href="https://quotas.console.aliyun.com/products/csk/quotas">Quota Center console</a> to increase the quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("node_quota")]
        [Validation(Required=false)]
        public long? NodeQuota { get; set; }

        /// <summary>
        /// <para>Information about the new quota.</para>
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, QuotasValue> Quotas { get; set; }

    }

}
