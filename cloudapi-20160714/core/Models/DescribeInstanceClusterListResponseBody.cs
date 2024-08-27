// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterListResponseBody : TeaModel {
        [NameInMap("InstanceClusters")]
        [Validation(Required=false)]
        public DescribeInstanceClusterListResponseBodyInstanceClusters InstanceClusters { get; set; }
        public class DescribeInstanceClusterListResponseBodyInstanceClusters : TeaModel {
            [NameInMap("InstanceCluster")]
            [Validation(Required=false)]
            public List<DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster> InstanceCluster { get; set; }
            public class DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster : TeaModel {
                /// <summary>
                /// The time when the cluster was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The cluster description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The cluster ID.
                /// </summary>
                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                /// <summary>
                /// The cluster name.
                /// </summary>
                [NameInMap("InstanceClusterName")]
                [Validation(Required=false)]
                public string InstanceClusterName { get; set; }

                /// <summary>
                /// The cluster status.
                /// </summary>
                [NameInMap("InstanceClusterStatus")]
                [Validation(Required=false)]
                public string InstanceClusterStatus { get; set; }

                /// <summary>
                /// The cluster type.
                /// </summary>
                [NameInMap("InstanceClusterType")]
                [Validation(Required=false)]
                public string InstanceClusterType { get; set; }

                /// <summary>
                /// The time when the cluster was last modified. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// The region ID of the cluster.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
