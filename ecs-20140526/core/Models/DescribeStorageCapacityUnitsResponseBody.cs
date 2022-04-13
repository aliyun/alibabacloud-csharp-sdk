// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageCapacityUnitsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageCapacityUnits")]
        [Validation(Required=false)]
        public DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnits StorageCapacityUnits { get; set; }
        public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnits : TeaModel {
            [NameInMap("StorageCapacityUnit")]
            [Validation(Required=false)]
            public List<DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnit> StorageCapacityUnit { get; set; }
            public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnit : TeaModel {
                public string AllocationStatus { get; set; }
                public int? Capacity { get; set; }
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ExpiredTime { get; set; }
                public string Name { get; set; }
                public string RegionId { get; set; }
                public string StartTime { get; set; }
                public string Status { get; set; }
                public string StorageCapacityUnitId { get; set; }
                public DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTags Tags { get; set; }
                public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTagsTag> Tag { get; set; }
                    public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
