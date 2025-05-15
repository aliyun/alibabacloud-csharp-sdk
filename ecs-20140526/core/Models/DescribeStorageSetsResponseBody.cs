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

        /// <summary>
        /// <para>Details about the storage sets. The value of this parameter is an array that consists of StorageSet data.</para>
        /// </summary>
        [NameInMap("StorageSets")]
        [Validation(Required=false)]
        public DescribeStorageSetsResponseBodyStorageSets StorageSets { get; set; }
        public class DescribeStorageSetsResponseBodyStorageSets : TeaModel {
            [NameInMap("StorageSet")]
            [Validation(Required=false)]
            public List<DescribeStorageSetsResponseBodyStorageSetsStorageSet> StorageSet { get; set; }
            public class DescribeStorageSetsResponseBodyStorageSetsStorageSet : TeaModel {
                /// <summary>
                /// <para>The time when the storage set was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the storage set belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ss-bp1d6tsvznfghy7y****</para>
                /// </summary>
                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                /// <summary>
                /// <para>The name of the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testStorageSetName</para>
                /// </summary>
                [NameInMap("StorageSetName")]
                [Validation(Required=false)]
                public string StorageSetName { get; set; }

                /// <summary>
                /// <para>The maximum number of partitions supported by the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
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

                /// <summary>
                /// <para>The ID of the zone to which the storage set belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
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
