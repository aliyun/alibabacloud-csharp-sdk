// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyFileSystemRequest : TeaModel {
        /// <summary>
        /// The description of the file system.
        /// 
        /// Limits:
        /// 
        /// *   The description must be 2 to 128 characters in length.
        /// *   It must start with a letter but cannot start with `http://` or `https://`.
        /// *   The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// *   Sample ID of a General-purpose NAS file system: `31a8e4****`.
        /// *   The IDs of Extreme NAS file systems must start with `extreme-`. Example: `extreme-0015****`.
        /// *   The IDs of Cloud Paralleled File System (CPFS) file systems must start with `cpfs-`. Example: `cpfs-125487****`.
        /// >CPFS file systems are available only on the China site (aliyun.com).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The options.
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public ModifyFileSystemRequestOptions Options { get; set; }
        public class ModifyFileSystemRequestOptions : TeaModel {
            /// <summary>
            /// Specifies whether to enable the oplock feature. Valid values:
            /// 
            /// *   true: enables the feature.
            /// *   false: disables the feature.
            /// 
            /// >  Only Server Message Block (SMB) file systems support this feature.
            /// </summary>
            [NameInMap("EnableOplock")]
            [Validation(Required=false)]
            public bool? EnableOplock { get; set; }

        }

    }

}
