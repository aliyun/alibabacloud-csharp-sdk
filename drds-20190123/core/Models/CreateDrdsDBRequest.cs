// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsDBRequest : TeaModel {
        /// <summary>
        /// The name of the account that has permissions to access all databases on the ApsaraDB RDS for MySQL instance.
        /// 
        /// This parameter is required only when the Type parameter is set to VERTICAL.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The type of the storage instances that are used by the PolarDB-X 1.0 database. Set the value to RDS.
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// Specifies whether the required ApsaraDB RDS for MySQL instance is being created.
        /// </summary>
        [NameInMap("DbInstanceIsCreating")]
        [Validation(Required=false)]
        public bool? DbInstanceIsCreating { get; set; }

        /// <summary>
        /// The name of the PolarDB-X 1.0 database you want to create.
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance on which you want to create the database.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The encoding method that is used by the database.
        /// </summary>
        [NameInMap("Encode")]
        [Validation(Required=false)]
        public string Encode { get; set; }

        [NameInMap("InstDbName")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestInstDbName> InstDbName { get; set; }
        public class CreateDrdsDBRequestInstDbName : TeaModel {
            /// <summary>
            /// The ID of the ApsaraDB RDS for MySQL instance on which the databases need to be vertically partitioned. This parameter is required only when the Type parameter is set to VERTICAL.
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            [NameInMap("ShardDbName")]
            [Validation(Required=false)]
            public List<string> ShardDbName { get; set; }

        }

        /// <summary>
        /// The password that is used to log on to the database.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("RdsInstance")]
        [Validation(Required=false)]
        public List<string> RdsInstance { get; set; }

        [NameInMap("RdsSuperAccount")]
        [Validation(Required=false)]
        public List<CreateDrdsDBRequestRdsSuperAccount> RdsSuperAccount { get; set; }
        public class CreateDrdsDBRequestRdsSuperAccount : TeaModel {
            /// <summary>
            /// The account name of the super administrator that is used to connect to the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The ID of ApsaraDB RDS instance.
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public string DbInstanceId { get; set; }

            /// <summary>
            /// The password of the super administrator account that is used to connect to the ApsaraDB RDS instance.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// The partitioning mode of the database. Valid values:
        /// 
        /// *   **HORIZONTAL**: The database is horizontally partitioned (sharded).
        /// *   **VERTICAL**: The database is vertically partitioned.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
