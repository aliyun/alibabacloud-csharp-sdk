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
                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DeleteTime")]
                [Validation(Required=false)]
                public string DeleteTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("MajorVersion")]
                [Validation(Required=false)]
                public string MajorVersion { get; set; }

                [NameInMap("ModuleStackVersion")]
                [Validation(Required=false)]
                public string ModuleStackVersion { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

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
        public long? TotalCount { get; set; }

    }

}
