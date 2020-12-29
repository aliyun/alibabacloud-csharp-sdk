// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ReservedInstances")]
        [Validation(Required=false)]
        public DescribeReservedInstancesResponseBodyReservedInstances ReservedInstances { get; set; }
        public class DescribeReservedInstancesResponseBodyReservedInstances : TeaModel {
            [NameInMap("ReservedInstance")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance> ReservedInstance { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance : TeaModel {
                public string CreationTime { get; set; }
                public string Status { get; set; }
                public string ReservedInstanceName { get; set; }
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }
                public string ReservedInstanceId { get; set; }
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags Tags { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag> Tag { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag : TeaModel {
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                    }

                }
                public string InstanceType { get; set; }
                public int? InstanceAmount { get; set; }
                public string OfferingType { get; set; }
                public string RegionId { get; set; }
                public string StartTime { get; set; }
                public string Description { get; set; }
                public string AllocationStatus { get; set; }
                public string ExpiredTime { get; set; }
                public string ResourceGroupId { get; set; }
                public string ZoneId { get; set; }
                public string Platform { get; set; }
                public string Scope { get; set; }
            }
        };

    }

}
