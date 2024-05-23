// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterTemplatesRequest : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition
        /// *   **HighAvailability**: RDS High-availability Edition
        /// *   **Finance**: RDS Enterprise Edition
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The database engine of the instance. Valid values:
        /// 
        /// *   **mysql**: MySQL
        /// *   **mssql**: SQL Server
        /// *   **PostgreSQL**: PostgreSQL
        /// *   **MariaDB**: MariaDB
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The version of the database engine. Valid values:
        /// 
        /// *   Valid values when you set the Engine parameter to mysql: **5.5, 5.6, 5.7, and 8.0**.
        /// *   Valid values when you set the Engine parameter to mssql: **2008r2**.
        /// *   Valid values when you set the Engine parameter to PostgreSQL: **10.0, 11.0, 12.0, 13.0, 14.0, and 15.0**.
        /// *   Valid values when you set the Engine parameter to MariaDB: **10.3**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
