// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifySmbAclRequest : TeaModel {
        /// <summary>
        /// Specifies whether to allow anonymous access. Valid values:
        /// 
        /// *   true: The file system allows anonymous access.
        /// *   false (default): The file system denies anonymous access.
        /// </summary>
        [NameInMap("EnableAnonymousAccess")]
        [Validation(Required=false)]
        public bool? EnableAnonymousAccess { get; set; }

        /// <summary>
        /// Specifies whether to enable encryption in transit. Valid values:
        /// 
        /// *   true: enables encryption in transit.
        /// *   false (default): disables encryption in transit.
        /// </summary>
        [NameInMap("EncryptData")]
        [Validation(Required=false)]
        public bool? EncryptData { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The home directory of each user. Each user-specific home directory must meet the following requirements:
        /// 
        /// *   Each segment starts with a forward slash (/) or a backward slash (\\\\).
        /// *   Each segment does not contain the following special characters: `<>":|?*`.
        /// *   Each segment is 0 to 255 characters in length.
        /// *   The total length is 0 to 32,767 characters.
        /// 
        /// For example, if you create a user named A and the home directory is `/home`, the file system automatically creates a directory named `/home/A` when User A logs on to the file system. If the `/home/A` directory already exists, the file system does not create the directory.
        /// 
        /// > User A must have the permissions to create folders in the \\home directory. Otherwise, the file system cannot create the `/home/A` directory when User A logs on to the file system.
        /// </summary>
        [NameInMap("HomeDirPath")]
        [Validation(Required=false)]
        public string HomeDirPath { get; set; }

        /// <summary>
        /// The string that is generated after the system encodes the keytab file by using Base64.
        /// </summary>
        [NameInMap("Keytab")]
        [Validation(Required=false)]
        public string Keytab { get; set; }

        /// <summary>
        /// The string that is generated after the system encodes the keytab file by using MD5.
        /// </summary>
        [NameInMap("KeytabMd5")]
        [Validation(Required=false)]
        public string KeytabMd5 { get; set; }

        /// <summary>
        /// Specifies whether to deny access from non-encrypted clients. Valid values:
        /// 
        /// *   true: The file system denies access from non-encrypted clients.
        /// *   false (default): The file system allows access from non-encrypted clients.
        /// </summary>
        [NameInMap("RejectUnencryptedAccess")]
        [Validation(Required=false)]
        public bool? RejectUnencryptedAccess { get; set; }

        /// <summary>
        /// The ID of a super admin. The ID must meet the following requirements:
        /// 
        /// *   The ID starts with `S` and does not contain letters except S.
        /// *   The ID contains at least three hyphens (-) as delimiters.
        /// 
        /// Examples: `S-1-5-22` and `S-1-5-22-23`.
        /// </summary>
        [NameInMap("SuperAdminSid")]
        [Validation(Required=false)]
        public string SuperAdminSid { get; set; }

    }

}
