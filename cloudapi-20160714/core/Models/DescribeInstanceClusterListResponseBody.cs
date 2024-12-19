// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterListResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance cluster list.</para>
        /// </summary>
        [NameInMap("InstanceClusters")]
        [Validation(Required=false)]
        public DescribeInstanceClusterListResponseBodyInstanceClusters InstanceClusters { get; set; }
        public class DescribeInstanceClusterListResponseBodyInstanceClusters : TeaModel {
            [NameInMap("InstanceCluster")]
            [Validation(Required=false)]
            public List<DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster> InstanceCluster { get; set; }
            public class DescribeInstanceClusterListResponseBodyInstanceClustersInstanceCluster : TeaModel {
                /// <summary>
                /// <para>The time when the cluster was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-14T17:46:59+08:00</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The cluster description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test TrafficControl</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apigateway-cluster-hz-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceClusterId")]
                [Validation(Required=false)]
                public string InstanceClusterId { get; set; }

                /// <summary>
                /// <para>The cluster name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-cluster</para>
                /// </summary>
                [NameInMap("InstanceClusterName")]
                [Validation(Required=false)]
                public string InstanceClusterName { get; set; }

                /// <summary>
                /// <para>The cluster status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("InstanceClusterStatus")]
                [Validation(Required=false)]
                public string InstanceClusterStatus { get; set; }

                /// <summary>
                /// <para>The cluster type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("InstanceClusterType")]
                [Validation(Required=false)]
                public string InstanceClusterType { get; set; }

                /// <summary>
                /// <para>The time when the cluster was last modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-12T10:11:08+08:00</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The region ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
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
