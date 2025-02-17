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

        /// <summary>
        /// <para>Details about the SCUs.</para>
        /// </summary>
        [NameInMap("StorageCapacityUnits")]
        [Validation(Required=false)]
        public DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnits StorageCapacityUnits { get; set; }
        public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnits : TeaModel {
            [NameInMap("StorageCapacityUnit")]
            [Validation(Required=false)]
            public List<DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnit> StorageCapacityUnit { get; set; }
            public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnit : TeaModel {
                /// <summary>
                /// <para>Indicates the allocation state of the SCU when the AllocationType parameter is set to Shared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>allocated: The SCU is allocated to other accounts.</description></item>
                /// <item><description>BeAllocated: The SCU is allocated from another account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>allocated</para>
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// <para>The capacity of the SCU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public int? Capacity { get; set; }

                /// <summary>
                /// <para>The time when the SCU was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-17T02:55Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the SCU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testScuDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the SCU expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-17T16:00Z</para>
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// <para>The name of the SCU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testScuName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region ID of the SCU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the SCU took effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-08-17T02:55Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the SCU. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Creating: The SCUs are being created.</description></item>
                /// <item><description>Active: The SCUs are in effect.</description></item>
                /// <item><description>Expired: The SCUs have expired.</description></item>
                /// <item><description>Pending: The SCUs have not taken effect.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the SCU.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scu-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("StorageCapacityUnitId")]
                [Validation(Required=false)]
                public string StorageCapacityUnitId { get; set; }

                /// <summary>
                /// <para>The tag key-value pairs of the SCU.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTags Tags { get; set; }
                public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTagsTag> Tag { get; set; }
                    public class DescribeStorageCapacityUnitsResponseBodyStorageCapacityUnitsStorageCapacityUnitTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of tag N.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
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
