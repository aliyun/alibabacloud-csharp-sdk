// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSClustersResponseBody : TeaModel {
        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public DescribeGWSClustersResponseBodyClusters Clusters { get; set; }
        public class DescribeGWSClustersResponseBodyClusters : TeaModel {
            [NameInMap("ClusterInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSClustersResponseBodyClustersClusterInfo> ClusterInfo { get; set; }
            public class DescribeGWSClustersResponseBodyClustersClusterInfo : TeaModel {
                public string ClusterId { get; set; }
                public string CreateTime { get; set; }
                public int? InstanceCount { get; set; }
                public string Status { get; set; }
                public string VpcId { get; set; }
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
