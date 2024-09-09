// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDirRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The ID of the owner group for the directory. Valid values: 0 to 4294967295.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerGroupId")]
        [Validation(Required=false)]
        public int? OwnerGroupId { get; set; }

        /// <summary>
        /// The owner ID for the directory. Valid values: 0 to 4294967295.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public int? OwnerUserId { get; set; }

        /// <summary>
        /// The Portable Operating System Interface (POSIX) permissions applied to the root directory. The value is a valid octal number, such as 0755.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// Specifies whether to create a multi-level directory. Valid values:
        /// 
        /// *   true (default): If no multi-level directory exists, directories are created level by level.
        /// *   false: Only the last level of directory is created. An error message is returned because the parent directory does not exist.
        /// </summary>
        [NameInMap("Recursion")]
        [Validation(Required=false)]
        public bool? Recursion { get; set; }

        /// <summary>
        /// The directory name.
        /// 
        /// *   The directory must start with a forward slash (/).
        /// *   The directory can contain digits and letters.
        /// *   The directory can contain underscores (_), hyphens (-), and periods (.).
        /// *   The directory cannot contain symbolic links, such as the current directory (.), the upper-level directory (..), and other symbolic links.
        /// 
        /// > *   If the root directory does not exist, configure the information for directory creation. The system then automatically creates the specified root directory based on your settings.
        /// > *  If the root directory exists, you do not need to configure the information for directory creation. The configurations for directory creation are ignored even if you configure the information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RootDirectory")]
        [Validation(Required=false)]
        public string RootDirectory { get; set; }

    }

}
