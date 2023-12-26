// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid values:
        /// 
        /// *   all: all types of file systems
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

    }

}
