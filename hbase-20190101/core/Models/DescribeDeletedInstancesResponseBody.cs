// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeDeletedInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeDeletedInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeDeletedInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeDeletedInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeDeletedInstancesResponseBodyInstancesInstance : TeaModel {
                public string Status { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
                public string ParentId { get; set; }
                public string ClusterType { get; set; }
                public string InstanceName { get; set; }
                public string DeleteTime { get; set; }
                public string ZoneId { get; set; }
                public string ModuleStackVersion { get; set; }
                public string Engine { get; set; }
                public string MajorVersion { get; set; }
                public string CreatedTime { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
