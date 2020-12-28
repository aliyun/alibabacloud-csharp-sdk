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
        public List<DescribeReservedInstancesResponseBodyReservedInstances> ReservedInstances { get; set; }
        public class DescribeReservedInstancesResponseBodyReservedInstances : TeaModel {
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ReservedInstanceName")]
            [Validation(Required=false)]
            public string ReservedInstanceName { get; set; }

            [NameInMap("OperationLocks")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesOperationLocks> OperationLocks { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesOperationLocks : TeaModel {
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

            }

            [NameInMap("ReservedInstanceId")]
            [Validation(Required=false)]
            public string ReservedInstanceId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeReservedInstancesResponseBodyReservedInstancesTags> Tags { get; set; }
            public class DescribeReservedInstancesResponseBodyReservedInstancesTags : TeaModel {
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

            }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

            [NameInMap("OfferingType")]
            [Validation(Required=false)]
            public string OfferingType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("AllocationStatus")]
            [Validation(Required=false)]
            public string AllocationStatus { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

    }

}
