// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDatabasesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the tenant.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<DescribeDatabasesResponseBodyDatabases> Databases { get; set; }
        public class DescribeDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// Specifies whether to return the information of tables in the database.   
            /// Default value: false.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public double? DataSize { get; set; }

            /// <summary>
            /// The number of the page to return.   
            /// - Start value: 1   
            /// - Default value: 1
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The status of the database. Valid values:    
            /// - ONLINE: The database is running.  
            /// - DELETING: The database is being deleted.
            /// </summary>
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RequiredSize")]
            [Validation(Required=false)]
            public double? RequiredSize { get; set; }

            /// <summary>
            /// The list of databases in the tenant.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesTables> Tables { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesTables : TeaModel {
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// The name of the database table.
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<DescribeDatabasesResponseBodyDatabasesUsers> Users { get; set; }
            public class DescribeDatabasesResponseBodyDatabasesUsers : TeaModel {
                [NameInMap("Privileges")]
                [Validation(Required=false)]
                public string Privileges { get; set; }

                /// <summary>
                /// The request ID.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// Example 1
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The type of the account. Valid values:  - Admin: the super administrator account. - Normal: a general account.
                /// </summary>
                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The search keyword.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
