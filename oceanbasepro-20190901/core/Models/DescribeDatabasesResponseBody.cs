// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The list of databases in the tenant.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            /// <summary>
            /// The collation.
            /// </summary>
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// The time when the database was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The actual data size, in GB. 
            /// ><notice>This parameter is no longer used in later versions. RequiredSize is used instead.></notice>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public double? DataSize { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The database type.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The description of the database.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The encoding standard of the database. Encoding standards such as utf8mb4 and GBK are supported.
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            /// <summary>
            /// The ID of the cluster to which the tenant belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The storage space required, in GB.
            /// </summary>
            [NameInMap("RequiredSize")]
            [Validation(Required=false)]
            public double? RequiredSize { get; set; }

            /// <summary>
            /// The status of the database. Valid values:    
            /// - ONLINE: The database is running.  
            /// - DELETING: The database is being deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The list of database tables.
            /// </summary>
            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesTables> Tables { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesTables : TeaModel {
                /// <summary>
                /// The name of the database table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The name of the tenant.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The list of accounts that are granted privileges on this database.
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesUsers> Users { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesUsers : TeaModel {
                /// <summary>
                /// If you have granted custom privileges on the database, this parameter indicates the custom privileges, separated by commas (,). Otherwise, no data is returned for this parameter.
                /// </summary>
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public string Privileges { get; set; }

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

                /// <summary>
                /// The type of the account. Valid values:  
                /// - Admin: the super administrator account. 
                /// - Normal: a general account.
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of databases in the tenant.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
