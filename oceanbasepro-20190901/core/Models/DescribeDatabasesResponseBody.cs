// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of databases in the tenant.</para>
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            /// <summary>
            /// <para>The collation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4_general_ci</para>
            /// </summary>
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// <para>The time when the database was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-21 15:41:06</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The actual data size, in GB. </para>
            /// <remarks>
            /// <para>Notice: This parameter is no longer used in later versions. RequiredSize is used instead.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5.67 GB</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public double? DataSize { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sms_pre</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// <para>The description of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test db</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The encoding standard of the database. Encoding standards such as utf8mb4 and GBK are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// <para>The ID of the cluster to which the tenant belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obsdh2f****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The storage space required, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.67 GB</para>
            /// </summary>
            [NameInMap("RequiredSize")]
            [Validation(Required=false)]
            public double? RequiredSize { get; set; }

            /// <summary>
            /// <para>The status of the database. Valid values:    </para>
            /// <list type="bullet">
            /// <item><description>ONLINE: The database is running.  </description></item>
            /// <item><description>DELETING: The database is being deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of database tables.</para>
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesTables> Tables { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesTables : TeaModel {
                /// <summary>
                /// <para>The name of the database table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTables</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t33h8y08k****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tenantABC</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The list of accounts that are granted privileges on this database.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesUsers> Users { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesUsers : TeaModel {
                /// <summary>
                /// <para>If you have granted custom privileges on the database, this parameter indicates the custom privileges, separated by commas (,). Otherwise, no data is returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select,delete,update</para>
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public string Privileges { get; set; }

                /// <summary>
                /// <para>The role of the account.<br>In MySQL mode, a role is a database-level role. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description>ReadWrite: a role that has the read and write privileges, namely ALL PRIVILEGES.  </description></item>
                /// <item><description>ReadOnly: a role that has only the read-only privilege SELECT.   </description></item>
                /// <item><description>DDL: a role that has the DDL privileges such as CREATE, DROP, ALTER, SHOW VIEW, and CREATE VIEW.   </description></item>
                /// <item><description>DML: a role that has the DML privileges such as SELECT, INSERT, UPDATE, DELETE, and SHOW VIEW.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ReadOnly</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The name of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_pay_ro</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The type of the account. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description>Admin: the super administrator account. </description></item>
                /// <item><description>Normal: a general account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of databases in the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
