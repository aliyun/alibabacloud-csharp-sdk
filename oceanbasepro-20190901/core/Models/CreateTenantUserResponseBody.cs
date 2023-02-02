// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateTenantUserResponseBody : TeaModel {
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
        public List<CreateTenantUserResponseBodyTenantUser> TenantUser { get; set; }
        public class CreateTenantUserResponseBodyTenantUser : TeaModel {
            /// <summary>
            /// The roles of the accounts.
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<CreateTenantUserResponseBodyTenantUserRoles> Roles { get; set; }
            public class CreateTenantUserResponseBodyTenantUserRoles : TeaModel {
                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The role of the account.   
                /// In Oracle mode, a role is a schema-level role. Valid values:  
                /// 
                /// - ReadWrite: a role that has the read and write privileges, including CREATE TABLE, CREATE VIEW, CREATE PROCEDURE, CREATE SYNONYM, CREATE SEQUENCE, CREATE TRIGGER, CREATE TYPE, CREATE SESSION, EXECUTE ANY PROCEDURE, CREATE ANY OUTLINE, ALTER ANY OUTLINE, DROP ANY OUTLINE, CREATE ANY PROCEDURE, ALTER ANY PROCEDURE, DROP ANY PROCEDURE, CREATE ANY SEQUENCE, ALTER ANY SEQUENCE, DROP ANY SEQUENCE, CREATE ANY TYPE, ALTER ANY TYPE, DROP ANY TYPE, SYSKM, CREATE ANY TRIGGER, ALTER ANY TRIGGER, DROP ANY TRIGGER, CREATE PROFILE, ALTER PROFILE, and DROP PROFILE.   
                /// - ReadOnly: a role that has only the read-only privilege SELECT. 
                /// 
                /// In MySQL mode, a role is a database-level role. Valid values:  
                /// 
                /// - ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES. 
                /// - ReadOnly: a role that has only the read-only privilege SELECT.   
                /// - DDL: a role that has the DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.   
                /// - DML: a role that has the DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW. 
                /// 
                /// > <br>By default, an Oracle account has the read and write privileges on its own schema, which are not listed here.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The status of the database account. Valid values:    
            /// - Locked: The account is locked.   
            /// - ONLINE: The account is unlocked. The default status of a new account is ONLINE after it is created.
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            /// <summary>
            /// The type of the database account. Valid values:   
            ///  - Admin: the super administrator account.   
            ///  - Normal: a general account.
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
