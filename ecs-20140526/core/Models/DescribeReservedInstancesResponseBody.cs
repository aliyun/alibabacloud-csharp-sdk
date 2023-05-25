// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeReservedInstancesResponseBody : TeaModel {
        /// <summary>
        /// The returned page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the reserved instances.
        /// </summary>
        [NameInMap("ReservedInstances")]
        [Validation(Required=false)]
        public DescribeReservedInstancesResponseBodyReservedInstances ReservedInstances { get; set; }
        public class DescribeReservedInstancesResponseBodyReservedInstances : TeaModel {
            [NameInMap("ReservedInstance")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance> ReservedInstance { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstance : TeaModel {
                /// <summary>
                /// Indicates the allocation status of the reserved instance when the AllocationType parameter is set to Shared. Valid values:
                /// 
                /// *   allocated: The reserved instance is allocated to another account.
                /// *   beAllocated: The reserved instance is allocated by another account.
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The expiration time.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The number of pay-as-you-go instances that are of the same instance type as the reserved instance and can be matched to the reserved instance.
                /// </summary>
                [NameInMap("InstanceAmount")]
                [Validation(Required=false)]
                public int? InstanceAmount { get; set; }

                /// <summary>
                /// The instance type of the pay-as-you-go instances that can be matched to the reserved instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The payment options for the reserved instance.
                /// </summary>
                [NameInMap("OfferingType")]
                [Validation(Required=false)]
                public string OfferingType { get; set; }

                /// <summary>
                /// Details about the lock status of the reserved instance.
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks OperationLocks { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceOperationLocksOperationLock : TeaModel {
                        /// <summary>
                        /// The reason why the instance is locked.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// The operating system of the image used by the instance. Valid values:
                /// 
                /// *   Windows: Windows Server operating system
                /// *   Linux: Linux and UNIX-like operating system
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The ID of the region where the instance resides.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The reserved instance ID.
                /// </summary>
                [NameInMap("ReservedInstanceId")]
                [Validation(Required=false)]
                public string ReservedInstanceId { get; set; }

                /// <summary>
                /// The name.
                /// </summary>
                [NameInMap("ReservedInstanceName")]
                [Validation(Required=false)]
                public string ReservedInstanceName { get; set; }

                /// <summary>
                /// The resource group ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates range.
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// The validation time.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Details about the reserved instance tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags Tags { get; set; }
                public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag> Tag { get; set; }
                    public class DescribeReservedInstancesResponseBodyReservedInstancesReservedInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the reserved instance tag N.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The value of the reserved instance tag N.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The total number of reserved instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
