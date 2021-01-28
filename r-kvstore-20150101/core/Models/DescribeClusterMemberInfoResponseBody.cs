// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeClusterMemberInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClusterChildren")]
        [Validation(Required=false)]
        public List<DescribeClusterMemberInfoResponseBodyClusterChildren> ClusterChildren { get; set; }
        public class DescribeClusterMemberInfoResponseBodyClusterChildren : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("DiskSizeMB")]
            [Validation(Required=false)]
            public int? DiskSizeMB { get; set; }

            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

            [NameInMap("BinlogRetentionDays")]
            [Validation(Required=false)]
            public int? BinlogRetentionDays { get; set; }

            [NameInMap("Connections")]
            [Validation(Required=false)]
            public long? Connections { get; set; }

            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }

            [NameInMap("ReplicaSize")]
            [Validation(Required=false)]
            public int? ReplicaSize { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
