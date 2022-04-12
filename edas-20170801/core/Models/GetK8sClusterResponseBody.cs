// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterResponseBody : TeaModel {
        [NameInMap("ClusterPage")]
        [Validation(Required=false)]
        public GetK8sClusterResponseBodyClusterPage ClusterPage { get; set; }
        public class GetK8sClusterResponseBodyClusterPage : TeaModel {
            [NameInMap("ClusterList")]
            [Validation(Required=false)]
            public GetK8sClusterResponseBodyClusterPageClusterList ClusterList { get; set; }
            public class GetK8sClusterResponseBodyClusterPageClusterList : TeaModel {
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public List<GetK8sClusterResponseBodyClusterPageClusterListCluster> Cluster { get; set; }
                public class GetK8sClusterResponseBodyClusterPageClusterListCluster : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterImportStatus")]
                    [Validation(Required=false)]
                    public int? ClusterImportStatus { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("ClusterStatus")]
                    [Validation(Required=false)]
                    public int? ClusterStatus { get; set; }

                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public int? ClusterType { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("CsClusterId")]
                    [Validation(Required=false)]
                    public string CsClusterId { get; set; }

                    [NameInMap("CsClusterStatus")]
                    [Validation(Required=false)]
                    public string CsClusterStatus { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("NetworkMode")]
                    [Validation(Required=false)]
                    public int? NetworkMode { get; set; }

                    [NameInMap("NodeNum")]
                    [Validation(Required=false)]
                    public int? NodeNum { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SubNetCidr")]
                    [Validation(Required=false)]
                    public string SubNetCidr { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

            }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
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
