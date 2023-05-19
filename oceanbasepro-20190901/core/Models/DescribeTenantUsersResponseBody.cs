// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantUsersResponseBody : TeaModel {
        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the database account. Valid values:    
        /// - Admin: the super administrator account.   
        /// - NORMAL: a general account.
        /// </summary>
        [NameInMap("TenantUsers")]
        [Validation(Required=false)]
        public List<DescribeTenantUsersResponseBodyTenantUsers> TenantUsers { get; set; }
        public class DescribeTenantUsersResponseBodyTenantUsers : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<DescribeTenantUsersResponseBodyTenantUsersDatabases> Databases { get; set; }
            public class DescribeTenantUsersResponseBodyTenantUsersDatabases : TeaModel {
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 所属集群Id
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 所属租户Id
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// The role of the account.   
        /// In Oracle mode, a role is a schema-level role. Valid values:  
        /// - ReadWrite: a role that has the read and write privileges, including: CREATE TABLE, CREATE VIEW, CREATE PROCEDURE, CREATE SYNONYM, CREATE SEQUENCE, CREATE TRIGGER, CREATE TYPE, CREATE SESSION, EXECUTE ANY PROCEDURE, CREATE ANY OUTLINE, ALTER ANY OUTLINE, DROP ANY OUTLINE, CREATE ANY PROCEDURE, ALTER ANY PROCEDURE, DROP ANY PROCEDURE, CREATE ANY SEQUENCE, ALTER ANY SEQUENCE, DROP ANY SEQUENCE, CREATE ANY TYPE, ALTER ANY TYPE, DROP ANY TYPE, SYSKM, CREATE ANY TRIGGER, ALTER ANY TRIGGER, DROP ANY TRIGGER, CREATE PROFILE, ALTER PROFILE, and DROP PROFILE.  
        /// - ReadOnly: a role that has only the read-only privilege SELECT.
        /// In MySQL mode, a role is a database-level role. Valid values: 
        /// - ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.   
        /// - ReadOnly: a role that has only the read-only privilege SELECT.   
        /// - DDL: a role that has the DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.   
        /// - DML: a role that has the DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.   
        /// 
        /// > <br>By default, an Oracle account has the read and write privileges on its own schema, which are not listed here.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
