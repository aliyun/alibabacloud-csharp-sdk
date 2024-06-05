// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotTasksRequest : TeaModel {
        /// <summary>
        /// The IDs of automatic snapshot policies.
        /// 
        /// You can specify a maximum of 100 policy IDs. If you want to query the tasks of multiple automatic snapshot policies, you must separate the policy IDs with commas (,).
        /// </summary>
        [NameInMap("AutoSnapshotPolicyIds")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyIds { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// You can specify a maximum of 100 file system IDs. If you want to query the snapshots of multiple file systems, you must separate the file system IDs with commas (,).
        /// </summary>
        [NameInMap("FileSystemIds")]
        [Validation(Required=false)]
        public string FileSystemIds { get; set; }

        /// <summary>
        /// The type of the file system.
        /// 
        /// Valid value: extreme, which indicates Extreme NAS file systems.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
