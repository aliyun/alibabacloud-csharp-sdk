// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelDirQuotaRequest : TeaModel {
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
        /// The UID or GID of a user for whom you want to cancel the directory quota.
        /// 
        /// This parameter is required and valid only if the UserType parameter is set to Uid or Gid.
        /// 
        /// Examples:
        /// 
        /// *   If you want to cancel a quota for a user whose UID is 500, set the UserType parameter to Uid and set the UserId parameter to 500.
        /// *   If you want to cancel a quota for a group whose GID is 100, set the UserType parameter to Gid and set the UserId parameter to 100.
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
