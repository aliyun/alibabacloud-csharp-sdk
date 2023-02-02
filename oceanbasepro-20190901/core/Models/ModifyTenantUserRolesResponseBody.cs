// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyTenantUserRolesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of database accounts in the tenant.
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyTenantUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyTenantUserRolesResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The name of the account.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The type of the account. Valid values:   
            /// - Admin: the super administrator account.   
            /// - Normal: a general account.
            /// </summary>
            [NameInMap("UserRole")]
            [Validation(Required=false)]
            public List<ModifyTenantUserRolesResponseBodyTenantUserUserRole> UserRole { get; set; }
            public class ModifyTenantUserRolesResponseBodyTenantUserUserRole : TeaModel {
                /// <summary>
                /// The name of the database (MySQL mode) or schema (Oracle mode).
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// Indicates whether the privilege was granted to the role.
                /// </summary>
                [NameInMap("IsSuccess")]
                [Validation(Required=false)]
                public bool? IsSuccess { get; set; }

                /// <summary>
                /// The role of the account.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

        }

    }

}
