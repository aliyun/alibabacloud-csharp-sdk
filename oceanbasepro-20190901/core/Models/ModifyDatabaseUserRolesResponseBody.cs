// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyDatabaseUserRolesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The account information.
        /// </summary>
        [NameInMap("TenantUser")]
        [Validation(Required=false)]
        public ModifyDatabaseUserRolesResponseBodyTenantUser TenantUser { get; set; }
        public class ModifyDatabaseUserRolesResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The accounts that have privileges on the database.
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<ModifyDatabaseUserRolesResponseBodyTenantUserUsers> Users { get; set; }
            public class ModifyDatabaseUserRolesResponseBodyTenantUserUsers : TeaModel {
                /// <summary>
                /// The role of the account.   
                /// In MySQL mode, a role is a database-level role. Valid values:
                /// - ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.
                /// - ReadOnly: a role that has only the read-only privilege SELECT. 
                /// - DDL: a role that has the DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW. 
                /// - DML: a role that has the DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// The name of the account.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
