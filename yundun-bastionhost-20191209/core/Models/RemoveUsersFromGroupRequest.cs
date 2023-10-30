// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class RemoveUsersFromGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the user who you want to remove. The value is a JSON string. You can add up to 100 user IDs. If you specify multiple IDs, separate the IDs with commas (,).
        /// 
        /// >  You can call the [ListUsers](~~204522~~) operation to query the IDs of users.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The return code that indicates whether the call was successful. Valid values:
        /// 
        /// *   **OK**: The call was successful.
        /// 
        /// *   **UNEXPECTED**: An unknown error occurred.
        /// 
        /// *   **INVALID_ARGUMENT**: A request parameter is invalid.
        /// 
        /// > Make sure that the request parameters are valid and call the operation again.
        /// 
        /// *   **OBJECT_NOT_FOUND**: The specified object on which you want to perform the operation does not exist.
        /// 
        /// > Check whether the specified ID of the bastion host exists, whether the specified hosts exist, and whether the specified host IDs are valid. Then, call the operation again.
        /// 
        /// *   **OBJECT_AlREADY_EXISTS**: The specified object on which you want to perform the operation already exists.
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
