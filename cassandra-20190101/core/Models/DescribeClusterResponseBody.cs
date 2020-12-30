// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeClusterResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public DescribeClusterResponseBodyCluster Cluster { get; set; }
        public class DescribeClusterResponseBodyCluster : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public DescribeClusterResponseBodyClusterTags Tags { get; set; }
            public class DescribeClusterResponseBodyClusterTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<DescribeClusterResponseBodyClusterTagsTag> Tag { get; set; }
                public class DescribeClusterResponseBodyClusterTagsTag : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }
            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public int? AutoRenewPeriod { get; set; }
            [NameInMap("IsLatestVersion")]
            [Validation(Required=false)]
            public bool? IsLatestVersion { get; set; }
            [NameInMap("DataCenterCount")]
            [Validation(Required=false)]
            public int? DataCenterCount { get; set; }
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }
            [NameInMap("MajorVersion")]
            [Validation(Required=false)]
            public string MajorVersion { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
        };

    }

}
