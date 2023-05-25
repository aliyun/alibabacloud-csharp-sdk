// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeHpcClustersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the HPC cluster.
        /// </summary>
        [NameInMap("HpcClusters")]
        [Validation(Required=false)]
        public DescribeHpcClustersResponseBodyHpcClusters HpcClusters { get; set; }
        public class DescribeHpcClustersResponseBodyHpcClusters : TeaModel {
            [NameInMap("HpcCluster")]
            [Validation(Required=false)]
            public List<DescribeHpcClustersResponseBodyHpcClustersHpcCluster> HpcCluster { get; set; }
            public class DescribeHpcClustersResponseBodyHpcClustersHpcCluster : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the HPC cluster.
                /// </summary>
                [NameInMap("HpcClusterId")]
                [Validation(Required=false)]
                public string HpcClusterId { get; set; }

                /// <summary>
                /// The description of the HPC cluster.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The total number of HPC clusters queried.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the HPC clusters. The value is an array that consists of the information of each HPC cluster.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
