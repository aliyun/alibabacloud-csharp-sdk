// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeAutoProvisioningGroupInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeAutoProvisioningGroupInstancesResponseBodyInstancesInstance : TeaModel {
                public int? CPU { get; set; }
                public string CreationTime { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public bool? IoOptimized { get; set; }
                public bool? IsSpot { get; set; }
                public int? Memory { get; set; }
                public string NetworkType { get; set; }
                public string OsType { get; set; }
                public string RegionId { get; set; }
                public string Status { get; set; }
                public string ZoneId { get; set; }
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
