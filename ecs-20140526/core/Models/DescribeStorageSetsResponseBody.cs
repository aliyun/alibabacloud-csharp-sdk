// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageSetsResponseBody : TeaModel {
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
        /// <para>1</para>
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

        [NameInMap("StorageSets")]
        [Validation(Required=false)]
        public DescribeStorageSetsResponseBodyStorageSets StorageSets { get; set; }
        public class DescribeStorageSetsResponseBodyStorageSets : TeaModel {
            [NameInMap("StorageSet")]
            [Validation(Required=false)]
            public List<DescribeStorageSetsResponseBodyStorageSetsStorageSet> StorageSet { get; set; }
            public class DescribeStorageSetsResponseBodyStorageSetsStorageSet : TeaModel {
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                [NameInMap("StorageSetName")]
                [Validation(Required=false)]
                public string StorageSetName { get; set; }

                [NameInMap("StorageSetPartitionNumber")]
                [Validation(Required=false)]
                public int? StorageSetPartitionNumber { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeStorageSetsResponseBodyStorageSetsStorageSetTags Tags { get; set; }
                public class DescribeStorageSetsResponseBodyStorageSetsStorageSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeStorageSetsResponseBodyStorageSetsStorageSetTagsTag> Tag { get; set; }
                    public class DescribeStorageSetsResponseBodyStorageSetsStorageSetTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of storage sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
