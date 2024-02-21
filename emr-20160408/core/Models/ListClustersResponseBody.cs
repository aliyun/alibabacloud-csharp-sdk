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
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CreateResource")]
                [Validation(Required=false)]
                public string CreateResource { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DepositType")]
                [Validation(Required=false)]
                public string DepositType { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public long? ExpiredTime { get; set; }

                [NameInMap("FailReason")]
                [Validation(Required=false)]
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

                [NameInMap("HasUncompletedOrder")]
                [Validation(Required=false)]
                public bool? HasUncompletedOrder { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("K8sClusterId")]
                [Validation(Required=false)]
                public string K8sClusterId { get; set; }

                [NameInMap("MachineType")]
                [Validation(Required=false)]
                public string MachineType { get; set; }

                [NameInMap("MetaStoreType")]
                [Validation(Required=false)]
                public string MetaStoreType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OperationId")]
                [Validation(Required=false)]
                public long? OperationId { get; set; }

                [NameInMap("OrderList")]
                [Validation(Required=false)]
                public string OrderList { get; set; }

                [NameInMap("OrderTaskInfo")]
                [Validation(Required=false)]
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

                [NameInMap("Period")]
                [Validation(Required=false)]
                public int? Period { get; set; }

                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public int? RunningTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
