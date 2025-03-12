// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the database account. Valid values:    </para>
        /// <list type="bullet">
        /// <item><description>Admin: the super administrator account.   </description></item>
        /// <item><description>NORMAL: a general account.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TenantUsers")]
        [Validation(Required=false)]
        public List<DescribeTenantUsersResponseBodyTenantUsers> TenantUsers { get; set; }
        public class DescribeTenantUsersResponseBodyTenantUsers : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<DescribeTenantUsersResponseBodyTenantUsersDatabases> Databases { get; set; }
            public class DescribeTenantUsersResponseBodyTenantUsersDatabases : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>db_pay1</para>
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public string Privileges { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tbl_pay1</para>
                /// </summary>
                [NameInMap("Table")]
                [Validation(Required=false)]
                public string Table { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>use for test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Encrypt,Decrypt</para>
            /// </summary>
            [NameInMap("GlobalPermissions")]
            [Validation(Required=false)]
            public string GlobalPermissions { get; set; }

            /// <summary>
            /// <para>所属集群Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>obshc32****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>所属租户Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>tshfs3****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pay_test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("UserStatus")]
            [Validation(Required=false)]
            public string UserStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>The role of the account.<br>In Oracle mode, a role is a schema-level role. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>ReadWrite: a role that has the read and write privileges, including: CREATE TABLE, CREATE VIEW, CREATE PROCEDURE, CREATE SYNONYM, CREATE SEQUENCE, CREATE TRIGGER, CREATE TYPE, CREATE SESSION, EXECUTE ANY PROCEDURE, CREATE ANY OUTLINE, ALTER ANY OUTLINE, DROP ANY OUTLINE, CREATE ANY PROCEDURE, ALTER ANY PROCEDURE, DROP ANY PROCEDURE, CREATE ANY SEQUENCE, ALTER ANY SEQUENCE, DROP ANY SEQUENCE, CREATE ANY TYPE, ALTER ANY TYPE, DROP ANY TYPE, SYSKM, CREATE ANY TRIGGER, ALTER ANY TRIGGER, DROP ANY TRIGGER, CREATE PROFILE, ALTER PROFILE, and DROP PROFILE.  </description></item>
        /// <item><description>ReadOnly: a role that has only the read-only privilege SELECT.
        /// In MySQL mode, a role is a database-level role. Valid values: </description></item>
        /// <item><description>ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.   </description></item>
        /// <item><description>ReadOnly: a role that has only the read-only privilege SELECT.   </description></item>
        /// <item><description>DDL: a role that has the DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.   </description></item>
        /// <item><description>DML: a role that has the DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.</description></item>
        /// </list>
        /// <remarks>
        /// <para><br>By default, an Oracle account has the read and write privileges on its own schema, which are not listed here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
