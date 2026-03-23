// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListRCVClustersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VClusters")]
        [Validation(Required=false)]
        public List<ListRCVClustersResponseBodyVClusters> VClusters { get; set; }
        public class ListRCVClustersResponseBodyVClusters : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SupportDiskPerformanceLevel")]
            [Validation(Required=false)]
            public List<string> SupportDiskPerformanceLevel { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
