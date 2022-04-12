// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterResponseBody : TeaModel {
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public ListClusterResponseBodyClusterList ClusterList { get; set; }
        public class ListClusterResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<ListClusterResponseBodyClusterListCluster> Cluster { get; set; }
            public class ListClusterResponseBodyClusterListCluster : TeaModel {
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public int? ClusterType { get; set; }
                public int? Cpu { get; set; }
                public int? CpuUsed { get; set; }
                public long? CreateTime { get; set; }
                public string CsClusterId { get; set; }
                public string Description { get; set; }
                public string IaasProvider { get; set; }
                public int? Mem { get; set; }
                public int? MemUsed { get; set; }
                public int? NetworkMode { get; set; }
                public int? NodeNum { get; set; }
                public int? OversoldFactor { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public long? UpdateTime { get; set; }
                public string VpcId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
