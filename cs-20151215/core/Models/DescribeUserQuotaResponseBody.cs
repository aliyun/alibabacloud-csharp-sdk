// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeUserQuotaResponseBody : TeaModel {
        [NameInMap("amk_cluster_quota")]
        [Validation(Required=false)]
        public long? AmkClusterQuota { get; set; }

        [NameInMap("ask_cluster_quota")]
        [Validation(Required=false)]
        public long? AskClusterQuota { get; set; }

        [NameInMap("cluster_nodepool_quota")]
        [Validation(Required=false)]
        public long? ClusterNodepoolQuota { get; set; }

        [NameInMap("cluster_quota")]
        [Validation(Required=false)]
        public long? ClusterQuota { get; set; }

        [NameInMap("node_quota")]
        [Validation(Required=false)]
        public long? NodeQuota { get; set; }

    }

}
