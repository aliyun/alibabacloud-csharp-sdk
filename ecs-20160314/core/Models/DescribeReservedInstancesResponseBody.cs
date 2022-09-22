// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeReservedInstancesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReservedInstances")]
        [Validation(Required=false)]
        public DescribeReservedInstancesResponseBodyReservedInstances ReservedInstances { get; set; }
        public class DescribeReservedInstancesResponseBodyReservedInstances : TeaModel {
            [NameInMap("ReservedInstance")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance> ReservedInstance { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance : TeaModel {
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("OfferingType")]
                [Validation(Required=false)]
                public string OfferingType { get; set; }

                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
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

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                [NameInMap("ReservedInstanceName")]
                [Validation(Required=false)]
                public string ReservedInstanceName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags Tags { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag> Tag { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
