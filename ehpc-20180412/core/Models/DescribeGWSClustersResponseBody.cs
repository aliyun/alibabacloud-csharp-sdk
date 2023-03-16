// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSClustersResponseBody : TeaModel {
        /// <summary>
        /// The type of the account. Valid values:
        /// 
        /// *   sub: a RAM user.
        /// *   parent: an Alibaba Cloud account.
        /// </summary>
        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        /// <summary>
        /// The information of the visualization services.
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public DescribeGWSClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeGWSClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSClustersResponseBodyClustersClusterInfo> ClusterInfo { get; set; }
            public class DescribeGWSClustersResponseBodyClustersClusterInfo : TeaModel {
                /// <summary>
                /// The ID of the visualization service.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The time when the visualization service was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The number of visualization instances.
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public int? InstanceCount { get; set; }

                /// <summary>
                /// The status of the visualization services. Valid values:
                /// 
                /// *   creating: The service is being created.
                /// *   starting: The service is being started.
                /// *   running: The service is running.
                /// *   deleted: The service is deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC).
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
