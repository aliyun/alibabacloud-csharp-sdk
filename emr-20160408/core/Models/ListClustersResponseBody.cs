// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClustersResponseBody : TeaModel {
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public ListClustersResponseBodyClusters Clusters { get; set; }
        public class ListClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public List<ListClustersResponseBodyClustersClusterInfo> ClusterInfo { get; set; }
            public class ListClustersResponseBodyClustersClusterInfo : TeaModel {
                public string ChargeType { get; set; }
                public string CreateResource { get; set; }
                public long? CreateTime { get; set; }
                public string DepositType { get; set; }
                public long? ExpiredTime { get; set; }
                public ListClustersResponseBodyClustersClusterInfoFailReason FailReason { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoFailReason : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMsg")]
                    [Validation(Required=false)]
                    public string ErrorMsg { get; set; }

                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                }
                public bool? HasUncompletedOrder { get; set; }
                public string Id { get; set; }
                public string K8sClusterId { get; set; }
                public string MachineType { get; set; }
                public string MetaStoreType { get; set; }
                public string Name { get; set; }
                public long? OperationId { get; set; }
                public string OrderList { get; set; }
                public ListClustersResponseBodyClustersClusterInfoOrderTaskInfo OrderTaskInfo { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoOrderTaskInfo : TeaModel {
                    [NameInMap("CurrentCount")]
                    [Validation(Required=false)]
                    public int? CurrentCount { get; set; }

                    [NameInMap("OrderIdList")]
                    [Validation(Required=false)]
                    public string OrderIdList { get; set; }

                    [NameInMap("TargetCount")]
                    [Validation(Required=false)]
                    public int? TargetCount { get; set; }

                }
                public int? Period { get; set; }
                public int? RunningTime { get; set; }
                public string Status { get; set; }
                public ListClustersResponseBodyClustersClusterInfoTags Tags { get; set; }
                public class ListClustersResponseBodyClustersClusterInfoTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListClustersResponseBodyClustersClusterInfoTagsTag> Tag { get; set; }
                    public class ListClustersResponseBodyClustersClusterInfoTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
                public string Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
