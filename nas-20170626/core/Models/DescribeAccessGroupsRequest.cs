// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAccessGroupsRequest : TeaModel {
        /// <summary>
        /// The name of the permission group.
        /// 
        /// Limits:
        /// 
        /// *   The name must be 3 to 64 characters in length.
        /// *   The name must start with a letter and can contain letters, digits, underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid values:
        /// 
        /// *   standard (default): General-purpose NAS file system
        /// *   extreme: Extreme NAS file system
        /// *   cpfs: Cloud Parallel File Storage (CPFS) file system
        /// 
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
        /// Specifies whether to display the creation time of the permission group in UTC.
        /// 
        /// Valid values:
        /// 
        /// *   true (default): The time is displayed in UTC.
        /// *   false: The time is not displayed in UTC.
        /// </summary>
        [NameInMap("UseUTCDateTime")]
        [Validation(Required=false)]
        public bool? UseUTCDateTime { get; set; }

    }

}
