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
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                [NameInMap("InstanceClusterName")]
                [Validation(Required=false)]
                public string InstanceClusterName { get; set; }

                [NameInMap("InstanceClusterStatus")]
                [Validation(Required=false)]
                public string InstanceClusterStatus { get; set; }

                [NameInMap("InstanceClusterType")]
                [Validation(Required=false)]
                public string InstanceClusterType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
