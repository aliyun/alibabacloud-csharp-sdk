// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MoveCdsFileRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The processing mode of files that have the same name.
        /// 
        /// Valid values:
        /// 
        /// *   <!-- -->
        /// 
        ///     refuse
        /// 
        ///     <!-- -->
        /// 
        ///     : If you want to create a file that uses the same name as an existing file in the cloud, the system denies your request and returns the details of the existing file.
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     auto_rename
        /// 
        ///     <!-- -->
        /// 
        ///     : If you want to create a file that uses the same name as an existing file in the cloud, the system renames the file that you want to create by appending the current time point.
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     ignore
        /// 
        ///     <!-- -->
        /// 
        ///     : The system allows you to create a file that uses the same name as an existing file in the cloud.
        /// 
        ///     <!-- -->
        /// 
        /// *   <!-- -->
        /// 
        ///     over_write
        /// 
        ///     <!-- -->
        /// 
        ///     : After you create a file that uses the same name as an existing file in the cloud, the new file overwrites the existing file.
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("ConflictPolicy")]
        [Validation(Required=false)]
        public string ConflictPolicy { get; set; }

        /// <summary>
        /// The user ID that you want to use to access the cloud disk.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The ID of the file.
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The ID of the parent folder that you want to move. If you want to remove the root folder, set the value to root.
        /// </summary>
        [NameInMap("ParentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
