// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// **
        /// 
        /// Valid values: 10, 20, 50, and 100.**** Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The role that is assigned to the user. Valid values:
        /// 
        /// *   **USER**: a regular user.
        /// *   **DBA** : a database administrator (DBA).
        /// *   **ADMIN**: a Data Management (DMS) administrator.
        /// *   **SECURITY_ADMIN**: a security administrator.
        /// *   **STRUCT_READ_ONLY**: a schema read-only user.
        /// 
        /// >  To check your role, move the pointer over the profile picture in the upper-right corner of the DMS console.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// The search keyword. Fuzzy match is supported.
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The status of the user. Valid values:
        /// 
        /// *   **NORMAL**: The user is normal.
        /// *   **DISABLE**: The user is disabled.
        /// *   **DELETE**: The user is deleted.
        /// </summary>
        [NameInMap("UserState")]
        [Validation(Required=false)]
        public string UserState { get; set; }

    }

}
