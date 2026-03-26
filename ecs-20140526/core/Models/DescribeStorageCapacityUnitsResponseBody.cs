// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageCapacityUnitsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
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
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageCapacityUnitId")]
                [Validation(Required=false)]
                public string StorageCapacityUnitId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

        }

        /// <summary>
        /// <para>The total number of SCUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
