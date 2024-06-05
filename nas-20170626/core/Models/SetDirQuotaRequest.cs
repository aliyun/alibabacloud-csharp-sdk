// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetDirQuotaRequest : TeaModel {
        /// <summary>
        /// The number of files that a user can create in the directory.
        /// 
        /// This number includes the number of files, subdirectories, and special files.
        /// 
        /// If you set the QuotaType parameter to Enforcement, you must specify at least one of the SizeLimit and FileCountLimit parameters.
        /// </summary>
        [NameInMap("FileCountLimit")]
        [Validation(Required=false)]
        public long? FileCountLimit { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The absolute path of a directory.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// The type of the quota.
        /// 
        /// Valid values:
        /// 
        /// *   Accounting: a statistical quota. If you set this parameter to Accounting, NAS calculates only the storage usage of the directory.
        /// *   Enforcement: a restricted quota. If you set this parameter to Enforcement and the storage usage exceeds the quota, you can no longer create files or subdirectories for the directory, or write data to the directory.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuotaType")]
        [Validation(Required=false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// The size of files that a user can create in the directory.
        /// 
        /// Unit: GiB.
        /// 
        /// If you set the QuotaType parameter to Enforcement, you must specify at least one of the SizeLimit and FileCountLimit parameters.
        /// </summary>
        [NameInMap("SizeLimit")]
        [Validation(Required=false)]
        public long? SizeLimit { get; set; }

        /// <summary>
        /// The UID or GID of the user for whom you want to set a directory quota.
        /// 
        /// This parameter is required and valid only if the UserType parameter is set to Uid or Gid.
        /// 
        /// Examples:
        /// 
        /// *   If you want to set a directory quota for a user whose UID is 500, set the UserType parameter to Uid and set the UserId parameter to 500.
        /// *   If you want to set a directory quota for a user group whose GID is 100, set the UserType parameter to Gid and set the UserId parameter to 100.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The type of the user.
        /// 
        /// Valid values:
        /// 
        /// *   Uid: user ID
        /// *   Gid: user group ID
        /// *   AllUsers: all users
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
