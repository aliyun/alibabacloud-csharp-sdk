// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFileSystemsRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// - Sample ID of a General-purpose NAS file system: 31a8e4****.
        /// - The IDs of Extreme NAS file systems must start with extreme-, for example, extreme-0015****.
        /// - The IDs of Cloud Parallel File Storage (CPFS) file systems must start with cpfs-, for example, cpfs-125487****.
        /// > CPFS file systems are available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid values:
        /// - all (default): all types
        /// - standard: General-purpose NAS file system
        /// - extreme: Extreme NAS file system
        /// - cpfs: CPFS file system
        /// > CPFS file systems are available only on the China site (aliyun.com).
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The resource group ID.
        /// 
        /// You can log on to the [Resource Management console](https://resourcemanager.console.aliyun.com/resource-groups?) to view resource group IDs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The details about the tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeFileSystemsRequestTag> Tag { get; set; }
        public class DescribeFileSystemsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource.
            /// 
            /// Limits:
            /// - Valid values of N: 1 to 20.
            /// - The tag key must be 1 to 128 characters in length.
            /// - The tag key cannot start with aliyun or acs:.
            /// - The tag key cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource.
            /// 
            /// Limits:
            /// - Valid values of N: 1 to 20.
            /// - The tag value must be 1 to 128 characters in length.
            /// - The tag value cannot start with aliyun or acs:.
            /// - The tag value cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC).
        /// 
        /// If you want to mount the file system on an Elastic Compute Service (ECS) instance, the file system and the ECS instance must reside in the same VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
