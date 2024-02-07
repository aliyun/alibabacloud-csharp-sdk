// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateAccessAssignmentRequest : TeaModel {
        /// <summary>
        /// The ID of the access configuration.
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// The ID of the directory.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The ID of the CloudSSO identity.
        /// 
        /// *   If you set `PrincipalType` to `User`, set `PrincipalId` to the ID of the CloudSSO user.
        /// *   If you set `PrincipalType` to `Group`, set `PrincipalId` to the ID of the CloudSSO group.
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// The type of the CloudSSO identity. Valid values:
        /// 
        /// *   User
        /// *   Group
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// The ID of the task object.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The type of the task object. Set the value to RD-Account, which specifies the accounts in the resource directory.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
