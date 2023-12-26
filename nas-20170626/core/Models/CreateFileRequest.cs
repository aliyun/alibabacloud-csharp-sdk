// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateFileRequest : TeaModel {
        /// <summary>
        /// The ID of the file system.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The ID of the portable account. The ID must be a 16-digit string. The string can contain digits and lowercase letters.
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// Specifies whether to share the directory. Valid values:
        /// 
        /// *   false (default): does not share the directory.
        /// *   true: shares the directory.
        /// 
        /// > *   This parameter takes effect only if the Type parameter is set to Directory and the Owner parameter is not empty.
        /// > *   The permissions on a directory can be inherited by the owner. The owner has read and write permissions on the subdirectories and subfiles created in the directory, even if they are created by others.
        /// </summary>
        [NameInMap("OwnerAccessInheritable")]
        [Validation(Required=false)]
        public bool? OwnerAccessInheritable { get; set; }

        /// <summary>
        /// The absolute path of the directory or file. The path must start and end with a forward slash (/) and must be 2 to 1024 characters in length.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The type of the object. Valid values:
        /// 
        /// *   File
        /// *   Directory
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
