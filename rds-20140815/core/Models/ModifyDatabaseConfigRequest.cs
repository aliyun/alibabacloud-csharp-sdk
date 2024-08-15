// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDatabaseConfigRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database name.
        /// 
        /// >  You can specify only one database name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// The database property that you want to modify.
        /// 
        /// *   **If you want to modify a property of the database**, set this parameter to the name of the database property.
        /// *   **If you want to archive data from the database to an OSS bucket**, specify the database status. If you set this parameter to `covert_online_db_to_cold_storage`, the system converts an online database to a cold storage database. If you set this parameter to `convert_cold_storage_db_to_online`, the system converts a cold storage database to an online database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatabasePropertyName")]
        [Validation(Required=false)]
        public string DatabasePropertyName { get; set; }

        /// <summary>
        /// The value of the database property that you want to modify.
        /// 
        /// *   **If you want to modify a property of the database**, set this parameter to the property value.
        /// *   **If you want to archive data from the database to an OSS bucket**, set this parameter to **1**. The system converts a database to a cold storage database or an online database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DatabasePropertyValue")]
        [Validation(Required=false)]
        public string DatabasePropertyValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
