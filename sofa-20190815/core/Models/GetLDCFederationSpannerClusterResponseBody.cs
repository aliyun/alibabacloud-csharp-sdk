// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCFederationSpannerClusterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLDCFederationSpannerClusterResponseBodyData Data { get; set; }
        public class GetLDCFederationSpannerClusterResponseBodyData : TeaModel {
            [NameInMap("LocalClusters")]
            [Validation(Required=false)]
            public List<GetLDCFederationSpannerClusterResponseBodyDataLocalClusters> LocalClusters { get; set; }
            public class GetLDCFederationSpannerClusterResponseBodyDataLocalClusters : TeaModel {
                public string Az { get; set; }
                public string ClusterName { get; set; }
                public string Message { get; set; }
                public string Phase { get; set; }
                public string SpannerClusterId { get; set; }
                public string State { get; set; }
                public List<GetLDCFederationSpannerClusterResponseBodyDataLocalClustersSubClustersDetails> SubClustersDetails { get; set; }
                public class GetLDCFederationSpannerClusterResponseBodyDataLocalClustersSubClustersDetails : TeaModel {
                    public long? Available { get; set; }
                    public long? Desired { get; set; }
                    public string Image { get; set; }
                    public string Message { get; set; }
                    public long? Ready { get; set; }
                    public string State { get; set; }
                    public long? Updated { get; set; }
                    public string Version { get; set; }
                    public List<GetLDCFederationSpannerClusterResponseBodyDataLocalClustersSubClustersDetailsLabels> Labels { get; set; }
                    public class GetLDCFederationSpannerClusterResponseBodyDataLocalClustersSubClustersDetailsLabels : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                }
            }
            [NameInMap("ClusterDetail")]
            [Validation(Required=false)]
            public GetLDCFederationSpannerClusterResponseBodyDataClusterDetail ClusterDetail { get; set; }
            public class GetLDCFederationSpannerClusterResponseBodyDataClusterDetail : TeaModel {
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public string CreateTimestamp { get; set; }

                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                [NameInMap("ExpectClusterState")]
                [Validation(Required=false)]
                public string ExpectClusterState { get; set; }

                [NameInMap("Flavor")]
                [Validation(Required=false)]
                public string Flavor { get; set; }

                [NameInMap("HostNetwork")]
                [Validation(Required=false)]
                public bool? HostNetwork { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Instances")]
                [Validation(Required=false)]
                public long? Instances { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public long? Mem { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Tenant")]
                [Validation(Required=false)]
                public string Tenant { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public string UpdateTimestamp { get; set; }

                [NameInMap("WorkspaceGroup")]
                [Validation(Required=false)]
                public string WorkspaceGroup { get; set; }

            }
        };

    }

}
