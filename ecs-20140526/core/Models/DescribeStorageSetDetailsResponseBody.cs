// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeStorageSetDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the disks or Shared Block Storage devices in the storage set.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeStorageSetDetailsResponseBodyDisks Disks { get; set; }
        public class DescribeStorageSetDetailsResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeStorageSetDetailsResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeStorageSetDetailsResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// <para>The category of the disk or Shared Block Storage device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The time when the disk or Shared Block Storage device was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the disk or Shared Block Storage device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The name of the disk or Shared Block Storage device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDiskName</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>The region to which the disk or Shared Block Storage device belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ss-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                /// <summary>
                /// <para>The number of partitions in the storage set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("StorageSetPartitionNumber")]
                [Validation(Required=false)]
                public int? StorageSetPartitionNumber { get; set; }

                /// <summary>
                /// <para>The zone to which the disk or Shared Block Storage device belongs.</para>
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
        /// <para>49765E79-0D5D-4451-B3AE-580A20831846</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of storage sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
