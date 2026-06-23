// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota for managed clusters. Default value: 20. To request a quota increase beyond the default value, <a href="https://quotas.console.aliyun.com/products/csk/quotas">submit a request on the Quota Center page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("amk_cluster_quota")]
        [Validation(Required=false)]
        public long? AmkClusterQuota { get; set; }

        /// <summary>
        /// <para>The quota for ASK clusters. Default value: 20. To request a quota increase beyond the default value, <a href="https://quotas.console.aliyun.com/products/csk/quotas">submit a request on the Quota Center page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ask_cluster_quota")]
        [Validation(Required=false)]
        public long? AskClusterQuota { get; set; }

        /// <summary>
        /// <para>The node pool quota per cluster. Default value: 20. To request a quota increase beyond the default value, <a href="https://quotas.console.aliyun.com/products/csk/quotas">submit a request on the Quota Center page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("cluster_nodepool_quota")]
        [Validation(Required=false)]
        public long? ClusterNodepoolQuota { get; set; }

        /// <summary>
        /// <para>The total cluster quota per account. Default value: 50. To request a quota increase beyond the default value, <a href="https://quotas.console.aliyun.com/products/csk/quotas">submit a request on the Quota Center page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("cluster_quota")]
        [Validation(Required=false)]
        public long? ClusterQuota { get; set; }

        [NameInMap("edge_improved_nodepool_quota")]
        [Validation(Required=false)]
        public DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota EdgeImprovedNodepoolQuota { get; set; }
        public class DescribeUserQuotaResponseBodyEdgeImprovedNodepoolQuota : TeaModel {
            [NameInMap("bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

        }

        /// <summary>
        /// <para>The node quota per cluster. Default value: 100. To request a quota increase beyond the default value, <a href="https://quotas.console.aliyun.com/products/csk/quotas">submit a request on the Quota Center page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("node_quota")]
        [Validation(Required=false)]
        public long? NodeQuota { get; set; }

        /// <summary>
        /// <para>The new quota items. If this field is returned, the values in this field take precedence.</para>
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public Dictionary<string, QuotasValue> Quotas { get; set; }

    }

}
