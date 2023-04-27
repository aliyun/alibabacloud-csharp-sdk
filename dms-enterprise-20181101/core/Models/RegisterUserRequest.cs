// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class RegisterUserRequest : TeaModel {
        /// <summary>
        /// The mobile number of the user.
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **RegisterUser**.
        /// </summary>
        [NameInMap("RoleNames")]
        [Validation(Required=false)]
        public string RoleNames { get; set; }

        /// <summary>
        /// The role that you want to assign to the user. Valid values:
        /// 
        /// *   **USER**: a regular user role
        /// *   **DBA**: a database administrator (DBA) role
        /// *   **ADMIN**: a DMS administrator role
        /// *   **SECURITY_ADMIN**: a security administrator role
        /// 
        /// >  If you do not specify this parameter, the regular user role is assigned to the user by default. You can assign one or more roles to the user. Separate multiple roles with commas (,).
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("UserNick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
